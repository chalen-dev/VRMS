using VRMS.Database.Seeders;
using VRMS.Enums;
using VRMS.Repositories.Billing;
using VRMS.Services.Rental;

namespace VRMS.Database.Seeders.Rental;

public class ReservationSeeder : ISeeder
{
    public string Name => nameof(ReservationSeeder);

    private readonly ReservationService _reservationService;
    private readonly PaymentRepository _paymentRepo;

    public ReservationSeeder(
        ReservationService reservationService,
        PaymentRepository paymentRepo)
    {
        _reservationService = reservationService;
        _paymentRepo = paymentRepo;
    }

    public void Run()
    {
        // Customer 1 reserves Vehicle 1
        var r1 = _reservationService.CreateReservation(
            customerId: 1,
            vehicleId: 1,
            startDate: DateTime.Today.AddDays(1),
            endDate: DateTime.Today.AddDays(4)
        );

        // PAY reservation fee BEFORE confirmation
        _paymentRepo.Create(
            invoiceId: null,
            reservationId: r1,
            amount: _reservationService
                .GetReservationById(r1)
                .ReservationFeeAmount,
            method: PaymentMethod.Cash,
            paymentType: PaymentType.Reservation,
            date: DateTime.UtcNow
        );
        _reservationService.ConfirmReservation(r1);

        // Customer 2 reserves Vehicle 2 (pending only)
        _reservationService.CreateReservation(
            customerId: 2,
            vehicleId: 2,
            startDate: DateTime.Today.AddDays(3),
            endDate: DateTime.Today.AddDays(6)
        );

        // Customer 3 reserves Vehicle 3 and confirms
        var r3 = _reservationService.CreateReservation(
            customerId: 3,
            vehicleId: 3,
            startDate: DateTime.Today.AddDays(2),
            endDate: DateTime.Today.AddDays(5)
        );
        _paymentRepo.Create(
            invoiceId: null,
            reservationId: r3,
            amount: _reservationService
                .GetReservationById(r3)
                .ReservationFeeAmount,
            method: PaymentMethod.Cash,
            paymentType: PaymentType.Reservation,
            date: DateTime.UtcNow
        );

        _reservationService.ConfirmReservation(r3);
    }
}
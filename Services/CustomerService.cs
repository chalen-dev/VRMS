using System;
using System.Collections.Generic;
using System.Data;
using VRMS.Database;
using VRMS.Enums;
using VRMS.Models.Customers;

namespace VRMS.Services;

public class CustomerService
{
    // DriversLicense methods
    public int CreateDriversLicense(DriversLicense license)
    {
        var result = DB.ExecuteScalar($"""
            CALL sp_drivers_licenses_create(
                '{license.LicenseNumber}',
                '{license.IssueDate:yyyy-MM-dd}',
                '{license.ExpiryDate:yyyy-MM-dd}',
                '{license.IssuingCountry}'
            );
        """);

        return Convert.ToInt32(result);
    }

    public DriversLicense? GetDriversLicenseById(int id)
    {
        var table = DB.ExecuteQuery($"CALL sp_drivers_licenses_get_by_id({id});");
        if (table.Rows.Count == 0) return null;
        return MapDriversLicense(table.Rows[0]);
    }

    public DriversLicense? GetDriversLicenseByNumber(string licenseNumber)
    {
        var table = DB.ExecuteQuery($"CALL sp_drivers_licenses_get_by_number('{licenseNumber}');");
        if (table.Rows.Count == 0) return null;
        return MapDriversLicense(table.Rows[0]);
    }

    public void UpdateDriversLicense(DriversLicense license)
    {
        DB.ExecuteNonQuery($"""
            CALL sp_drivers_licenses_update(
                {license.Id},
                '{license.IssueDate:yyyy-MM-dd}',
                '{license.ExpiryDate:yyyy-MM-dd}',
                '{license.IssuingCountry}'
            );
        """);
    }

    public void DeleteDriversLicense(int id)
    {
        DB.ExecuteNonQuery($"CALL sp_drivers_licenses_delete({id});");
    }

    // Customer methods
    public int CreateCustomer(Customer customer)
    {
        var existingLicense = GetDriversLicenseById(customer.DriversLicenseId);
        if (existingLicense == null)
            throw new InvalidOperationException("Drivers license not found.");

        var result = DB.ExecuteScalar($"""
            CALL sp_customers_create(
                '{customer.FirstName}',
                '{customer.LastName}',
                '{customer.Email}',
                '{customer.Phone}',
                '{customer.DateOfBirth:yyyy-MM-dd}',
                '{customer.CustomerType}',
                {customer.DriversLicenseId}
            );
        """);

        return Convert.ToInt32(result);
    }

    public Customer? GetById(int id)
    {
        var table = DB.ExecuteQuery($"CALL sp_customers_get_by_id({id});");
        if (table.Rows.Count == 0) return null;
        return MapCustomer(table.Rows[0]);
    }

    public List<Customer> GetAll()
    {
        var table = DB.ExecuteQuery("CALL sp_customers_get_all();");
        var list = new List<Customer>();
        foreach (DataRow row in table.Rows)
            list.Add(MapCustomer(row));
        return list;
    }

    public void UpdateCustomer(Customer customer)
    {
        DB.ExecuteNonQuery($"""
            CALL sp_customers_update(
                {customer.Id},
                '{customer.FirstName}',
                '{customer.LastName}',
                '{customer.Email}',
                '{customer.Phone}',
                '{customer.CustomerType}'
            );
        """);
    }

    public void DeleteCustomer(int id)
    {
        DB.ExecuteNonQuery($"CALL sp_customers_delete({id});");
    }

    // Validation helpers
    public bool IsLicenseExpired(DriversLicense license)
    {
        return license.ExpiryDate.Date < DateTime.UtcNow.Date;
    }

    public bool IsOfAge(Customer customer, int minimumAge = 21)
    {
        var today = DateTime.UtcNow.Date;
        var age = today.Year - customer.DateOfBirth.Year;
        if (customer.DateOfBirth.Date > today.AddYears(-age)) age--;
        return age >= minimumAge;
    }

    // Mapping
    private static DriversLicense MapDriversLicense(DataRow row)
    {
        return new DriversLicense
        {
            Id = Convert.ToInt32(row["id"]),
            LicenseNumber = row["license_number"].ToString()!,
            IssueDate = Convert.ToDateTime(row["issue_date"]),
            ExpiryDate = Convert.ToDateTime(row["expiry_date"]),
            IssuingCountry = row["issuing_country"].ToString()!
        };
    }

    private static Customer MapCustomer(DataRow row)
    {
        return new Customer
        {
            Id = Convert.ToInt32(row["id"]),
            FirstName = row["first_name"].ToString()!,
            LastName = row["last_name"].ToString()!,
            Email = row["email"].ToString()!,
            Phone = row["phone"].ToString()!,
            DateOfBirth = Convert.ToDateTime(row["date_of_birth"]),
            CustomerType = Enum.Parse<CustomerType>(row["customer_type"].ToString()!),
            DriversLicenseId = Convert.ToInt32(row["drivers_license_id"])
        };
    }
}

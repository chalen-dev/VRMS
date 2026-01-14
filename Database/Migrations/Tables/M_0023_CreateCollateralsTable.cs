using VRMS.Database.DBHelpers.EnumHelper;
using VRMS.Enums;

namespace VRMS.Database.Migrations.Tables;

public static class M_0023_CreateCollateralsTable
{
    public static string Create() => $"""
                                      CREATE TABLE IF NOT EXISTS collaterals (
                                          id INT AUTO_INCREMENT PRIMARY KEY,

                                          rental_id INT NOT NULL,
                                          type {Tbl.ToEnum<CollateralType>()} NOT NULL,

                                          description VARCHAR(255) NULL,
                                          reference_number VARCHAR(100) NULL,

                                          received_at DATETIME NOT NULL,
                                          returned_at DATETIME NULL,

                                          status {Tbl.ToEnum<CollateralStatus>()} NOT NULL DEFAULT 'Held',

                                          CONSTRAINT fk_collaterals_rental
                                              FOREIGN KEY (rental_id)
                                              REFERENCES rentals(id)
                                              ON DELETE CASCADE
                                      ) ENGINE=InnoDB;
                                      """;

    public static string Drop() => """
                                   DROP TABLE IF EXISTS collaterals;
                                   """;
}
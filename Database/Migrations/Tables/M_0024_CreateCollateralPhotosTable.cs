using VRMS.Database.DBHelpers.EnumHelper;
using VRMS.Enums;

namespace VRMS.Database.Migrations.Tables;

public static class M_0024_CreateCollateralPhotosTable
{
    public static string Create() => $"""
                                      CREATE TABLE IF NOT EXISTS collateral_photos (
                                          id INT AUTO_INCREMENT PRIMARY KEY,

                                          collateral_id INT NOT NULL,
                                          file_path VARCHAR(255) NOT NULL,

                                          photo_type {Tbl.ToEnum<CollateralPhotoType>()} NOT NULL DEFAULT 'Other',
                                          uploaded_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

                                          CONSTRAINT fk_collateral_photos_collateral
                                              FOREIGN KEY (collateral_id)
                                              REFERENCES collaterals(id)
                                              ON DELETE CASCADE
                                      ) ENGINE=InnoDB;
                                      """;

    public static string Drop() => """
                                   DROP TABLE IF EXISTS collateral_photos;
                                   """;
}
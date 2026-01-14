using VRMS.Database.SPImplementations.Rentals.Collateral;
using VRMS.Database.SPImplementations.Rentals.CollateralPhoto;

namespace VRMS.Database.Migrations.StoredProcedures;

public static class M_1024_CreateCollateralProcedures
{
    public static string Create() => $"""
                                      {SP_Collaterals_Create.Sql()}
                                      {SP_Collaterals_GetByRental.Sql()}
                                      {SP_Collaterals_GetById.Sql()}
                                      {SP_Collaterals_Return.Sql()}
                                      {SP_Collaterals_MarkLost.Sql()}

                                      {SP_CollateralPhotos_Add.Sql()}
                                      {SP_CollateralPhotos_GetByCollateral.Sql()}
                                      {SP_CollateralPhotos_Delete.Sql()}
                                      """;

    public static string Drop() => """
                                   DROP PROCEDURE IF EXISTS sp_collaterals_create;
                                   DROP PROCEDURE IF EXISTS sp_collaterals_get_by_rental;
                                   DROP PROCEDURE IF EXISTS sp_collaterals_get_by_id;
                                   DROP PROCEDURE IF EXISTS sp_collaterals_return;
                                   DROP PROCEDURE IF EXISTS sp_collaterals_mark_lost;

                                   DROP PROCEDURE IF EXISTS sp_collateral_photos_add;
                                   DROP PROCEDURE IF EXISTS sp_collateral_photos_get_by_collateral;
                                   DROP PROCEDURE IF EXISTS sp_collateral_photos_delete;
                                   """;
}
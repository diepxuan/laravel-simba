# System/Utility Procedures Conversion (Batch 2)

This document lists additional system/utility stored procedures, functions, and views that have been converted to PHP classes in the `Diepxuan\Simba\StoredProcedures` namespace.

## Procedures Converted

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| GetFolderUpdate | GetFolderUpdate | purl (nvarchar), pupd (int) | Update or retrieve updateserver column in sisetup |
| XoaTable_Liennk | XoaTableLiennk | none | Drop tables with name like '%BCTCTM%' |
| afChkCodeExists | AfChkCodeExists | pMa_Cty, pTable_name, pCode_name, pCode_value | Check if a code exists in a table (returns int) |
| afChkExistsCodeDict | AfChkExistsCodeDict | pMa_cty, pTable_name, pCode_name, pCode_value | Check existence of a code across dictionary tables (returns int) |
| afChkExistsCodeDictOnTable | AfChkExistsCodeDictOnTable | pMa_cty, pTable_name, pCode_name, pCode_value, pTblName (output) | Check existence and return table name with description |
| sysBackupAsData | SysBackupAsData | none | Backup asData database to device asData_srv |
| sysGrant | SysGrant | stm (nvarchar), obj (nvarchar), user (nvarchar) | Grant permissions on objects to a user |
| sysRevoke | SysRevoke | stm (nvarchar), obj (nvarchar), user (nvarchar) | Revoke permissions from a user |
| zAsAddYear2NgayCt | ZAsAddYear2NgayCt | pMa_cty, increment | Add/subtract years to NGAY_CT and related date fields |
| zCheckSmSysTable | ZCheckSmSysTable | pMa_cty | Check system table records for a company |
| zChkDatabaseDesign | ZChkDatabaseDesign | none | Check database design inconsistencies (column length, defaults) |
| zChk_Var_Len | ZChkVarLen | pTable | Check variable length usage in procedures |
| zCopyDatabase | ZCopyDatabase | sourcedb, destdb | Copy data between databases (excluding system tables) |
| zCreateCompany | ZCreateCompany | ma_cty, ma_cty_mau | Create a new company by copying setup data |
| zDeleteCompany | ZDeleteCompany | ma_cty | Delete all data for a given company |
| zDropExtendedPropery | ZDropExtendedPropery | tblName, colName, property | Drop an extended property from a column |
| zFindColumns | ZFindColumns | pColumnName | Find columns matching a pattern across tables |
| zGenExits | ZGenExits | pTablename, pFieldName | Generate function afExist{FieldName} to check existence |
| zGenExits_new | ZGenExitsNew | pTablename, pFieldName | Similar to zGenExits but prints to screen |
| zGenFieldDescription | ZGenFieldDescription | table_name | Get extended property descriptions for columns of a table |
| zGenSP_GetAllSP | ZGenSPGetAllSP | none | Get all stored procedure names |
| zGenSp | ZGenSp | tbl, out (default 'SCREEN') | Generate CRUD stored procedures for a table (asIns, asUpd, asGet, asDel) |
| zGenSpAll | ZGenSpAll | table | Generate CRUD procedures for all tables (or one) |
| zGenSpCt | ZGenSpCt | tbl, out (default 'SCREEN') | Generate CRUD stored procedures for a document table (with module prefix) |
| zGenSpDanhMuc | ZGenSpDanhMuc | tbl, out (default 'SCREEN') | Generate CRUD stored procedures for a master data table (with dictionary info) |
| zGenTest | ZGenTest | sptest, spinsert (default '') | Generate test call for a stored procedure |

## Notes

- Parameters with default values in SQL are given appropriate defaults in PHP (null, empty string, '0', etc.).
- Output parameters (`@pRet output`) are omitted from the PHP call; they are handled internally by the stored procedure.
- All classes return `Illuminate\Support\Collection` unless otherwise specified.
- The connection is automatically determined via `SModel::getConnectionName()`.

## Usage Example

```php
use Diepxuan\Simba\StoredProcedures\GetFolderUpdate;

$result = GetFolderUpdate::call([
    'purl' => 'http://update.example.com',
    'pupd' => 1,
]);
```

## Conversion Progress

- This batch: 26 procedures (including SiGetDmProduct already existed)
- Total system procedures converted: 46 (previous 20 + new 26)
- Last updated: 2026-02-12

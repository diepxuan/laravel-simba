# DynamicReport.dll - Dynamic Report Form

## Tong quan

| Thuoc tinh | Gia tri |
|------------|---------|
| **Module** | Common (Reporting) |
| **Loai** | Windows Forms Class Library |
| **Chuc nang** | Form bao cao dong - tu dong sinh controls tu stored procedure parameters, xu ly filter input |
| **Assembly** | DynamicReport v1.0.0.0 |
| **Framework** | .NET Framework 3.5 |
| **Namespace** | AsiaErp.UserInterface, AsiaErp.DataAccess |
| **AllowUnsafeBlocks** | True |
| **GUID** | 5b533d97-568d-41be-b375-36ef4aabce81 |

## Dependencies

| Assembly | Muc dich |
|----------|----------|
| AsiaErp.Framework | Framework base (frmReport, AsTextBox, etc.) |
| AsiaErp.Helper | Helper utilities |
| Microsoft.VisualBasic | VB runtime support |
| System.Data | Data access |

## File Structure

```
DynamicReport.dll/
├── DynamicReport.csproj
├── app.ico
├── Properties/
│   └── AssemblyInfo.cs
├── AsiaErp.UserInterface/
│   └── frmDynamicReport.cs         # Main form - dynamic report
├── AsiaErp.DataAccess/
│   ├── DynamicReportDAO.cs         # DAO Interface
│   └── MsSqlDynamicReportDAO.cs    # SQL Server implementation
└── My/
    ├── MyApplication.cs
    ├── MyComputer.cs
    ├── MyProject.cs
    ├── MySettings.cs
    └── MySettingsProperty.cs
```

## Forms

### frmDynamicReport

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Ke thua** | frmReport |
| **Muc dich** | Form bao cao dong - tu dong tao filter controls tu stored procedure parameters |

**Controls chinh:**

| Control | Loai | Muc dich |
|---------|------|----------|
| cboMau_bc | ComboBox | Chon mau bao cao |
| cboKyBc | ComboBox | Chon ky bao cao |
| txtNgay1 | AsMaskedTextBox | Tu ngay |
| txtNgay2 | AsMaskedTextBox | Den ngay |
| txtTieu_De | TextBox | Tieu de bao cao |
| cmdOk | Button | Xem bao cao |
| cmdCancel | Button | Huy |
| cmdExcel | Button | Xuat Excel |
| cmdModifyReport | Button | Sua mau bao cao |
| AsTabControl | TabControl | Tab container |

**Dynamic Controls (sinh tu SP parameters):**

| Control Type | Width (W) | Muc dich |
|--------------|-----------|----------|
| TEXTBOX | 330 | Nhap lieu tu do |
| LOOKUP | 90 | Lookup danh muc (AsTextBox) |
| DROPDOWN | 90 | Dropdown |
| CHECKBOX | 90 | Checkbox filter |
| DATETIME | 67 | Date picker |
| RADIO | 396 | Radio button group |

**Constants:**

| Constant | Value | Muc dich |
|----------|-------|----------|
| W_TEXT | 330 | Chieu rong textbox |
| W_LOOK | 90 | Chieu rong lookup |
| W_DROP | 90 | Chieu rong dropdown |
| W_CHECK | 90 | Chieu rong checkbox |
| W_DATETIME | 67 | Chieu rong datetime |
| W_RADIO | 396 | Chieu rong radio group |
| H_ALING_TEXT | 10 | Khoang cach text alignment |
| H_ALING_GROUP | 25 | Khoang cach group alignment |
| LBL_X | 24 | Vi tri X label |
| CONTROL_X | 110 | Vi tri X control |
| LBL_NAME_X | 202 | Vi tri X label name |

**Fields:**

| Field | Kieu | Muc dich |
|-------|------|----------|
| f_arrParRequired | List<Control> | Cac control bat buoc |
| f_arrParControls | List<Control> | Tat ca control filter |
| f_arrLabelControls | List<Label> | Cac label |
| f_arrAllControlFilterCustom | List<Control> | Custom filter controls |
| f_blnIsLoading | bool | Dang load |
| f_Y_Value | int | Vi tri Y hien tai cho layout |

**Business Logic:**

1. **LoadSPParams**: Lay parameters tu stored procedure qua DAO
2. **CreateControls**: Tu dong sinh controls dua trên kieu parameter
3. **Validate**: Kiem tra required fields truoc khi chay report
4. **BuildFilterTitle**: Tieu de filter tu gia tri da chon

## DataAccess Classes

### DynamicReportDAO (Interface)

| Method | Input | Output | Muc dich |
|--------|-------|--------|----------|
| GetFilterControl | spName (string) | string | Lay cau hinh filter control tu SP `asDynGetControl4Form` |
| GetStoreParameterInfo | spName (string) | SqlParameterCollection | Lay thong tin parameters cua stored procedure |

### MsSqlDynamicReportDAO

| Method | Input | Output | Muc dich |
|--------|-------|--------|----------|
| GetFilterControl | spName (string) | string | Goi SP `asDynGetControl4Form` voi @sp_name, tra ve @str (output, nvarchar(500)) |
| GetStoreParameterInfo | spName (string) | SqlParameterCollection | Dung SqlCommandBuilder.DeriveParameters() |

**Stored Procedures su dung:**

| SP Name | Muc dich |
|---------|----------|
| asDynGetControl4Form | Tra ve cau hinh filter controls (output: @str) |
| [spName bat ky] | Stored procedure bao cao (derive parameters) |

## Ket luan

DynamicReport.dll la **Dynamic Report Framework** - form tu dong sinh filter controls tu stored procedure parameters. Su dung reflection/SqlCommandBuilder.DeriveParameters de lay thong tin parameters, sau do tao controls tuong ung (TextBox, Lookup, DateTimePicker, Checkbox, Radio). Day la co so ha tang cho cac bao cao dong trong he thong Asia ERP.

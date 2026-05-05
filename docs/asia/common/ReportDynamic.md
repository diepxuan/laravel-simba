# ReportDynamic.dll - Dynamic Report Framework (v2)

## Tong quan

| Thuoc tinh | Gia tri |
|------------|---------|
| **Module** | Common (Reporting) |
| **Loai** | Windows Forms Class Library |
| **Chuc nang** | Form bao cao dong phien ban 2 - doc cau hinh filter tu database (asDynGetControl4Form), tu dong render controls, xu ly validation va chuyen tham so vao SP bao cao |
| **Assembly** | ReportDynamic v1.0.0.0 |
| **Framework** | .NET Framework 3.5 |
| **Namespace** | AsiaErp.UserInterface, AsiaErp.DataAccess |
| **AllowUnsafeBlocks** | True |
| **GUID** | 5b533d97-568d-41be-b375-36ef4aabce81 |
| **Ghi chu** | Cung GUID voi DynamicReport.dll - co the la refactored/replaced version |

## Dependencies

| Assembly | Muc dich |
|----------|----------|
| AsiaErp.Framework | Framework base (frmReport, AsTabControl, AsTextBox, etc.) |
| AsiaErp.Helper | Helper utilities |
| Microsoft.VisualBasic | VB runtime support |
| System.Data | Data access |

## File Structure

```
ReportDynamic.dll/
├── ReportDynamic.csproj
├── app.ico
├── Properties/
│   └── AssemblyInfo.cs
├── AsiaErp.UserInterface/
│   └── frmReportDynamic.cs        # Main dynamic report form
├── AsiaErp.DataAccess/
│   ├── ReportDynamicDAO.cs        # DAO Interface
│   └── MsSqlReportDynamicDAO.cs   # SQL Server implementation
└── My/
    ├── MyApplication.cs
    ├── MyComputer.cs
    ├── MyProject.cs
    ├── MySettings.cs
    └── MySettingsProperty.cs
```

## Forms

### frmReportDynamic

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Ke thua** | frmReport |
| **Constructor** | frmReportDynamic(string MenuID) |
| **Muc dich** | Form bao cao dong - render controls tu cau hinh filter |

**Controls (inherited from frmReport + dynamic):**

| Control | Loai | Muc dich |
|---------|------|----------|
| cboMau_bc | ComboBox | Chon mau bao cao |
| cboKyBc | ComboBox | Chon ky bao cao |
| txtNgay1 | AsMaskedTextBox | Tu ngay |
| txtNgay2 | AsMaskedTextBox | Den ngay |
| lblKyBc | Label | Label "Ky bao cao" |
| lbl2 | Label | Label "Den ngay" |
| cmdOk | Button | Xem bao cao |
| cmdCancel | Button | Huy |
| cmdExcel | Button | Xuat Excel |
| cmdModifyReport | Button | Sua mau bao cao |
| AsTabControl | TabControl | Tab container (tabFilter, tabGrid) |

**Dynamic Control Types (tu cau hinh filter):**

| Type | Control | Default Width | Mieu ta |
|------|---------|---------------|---------|
| TEXTBOX | TextBox | 330 | Nhap lieu tu do |
| LOOKUP | AsTextBox | 90 | Lookup danh muc (AutoLookup) |
| CHECKBOX | CheckBox | 90 | Checkbox filter |
| RADIO | GroupBox + RadioButton | 396 | Radio button group |
| COMBOBOX | ComboBox | auto | Dropdown list |

**Constants:**

| Constant | Value | Muc dich |
|----------|-------|----------|
| W_TEXT | 330 | Width textbox |
| W_LOOK | 90 | Width lookup |
| W_DROP | 90 | Width dropdown |
| W_CHECK | 90 | Width checkbox |
| W_RADIO | 396 | Width radio group |
| H_ALING_TEXT | 10 | Align text spacing |
| H_ALING_GROUP | 25 | Align group spacing |

**Fields:**

| Field | Kieu | Muc dich |
|-------|------|----------|
| f_arrParRequired | List<Control> | Required controls (validate) |
| f_arrParControls | List<Control> | All filter controls |
| f_arrLabelControls | List<Label> | Labels |

## DataAccess Classes

### ReportDynamicDAO (Interface)

| Method | Input | Output | Muc dich |
|--------|-------|--------|----------|
| GetFilterControl | spName (string) | string | Lay cau hinh filter control |

### MsSqlReportDynamicDAO

| Method | Input | Output | Muc dich |
|--------|-------|--------|----------|
| GetFilterControl | spName (string) | string | Goi SP `asDynGetControl4Form` voi @sp_name, tra ve output @str (size 500) |

**Stored Procedures:**

| SP Name | Muc dich |
|---------|----------|
| asDynGetControl4Form | Tra ve cau hinh filter string (output: @str nvarchar(500)) |

## Filter Configuration Format

Cau hinh filter duoc tra ve duoi dang string tu `asDynGetControl4Form`:

```
FieldName:Label:Type:Width:Required
```

Vi du:
```
ma_kh:Khach hang:LOOKUP:120:Y
ngay_ct:Ngay chung tu:DATETIME:100:
```

## Business Logic

1. **Constructor**: Nhan MenuID, khoi tao arrays
2. **Form Load**:
   - Doc cau hinh filter tu `asDynGetControl4Form`
   - Parse filter string
   - Tao controls dong (TextBox, AsTextBox, CheckBox, ComboBox, DateTimePicker)
   - Add vao palFilter panel
3. **cmdOk_Click**:
   - Validate required fields
   - Thu thap gia tri controls
   - Goi stored procedure bao cao
4. **cmdExcel_Click**: Xuat du lieu ra Excel
5. **cmdCancel_Click**: Dong form

## So sanh voi DynamicReport.dll

| Aspect | DynamicReport.dll | ReportDynamic.dll |
|--------|-------------------|-------------------|
| Form class | frmDynamicReport | frmReportDynamic |
| DAO interface | DynamicReportDAO | ReportDynamicDAO |
| GetStoreParameterInfo | Co (derive SP params) | Khong |
| Dynamic control creation | Tu SP parameters | Tu filter config string |
| Control types | TEXTBOX, LOOKUP, DROPDOWN, CHECKBOX, DATETIME, RADIO | TEXTBOX, LOOKUP, CHECKBOX, RADIO, COMBOBOX |
| GUID | Giong nhau | Giong nhau |

## Ket luan

ReportDynamic.dll la phien ban **nang cap cua DynamicReport.dll**, thay vi derive parameters tu stored procedure, no doc cau hinh filter tu database qua SP `asDynGetControl4Form`. Cach tiep can nay linh hoat hon vi cho phep cau hinh filter ma khong can thay đổi stored procedure signature.

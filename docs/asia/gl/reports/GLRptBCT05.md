# GlRptBCT05

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp (Direct Method Cash Flow Statement) - Phiên bản 5
- **Assembly**: GlRptBCT05.dll
- **Version**: 9.1.0.0
- **Framework**: .NET Framework 3.5

## Forms

### frmGlRptBCT05.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cmdCF | Button | - | cmdCF_Click |
| cboKyBc | ComboBox | - | - |
| cboMau_bc | ComboBox | - | - |
| txtNgay1 | AsMaskedTextBox | - | - |
| txtNgay2 | AsMaskedTextBox | - | - |
| txtMa_Nt | AsTextBox | - | - |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| _source | DataTable | Dữ liệu nguồn |
| _sourceCalc | DataTable | Dữ liệu tính toán |
| dgvBC | DataGridView | Override để attach events |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| cmdCF_Click | sender, e | void | Mở form khai báo công thức |
| FormatGridView | - | void | Format grid cho phép edit |
| CellEnter | sender, e | void | Xử lý khi enter cell |
| CellValidated | sender, e | void | Xử lý khi validate cell |
| UpdateDataCell | maSo, tien, stt | int | Cập nhật dữ liệu cell |
| UpdateList | - | void | Cập nhật danh sách tính toán |
| ValidChiTieu | strList, strChitieu | bool | Validate chỉ tiêu |

### frmGLMauCF01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form mẫu công thức 01 - Khai báo công thức tính toán

### frmTATNDN03Edit.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form chỉnh sửa dữ liệu

## Data Access

### IGlRptBCT05.cs
- **Interface**: IGlRptBCT05
- **Method**: UpdateDataCell

### MsSqlGlRptBCT05.cs
- **Implementation**: MsSqlGlRptBCT05
- **SP**: asRptUpdTatndn03_dc

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| UpdateDataCell | asRptUpdTatndn03_dc | @pMa_cty, @pNgay1, @pNgay2, @pMau, @pMa_So, @pTien, @pStt | @pRet | Cập nhật dữ liệu điều chỉnh |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asRptUpdTatndn03_dc | Cập nhật dữ liệu điều chỉnh | @pMa_cty, @pNgay1, @pNgay2, @pM
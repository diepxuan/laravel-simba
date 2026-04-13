# SORptLaiLo.dll - Báo cáo lãi lỗ

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SORptLaiLo.dll |
| **Chức năng** | Báo cáo lãi lỗ theo hợp đồng |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmSORptLaiLo |
| **Kế thừa** | frmReport |
| **Phiên bản** | 14.1.0.0 |
| **Framework** | .NET 3.5 |

## Mô tả

DLL báo cáo lãi lỗ theo hợp đồng. Tính toán và hiển thị kết quả kinh doanh (lãi/lỗ) dựa trên doanh thu và chi phí theo từng hợp đồng.

## Cấu trúc Form

### frmSORptLaiLo

Form báo cáo kế thừa từ `frmReport` với các thành phần chính:

#### Controls trên tabFilter

| Control | Loại | Mô tả |
|---------|------|-------|
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| txtMa_HD | AsTextBox | Mã hợp đồng |
| txtMa_KH | AsTextBox | Mã khách hàng |
| txtTk_DT | AsTextBoxMulti | Danh sách TK doanh thu |
| txtTkDu_DT | AsTextBoxMulti | Danh sách TK đối ứng DT |
| chkNC_DT | CheckBox | Lấy PS Nợ/Có (DT) |
| txtTk_Cp | AsTextBoxMulti | Danh sách TK chi phí |
| txtTkDu_CP | AsTextBoxMulti | Danh sách TK đối ứng CP |
| chkNc_CP | CheckBox | Lấy PS Nợ/Có (CP) |
| Panel1 | Panel | Panel phát sinh doanh thu |
| rbDT_No | RadioButton | Doanh thu Nợ |
| rbDS_Co | RadioButton | Doanh thu Có |
| Panel2 | Panel | Panel phát sinh chi phí |
| rbCP_No | RadioButton | Chi phí Nợ |
| rbCP_CO | RadioButton | Chi phí Có |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND | RadioButton | Tiền VND |
| optNt | RadioButton | Tiền ngoại tệ |

#### Các Label

- lblTen_HD: Hiển thị tên hợp đồng
- lblMa_TD: Label "Mã HĐ"
- lblMa_KH: Hiển thị tên khách hàng
- Label1: "DS TK doanh thu"
- Label2: "DS TK đối ứng"
- Label3: "DS TK đối ứng" (CP)
- Label4: "Mã KH"
- Label5: "DS TK chi phí"
- Label6: "Phát sinh" (DT)
- Label7: "Phát sinh" (CP)

## Business Logic

### frmSORptLaiLo_Load()

Khởi tạo giá trị mặc định:

```csharp
private void frmSORptLaiLo_Load(object sender, EventArgs e)
{
    txtTk_DT.Text = MyMenuInfo.par3;  // TK doanh thu mặc định
    txtTk_Cp.Text = MyMenuInfo.par4;  // TK chi phí mặc định
    cboKyBc.Select();
}
```

### LoadData()

Xây dựng tham số cho stored procedure:

```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(txtNgay1.Value);
arrayList.Add(txtNgay2.Value);
arrayList.Add(txtMa_HD.Text);
arrayList.Add(txtMa_KH.Text);
arrayList.Add(txtTk_DT.Text);
arrayList.Add(txtTkDu_DT.Text);
arrayList.Add(chkNC_DT.Checked);
arrayList.Add(txtTk_Cp.Text);
arrayList.Add(txtTkDu_CP.Text);
arrayList.Add(chkNc_CP.Checked);
```

### Event Handlers

**rbDT_No_CheckedChanged:**
```csharp
private void rbDT_No_CheckedChanged(object sender, EventArgs e)
{
    chkNC_DT.Checked = !rbDT_No.Checked;
}
```

**tbCP_No_CheckedChanged:**
```csharp
private void tbCP_No_CheckedChanged(object sender, EventArgs e)
{
    chkNc_CP.Checked = !rbCP_No.Checked;
}
```

### Drill-down

Hỗ trợ drill-down khi nhấn F4 trên dòng có mã hợp đồng:
- Drill-down menu: SORptF5LaiLo
- Truyền các tham số lọc tương tự báo cáo gốc

## Dependencies

- AsiaErp.Framework.dll
- Helper.dll
- System.Data
- Microsoft.VisualBasic

## Ghi chú

- Báo cáo tính lãi lỗ = Doanh thu - Chi phí
- Cho phép chọn TK doanh thu và TK chi phí linh hoạt
- Hỗ trợ lọc theo nhiều tài khoản (AsTextBoxMulti)
- Có thể chọn phát sinh Nợ/Có cho doanh thu và chi phí
- Lookup điều kiện cho TK doanh thu: `tk like '5%'`
- Lookup điều kiện cho TK chi phí: `tk like '6%'`

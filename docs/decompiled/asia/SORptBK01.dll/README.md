# SORptBK01.dll - Bảng kê chứng từ bán hàng

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SORptBK01.dll |
| **Chức năng** | Bảng kê chứng từ bán hàng |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmSORptBK01 |
| **Kế thừa** | frmReport2DGV |
| **Phiên bản** | 14.1.0.0 |
| **Framework** | .NET 3.5 |

## Mô tả

DLL bảng kê bán hàng hiển thị dạng master-detail với 2 DataGridView: phiếu (ph) và chi tiết (ct). Cho phép xem danh sách chứng từ bán hàng và chi tiết từng chứng từ.

## Cấu trúc Form

### frmSORptBK01

Form báo cáo kế thừa từ `frmReport2DGV` với các thành phần chính:

#### Controls trên tabFilter

| Control | Loại | Mô tả |
|---------|------|-------|
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| txtSo_ct1 | TextBox | Chứng từ số từ |
| txtSo_ct2 | TextBox | Chứng từ số đến |
| cboLoaiPhieu | AsComboBox | Loại phiếu |
| cboTrang_Thai | AsComboBox | Trạng thái |
| txtMa_kh | AsTextBox | Mã khách hàng |
| txtMa_Nhkh | AsTextBox | Nhóm khách hàng |
| txtMa_Plkh1 | AsTextBox | Phân loại khách hàng 1 |
| txtMa_Plkh2 | AsTextBox | Phân loại khách hàng 2 |
| txtMa_Plkh3 | AsTextBox | Phân loại khách hàng 3 |
| txtMa_hd | AsTextBox | Mã hợp đồng |
| txtMa_nhhd | AsTextBox | Nhóm hợp đồng |
| txtMa_vt | AsTextBox | Mã vật tư |
| txtMa_nhvt | AsTextBox | Nhóm vật tư |
| txtMa_plvt1 | AsTextBox | Phân loại vật tư 1 |
| txtMa_plvt2 | AsTextBox | Phân loại vật tư 2 |
| txtMa_plvt3 | AsTextBox | Phân loại vật tư 3 |
| txtMa_kho | AsTextBox | Mã kho |
| txtMa_bp | AsTextBox | Mã bộ phận |
| txtMa_nvkd | AsTextBox | Mã nhân viên kinh doanh |
| txtMA_HTTT | AsTextBox | Hình thức thanh toán |
| txtMA_DKTT | AsTextBox | Điều khoản thanh toán |
| txtMa_vitri | AsTextBox | Mã vị trí |
| txtMaLo | AsTextBox | Mã lô |
| txtMa_spct | AsTextBox | Mã sản phẩm chi tiết |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND | RadioButton | Tiền VND |
| optNt | RadioButton | Tiền ngoại tệ |
| crvReportViewer | CrystalReportViewer | Viewer báo cáo |

#### Các Label hiển thị tên

- lblTen_KH, lblTen_nhkh, lblTen_lkh1, lblTen_lkh2, lblTen_lkh3
- lblTen_hd, lblTen_Nhhd
- lblTen_vt, lblTen_Nhvt
- lblTen_plvt1, lblTen_plvt2, lblTen_plvt3
- lblTen_kho, lblTen_bp, lblTen_nvkd
- lblTenHTTT, lblTen_TT, lblTen_lo, lblTen_spct

## Business Logic

### InitOtherComponents()

Khởi tạo danh mục loại phiếu:

```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(MyMenuInfo.moduleid);
arrayList.Add("0");
arrayList.Add(SystemInformations.CurrentCultureName);
ArrayList arrayList2 = CBO<lstVoucherInfo>.FillCollection(
    Commons.GetDataReader("asSIGetDmSo_ct", arrayList.ToArray()));
arrayList2.Add(new lstVoucherInfo("", AsiaErp.Framework.Environment.getLangSysMessageResX("#SYS_ALL").value));
cboLoaiPhieu.DataSource = arrayList2;
cboLoaiPhieu.DisplayMember = "TEN_CT";
cboLoaiPhieu.ValueMember = "MA_CT";
```

### LoadData()

Lấy dữ liệu master-detail từ DataSet:

```csharp
DataSet dataSet = MyController.GetDataSet(arrayList.ToArray());
set_MyDGVPhSource(isSet2Print: true, dataSet.Tables[1]);  // Phiếu
set_MyDGVCtSource(isSet2Print: true, dataSet.Tables[0]);  // Chi tiết
```

### dgvBCPh_RowEnter()

Xử lý sự kiện chuyển dòng trên grid phiếu để lọc chi tiết:

```csharp
((DataTable)dgvBCCt.DataSource).DefaultView.RowFilter = 
    "stt_rec='" + ((DataTable)dgvBCPh.DataSource).DefaultView[e.RowIndex]["stt_rec"].ToString() + "'";
```

### GetFilterTitle()

Xây dựng chuỗi tiêu đề lọc từ các điều kiện đã chọn.

## Dependencies

- AsiaErp.Framework.dll
- Helper.dll
- CrystalDecisions.Windows.Forms
- System.Data
- Microsoft.VisualBasic

## Ghi chú

- Sử dụng SplitContainer (scGrid) để chia 2 DataGridView
- Grid trên: danh sách phiếu (dgvBCPh)
- Grid dưới: chi tiết phiếu được chọn (dgvBCCt)
- Liên kết 2 grid qua field stt_rec

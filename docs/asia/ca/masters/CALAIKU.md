# Phân tích DLL: CALAIKU.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CALAIKU.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCALAIKU, frmCALAIKUEdit |
| **Kế thừa** | frmDMComplexView, frmDMComplexEdit |
| **Chức năng** | Quản lý lãi khế ước theo tháng |

## 2. Forms chi tiết

### frmCALAIKU (View Form)

**Controls:**
- Kế thừa từ frmDMComplexView
- Ẩn các nút: ChgCode, Search, Print
- Ẩn các control: txtValue, cboFilter, lblTen
- Điều chỉnh vị trí các nút còn lại

**Events:**

| Event | Mô tả |
|-------|-------|
| InitOtherAfterLoadData | Điều chỉnh vị trí nút Edit, Del, ẩn nút Add và ChgCode |
| Edit | Chỉ cho phép sửa nếu có quyền (sua_goc=1 hoặc sua_lai=1) |

### frmCALAIKUEdit (Edit Form)

**Controls:**

| Control | Type | DataField | Mô tả |
|---------|------|-----------|-------|
| txtNgay_tra | AsMaskedTextBox | Ngay_tra | Ngày trả |
| txtMa_ku | TextBox | Ma_ku | Mã khế ước (readonly) |
| txtNam | AsTextNumeric | Nam | Năm (readonly) |
| txtThang | AsTextNumeric | thang | Tháng (readonly) |
| txtTien_lai_tk | AsTextNumeric | Tien_lai_tk | Lãi trong kỳ |
| txtTien_lai_tk_nt | AsTextNumeric | Tien_lai_tk_nt | Lãi trong kỳ NT |
| txtTien_goc_tk | AsTextNumeric | Tien_goc_tk | Gốc trong kỳ |
| txtTien_goc_tk_nt | AsTextNumeric | Tien_goc_tk_nt | Gốc trong kỳ NT |
| txtTien_lai_qh | AsTextNumeric | Tien_lai_qh | Lãi quá hạn |
| txtTien_lai_qh_nt | AsTextNumeric | Tien_lai_qh_nt | Lãi quá hạn NT |
| txtTien_goc_qh | AsTextNumeric | Tien_goc_qh | Gốc quá hạn |
| txtTien_goc_qh_nt | AsTextNumeric | Tien_goc_qh_nt | Gốc quá hạn NT |
| chkSua_lai | AsCheckBox | Sua_lai | Cho phép sửa lãi |
| chkSua_goc | AsCheckBox | Sua_goc | Cho phép sửa gốc |

**Events:**

| Event | Mô tả |
|-------|-------|
| chkSua_lai_CheckedChanged | Enable/disable các trường lãi |
| chkSua_goc_CheckedChanged | Enable/disable các trường gốc |
| DataBinding | Bind dữ liệu vào controls |
| InitAfterGetData | Khởi tạo sau khi load dữ liệu |

**Business Logic:**

- Các trường thông tin chính (Ngày trả, Mã KU, Năm, Tháng) ở chế độ readonly
- Chỉ cho phép sửa khi check vào "Cho phép sửa"
- Nếu check "Sửa lãi": Enable các trường tiền lãi
- Nếu check "Sửa gốc": Enable các trường tiền gốc
- Có thể check cả 2 để sửa cả lãi và gốc
- Phân biệt: Trong kỳ vs Quá hạn
- Phân biệt: VND vs Ngoại tệ

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CALAIKU_GET | Lấy danh sách lãi khế ước |
| SP_CALAIKU_UPDATE | Update lãi khế ước |

## 4. Tables

| Table | Mô tả |
|-------|-------|
| CALAIKU | Lãi khế ước |

---

**Lưu ý:** 
- Form sử dụng bảng: CALAIKU (Lãi khế ước)
- Kế thừa từ frmDMComplexView/frmDMComplexEdit - framework danh mục phức tạp
- Có cơ chế phân quyền sửa (sua_goc, sua_lai)
- Không áp dụng mapping PHP (đây là form danh mục phức tạp, không phải voucher)

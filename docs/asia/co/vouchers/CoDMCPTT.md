# CoDMCPTT - Danh mục chi phí tập trung

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CoDMCPTT.dll |
| Assembly Title | FADMCC |
| Loại | Danh mục |
| Framework | .NET Framework 3.5 |

## Mô tả

Module quản lý **Danh mục chi phí tập trung** trong hệ thống ERP Asia Enterprise. Đây là module khai báo và quản lý các chi phí tập trung để phân bổ dần.

## Chức năng chính

1. **Quản lý danh mục chi phí tập trung**
   - Khai báo các loại chi phí tập trung (CPTT)
   - Quản lý thông tin cơ bản: mã, tên, đơn vị tính, số chứng từ
   - Theo dõi số lượng và đơn giá

2. **Phân bổ chi phí**
   - Xác định số kỳ phân bổ
   - Tính toán giá trị phân bổ cho từng kỳ
   - Theo dõi giá trị đã phân bổ và còn lại
   - Hỗ trợ sửa đổi giá trị phân bổ 1 kỳ (nếu được phép)

3. **Tích hợp tài khoản kế toán**
   - TK phân bổ: Tài khoản ghi nhận phân bổ
   - TK chi phí: Tài khoản chi phí tương ứng
   - Mã bộ phận sử dụng, mã phí, mã SPCT để phân bổ chi tiết

4. **Quản lý thời gian**
   - Ngày chứng từ
   - Ngày bắt đầu phân bổ
   - Ngày tính giá trị còn lại

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| ma_cptt | Mã chi phí tập trung |
| ten_cptt | Tên chi phí tập trung |
| dvt | Đơn vị tính |
| so_ct | Số chứng từ |
| ngay_ct | Ngày chứng từ |
| so_luong | Số lượng |
| don_gia | Đơn giá |
| so_ky | Số kỳ phân bổ |
| ng_gia | Nguyên giá |
| gt_da_kh | Giá trị đã phân bổ |
| gt_cl | Giá trị phân bổ còn lại |
| kh_ky | Giá trị phân bổ 1 kỳ |
| ngay_bdkh | Ngày bắt đầu phân bổ |
| ngay_gt_cl | Ngày giá trị còn lại |
| sua_kh | Cho phép sửa phân bổ |
| tk_cptt | TK phân bổ |
| tk_cp | TK chi phí |
| ma_bpsd | Mã bộ phận sử dụng |
| ma_spct | Mã sản phẩm chi tiết |
| MA_PHI | Mã phí |

## Forms

- `frmCoDMCPTT`: Form danh sách danh mục (kế thừa frmDMComplexView)
- `frmCoDMCPTTEdit`: Form nhập liệu (kế thừa frmDMComplexEdit)

## Business Logic

### Tính toán tự động

1. **Nguyên giá**: `txtNguyen_gia = txtSo_luong * txtDon_gia`
2. **Giá trị còn lại**: `txtGiatri_pn_con_lai = txtNguyen_gia - txtGia_tri_da_pb`
3. **Giá trị phân bổ 1 kỳ**: `txtGiatri_pb_1ky = txtNguyen_gia / txtSo_ky_BP`

### DAO Methods

| Method | Mô tả |
|--------|-------|
| InsCPTT | Thêm mới chi phí tập trung |
| UpdCPTT | Cập nhật chi phí tập trung |
| DelCPTT | Xóa chi phí tập trung |

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data

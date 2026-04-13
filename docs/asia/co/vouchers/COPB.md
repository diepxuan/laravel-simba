# COPB - Bút toán phân bổ tự động

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | COPB.dll |
| Assembly Title | BÚT TOÁN PHÂN BỔ TỰ ĐỘNG |
| Loại | Nghiệp vụ |
| Framework | .NET Framework 3.5 |

## Mô tả

Module thực hiện **Bút toán phân bổ chi phí tự động** trong hệ thống ERP Asia Enterprise. Đây là công cụ quan trọng để phân bổ chi phí gián tiếp về các đối tượng chi phí trực tiếp.

## Chức năng chính

1. **Phân bổ chi phí tự động**
   - Thực hiện bút toán phân bổ chi phí gián tiếp
   - Phân bổ theo nhiều tiêu chí: SPCT, bộ phận, TK đối ứng
   - Tính toán hệ số và tiền phân bổ tự động

2. **Quản lý kỳ phân bổ**
   - Chọn kỳ báo cáo (tháng/quý/năm)
   - Xác định khoảng thời gian phân bổ
   - Lưu lịch sử phân bổ

3. **Xử lý phân bổ**
   - Tính toán tiền nhận phân bổ
   - Áp dụng hệ số phân bổ
   - Xóa phân bổ khi cần điều chỉnh

4. **Tích hợp danh mục**
   - Lấy dữ liệu từ CODMPB (Danh mục phân bổ)
   - Hiển thị chi tiết phân bổ theo TK, SPCT, BP

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| pb | Phân bổ |
| tk_pb | Tài khoản phân bổ |
| tien_pb | Tiền phân bổ |
| he_so | Hệ số phân bổ |
| tien_nhan | Tiền nhận phân bổ |
| ma_spct | Mã sản phẩm chi tiết |
| ma_bo | Mã bộ phận |
| tk_du | Tài khoản đối ứng |

## Forms

- `frmCOPB`: Form thực hiện phân bổ (kế thừa frmAsiaRoot)

## UI Components

- `cboKyBc`: ComboBox chọn kỳ báo cáo
- `txtNgay1`, `txtNgay2`: Ngày bắt đầu/kết thúc
- `dgvDMPB`: DataGridView danh mục phân bổ 1
- `dgvDMPB2`: DataGridView danh mục phân bổ 2
- `btn_PB`: Button thực hiện phân bổ
- `btn_XPB`: Button xóa phân bổ

## Data Access Layer

- `COPBDAO`: Data Access Object cho phân bổ

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data

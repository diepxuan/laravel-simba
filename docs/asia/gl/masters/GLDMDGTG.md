# GLDMDGTG - Khai báo các bút toán đánh giá tỷ giá

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLDMDGTG.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Khai báo các bút toán đánh giá tỷ giá (DGTG) |

## Chức năng chính

### 1. Khai báo bút toán đánh giá tỷ giá
- Thiết lập các bút toán đánh giá tỷ giá tự động
- Cấu hình tài khoản lãi/lỗ chênh lệch tỷ giá
- Thiết lập tài khoản đánh giá tỷ giá công nợ

### 2. Phân tích đánh giá
- Chọn các chiều phân tích: bộ phận, phí, hợp đồng, SPCT, khách hàng
- Cấu hình loại đánh giá tỷ giá

### 3. Quản lý danh mục
- Thêm, sửa, xóa các bút toán đánh giá
- Sắp xếp theo số thứ tự
- Quản lý số chứng từ mặc định

## Các tài khoản đánh giá

| Control | Ý nghĩa |
|---------|---------|
| TK đánh giá TG | Tài khoản đánh giá tỷ giá |
| TK lãi CLTG | Tài khoản lãi chênh lệch tỷ giá |
| TK lỗ CLTG | Tài khoản lỗ chênh lệch tỷ giá |
| TK CLTG công nợ | Tài khoản CLTG công nợ |

## Các đối tượng đánh giá

| Checkbox | Ý nghĩa |
|----------|----------|
| ĐG theo bộ phận | Đánh giá theo bộ phận |
| ĐG theo phí | Đánh giá theo phí |
| ĐG theo hợp đồng | Đánh giá theo hợp đồng |
| ĐG theo SPCT | Đánh giá theo sản phẩm chi tiết |
| ĐG theo khách hàng | Đánh giá theo khách hàng |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `stt` | Số thứ tự |
| `ten_bt` | Tên bút toán |
| `so_ct` | Số chứng từ |
| `loai_dg` | Loại đánh giá |
| `tk_dgtg` | Tài khoản đánh giá tỷ giá |
| `tk_lai_cltg` | Tài khoản lãi CLTG |
| `tk_lo_cltg` | Tài khoản lỗ CLTG |
| `tk_cltg_cn` | Tài khoản CLTG công nợ |
| `dg_bp` | Đánh giá theo bộ phận |
| `dg_phi` | Đánh giá theo phí |
| `dg_hd` | Đánh giá theo hợp đồng |
| `dg_spct` | Đánh giá theo SPCT |
| `dg_kh` | Đánh giá theo khách hàng |

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLDMDGTG` | `frmDMComplexView` | Form xem danh mục đánh giá tỷ giá |
| `frmGLDMDGTGEdit` | `frmDMComplexEdit` | Form nhập liệu đánh giá tỷ giá |

## Dependencies

- `System.Data` - Data access
- `AsiaErp.Framework` - Asia ERP Framework

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLDMDGTG |
| Assembly Title | Khai báo các bút toán đánh giá tỷ giá |
| Assembly Company | ASIASOFT |
| Assembly Product | GLDMDGTG |
| Assembly Copyright | Copyright © ASIA 2010 |
| Assembly Version | 1.0.0.0 |
| GUID | 0ce1218b-9158-4801-a59d-f3c8d40d51f2 |

---

*Ngày cập nhật: 2026-03-29*

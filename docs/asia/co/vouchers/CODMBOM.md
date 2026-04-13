# CODMBOM - Định mức nguyên vật liệu (BOM)

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CODMBOM.dll |
| Assembly Title | Định mức nguyên vật liệu |
| Loại | Danh mục |
| Framework | .NET Framework 3.5 |

## Mô tả

Module quản lý **Định mức nguyên vật liệu (BOM - Bill of Materials)** trong hệ thống ERP Asia Enterprise. Đây là module định nghĩa cấu trúc sản phẩm và định mức tiêu hao vật tư.

## Chức năng chính

1. **Quản lý BOM (Bill of Materials)**
   - Định nghĩa cấu trúc sản phẩm (thành phần nguyên vật liệu)
   - Thiết lập định mức tiêu hao cho từng vật tư
   - Phân loại vật tư chính/phụ
   - Quản lý thời gian hiệu lực của định mức

2. **Quản lý giá nhân công**
   - Thiết lập đơn giá nhân công cho sản phẩm
   - Hỗ trợ tính giá thành sản phẩm
   - Cập nhật định kỳ đơn giá

3. **Tìm kiếm và Lọc**
   - Tìm kiếm theo mã sản phẩm
   - Lọc theo tiêu chí người dùng
   - Hiển thị danh sách sản phẩm và chi tiết vật tư

4. **Tích hợp sản xuất**
   - Cung cấp dữ liệu cho tính giá thành
   - Hỗ trợ lập kế hoạch nguyên vật liệu
   - Liên kết với module định mức chi tiết (CODD1)

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| ma_spct | Mã sản phẩm chi tiết |
| ma_vt | Mã vật tư |
| so_luong | Số lượng định mức |
| don_gia_luong | Đơn giá nhân công |
| vt_chinh | Vật tư chính |
| ngay1 | Ngày bắt đầu hiệu lực |
| ngay2 | Ngày kết thúc hiệu lực |
| ghi_chu | Ghi chú |

## Forms

- `frmCODMBOM`: Form quản lý BOM chính (kế thừa frmAsiaRoot)

## Data Access Layer

### Stored Procedures

| Stored Procedure | Mục đích |
|----------------|----------|
| asCOGetDMCobomPH | Lấy dữ liệu BOM master |
| asCOInsDMCoBomPH | Insert BOM master |
| asCOUpdDMCoBomPH | Update BOM master |
| asCODelDMCobomPH | Delete BOM master |
| asCOGetDMCobomCT | Lấy dữ liệu BOM chi tiết |
| asCOInsDMCobomCT | Insert BOM chi tiết |
| asCODelDMCobomCT | Delete BOM chi tiết |

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
- System.Xml.Linq
- System.Core

# Module SI - Sales Invoice / Hệ thống chung

## Tổng quan

Module SI (Sales Invoice) là tập hợp các chức năng hệ thống chung của Asia ERP, bao gồm các module danh mục, chứng từ, báo cáo và công cụ hỗ trợ.

## Phân loại module

### 1. Danh mục chính

| DLL | Tên | Mô tả |
|-----|-----|---------|
| SIDMCT.dll | Danh mục chứng từ | Khai báo và cấu hình các loại chứng từ |
| SIDMHD.dll | Danh mục hợp đồng | Quản lý hợp đồng mua/bán |
| SIDMNHHD.dll | Danh mục nhóm hợp đồng | Phân loại hợp đồng |
| SIDMHTTT.dll | Danh mục hình thức thanh toán | Các phương thức thanh toán |
| SIDMNT.dll | Danh mục ngoại tệ | Quản lý tiền tệ |
| SIDMTGNT.dll | Danh mục tỷ giá ngoại tệ | Tỷ giá và chuyển đổi tiền tệ |
| SIDMNGH.dll | Danh mục ngân hàng | Thông tin ngân hàng |
| SIDMPHI.dll | Danh mục phí | Các loại phí |
| SIDMOpt9.dll | Danh mục tùy chọn 9 | Thông tin mở rộng |
| SIDMOpt10.dll | Danh mục tùy chọn 10 | Thông tin mở rộng |

### 2. Chứng từ

| DLL | Tên | Mã CT | Mô tả |
|-----|-----|-------|---------|
| SIVchSI1.dll | Phiếu nhập kho | IN1 | Nhập kho thành phẩm và khác |

### 3. Báo cáo

| DLL | Tên | Mô tả |
|-----|-----|---------|
| SIRptLOGCT.dll | Thống kê cập nhật chứng từ | Theo dõi log sửa/xóa chứng từ |

### 4. Công cụ hệ thống

| DLL | Tên | Mô tả |
|-----|-----|---------|
| SIAbout.dll | Thông tin chương trình | Hiển thị thông tin phần mềm |
| SIBackupData.dll | Sao lưu dữ liệu | Backup/Restore database |
| SIMaintain.dll | Bảo trì hệ thống | Các công cụ bảo trì |
| SISysvars.dll | Tham số hệ thống | Cấu hình tham số |
| SITheme.dll | Theme | Cấu hình giao diện |
| SIUPDATETOOL.dll | Cập nhật chương trình | Đồng bộ và cập nhật phiên bản |
| SIGroupInfo.dll | Danh mục bộ phận | Quản lý nhóm người dùng và phân quyền |

### 5. Công cụ tiện ích

| DLL | Tên | Mô tả |
|-----|-----|---------|
| SiChangeFY.dll | Thay đổi năm tài chính | Chuyển đổi năm làm việc |
| SiImExData.dll | Import/Export dữ liệu | Chuyển số liệu giữa các công ty |
| SiInfomationProduct.dll | Thông tin sản phẩm | Thông tin và đăng ký bản quyền |
| SiReOrderVoucherNumber.dll | Sắp xếp số chứng từ | Kết chuyển và đánh số lại |
| SiTools.dll | Công cụ hệ thống | Công cụ admin và cấu hình |
| SiTools_2.dll | Công cụ hệ thống (v2) | Phiên bản cải tiến |
| SiUpdateLog.dll | Log cập nhật | Quản lý và tạo package update |

## Cấu trúc thư mục

```
docs/asia/si/
├── README.md                 # Tài liệu tổng quan
├── vouchers/                 # Tài liệu chứng từ
│   └── IN1.md             # Phiếu nhập kho
└── ...
```

## Thông tin kỹ thuật

- **Framework**: .NET Framework 3.5
- **Ngôn ngữ**: C# (một số decompiled từ VB.NET)
- **UI Framework**: Windows Forms
- **Database**: SQL Server
- **Company**: Asia Software Development JSC / ASIASOFT
- **Product**: Asia Enterprise / AsiaERP
- **Copyright**: 2010-2012

## Dependencies chung

- AsiaErp.Framework
- AsiaErp.DataAccess
- AsiaErp.Helper
- Microsoft.VisualBasic
- System.Data
- System.Drawing
- System.Windows.Forms
- System.Xml

## Danh mục chứng từ (SIDMCT)

Module SIDMCT.dll quản lý danh mục chứng từ với các chức năng:

### Cấu hình số chứng từ

| Trường | Ý nghĩa |
|---------|----------|
| `vn_prefix` | Phần đầu số chứng từ |
| `vn_sequence` | Phần tự tăng |
| `vn_postfix` | Phần cuối số chứng từ |
| `vn_pattern` | Ký tự mẫu (pad character) |
| `vn_width` | Độ rộng số chứng từ |

### Kiểu trùng số chứng từ

| Giá trị | Ý nghĩa |
|---------|----------|
| 0 | Cho phép trùng |
| 1 | Theo tháng |
| 2 | Theo năm |

### Các trường mở rộng có thể bật/tắt

- `vv` - Sử dụng trường mã hợp đồng
- `phi` - Sử dụng trường mã phí
- `bp` - Sử dụng trường mã bộ phận
- `spct` - Sử dụng trường mã SPCT
- `lo` - Sử dụng trường mã lô

## Danh mục hợp đồng (SIDMHD)

### Loại hợp đồng

| Giá trị | Ý nghĩa |
|---------|----------|
| 1 | Bán |
| 2 | Mua |

### Thông tin quản lý

- Mã hợp đồng (`ma_hd`)
- Tên hợp đồng (`ten_hd`)
- Số hợp đồng (`so_hd`)
- Nhóm hợp đồng (`ma_nhhd`)
- Khách hàng (`ma_kh`, `ten_kh`)
- Bộ phận (`ma_bp`, `ten_bp`)
- Ngày hợp đồng (`ngay_hd`)
- Ngày hết hạn (`ngay_hh`)
- Mã ngoại tệ (`ma_nt`)
- Tiền hợp đồng (`tien`, `tien_nt`)
- Nội dung (`noi_dung`)

## Bảo trì hệ thống (SIMaintain)

Các chức năng bảo trì chính:

| Chức năng | Mô tả |
|-------------|-------|
| Đánh lại chỉ mục | Tối ưu database (ReIndex) |
| Loại bỏ dấu trắng | Trim khoảng trắng trong mã |
| Kiểm tra hạch toán | Kiểm tra hạch toán vào TK tổng hợp |
| Kiểm tra lệch sổ | Đối chiếu sổ kế toán và kho |
| Sao lưu dữ liệu | Backup thủ công |
| Tự động sao lưu | Cấu hình auto backup |

## Phân quyền (SIGroupInfo)

Các quyền trong hệ thống:

| Quyền | Ý nghĩa |
|--------|----------|
| ViewRight | Quyền xem dữ liệu |
| InsertRight | Quyền thêm mới |
| UpdateRight | Quyền chỉnh sửa |
| DeleteRight | Quyền xóa dữ liệu |

## Ghi chú

- Module SI là phân hệ hệ thống chung, cung cấp nền tảng cho các phân hệ khác
- Các danh mục trong SI được sử dụng rộng rãi trong các module khác
- Chứng từ IN1 (Phiếu nhập kho) là chứng từ kho chính
- Các công cụ bảo trì và cấu hình giúp quản trị viên duy trì hệ thống

---

*Ngày cập nhật: 2026-03-29*

# GLRptBCTCCR01F5 - Drill-down báo cáo CCR01

## Mô tả

Module drill-down hiển thị chi tiết từ báo cáo tài chính CCR01.

## Chức năng chính

### 1. Drill-down báo cáo CCR01
- Hiển thị chi tiết từ báo cáo CCR01 chính
- Xem thông tin tài khoản đối ứng (tk_du)
- Drill-down sâu hơn với F5

### 2. Tạo tham số drill-down
- Tự động tạo tham số từ dòng được chọn
- Truyền tham số: CompanyID, TK, TK đối ứng, ngày, mã ngoại tệ
- Hiển thị tiêu đề lọc với định dạng "TK/TK_du"

### 3. Tích hợp với báo cáo mẹ
- Nhận thông tin từ báo cáo mẹ (motherReportInfo)
- Kế thừa các tham số từ báo cáo gốc
- Chia sẻ datasource với báo cáo mẹ

## Tham số drill-down

| Tham số | Kiểu | Mục đích |
|---------|------|----------|
| motherReportInfo | ReportInformation | Thông tin báo cáo mẹ |
| drilldownMenuId | string | ID menu drill-down |
| formularFields | AsDictionary | Các trường công thức |
| isNT | bool | Có phải ngoại tệ không |
| nhan_in | string | Nhãn in |
| filter4Tilte | string | Điều kiện lọc cho tiêu đề |
| formatedColList | string | Danh sách cột định dạng |
| datasource | object | Nguồn dữ liệu |
| arg | params object[] | Tham số bổ sung |

## Thuật ngữ kỹ thuật

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk_du` | Tài khoản đối ứng |
| `Parameters4DrillDown` | Tham số drill-down |
| `ngay_ct1` | Ngày chứng từ từ |
| `ngay_ct2` | Ngày chứng từ đến |
| `ma_nt` | Mã ngoại tệ |

## Đặc điểm kỹ thuật

- Kế thừa từ `frmDrilldownReport` - form drill-down chuẩn
- Sử dụng `CreateDrilldownArgument` để tạo tham số
- Hỗ trợ phím tắt F5 để drill-down tiếp
- Tự động kiểm tra `tk_du` trước khi drill-down

## Dependencies

- AsiaErp.Framework
- AsiaErp.DataAccess
- System.Data
- System.Windows.Forms
- Microsoft.VisualBasic

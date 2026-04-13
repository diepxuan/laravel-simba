# Phân tích DLL: ArRptF5BCCN01a.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ArRptF5BCCN01a.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmArRptF5BCCN01a |
| **Kế thừa** | frmDrilldownReport |
| **Chức năng** | Báo cáo F5 công nợ khách hàng (Drill-down) |

## 2. Forms

### 2.1 frmArRptF5BCCN01a (Drilldown Report Form)

**Mô tả:** Form báo cáo F5 công nợ với khả năng drill-down

**Chức năng:**
- Hiển thị báo cáo công nợ khách hàng theo định dạng F5
- Hỗ trợ drilldown (đào sâu) từ báo cáo tổng hợp sang chi tiết
- Hiển thị dữ liệu dưới dạng DataGridView với khả năng tương tác

## 3. Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| motherReportInfo | ReportInformation | Thông tin báo cáo mẹ |
| drilldownMenuId | string | ID menu drilldown |
| formularFields | AsDictionary | Dictionary các trường công thức |
| isNT | bool | Có phải ngoại tệ không |
| nhan_in | string | Nhãn in |
| filter4Tilte | string | Filter cho tiêu đề |
| formatedColList | string | Danh sách cột định dạng |
| datasource | object | Nguồn dữ liệu |
| arg | params object[] | Các tham số bổ sung |

## 4. Business Logic

### Chức năng Drilldown
- Kế thừa từ `frmDrilldownReport` - form báo cáo có khả năng drilldown
- Hỗ trợ điều hướng từ báo cáo tổng quan sang chi tiết
- Truyền thông tin drilldown qua `ReportInformation` và các tham số liên quan

### Methods chính
| Phương thức | Mô tả |
|-------------|-------|
| `InitOtherComponents()` | Khởi tạo các component bổ sung, focus vào DataGridView báo cáo |
| `CreateDrilldownArgument()` | Tạo argument cho drilldown report (trả về null) |
| `InitializeComponent()` | Khởi tạo UI components |

## 5. Dependencies

- `AsiaErp.Framework`
- `AsiaErp.Helper`
- `Microsoft.VisualBasic`
- `System.Windows.Forms`
- `System.Data`

## 6. Ghi chú

- Đây là module báo cáo F5 công nợ khách hàng
- Hỗ trợ drill-down từ báo cáo ARRptBCCN01a
- Phù hợp cho việc xem chi tiết công nợ từ báo cáo tổng hợp

# SORptF5BCPT06.dll - Báo cáo phân tích F5 06

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SORptF5BCPT06.dll |
| **Chức năng** | Báo cáo phân tích F5 06 (Drill-down) |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmSORptF5BCPT06 |
| **Kế thừa** | frmDrilldownReport |
| **Phiên bản** | 1.0.0.0 |
| **Framework** | .NET 3.5 |

## Mô tả

DLL báo cáo drill-down từ SORptBCPT06. Được gọi khi người dùng nhấn F4 trên báo cáo bán hàng 2 chỉ tiêu để xem chi tiết.

## Cấu trúc Form

### frmSORptF5BCPT06

Form báo cáo kế thừa từ `frmDrilldownReport`:

#### Constructors

```csharp
// Constructor chính được gọi từ báo cáo mẹ
public frmSORptF5BCPT06(
    ReportInformation motherReportInfo, 
    string drilldown_menuid, 
    AsDictionary formularFields, 
    bool isNT, 
    string nhan_in, 
    string filter4Title, 
    string formatedColList, 
    object datasource, 
    params object[] arg)

// Constructor mặc định
public frmSORptF5BCPT06()
```

## Business Logic

### InitializeComponent()

Khởi tạo container cơ bản:

```csharp
private void InitializeComponent()
{
    components = new Container();
}
```

## Dependencies

- AsiaErp.Framework.dll
- Microsoft.VisualBasic

## Ghi chú

- Đây là báo cáo drill-down, không có tabFilter
- Dữ liệu được truyền từ báo cáo mẹ (SORptBCPT06)
- Hiển thị chi tiết theo tham số đã được lọc từ báo cáo gốc
- Phiên bản đơn giản, chỉ hiển thị dữ liệu đã được xử lý

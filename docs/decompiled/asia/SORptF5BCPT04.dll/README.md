# SORptF5BCPT04.dll - Báo cáo phân tích F5 04

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SORptF5BCPT04.dll |
| **Chức năng** | Báo cáo phân tích F5 04 (Drill-down) |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmSORptF5BCPT04 |
| **Kế thừa** | frmDrilldownReport |
| **Phiên bản** | 1.0.0.0 |
| **Framework** | .NET 3.5 |

## Mô tả

DLL báo cáo drill-down từ SORptBCPT04. Được gọi khi người dùng nhấn F4 trên báo cáo doanh số theo bộ phận/nhân viên bán hàng để xem chi tiết.

## Cấu trúc Form

### frmSORptF5BCPT04

Form báo cáo kế thừa từ `frmDrilldownReport`:

#### Constructors

```csharp
// Constructor chính được gọi từ báo cáo mẹ
public frmSORptF5BCPT04(
    ReportInformation motherReportInfo, 
    string drilldownMenuId, 
    AsDictionary formularFields, 
    bool isNT, 
    string nhan_in, 
    string filter4Tilte, 
    string formatedColList, 
    object datasource, 
    params object[] arg)

// Constructor mặc định
public frmSORptF5BCPT04()
```

#### Phương thức

| Phương thức | Mô tả |
|-------------|-------|
| InitOtherComponents() | Khởi tạo, focus vào grid báo cáo |
| CreateDrilldownArgument() | Không hỗ trợ drill-down tiếp (trả về null) |

## Business Logic

### InitOtherComponents()

```csharp
protected override void InitOtherComponents()
{
    base.InitOtherComponents();
    ((Control)base.dgvBC).Select();
}
```

### CreateDrilldownArgument()

Báo cáo này không hỗ trợ drill-down tiếp:

```csharp
protected override ArrayList CreateDrilldownArgument(...)
{
    return null;
}
```

## Dependencies

- AsiaErp.Framework.dll
- Microsoft.VisualBasic

## Ghi chú

- Đây là báo cáo drill-down, không có tabFilter
- Dữ liệu được truyền từ báo cáo mẹ (SORptBCPT04)
- Hiển thị chi tiết theo tham số đã được lọc từ báo cáo gốc
- Không hỗ trợ drill-down tiếp (F4 không có tác dụng)

# SORptF5TH0.dll - Báo cáo tổng hợp F5

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SORptF5TH0.dll |
| **Chức năng** | Báo cáo tổng hợp F5 (Drill-down) |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmSORptF5TH0 |
| **Kế thừa** | frmDrilldownReport |
| **Phiên bản** | 1.0.0.0 |
| **Framework** | .NET 3.5 |

## Mô tả

DLL báo cáo drill-down tổng hợp. Được gọi khi người dùng nhấn F4 trên các báo cáo tổng hợp để xem chi tiết.

## Cấu trúc Form

### frmSORptF5TH0

Form báo cáo kế thừa từ `frmDrilldownReport`:

#### Constructors

```csharp
// Constructor chính được gọi từ báo cáo mẹ
public frmSORptF5TH0(
    ReportInformation motherReportInfo, 
    string drilldown_menuid, 
    AsDictionary formularFields, 
    bool isNT, 
    string nhan_in, 
    string filter4Tilte, 
    string formatedColList, 
    ref object datasource, 
    params object[] arg)

// Constructor mặc định
public frmSORptF5TH0()
```

#### Phương thức

| Phương thức | Mô tả |
|-------------|-------|
| CreateDrilldownArgument() | Gọi base.CreateDrilldownArgument (hỗ trợ drill-down tiếp) |

## Business Logic

### CreateDrilldownArgument()

Hỗ trợ drill-down tiếp:

```csharp
protected override ArrayList CreateDrilldownArgument(
    ReportDrillDownInfo drilldownInfo, 
    ref string sDrilldownMenuId, 
    Keys keycode, 
    Keys modifierKeys, 
    ref string filterCondition4title, 
    ref object datasource)
{
    return base.CreateDrilldownArgument(
        drilldownInfo, ref sDrilldownMenuId, keycode, modifierKeys, 
        ref filterCondition4title, ref datasource);
}
```

## Dependencies

- AsiaErp.Framework.dll
- Microsoft.VisualBasic

## Ghi chú

- Đây là báo cáo drill-down, không có tabFilter
- Có thể hỗ trợ drill-down tiếp (khác với F5BCPT03, F5BCPT04, F5BCPT06)
- Dữ liệu được truyền từ báo cáo mẹ
- Form đơn giản, không có logic phức tạp

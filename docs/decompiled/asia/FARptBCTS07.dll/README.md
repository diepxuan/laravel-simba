# Báo cáo Phân tích DLL: FARptBCTS07.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | FARptBCTS07 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Target Framework | net35 |

---

## Cấu trúc File

```
FARptBCTS07.dll/
├── FARptBCTS07.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmFARptBCTS07.cs        # Main report form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFARptBCTS07` | `frmReport` | Form báo cáo biến động tài sản 07 |
| `GroupItem` | - | Class hỗ trợ nhóm dữ liệu (Value, Text) |

---

## Controls và UI

### Filter Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| txtNgay | AsMaskedTextBox | Ngày báo cáo |
| txtMa_TS | AsTextBox | Mã tài sản |
| lblTen_TS | Label | Tên tài sản |
| txtMa_nhts1 | AsTextBox | Mã nhóm tài sản 1 |
| lblTen_nhts1 | Label | Tên nhóm tài sản 1 |
| txtMa_nhts2 | AsTextBox | Mã nhóm tài sản 2 |
| lblTen_nhts2 | Label | Tên nhóm tài sản 2 |
| txtMa_nhts3 | AsTextBox | Mã nhóm tài sản 3 |
| lblTen_nhts3 | Label | Tên nhóm tài sản 3 |
| txtMa_Bp | AsTextBox | Mã bộ phận |
| lblTen_Bp | Label | Tên bộ phận |
| txtMa_Phi | AsTextBox | Mã phí |
| lblTen_Phi | Label | Tên phí |
| txtMa_Spct | AsTextBox | Mã SPCT |
| lblTen_Spct | Label | Tên SPCT |
| cboNhom_cap1 | AsComboBox | Nhóm cấp 1 |
| lblNhom_cap1 | Label | Nhãn "Nhóm cấp 1" |
| cboNhom_cap2 | AsComboBox | Nhóm cấp 2 |
| lblNhom_cap2 | Label | Nhãn "Nhóm cấp 2" |
| cboNhom_cap3 | AsComboBox | Nhóm cấp 3 |
| lblNhom_cap3 | Label | Nhãn "Nhóm cấp 3" |

### Buttons

| Button | Chức năng |
|--------|-----------|
| cmdOk | Xem báo cáo |
| cmdCancel | Hủy |
| cmdExcel | Xuất Excel |
| cmdModifyReport | Sửa mẫu báo cáo |

---

## Business Logic

### Class GroupItem

```csharp
internal class GroupItem
{
    private string mtext;
    private string mvalue;
    
    public object Text { get; set; }
    public object Value { get; set; }
    
    public GroupItem(string value, string text)
}
```

### Phương thức chính

#### `InitOtherComponents()`
- Khởi tạo mảng nhóm `ar[7]` với các GroupItem:
  - Index 0: "", "" (Không nhóm)
  - Index 1: "Ma_bpsd", "Bộ phận sử dụng"
  - Index 2: "ma_phi", "Phí"
  - Index 3: "ma_spct", "Sản phẩm công trình"
  - Index 4: "ma_nhts1", "Nhóm tài sản 1"
  - Index 5: "ma_nhts2", "Nhóm tài sản 2"
  - Index 6: "ma_nhts3", "Nhóm tài sản 3"
- Thiết lập ValueMember và DisplayMember cho cboNhom_cap1
- Gán ngày hiện tại cho txtNgay

#### `ValidData()`
- Kiểm tra ngày báo cáo không được rỗng
- Sử dụng ErrorProvider (epNotice) để hiển thị lỗi

#### `LoadData()`
- Lấy dữ liệu báo cáo từ controller
- Tham số truyền vào:
  - CompanyID
  - Ngày báo cáo (txtNgay)
  - Mã tài sản
  - Mã nhóm TS1, TS2, TS3
  - Mã bộ phận
  - Mã phí
  - Mã SPCT
  - cap1, cap2, cap3 (các cấp nhóm đã chọn)
- Gọi `ViewCrystalBySource()` để hiển thị báo cáo
- Thiết lập formula fields: strSubTitle, strFilterTitle

#### `GetFilterTitle()`
- Tạo chuỗi mô tả các điều kiện lọc đã chọn
- Bao gồm: mã TS, nhóm TS1-3, bộ phận, phí, SPCT, nhóm cấp 1-3

### Event Handlers

#### `cboNhom_cap1_SelectedIndexChanged()`
- Cập nhật giá trị cap1
- Lọc và cập nhật items cho cboNhom_cap2 và cboNhom_cap3
- Loại bỏ item đã chọn ở cboNhom_cap1

#### `cboNhom_cap2_SelectedIndexChanged()`
- Cập nhật giá trị cap2
- Lọc và cập nhật items cho cboNhom_cap3
- Loại bỏ cap1 và cap2 đã chọn

#### `cboNhom_cap3_SelectedIndexChanged()`
- Cập nhật giá trị cap3

---

## Lookup Codes

| Control | LookupCodeName | LookupWhereCondition | MaxLength |
|---------|----------------|----------------------|-----------|
| txtMa_TS | MA_TS | - | - |
| txtMa_nhts1 | Ma_nhts | loai_nh= '1' | - |
| txtMa_nhts2 | Ma_nhts | loai_nh = '2' | - |
| txtMa_nhts3 | Ma_nhts | loai_nh = '3' | - |
| txtMa_Bp | MA_BPSD | - | - |
| txtMa_Phi | MA_PHI | - | - |
| txtMa_Spct | MA_SPCT | - | - |

---

## Mục đích sử dụng

**FARptBCTS07.dll là module báo cáo biến động tài sản 07** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo biến động tài sản tại ngày
- Báo cáo tình hình tài sản tại một ngày cụ thể
- Không phải báo cáo theo kỳ mà là báo cáo tại thời điểm

#### 2. Nhóm dữ liệu 3 cấp động
- Hỗ trợ nhóm báo cáo theo 3 cấp (cboNhom_cap1, cboNhom_cap2, cboNhom_cap3)
- Các tiêu chí nhóm: BPSD, phí, SPCT, nhóm TS1-3
- Logic loại bỏ trùng lặp giữa các cấp nhóm

#### 3. Lọc dữ liệu đa chiều
- Theo ngày báo cáo
- Theo mã tài sản
- Theo 3 cấp nhóm tài sản
- Theo bộ phận, phí, SPCT

#### 4. Xuất báo cáo
- Xem trước báo cáo Crystal Reports
- In ấn
- Xuất Excel

### Đặc điểm kỹ thuật

- Báo cáo tại ngày (khác với báo cáo theo kỳ)
- Có class GroupItem riêng để quản lý nhóm
- Logic xử lý nhóm 3 cấp phức tạp với dependency
- Sử dụng ErrorProvider cho validation

---

## Kết luận

Đây là module báo cáo biến động tài sản tại thời điểm với khả năng nhóm dữ liệu 3 cấp động, phục vụ cho việc phân tích tài sản theo nhiều chiều khác nhau tại một ngày cụ thể.

---

*Ngày phân tích: 2026-03-29*

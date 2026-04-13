# Báo cáo Phân tích DLL: FARptBCTS04.dll

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
| Assembly Name | FARptBCTS04 |
| Assembly Title | FARptBCTS04 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | adc4b9eb-db5d-4014-951a-ebe022e87f7b |
| ComVisible | false |

---

## Cấu trúc File

```
FARptBCTS04.dll/
├── FARptBCTS04.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmFARptBCTS04.cs        # Main report form
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFARptBCTS04` | `frmReport` | Form báo cáo biến động tài sản 04 |
| `GroupItem` | - | Class hỗ trợ nhóm dữ liệu (value/text) |

---

## Các trường dữ liệu Filter

| Control | Loại | Mô tả | Lookup |
|---------|------|-------|--------|
| txtMa_ts | AsTextBox | Mã tài sản | MA_TS |
| txtMa_Nhts1 | AsTextBox | Mã nhóm TS1 | MA_NHTS (loai_nh=1) |
| txtMa_Nhts2 | AsTextBox | Mã nhóm TS2 | MA_NHTS (loai_nh=2) |
| txtMa_Nhts3 | AsTextBox | Mã nhóm TS3 | MA_NHTS (loai_nh=3) |
| txtMa_BPSD | AsTextBox | Mã bộ phận sử dụng | MA_BPSD |
| txtMa_Phi | AsTextBox | Mã phí | MA_PHI |
| txtMa_SPCT | AsTextBox | Mã SPCT | MA_SPCT |
| cboNhom_cap1 | AsComboBox | Nhóm cấp 1 | - |
| cboNhom_cap2 | AsComboBox | Nhóm cấp 2 | - |
| cboNhom_cap3 | AsComboBox | Nhóm cấp 3 | - |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ts` | Mã tài sản |
| `ma_nhts1` | Mã nhóm tài sản 1 |
| `ma_nhts2` | Mã nhóm tài sản 2 |
| `ma_nhts3` | Mã nhóm tài sản 3 |
| `ma_bpsd` | Mã bộ phận sử dụng |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm công trình |

---

## Mục đích sử dụng

**FARptBCTS04.dll là module báo cáo biến động tài sản 04** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Lọc dữ liệu báo cáo
- Lọc theo mã tài sản (MA_TS)
- Lọc theo 3 cấp nhóm tài sản (MA_NHTS1, MA_NHTS2, MA_NHTS3)
- Lọc theo bộ phận sử dụng (MA_BPSD)
- Lọc theo mã phí (MA_PHI)
- Lọc theo mã sản phẩm công trình (MA_SPCT)

#### 2. Nhóm dữ liệu đa cấp
- Hỗ trợ nhóm cấp 1: Bộ phận sử dụng, Phí, Sản phẩm công trình, Nhóm tài sản 1/2/3
- Hỗ trợ nhóm cấp 2: phụ thuộc vào cấp 1 (loại trừ đã chọn)
- Hỗ trợ nhóm cấp 3: phụ thuộc vào cấp 1 và 2
- Logic cascade: cboNhom_cap1 → cboNhom_cap2 → cboNhom_cap3

#### 3. Tham số báo cáo
- Kỳ báo cáo (cboKyBc)
- Ngày bắt đầu/kết thúc (txtNgay1, txtNgay2)
- Mẫu báo cáo (cboMau_bc)
- Tiêu đề báo cáo tùy chỉnh (txtTieu_De)

#### 4. Xuất dữ liệu
- Xem trước báo cáo (cmdOk)
- Xuất Excel (cmdExcel)
- Chỉnh sửa mẫu báo cáo (cmdModifyReport)

### Đặc điểm kỹ thuật

- Sử dụng AsTextBox với AutoLookup cho các trường mã
- Hiển thị tên đối tượng tự động qua NameControl
- Hỗ trợ lọc theo nhiều tiêu chí kết hợp
- Tạo subtitle động từ các điều kiện lọc
- Sử dụng GroupItem class cho việc binding dữ liệu nhóm
- Có sử dụng UseAutoCompleteSource cho các trường lookup

### Xử lý nhóm đa cấp

```csharp
// Các nhóm có thể chọn:
ar[0] = GroupItem("", "")
ar[1] = GroupItem("Ma_bpsd", "Bộ phận sử dụng")
ar[2] = GroupItem("ma_phi", "Phí")
ar[3] = GroupItem("ma_spct", "Sản phẩm công trình")
ar[4] = GroupItem("ma_nhts1", "Nhóm tài sản 1")
ar[5] = GroupItem("ma_nhts2", "Nhóm tài sản 2")
ar[6] = GroupItem("ma_nhts3", "Nhóm tài sản 3")
```

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và xuất báo cáo biến động tài sản cố định 04, có hỗ trợ nhóm dữ liệu đa cấp (3 cấp) linh hoạt.

---

*Ngày phân tích: 2026-03-29*

# Báo cáo Phân tích DLL: FARptBCPT03.dll

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
| Assembly Name | FARptBCPT03 |
| Assembly Title | FARptBCPT03 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 517f0c8b-4895-46f7-9113-70d8f948acca |
| ComVisible | false |

---

## Cấu trúc File

```
FARptBCPT03.dll/
├── FARptBCPT03.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmFARptBCPT03.cs        # Main report form
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
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFARptBCPT03` | `frmReport` | Form báo cáo phân tích tài sản 03 |

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
| `ten_nv` | Tên nguồn vốn |

---

## Mục đích sử dụng

**FARptBCPT03.dll là module báo cáo phân tích tài sản 03** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Lọc dữ liệu báo cáo
- Lọc theo mã tài sản (MA_TS)
- Lọc theo 3 cấp nhóm tài sản (MA_NHTS1, MA_NHTS2, MA_NHTS3)
- Lọc theo bộ phận sử dụng (MA_BPSD)
- Lọc theo mã phí (MA_PHI)
- Lọc theo mã sản phẩm công trình (MA_SPCT)

#### 2. Tham số báo cáo
- Kỳ báo cáo (cboKyBc)
- Ngày bắt đầu/kết thúc (txtNgay1, txtNgay2)
- Mẫu báo cáo (cboMau_bc)
- Tiêu đề báo cáo tùy chỉnh (txtTieu_De)

#### 3. Thông tin nguồn vốn
- Tích hợp lấy tên nguồn vốn từ `Commons.FAGetTenNguonVon()`
- Hỗ trợ 4 nguồn vốn: strNV1, strNV2, strNV3, strNV4
- Truyền thông tin nguồn vốn vào formula fields cho báo cáo

#### 4. Xuất dữ liệu
- Xem trước báo cáo (cmdOk)
- Xuất Excel (cmdExcel)
- Chỉnh sửa mẫu báo cáo (cmdModifyReport)

### Đặc điểm kỹ thuật

- Sử dụng AsTextBox với AutoLookup cho các trường mã
- Hiển thị tên đối tượng tự động qua NameControl
- Hỗ trợ lọc theo nhiều tiêu chí kết hợp
- Tạo subtitle động từ các điều kiện lọc (GetFilterTitle)
- Lấy thông tin nguồn vốn động từ database

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và xuất báo cáo phân tích tài sản cố định 03, có tích hợp thông tin nguồn vốn đầu tư.

---

*Ngày phân tích: 2026-03-29*

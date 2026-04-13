# Báo cáo Phân tích DLL: FAChuyenTS.dll

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
| Assembly Name | FAChuyenTS |
| Assembly Title | FADMTSCD |
| Assembly Company | (không có) |
| Assembly Product | FADMTSCD |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | c1f6ebc7-cf45-4ced-9e67-94d10d7b9a0c |
| ComVisible | false |

---

## Cấu trúc File

```
FAChuyenTS.dll/
├── FAChuyenTS.csproj              # Project file
├── app.ico                        # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmFAChuyenTS.cs           # Main form class (danh mục view)
│   └── frmFAChuyenTSEdit.cs       # Edit form class
└── AsiaErp.UserInterface.My/
    ├── MyProject.cs
    ├── MySettings.cs
    ├── MySettingsProperty.cs
    ├── MyApplication.cs
    ├── MyComputer.cs
    └── InternalXmlHelper.cs
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML LINQ support |
| System.Core | Core system functions |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |
| System.Data | Data access |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFAChuyenTS` | `frmDMComplexView` | Form xem danh mục chuyển tài sản |
| `frmFAChuyenTSEdit` | `frmDMComplexEdit` | Form nhập liệu chuyển tài sản |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã tài sản", "Tên tài sản"
- "Ngày chuyển", "Loại chuyển"
- "Mã BPSD" (bộ phận sử dụng)
- "Mã SPCT" (sản phẩm công trình)
- "Mã phí"
- "Tài khoản tài sản" (TK_TS)
- "Tài khoản khấu hao" (TK_KH)
- "Tài khoản chi phí" (TK_CP)

### Các loại chuyển (ComboBox)

| Giá trị | Ý nghĩa |
|---------|---------|
| MA_BPSD | Chuyển bộ phận sử dụng |
| MA_SPCT | Chuyển sản phẩm công trình |
| MA_PHI | Chuyển mã phí |
| TK_TS | Chuyển tài khoản tài sản |
| TK_KH | Chuyển tài khoản khấu hao |
| TK_CP | Chuyển tài khoản chi phí |

### Thuật ngữ kế toán

| Thuật tính | Ý nghĩa |
|------------|---------|
| `ma_ts` | Mã tài sản |
| `ngay` | Ngày chuyển |
| `loai_dt` | Loại đối tượng chuyển |
| `ma_bpsd` | Mã bộ phận sử dụng |
| `ma_spct` | Mã sản phẩm công trình |
| `ma_phi` | Mã phí |
| `tk_ts` | Tài khoản tài sản |
| `tk_kh` | Tài khoản khấu hao |
| `tk_cp` | Tài khoản chi phí |

---

## Mục đích sử dụng

**FAChuyenTS.dll là module quản lý "Chuyển tài sản"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Chuyển bộ phận sử dụng
- Chuyển tài sản từ bộ phận này sang bộ phận khác
- Cập nhật mã bộ phận sử dụng mới (ma_bpsd)

#### 2. Chuyển sản phẩm công trình
- Gán tài sản cho sản phẩm công trình khác
- Cập nhật mã SPCT mới (ma_spct)

#### 3. Chuyển mã phí
- Thay đổi mã phí theo dõi cho tài sản
- Cập nhật mã phí mới (ma_phi)

#### 4. Chuyển tài khoản kế toán
- Thay đổi tài khoản tài sản (TK_TS)
- Thay đổi tài khoản khấu hao (TK_KH)
- Thay đổi tài khoản chi phí (TK_CP)

### Đặc điểm kỹ thuật

- Sử dụng ComboBox để chọn loại chuyển (6 loại)
- Dynamic enable/disable fields dựa trên loại chuyển
- Lookup codes: MA_TS, MA_BPSD, MA_SPCT, MA_PHI, TK
- Validation theo loại chuyển đã chọn
- Ngày chuyển mặc định là ngày hiện tại

### Validation

- Mã tài sản: bắt buộc
- Ngày chuyển: bắt buộc
- Theo loại chuyển:
  - MA_BPSD: Mã bộ phận sử dụng bắt buộc
  - MA_SPCT: Mã SPCT bắt buộc
  - MA_PHI: Mã phí bắt buộc
  - TK_TS: Tài khoản tài sản bắt buộc
  - TK_KH: Tài khoản khấu hao bắt buộc
  - TK_CP: Tài khoản chi phí bắt buộc

### Business Logic

- Khi chọn loại chuyển, các trường tương ứng sẽ được enable
- Các trường không liên quan sẽ bị disable và clear
- Chỉ cho phép chuyển 1 loại đối tượng tại 1 thời điểm

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc chuyển tài sản giữa các bộ phận, sản phẩm công trình, hoặc thay đổi thông tin kế toán - một chức năng quan trọng trong quản lý và theo dõi tài sản cố định của doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*

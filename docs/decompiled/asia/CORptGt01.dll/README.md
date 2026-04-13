# Báo cáo Phân tích DLL: CORptGt01.dll

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
| Assembly Name | CORptGt01 |
| Assembly Title | Sổ cái |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
CORptGt01.dll/
├── CORptGt01.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmCORptGt01.cs        # Main form - Báo cáo giá thành 01
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
- `System`, `System.Collections`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCORptGt01` | `frmReport` | Form báo cáo Giá thành 01 |

---

## Chi tiết Forms

### frmCORptGt01 (Report Form)
- **Kế thừa**: `frmReport`
- **Chức năng**: Báo cáo Giá thành 01
- **Controls chính**:
  - `txtTk`: Mã tài khoản (AsTextBox)
  - `lblTen_Tk`: Tên tài khoản (Label)
  - `lblTk`: Nhãn "Tài khoản" (Label)
  - `Label1`, `Label2`, `Label3`, `Label4`: Các nhãn phụ
  - `txtNam`: Năm báo cáo (AsTextNumeric)
  - `txtThang1`: Tháng bắt đầu (AsTextNumeric)
  - `txtThang2`: Tháng kết thúc (AsTextNumeric)
  - `txtMA_SPCT`: Mã sản phẩm chi tiết (AsTextBox)
  - `chkCt_vt`: CheckBox chi tiết vật tư
- **Thuộc tính**:
  - `Ten_tk`: Biến lưu tên tài khoản

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI
- "Sổ cái" - Tên chức năng chung
- "Báo cáo giá thành 01" - Tên báo cáo cụ thể
- "Tài khoản", "Tên tài khoản"
- "Tháng", "Năm"
- "Mã SPCT", "Chi tiết vật tư"

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk` | Tài khoản kế toán |
| `nam` | Năm báo cáo |
| `thang1` | Tháng bắt đầu |
| `thang2` | Tháng kết thúc |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ct_vt` | Chi tiết vật tư |
| RptGt01 | Report Giá thành 01 |

---

## Mục đích sử dụng

**CORptGt01.dll là module báo cáo "Giá thành 01"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo Giá thành 01
- Báo cáo tổng hợp chi phí giá thành
- Phân tích chi phí theo tài khoản
- Theo dõi chi phí theo sản phẩm chi tiết

#### 2. Tham số báo cáo
- Chọn tài khoản chi phí
- Chọn sản phẩm chi tiết (SPCT)
- Lọc theo khoảng thời gian (tháng/năm)
- Tùy chọn xem chi tiết vật tư

#### 3. Tích hợp module giá thành
- Cung cấp dữ liệu cho phân tích giá thành
- Liên kết với định mức BOM
- Hỗ trợ đánh giá hiệu quả sản xuất

### Đặc điểm kỹ thuật

- Kế thừa từ frmReport
- AutoLookup cho mã tài khoản và SPCT
- TabControl cho filter parameters
- Hỗ trợ xem chi tiết vật tư

---

## So sánh với CORptGt02, CORptGt03

| Đặc điểm | CORptGt01 | CORptGt02 | CORptGt03 |
|-----------|-----------|-----------|-----------|
| Assembly Title | Sổ cái | Sổ cái | Sổ cái |
| Chức năng | Giá thành 01 | Giá thành 02 | Giá thành 03 |
| Có chi tiết VT | Có (chkCt_vt) | Không | Không |
| Controls | Nhiều nhất | Trung bình | Trung bình |

### Phân tích
- CORptGt01 là báo cáo chi tiết nhất với tùy chọn xem chi tiết vật tư
- CORptGt02 và CORptGt03 là các báo cáo khác với định dạng khác nhau
- Cùng GUID cho thấy đây là cùng một nhóm báo cáo

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xuất báo cáo giá thành 01 - báo cáo tổng hợp chi phí sản xuất theo tài khoản và sản phẩm chi tiết.

---

*Ngày phân tích: 2026-03-29*

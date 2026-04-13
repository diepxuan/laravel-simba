# Báo cáo Phân tích DLL: CORptGt02.dll

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
| Assembly Name | CORptGt02 |
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
CORptGt02.dll/
├── CORptGt02.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmCORptGt02.cs        # Main form - Báo cáo giá thành 02
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
| `frmCORptGt02` | `frmReport` | Form báo cáo Giá thành 02 |

---

## Chi tiết Forms

### frmCORptGt02 (Report Form)
- **Kế thừa**: `frmReport`
- **Chức năng**: Báo cáo Giá thành 02
- **Controls chính**:
  - `txtTk`: Mã tài khoản (AsTextBox)
  - `lblTen_Tk`: Tên tài khoản (Label)
  - `lblTk`: Nhãn "Tài khoản" (Label)
  - `Label1`: Nhãn phụ (Label)
  - `txtNam`: Năm báo cáo (AsTextNumeric)
  - `txtThang1`: Tháng bắt đầu (AsTextNumeric)
  - `txtThang2`: Tháng kết thúc (AsTextNumeric)
  - `txtMA_SPCT`: Mã sản phẩm chi tiết (AsTextBox)
  - `lblMa_SPCT`: Nhãn "Mã SPCT" (Label)
  - `lblTen_SPCT`: Tên sản phẩm chi tiết (Label)
- **Thuộc tính**:
  - `Ten_tk`: Biến lưu tên tài khoản

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI
- "Sổ cái" - Tên chức năng chung
- "Báo cáo giá thành 02" - Tên báo cáo cụ thể
- "Tài khoản", "Tên tài khoản"
- "Tháng", "Năm"
- "Mã SPCT", "Tên SPCT"

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk` | Tài khoản kế toán |
| `nam` | Năm báo cáo |
| `thang1` | Tháng bắt đầu |
| `thang2` | Tháng kết thúc |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ten_spct` | Tên sản phẩm chi tiết |
| RptGt02 | Report Giá thành 02 |

---

## Mục đích sử dụng

**CORptGt02.dll là module báo cáo "Giá thành 02"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo Giá thành 02
- Báo cáo phân tích giá thành theo SPCT
- Tổng hợp chi phí theo tài khoản và sản phẩm
- Đánh giá giá thành thực tế

#### 2. Tham số báo cáo
- Chọn tài khoản chi phí
- Chọn sản phẩm chi tiết (SPCT)
- Lọc theo khoảng thời gian (tháng/năm)
- Hiển thị tên SPCT đầy đủ

#### 3. Tích hợp module giá thành
- Cung cấp dữ liệu cho phân tích giá thành
- Liên kết với danh mục SPCT (CODMSPCT)
- Hỗ trợ đánh giá hiệu quả sản xuất

### Đặc điểm kỹ thuật

- Kế thừa từ frmReport
- AutoLookup cho mã tài khoản và SPCT
- TabControl cho filter parameters
- Hiển thị tên SPCT đầy đủ

---

## So sánh với CORptGt01, CORptGt03

| Đặc điểm | CORptGt01 | CORptGt02 | CORptGt03 |
|-----------|-----------|-----------|-----------|
| Assembly Title | Sổ cái | Sổ cái | Sổ cái |
| Chức năng | Giá thành 01 | Giá thành 02 | Giá thành 03 |
| Có chi tiết VT | Có (chkCt_vt) | Không | Không |
| Hiển thị tên SPCT | Không | Có | Có |
| Cấu trúc | Nhiều controls | Trung bình | Trung bình |

### Phân tích
- CORptGt02 có cấu trúc giống CORptGt03 (hiển thị tên SPCT)
- Khác với CORptGt01 ở chỗ không có checkbox chi tiết vật tư
- Cả 3 báo cáo đều có cùng GUID
- Có thể là 3 định dạng báo cáo khác nhau cho cùng loại dữ liệu

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xuất báo cáo giá thành 02 - báo cáo phân tích chi phí sản xuất theo sản phẩm chi tiết với hiển thị tên SPCT đầy đủ.

---

*Ngày phân tích: 2026-03-29*

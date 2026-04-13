# Báo cáo Phân tích DLL: INCalGiaNTXT.dll

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
| Assembly Name | INCalGiaNTXT |
| Assembly Title | Tính giá nhập trước xuất trước |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | f23c9a3f-c17b-4ff1-a575-2a320960c752 |
| ComVisible | false |

---

## Cấu trúc File

```
INCalGiaNTXT.dll/
├── INCalGiaNTXT.csproj              # Project file
├── app.ico                          # Application icon
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
├── AsiaERP.UserInterface/
│   └── frmINCalGiaNTXT.cs           # Main form class
├── AsiaERP.UserInterface.My/
│   ├── MyApplication.cs             # VB application support
│   ├── MyComputer.cs                # VB computer support
│   ├── MyProject.cs                 # VB project support
│   ├── MySettings.cs                # Application settings
│   └── MySettingsProperty.cs        # Settings property accessor
└── AsiaERP.UserInterface.My.Resources/
    └── Resources.cs                 # Resource manager
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
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINCalGiaNTXT` | `frmCalc` | Form tính giá nhập trước xuất trước (FIFO) |
| `Resources` | - | Resource manager cho localization |

---

## Phân tích Form: frmINCalGiaNTXT

### Kế thừa
- Kế thừa từ `frmCalc` - Base form cho các chức năng tính toán trong AsiaERP

### Controls

| Control | Type | Mục đích |
|---------|------|----------|
| `cboKyBc` | AsComboBox | Chọn kỳ báo cáo tính giá |
| `txtMa_kho` | AsTextBox | Nhập mã kho (có AutoLookup) |
| `lblTen_kho` | Label | Hiển thị tên kho |
| `txtMa_nhvt` | AsTextBox | Nhập mã nhóm vật tư (có AutoLookup) |
| `lblTen_nhvt` | Label | Hiển thị tên nhóm vật tư |
| `txtMa_vt` | AsTextBox | Nhập mã vật tư (có AutoLookup) |
| `lblTen_vt` | Label | Hiển thị tên vật tư |
| `bgWorker` | BackgroundWorker | Xử lý tính toán trong background |
| `cmdOK` | Button | Nút thực hiện tính giá |
| `cmdCancel` | Button | Nút hủy |
| `gbInput` | GroupBox | Nhóm các control nhập liệu |

### Thuộc tính Controls

**AsTextBox (txtMa_kho, txtMa_nhvt, txtMa_vt):**
- `AutoLookup = true`: Tự động tìm kiếm khi nhập
- `AutoValid = false`: Không tự động validate
- `BackColor = SystemColors.Info`: Màu nền info
- `CharacterCasing = Upper`: Chữ hoa
- `LookupCodeName`: MA_KHO, MA_NHVT, MA_VT
- `UseAutoCompleteSource = true`: Gợi ý tự động
- `NameControl`: Liên kết đến Label hiển thị tên

### Events và Business Logic

#### 1. InitComponents()
- Khởi tạo danh sách kỳ báo cáo (`InitKyBaoCao`)
- Set giá trị mặc định cho `cboKyBc` từ biến public `thang1`
- Nếu không có giá trị selected, mặc định là tháng hiện tại

#### 2. InitKyBaoCao()
- Lấy danh sách kỳ báo cáo từ `Environment.GetKyBaoCao()`
- ValueMember: `ma`
- DisplayMember: `ten_ky`
- Tham số: Ngày đầu năm tài chính, "10000"

#### 3. ValidData()
- Kiểm tra ngày kết thúc kỳ báo cáo > ngày khóa sổ (`ngay_ks`)
- Nếu không hợp lệ: hiển thị message box lỗi 50136

#### 4. Execute()
- Vô hiệu hóa các nút OK/Cancel trong quá trình xử lý
- Chuẩn bị tham số cho stored procedure:
  - `CompanyID`: Mã công ty
  - Kỳ báo cáo (text từ combo)
  - `FinancialYear`: Năm tài chính
  - Mã vật tư (trim)
  - Mã nhóm vật tư (trim)
  - Mã kho (trim)
- Xử lý theo `QueryReturnType`:
  - `NONE_QUERY`: Thực thi không trả kết quả
  - `DATATABLE`: Trả về DataTable kết quả
- Hiển thị thông báo thành công (50015) hoặc lỗi (50010)
- Đóng form sau khi hoàn thành

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Tính giá nhập trước xuất trước" - Tên chức năng chính
- "Kỳ tính" - Nhãn chọn kỳ báo cáo
- "Mã kho" - Nhãn nhập mã kho
- "Nhóm vật tư" - Nhãn nhập nhóm vật tư
- "Mã vật tư" - Nhãn nhập mã vật tư

### Thuật ngữ kế toán/kho

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_kho` | Mã kho |
| `ma_nhvt` | Mã nhóm vật tư |
| `ma_vt` | Mã vật tư |
| `KyBaoCao` | Kỳ báo cáo |
| `ngay_ks` | Ngày khóa sổ |
| `Ngay_DnTc` | Ngày đầu năm tài chính |
| FIFO | First In First Out - Nhập trước xuất trước |

### Mã message box

| Mã | Ý nghĩa |
|----|---------|
| 50015 | Thông báo thành công |
| 50010 | Thông báo lỗi |
| 50136 | Lỗi ngày kỳ báo cáo <= ngày khóa sổ |

---

## Mục đích sử dụng

**INCalGiaNTXT.dll là module tính giá vật tư theo phương pháp FIFO (Nhập trước xuất trước)** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Tính giá vật tư FIFO
- Tính giá xuất kho theo phương pháp nhập trước xuất trước
- Hỗ trợ tính giá theo kỳ (tháng)
- Có thể tính cho toàn bộ hoặc lọc theo:
  - Kho cụ thể
  - Nhóm vật tư
  - Vật tư cụ thể

#### 2. Kiểm soát khóa sổ
- Kiểm tra ngày kỳ tính giá phải sau ngày khóa sổ
- Đảm bảo không tính giá cho kỳ đã khóa

#### 3. Xử lý Background
- Sử dụng `BackgroundWorker` để xử lý tính toán
- Tránh treo UI trong quá trình tính giá

### Đặc điểm kỹ thuật

- Form kế thừa từ `frmCalc` - base form chuẩn cho tính toán
- Sử dụng `AsTextBox` với AutoLookup để tra cứu nhanh
- Tích hợp với AsiaERP Framework để lấy thông tin công ty, năm tài chính
- Gọi stored procedure qua Controller để thực hiện tính toán

### Mã chức năng

**INCalGiaNTXT** - Tính giá nhập trước xuất trước (FIFO Cost Calculation)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP AsiaERP, phục vụ cho việc tính giá vật tư xuất kho theo phương pháp FIFO (Nhập trước xuất trước). Module cung cấp giao diện đơn giản để người dùng chọn kỳ tính giá và các điều kiện lọc (kho, nhóm vật tư, vật tư), sau đó thực hiện tính toán thông qua stored procedure trong database.

---

*Ngày phân tích: 2026-03-29*

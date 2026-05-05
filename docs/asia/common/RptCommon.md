# RptCommon.dll - Common Report Form

## Tong quan

| Thuoc tinh | Gia tri |
|------------|---------|
| **Module** | Common (Reporting) |
| **Loai** | Windows Forms Class Library |
| **Chuc nang** | Form bao cao chung (common) - co so cho cac bao cao co filter dong, hien thi ket qua tren DataGridView, xuat Excel |
| **Assembly** | RptCommon v1.0.0.0 |
| **Framework** | .NET Framework 3.5 |
| **Namespace** | AsiaErp.UserInterface |
| **AllowUnsafeBlocks** | True |
| **GUID** | 5b533d97-568d-41be-b375-36ef4aabce81 |

## Dependencies

| Assembly | Muc dich |
|----------|----------|
| AsiaErp.Framework | Framework base (frmReport, FlowLayoutPanel, AsTextBox, etc.) |
| AsiaErp.Helper | Helper utilities |
| Microsoft.VisualBasic | VB runtime support |
| System.Data | Data access |

## File Structure

```
RptCommon.dll/
├── RptCommon.csproj
├── app.ico
├── Properties/
│   └── AssemblyInfo.cs
├── AsiaErp.UserInterface/
│   ├── frmRptCommon.cs      # Main common report form
│   ├── Form1.cs             # Form phu 1
│   ├── Form2.cs             # Form phu 2
│   └── Form3.cs             # Form phu 3
└── AsiaErp.UserInterface.My/
    ├── MyApplication.cs
    ├── MyComputer.cs
    ├── MyProject.cs
    ├── MySettings.cs
    └── MySettingsProperty.cs
```

## Forms

### frmRptCommon

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Ke thua** | frmReport |
| **Constructor** | frmRptCommon(string MenuID) |
| **Muc dich** | Form bao cao chung - filter dong qua par1 config, hien thi tren DataGridView |

**Controls chinh:**

| Control | Loai | Muc dich |
|---------|------|----------|
| palFilter | FlowLayoutPanel | Panel chua cac filter controls dong |
| palFilterMa | Panel | Panel chua filter ma (lookup) |
| cboMau_bc | ComboBox | Chon mau bao cao |
| cboKyBc | ComboBox | Chon ky bao cao |
| txtNgay1 | AsMaskedTextBox | Tu ngay |
| txtNgay2 | AsMaskedTextBox | Den ngay |
| txtMa_Nt | AsTextBox | Ma ngoại tệ |
| optVND | RadioButton | Option VND |
| optNt | RadioButton | Option ngoại tệ |
| txtTieu_De | TextBox | Tieu de bao cao |
| cmdOk | Button | Xem bao cao |
| cmdCancel | Button | Huy |
| cmdExcel | Button | Xuat Excel |
| cmdModifyReport | Button | Sua mau bao cao |
| dgvBC | DataGridView | Grid hien thi du lieu bao cao |
| oToolTip | ToolTip | Tooltip tro giup |

**Fields:**

| Field | Kieu | Muc dich |
|-------|------|----------|
| f_arrParRequired | ArrayList | Cac control required |
| f_arrParControls | ArrayList | Tat ca filter controls |

### Dynamic Filter Configuration (par1)

Filter controls duoc dinh nghia trong truong `par1` cua menu config:

**Format:**
```
FIELD:L=Label:R:T=C, FIELD2:L=Label2:T=T
```

| Token | Y nghia |
|-------|---------|
| `FIELD` | Ten truong |
| `L=Label` | Text hien thi |
| `R` | Required (bat buoc) |
| `T=C` | Control type: C = AsTextBox (code lookup) |
| `T=T` | Control type: T = TextBox thong thuong |

**Control Types:**

| Type | Control | Muc dich |
|------|---------|----------|
| C | AsTextBox | Lookup danh muc (AutoLookup) |
| T | TextBox | Nhap lieu thong thuong |

### Forms 1, 2, 3

- Form1.cs, Form2.cs, Form3.cs: Cac form phu (placeholder/test forms)

## Business Logic

1. **Constructor**: Nhan MenuID, khoi tao ArrayLists va ToolTip
2. **Form Load**:
   - Doc par1 config tu menu
   - Parse filter definitions
   - Tao controls dong (AsTextBox cho lookup, TextBox cho text)
   - Add vao palFilter / palFilterMa panels
   - Setup ToolTip cho tung control
3. **cmdOk_Click**:
   - Validate required fields
   - Thu thap gia tri filter
   - Goi stored procedure bao cao
   - Hien thi ket qua tren dgvBC
4. **cmdExcel_Click**: Xuat du lieu tu dgvBC ra Excel
5. **cmdCancel_Click**: Dong form

## Ket luan

RptCommon.dll la **Common Report Form** - form bao cao tong quat su dung FlowLayoutPanel de render filter controls dong tu menu config (par1). Khac voi DynamicReport/ReportDynamic (derive tu SP), RptCommon doc cau hinh truc tiep tu menu. Ket qua hien thi tren DataGridView thay vi Crystal Report. Day la form bao cao don gian, nhanh cho cac bang ke, danh sach.

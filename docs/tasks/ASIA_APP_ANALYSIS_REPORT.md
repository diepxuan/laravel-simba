# BÁO CÁO PHÂN TÍCH ASIA ERP APPLICATION

## Tổng quan

**Ngày phân tích:** 2026-03-18  
**Số lượng DLL:** 348 files  
**Công cụ decompile:** ilspycmd 9.1.0.7988  
**Thư mục nguồn:** `/root/.openclaw/workspace/projects/SimbaSql/native-apps/ASIA/`  
**Thư mục decompile:** `/root/.openclaw/workspace/docs/decompiled/asia/`  

---

## 1. Tổng quan kiến trúc Asia App

### 1.1 Kiến trúc tổng thể

Asia ERP là ứng dụng desktop được phát triển trên nền tảng **.NET Framework** (Windows Forms), sử dụng **SQL Server** làm cơ sở dữ liệu. Kiến trúc của hệ thống được thiết kế theo mô hình **3-tier**:

```
┌─────────────────────────────────────────────────────────────┐
│                    PRESENTATION LAYER                        │
│  (Windows Forms UI - frmVoucher, frmDMEdit, frmReport...)   │
├─────────────────────────────────────────────────────────────┤
│                    BUSINESS LOGIC LAYER                      │
│  (Framework.dll - VoucherController, Commons, DAO...)       │
├─────────────────────────────────────────────────────────────┤
│                    DATA ACCESS LAYER                         │
│  (MsSqlDAO, Stored Procedures - sp_*, as*...)               │
└─────────────────────────────────────────────────────────────┘
```

### 1.2 Cấu trúc Namespace chính

| Namespace | Mô tả |
|-----------|-------|
| `AsiaErp.Framework` | Core framework (Voucher, DAO, Commons, System Info) |
| `AsiaErp.UserInterface` | Forms và UI components |
| `AsiaErp.DataAccess` | Data Access Objects (MsSql*DAO) |
| `AsiaErp.ToolCommon` | Common utilities và database connection |
| `AsiaErp.Business` | Business logic layer |

### 1.3 Cơ chế kết nối Database

Từ phân tích `ToolCommon.dll/TCommon.cs`:

```csharp
// Connection string được lưu trong Startup.exe.config
// Hỗ trợ 2 chế độ authentication:
// 1. Windows Authentication (Integrated Security=Yes)
// 2. SQL Server Authentication (Uid/Pwd)

// Cấu trúc connection string:
// Data DB: Server={SqlServerName};Database={SqlDataDBName};...
// Sys DB: Server={SqlServerName};Database={SqlSysDBName};...
```

Các thông số kết nối được mã hóa (Encrypted) với các key: 125, 126, 127

---

## 2. Danh sách Modules và Chức năng

### 2.1 Phân loại theo Module Nghiệp vụ

| Module | Số lượng DLL | Mô tả |
|--------|--------------|-------|
| **GL** (General Ledger) | 35+ | Kế toán tổng hợp, sổ cái, báo cáo tài chính |
| **AP** (Accounts Payable) | 5+ | Công nợ phải trả, thanh toán |
| **AR** (Accounts Receivable) | 10+ | Công nợ phải thu, khách hàng |
| **IN** (Inventory) | 15+ | Quản lý kho, vật tư, tồn kho |
| **FA** (Fixed Asset) | 25+ | Tài sản cố định, khấu hao |
| **SO** (Sales Order) | 25+ | Đơn hàng bán, báo giá |
| **SI** (Sales Invoice) | 20+ | Hóa đơn bán hàng |
| **PO** (Purchase Order) | 10+ | Đơn hàng mua, nhập mua |
| **CO** (Cost) | 15+ | Tính giá thành, chi phí |
| **CA** (Cash) | 10+ | Quản lý quỹ, tiền mặt, ngân hàng |
| **System** | 30+ | Quản trị hệ thống, người dùng, phân quyền |
| **Reports** | 100+ | Các báo cáo chi tiết theo module |

### 2.2 Danh sách DLL Core/Framework

| DLL | Chức năng |
|-----|-----------|
| `Framework.dll` | Core framework - Base classes, Voucher, DAO, Commons |
| `ToolCommon.dll` | Database connection, session management, utilities |
| `Helper.dll` | Helper functions, encryption |
| `Docking.dll` | Docking windows UI |
| `DynamicReport.dll` | Dynamic report engine |
| `RptCommon.dll` | Common report functions |
| `AsiaLicenseCommon.dll` | License management |

### 2.3 Danh sách Voucher Forms (Nhập liệu)

| DLL | Module | Chức năng |
|-----|--------|-----------|
| `GLVchGL1.dll` | GL | Phiếu kế toán tổng hợp |
| `APVchAP4.dll` | AP | Phiếu chi/chi tiền |
| `ARVchAR4.dll` | AR | Phiếu thu/thu tiền |
| `INVchIN1.dll` | IN | Phiếu nhập kho |
| `INVchIN2.dll` | IN | Phiếu xuất kho |
| `SOVchSO1.dll` | SO | Đơn hàng bán |
| `SIVchSI1.dll` | SI | Hóa đơn bán hàng |
| `POVchPO1.dll` | PO | Đơn hàng mua |
| `CAVchCA1.dll` | CA | Phiếu thu/chi tiền mặt |

### 2.4 Danh sách Posting Modules (Hạch toán)

| DLL | Chức năng |
|-----|-----------|
| `GLPost2GL.dll` | Post chứng từ vào sổ tổng hợp |
| `GLPost2GLKC.dll` | Post vào sổ kết chuyển |
| `APPost2TT.dll` | Post công nợ phải trả |
| `ARPost2TT.dll` | Post công nợ phải thu |
| `FAPostTS2GL.dll` | Post tài sản cố định vào GL |
| `FAPostCC2GL.dll` | Post chi phí vào GL |
| `CoPostCPTT2GL.dll` | Post chi phí tính giá vào GL |

### 2.5 Danh sách Danh mục (Master Data)

| DLL | Module | Chức năng |
|-----|--------|-----------|
| `GLDMTK.dll` | GL | Danh mục tài khoản |
| `GLDMKC.dll` | GL | Danh mục khoản mục |
| `GLDMDGTG.dll` | GL | Danh mục đối tượng tổng hợp |
| `ARDMKH.dll` | AR | Danh mục khách hàng |
| `ARDMPLKH.dll` | AR | Danh mục phân loại khách hàng |
| `INDMVT.dll` | IN | Danh mục vật tư |
| `INDMKHO.dll` | IN | Danh mục kho |
| `FADMTS.dll` | FA | Danh mục tài sản |
| `FADMCC.dll` | FA | Danh mục công cụ |
| `SIDMHTTT.dll` | SI | Danh mục hình thức thanh toán |
| `SIDMHD.dll` | SI | Danh mục hợp đồng |

---

## 3. Phân tích từng Module chính

### 3.1 Framework Module (Framework.dll)

#### 3.1.1 Class Hierarchy

```
frmAsiaRoot (DockContent)
├── frmVoucher
│   ├── frmGlVchGL1 (GLVchGL1.dll)
│   ├── frmApVchAP4 (APVchAP4.dll)
│   └── ...
├── frmDMEdit
│   ├── frmGLDMTK (GLDMTK.dll)
│   └── ...
├── frmReport
└── ...

RootController
├── VoucherController
├── DMController
└── ReportController

MsSqlDAO
├── MsSqlBaseVoucherDAO
├── MsSqlDMEditDAO
└── ...
```

#### 3.1.2 Key Classes

| Class | Chức năng |
|-------|-----------|
| `VoucherInformation` | Lưu trữ thông tin chứng từ |
| `VoucherController` | Điều khiển nghiệp vụ chứng từ |
| `MsSqlBaseVoucherDAO` | Data access cho chứng từ |
| `Commons` | Common utilities, execute SP |
| `SystemInformations` | Thông tin hệ thống, user, culture |
| `CompanyInformations` | Thông tin công ty |

#### 3.1.3 Cơ chế Execute Stored Procedure

Từ `Framework.dll`:

```csharp
// Execute stored procedure không trả về
public static bool ExecuteStoredProcedure(string aSP_Name, params object[] aParList)

// Execute stored procedure trả về scalar
public static object ExecuteStoredProcedureScalar(string spName, params object[] ParamValues)

// Execute stored procedure trên SysDB
public static bool ExecuteSYSDBStoredProcedure(string aSP_Name, params object[] aParList)
```

### 3.2 General Ledger (GL) Module

#### 3.2.1 Các chức năng chính

| DLL | Chức năng |
|-----|-----------|
| `GLVchGL1.dll` | Nhập phiếu kế toán tổng hợp |
| `GLPost2GL.dll` | Post chứng từ vào sổ |
| `GLDMTK.dll` | Quản lý danh mục tài khoản |
| `GLDMKC.dll` | Quản lý khoản mục |
| `GLBudget.dll` | Quản lý ngân sách |

#### 3.2.2 Cấu trúc Form GLVchGL1

Từ phân tích `frmGlVchGL1.cs`:

```csharp
public class frmGlVchGL1 : frmVoucher
{
    // Controls chính
    AsInputDGV adgvDetail;           // Grid chi tiết
    AsMaskedTextBox txtNgay_lct;     // Ngày lập chứng từ
    AsTextNumeric txtT_Tien_No;      // Tổng tiền nợ
    AsTextNumeric txtT_Tien_Co;      // Tổng tiền có
    AsComboBoxNT cboMa_NT;           // Mã ngoại tệ
    AsTextNumeric txtTy_gia;         // Tỷ giá
    
    // Grid columns
    dgvcTk - Tài khoản
    dgvcMa_kh - Mã khách hàng
    dgvcPs_no_nt - Phát sinh nợ ngoại tệ
    dgvcPs_co_nt - Phát sinh có ngoại tệ
    dgvcPs_no - Phát sinh nợ
    dgvcPs_co - Phát sinh có
    dgvcDien_giai - Diễn giải
}
```

### 3.3 Accounts Payable (AP) Module

#### 3.3.1 Các chức năng chính

| DLL | Chức năng |
|-----|-----------|
| `APVchAP4.dll` | Phiếu chi/thanh toán |
| `APPost2TT.dll` | Post công nợ phải trả |
| `APTT.dll` | Thanh toán công nợ |

### 3.4 Accounts Receivable (AR) Module

#### 3.4.1 Các chức năng chính

| DLL | Chức năng |
|-----|-----------|
| `ARVchAR4.dll` | Phiếu thu |
| `ARPost2TT.dll` | Post công nợ phải thu |
| `ARTT.dll` | Thanh toán công nợ phải thu |

### 3.5 Inventory (IN) Module

#### 3.5.1 Các chức năng chính

| DLL | Chức năng |
|-----|-----------|
| `INVchIN1.dll` | Phiếu nhập kho |
| `INVchIN2.dll` | Phiếu xuất kho |
| `INVchIN3.dll` | Phiếu nhập khác |
| `INVchIN5.dll` | Phiếu kiểm kê |
| `INVchIN6.dll` | Phiếu điều chuyển kho |
| `INDMVT.dll` | Danh mục vật tư |
| `INDMKHO.dll` | Danh mục kho |
| `INCalGiaTB.dll` | Tính giá trung bình |
| `INCalGiaBQDD.dll` | Tính giá bình quân đầu đợt |
| `INCalGiaNTXT.dll` | Tính giá nhập trước xuất trước |

### 3.6 Fixed Asset (FA) Module

#### 3.6.1 Các chức năng chính

| DLL | Chức năng |
|-----|-----------|
| `FADMTS.dll` | Danh mục tài sản |
| `FADMCC.dll` | Danh mục công cụ |
| `FADGTS.dll` | Điều chỉnh giá trị tài sản |
| `FAGiamTS.dll` | Giảm tài sản |
| `FAChuyenTS.dll` | Chuyển tài sản |
| `FACalKHTS.dll` | Tính khấu hao tài sản |
| `FAPostTS2GL.dll` | Post khấu hao vào GL |
| `FAAdjustKHTS.dll` | Điều chỉnh khấu hao |
| `FAThoiKHTS.dll` | Thôi khấu hao |

### 3.7 Sales Order (SO) Module

#### 3.7.1 Các chức năng chính

| DLL | Chức năng |
|-----|-----------|
| `SOVchSO1.dll` | Đơn hàng bán |
| `SOVchSO3.dll` | Báo giá |
| `SOVchSO4.dll` | Đơn hàng bán nội bộ |
| `SOVchSO5.dll` | Đặt hàng của khách |
| `SODMHTTT.dll` | Danh mục hình thức thanh toán |
| `SODMKH.dll` | Danh mục khách hàng |
| `SODMNVKD.dll` | Danh mục nhân viên kinh doanh |
| `SOUtilities.dll` | Tiện ích bán hàng |

### 3.8 Sales Invoice (SI) Module

#### 3.8.1 Các chức năng chính

| DLL | Chức năng |
|-----|-----------|
| `SIVchSI1.dll` | Hóa đơn bán hàng |
| `SIDMHD.dll` | Danh mục hợp đồng |
| `SIDMHTTT.dll` | Danh mục hình thức thanh toán |
| `SIDMNGH.dll` | Danh mục người giao hàng |
| `SIDMPHI.dll` | Danh mục phí |
| `SIDMTGNT.dll` | Danh mục tỷ giá ngoại tệ |
| `SITheme.dll` | Giao diện hóa đơn |
| `SISysvars.dll` | Tham số hệ thống |

### 3.9 Purchase Order (PO) Module

#### 3.9.1 Các chức năng chính

| DLL | Chức năng |
|-----|-----------|
| `POVchPO1.dll` | Đơn hàng mua |
| `POVchPO3.dll` | Phiếu nhập mua |
| `POVchPO4.dll` | Phiếu trả hàng nhà cung cấp |
| `PODMHTTT.dll` | Danh mục hình thức thanh toán |
| `PODMDKTT.dll` | Danh mục điều khoản thanh toán |
| `POUtilities.dll` | Tiện ích mua hàng |

### 3.10 Cost (CO) Module

#### 3.10.1 Các chức năng chính

| DLL | Chức năng |
|-----|-----------|
| `CoCalcCost.dll` | Tính giá thành |
| `CoPostCPTT2GL.dll` | Post chi phí vào GL |
| `CoDelPostCP2GL.dll` | Xóa post chi phí |
| `CODMBOM.dll` | Định mức BOM |
| `CODMSPCT.dll` | Danh mục sản phẩm chi tiết |
| `CODMNHSPCT.dll` | Danh mục nhóm sản phẩm chi tiết |
| `COPB.dll` | Phân bổ chi phí |
| `COLK.dll` | Lập kế hoạch |

### 3.11 Cash (CA) Module

#### 3.11.1 Các chức năng chính

| DLL | Chức năng |
|-----|-----------|
| `CAVchCA1.dll` | Phiếu thu tiền mặt |
| `CAVchCA2.dll` | Phiếu chi tiền mặt |
| `CAVchCA3.dll` | Phiếu thu ngân hàng |
| `CAVchCA4.dll` | Phiếu chi ngân hàng |
| `CAVchCA5.dll` | Chuyển tiền nội bộ |
| `CADMKU.dll` | Danh mục quỹ |
| `CACalLaiKu.dll` | Tính lãi quỹ |
| `CALAIKU.dll` | Lãi quỹ |

### 3.12 System Modules

#### 3.12.1 Các chức năng hệ thống

| DLL | Chức năng |
|-----|-----------|
| `SMUserInfo.dll` | Quản lý người dùng |
| `SMKS.dll` | Quản lý khóa sổ |
| `SMFFY.dll` | Chuyển năm tài chính |
| `SIGroupInfo.dll` | Quản lý nhóm người dùng |
| `SIBackupData.dll` | Sao lưu dữ liệu |
| `SiImExData.dll` | Import/Export dữ liệu |
| `SiUpdateLog.dll` | Log cập nhật |
| `SIUPDATETOOL.dll` | Công cụ cập nhật |
| `SiChangeFY.dll` | Thay đổi năm tài chính |
| `SiReOrderVoucherNumber.dll` | Sắp xếp lại số chứng từ |
| `SiTools.dll` | Công cụ hệ thống |
| `SiMaintain.dll` | Bảo trì hệ thống |

---

## 4. Mapping Code - Stored Procedures

### 4.1 Cơ chế gọi Stored Procedure

Từ phân tích code, hệ thống sử dụng các phương thức chính để gọi SP:

```csharp
// 1. Từ ToolCommon.dll - TCommon class
public static DataTable TGetDataTable(bool isSys, string spName, params object[] ParamValues)
public static DataTable TGetDataTableByQuerry(bool isSys, string query)

// 2. Từ Framework.dll - Commons class
public static bool ExecuteStoredProcedure(string aSP_Name, params object[] aParList)
public static object ExecuteStoredProcedureScalar(string spName, params object[] ParamValues)
public static bool ExecuteSYSDBStoredProcedure(string aSP_Name, params object[] aParList)

// 3. Từ các MsSqlDAO classes
ExecuteNonQuery()  // Thực thi SP đã được cấu hình trong DAO
```

### 4.2 Danh sách Stored Procedures được gọi trong Code

Từ phân tích các DLL, các SP sau được gọi trực tiếp:

| Stored Procedure | DLL gọi | Chức năng |
|------------------|---------|-----------|
| `asUpdLangTranslationResx` | Framework.dll | Cập nhật ngôn ngữ |
| `asUpdateReportResX` | Framework.dll | Cập nhật report resource |
| `asUpdateDictResX` | Framework.dll | Cập nhật dictionary resource |
| `asUpdOpeningBlanceResx` | Framework.dll | Cập nhật số dư đầu |
| `asUpdateVoucherResX` | Framework.dll | Cập nhật voucher resource |
| `asUpdateLookupResX` | Framework.dll | Cập nhật lookup resource |
| `asFADelPostGlCt` | FAPostTS2GL.dll | Xóa post khấu hao |
| `asFAPost2GlCt` | FAPostTS2GL.dll | Post khấu hao vào GL |
| `asSiUpd_Ngay_dntc` | SMFFY.dll | Cập nhật ngày đầu năm TC |
| `asSiScheduleAutoBackupData` | SIBackupData.dll | Lập lịch backup |
| `afChkExistsCodeDict` | SODMHTTT.dll | Kiểm tra mã danh mục |

### 4.3 Cấu trúc DAO Pattern

```csharp
// Ví dụ từ MsSqlFAPostTS2GLDAO.cs
public class MsSqlFAPostTS2GLDAO : MsSqlDAO
{
    public MsSqlFAPostTS2GLDAO(DAOInformation daoInfo) : base(daoInfo)
    {
    }
    
    public int ExecuteNonQuery()
    {
        // Thực thi stored procedure đã được cấu hình
        return _command.ExecuteNonQuery();
    }
}
```

### 4.4 Mapping giữa Voucher và SP

| Voucher DLL | Post DLL | SP Post | SP Delete Post |
|-------------|----------|---------|----------------|
| GLVchGL1.dll | GLPost2GL.dll | asPostGL | asDelPostGL |
| APVchAP4.dll | APPost2TT.dll | asPostAP | asDelPostAP |
| ARVchAR4.dll | ARPost2TT.dll | asPostAR | asDelPostAR |
| FADMTS.dll | FAPostTS2GL.dll | asFAPost2GlCt | asFADelPostGlCt |

---

## 5. Luồng nghiệp vụ điển hình

### 5.1 Luồng nhập chứng từ kế toán (GL)

```
┌─────────────────────────────────────────────────────────────┐
│ 1. Mở Form GLVchGL1.dll (frmGlVchGL1)                     │
│    - Kế thừa từ frmVoucher                                  │
│    - Load thông tin từ VoucherController                    │
├─────────────────────────────────────────────────────────────┤
│ 2. Nhập thông tin chung                                     │
│    - Ngày chứng từ (txtNgay_lct)                            │
│    - Số chứng từ                                            │
│    - Loại tiền (cboMa_NT, txtTy_gia)                        │
├─────────────────────────────────────────────────────────────┤
│ 3. Nhập chi tiết (adgvDetail)                               │
│    - Tài khoản (dgvcTk)                                     │
│    - Khách hàng (dgvcMa_kh)                                 │
│    - Phát sinh nợ/có (dgvcPs_no, dgvcPs_co)                 │
│    - Diễn giải (dgvcDien_giai)                              │
├─────────────────────────────────────────────────────────────┤
│ 4. Validate dữ liệu                                         │
│    - Kiểm tra cân đối nợ/có                                 │
│    - Kiểm tra tài khoản hợp lệ                              │
├─────────────────────────────────────────────────────────────┤
│ 5. Lưu chứng từ                                             │
│    - Gọi VoucherController.Save()                           │
│    - Gọi MsSqlBaseVoucherDAO.Insert/Update                  │
│    - Thực thi SP: asSaveVoucherGL                          │
├─────────────────────────────────────────────────────────────┤
│ 6. Post chứng từ (tùy chọn)                                 │
│    - Gọi GLPost2GL.dll                                      │
│    - Thực thi SP: asPostGL                                  │
│    - Cập nhật sổ sách                                       │
└─────────────────────────────────────────────────────────────┘
```

### 5.2 Luồng tính khấu hao tài sản (FA)

```
┌─────────────────────────────────────────────────────────────┐
│ 1. Mở Form FACalKHTS.dll                                    │
│    - Chọn tháng/năm tính khấu hao                          │
├─────────────────────────────────────────────────────────────┤
│ 2. Tính toán khấu hao                                       │
│    - Lấy danh sách tài sản cần tính                        │
│    - Tính giá trị khấu hao tháng                           │
├─────────────────────────────────────────────────────────────┤
│ 3. Post khấu hao vào GL                                     │
│    - Gọi FAPostTS2GL.dll                                    │
│    - Thực thi SP: asFAPost2GlCt                            │
│    - Tạo bút toán khấu hao trong GL                        │
└─────────────────────────────────────────────────────────────┘
```

### 5.3 Luồng hóa đơn bán hàng (SI)

```
┌─────────────────────────────────────────────────────────────┐
│ 1. Mở Form SIVchSI1.dll                                     │
│    - Nhập thông tin hóa đơn                                │
│    - Chọn khách hàng, hợp đồng                             │
├─────────────────────────────────────────────────────────────┤
│ 2. Nhập chi tiết hàng hóa                                   │
│    - Chọn mã hàng, số lượng, đơn giá                       │
│    - Tính thuế, chiết khấu                                 │
├─────────────────────────────────────────────────────────────┤
│ 3. Lưu hóa đơn                                              │
│    - Cập nhật tồn kho (IN)                                 │
│    - Cập nhật công nợ (AR)                                 │
│    - Tạo bút toán doanh thu (GL)                           │
└─────────────────────────────────────────────────────────────┘
```

---

## 6. Kết luận và nhận xét

### 6.1 Đánh giá kiến trúc

| Ưu điểm | Nhược điểm |
|---------|------------|
| Kiến trúc 3-tier rõ ràng | Sử dụng .NET Framework cũ (WinForms) |
| Tách biệt Presentation - Business - Data | Khó mở rộng, khó maintain |
| Framework chuẩn hóa các chức năng | Không hỗ trợ web/mobile |
| Stored Procedures tập trung logic DB | Logic phân tán giữa code và SP |
| Hỗ trợ đa ngôn ngữ (Resource files) | Phụ thuộc vào SQL Server |

### 6.2 Công nghệ sử dụng

| Thành phần | Công nghệ |
|------------|-----------|
| UI Framework | Windows Forms (.NET Framework) |
| Database | SQL Server |
| Data Access | ADO.NET, SqlCommand |
| Report Engine | Microsoft ReportViewer |
| UI Components | Custom controls (AsInputDGV, AsTextNumeric...) |
| Docking | WeifenLuo.WinFormsUI.Docking |
| Excel Export | Microsoft.Office.Interop.Excel |

### 6.3 Các vấn đề cần lưu ý khi convert

1. **Business Logic trong Stored Procedures**: Rất nhiều logic nghiệp vụ nằm trong SP, cần phân tích kỹ trước khi chuyển sang API

2. **Custom UI Controls**: Hệ thống sử dụng nhiều custom controls (AsInputDGV, AsTextNumeric...), cần tìm tương đương trong React/web

3. **Form Inheritance**: Các form kế thừa từ frmVoucher, frmDMEdit... cần thiết kế lại component tương đương

4. **Session Management**: Sử dụng Hashtable để lưu session, cần chuyển sang stateless API

5. **Connection String**: Được mã hóa trong config file, cần chuyển sang environment variables

6. **Resource Files**: Hệ thống đa ngôn ngữ dùng .resx files, cần chuyển sang i18n JSON

### 6.4 Đề xuất chiến lược convert

```
Phase 1: API Layer
├── Tạo REST API với FastAPI/ASP.NET Core
├── Chuyển stored procedures thành API endpoints
└── Giữ nguyên database SQL Server

Phase 2: Web UI
├── Phát triển React frontend
├── Tạo components tương đương custom controls
└── Implement voucher forms

Phase 3: Migration
├── Song song chạy desktop và web
├── Migrate dữ liệu từng module
└── Decommission desktop app
```

### 6.5 Danh sách DLL ưu tiên convert

| Priority | DLL | Lý do |
|----------|-----|-------|
| 1 | Framework.dll | Core framework, base classes |
| 2 | ToolCommon.dll | Database connection, utilities |
| 3 | GLVchGL1.dll | Module kế toán tổng hợp quan trọng |
| 4 | SIVchSI1.dll | Hóa đơn bán hàng |
| 5 | INVchIN1.dll | Nhập kho |
| 6 | SIDMVT.dll | Danh mục vật tư |
| 7 | ARDMKH.dll | Danh mục khách hàng |
| 8 | GLDMTK.dll | Danh mục tài khoản |

---

## Phụ lục: Danh sách đầy đủ các DLL

### Framework & Core (7 files)
- Framework.dll
- ToolCommon.dll
- Helper.dll
- Docking.dll
- DynamicReport.dll
- RptCommon.dll
- AsiaLicenseCommon.dll

### GL Module (35+ files)
- GLVchGL1.dll
- GLPost2GL.dll, GLPost2GLKC.dll, GLPost2DGTG.dll
- GLDMTK.dll, GLDMKC.dll, GLDMDGTG.dll, GLDMCTGS.dll
- GLCDTK.dll, GLTransferGLCDTK.dll
- GLBudget.dll, GLNB.dll
- GLDKCTGS.dll
- GLRpt*.dll (30+ report files)

### AP Module (5+ files)
- APVchAP4.dll
- APPost2TT.dll
- APTT.dll
- APRpt*.dll

### AR Module (10+ files)
- ARVchAR4.dll
- ARPost2TT.dll
- ARTT.dll
- ARRecalCustBalance.dll
- ARDMKH.dll, ARDMPLKH.dll, ARDMNHKH.dll, ARCDKH.dll
- ARRpt*.dll

### IN Module (15+ files)
- INVchIN1.dll, INVchIN2.dll, INVchIN3.dll, INVchIN5.dll, INVchIN6.dll
- INCalGiaTB.dll, INCalGiaBQDD.dll, INCalGiaNTXT.dll
- INDMVT.dll, INDMKHO.dll, INDMLO.dll, INDMNHVT.dll, INDMPLVT.dll, INDMNHVAT.dll
- INCDFIFO.dll, INCDVT.dll, INTransferINCDVT.dll
- INRpt*.dll

### FA Module (25+ files)
- FADMTS.dll, FADMCC.dll, FADMBPSD.dll, FADMLDTS.dll, FADMNHTS.dll, FADMNV.dll
- FADGTS.dll, FAGiamTS.dll, FAChuyenTS.dll
- FACalKHTS.dll, FAAdjustKHTS.dll, FAThoiKHTS.dll
- FAPostTS2GL.dll, FAPostCC2GL.dll, FADelTS2GL.dll, FADelCC2GL.dll, FADelKHTS.dll
- FABHCC.dll, Fakkts.dll
- FARpt*.dll (20+ report files)

### SO Module (25+ files)
- SOVchSO1.dll, SOVchSO3.dll, SOVchSO4.dll, SOVchSO5.dll
- SODMHTTT.dll, SODMDKTT.dll, SODMNVKD.dll, SODMPTVT.dll, SODMTD.dll
- SODMGIABAN.dll, SODMHHKM.dll, SODMKM.dll, SODMTKM.dll, SODMTS.dll
- SODMCK.dll, SODMDGVT.dll
- SOTaOut.dll
- SOUtilities.dll
- SOND51*.dll (10+ files cho hóa đơn điện tử)
- SORpt*.dll

### SI Module (20+ files)
- SIVchSI1.dll
- SIDMCT.dll, SIDMHD.dll, SIDMHTTT.dll, SIDMNGH.dll, SIDMNHHD.dll, SIDMNT.dll
- SIDMPHI.dll, SIDMTGNT.dll, SIDMBp.dll
- SIDMOpt9.dll, SIDMOpt10.dll
- SITheme.dll, SISysvars.dll
- SIAbout.dll, SIGroupInfo.dll, SiInfomationProduct.dll
- SiTools.dll, SiTools_2.dll
- SiImExData.dll, SiUpdateLog.dll, SiReOrderVoucherNumber.dll
- SIUPDATETOOL.dll, SiChangeFY.dll
- SIRptLOGCT.dll
- SIBackupData.dll, SIMaintain.dll

### PO Module (10+ files)
- POVchPO1.dll, POVchPO3.dll, POVchPO4.dll, POVchPO5.dll, POVchPO6.dll, POVchPO7.dll
- PODMHTTT.dll, PODMDKTT.dll, PODMCP.dll
- POTAIN.dll
- POUtilities.dll
- PORpt*.dll

### CO Module (15+ files)
- CoCalcCost.dll
- CoPostCPTT2GL.dll, CoDelPostCP2GL.dll
- CODMBOM.dll, CODMBOM_.dll, CODMSPCT.dll, CODMNHSPCT.dll
- CoDMCPTT.dll, CODMPB.dll, COPB.dll
- CoNgungKHCPTT.dll
- COLK.dll, COGDBGT.dll, CODD1.dll
- CoRpt*.dll

### CA Module (10+ files)
- CAVchCA1.dll, CAVchCA2.dll, CAVchCA3.dll, CAVchCA4.dll, CAVchCA5.dll
- CADMKU.dll, CACDKU.dll, CACDPC.dll
- CACalLaiKu.dll, CADelLaiKu.dll, CALAIKU.dll
- CARpt*.dll

### System Modules (30+ files)
- SMUserInfo.dll, SMKS.dll, SMFFY.dll
- DashBoard.dll
- GenerationReport.dll, ReportDynamic.dll, DynReport.dll
- OptFieldInfo.dll, OptFieldSetup.dll
- unrar.dll, UnRARNET.dll
- Microsoft.*.dll (5 files)

---

**Kết thúc báo cáo**

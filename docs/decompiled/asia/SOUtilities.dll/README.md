# Báo cáo Phân tích DLL: SOUtilities.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Class Library) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SOUtilities |
| Assembly Title | SOUtilities |
| Assembly Company | nguyenthai |
| Assembly Product | SOUtilities |
| Assembly Copyright | Copyright © nguyenthai 2011 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 0e634c1e-5883-4704-b5a6-191e9728aeb9 |
| ComVisible | false |

---

## Cấu trúc File

```
SOUtilities.dll/
├── SOUtilities.csproj           # Project file
├── app.ico                      # Application icon
├── frmCA4SO.cs                  # Form xử lý bán hàng (CA4 module)
├── frmCA4SO.resx                # Resource file cho frmCA4SO
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── My/
│   ├── InternalXmlHelper.cs     # XML helper utilities
│   ├── MyApplication.cs         # Application settings
│   ├── MyComputer.cs            # Computer info wrapper
│   ├── MyProject.cs             # Project-wide utilities
│   ├── MySettings.cs            # Application settings
│   └── MySettingsProperty.cs    # Settings property wrapper
├── My.Resources/
│   └── Resources.cs             # Resource manager
└── AsiaErp/
    ├── DataAccess/
    │   ├── SOCommonDAO.cs       # Data access interface
    │   ├── MsSqlSOCommonDAO.cs  # SQL Server implementation
    │   └── MsSqlCA4SODAO.cs     # CA4 SO specific DAO
    └── SOUtilities/
        └── SOCommon.cs          # Common utilities module (static class)
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML processing |
| System.Core | Core .NET functionality |
| System.Data | Data access |
| Framework | Asia ERP Framework (../../../../projects/SimbaSql/native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../projects/SimbaSql/native-apps/ASIA/Helper.dll) |
| CrystalDecisions.CrystalReports.Engine | Crystal Reports engine |
| CrystalDecisions.Shared | Crystal Reports shared libraries |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.SOUtilities`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Linq`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`
- `System.Runtime.CompilerServices`, `System.Runtime.InteropServices`

---

## Classes và Components

### Data Access Layer (AsiaErp.DataAccess)

| Class | Interface | Mục đích |
|-------|-----------|----------|
| `SOCommonDAO` | Interface | Định nghĩa interface cho các tiện ích bán hàng |
| `MsSqlSOCommonDAO` | `SOCommonDAO`, `MsSqlDAO` | Implementation SQL Server cho SO utilities |
| `MsSqlCA4SODAO` | - | DAO specific cho module CA4 (Báo có) liên quan bán hàng |

### Business Logic Layer (AsiaErp.SOUtilities)

| Class | Type | Mục đích |
|-------|------|----------|
| `SOCommon` | Static Module | Collection các utility functions cho module bán hàng (SO) |

### User Interface Layer

| Class | Mục đích |
|-------|----------|
| `frmCA4SO` | Form xử lý nghiệp vụ bán hàng trong module CA4 (Báo có) |

---

## SOCommon Static Module Methods

### Pricing Functions

| Method | Mục đích | Parameters | Return |
|--------|----------|------------|--------|
| `Get_GiaBan` | Lấy giá bán | `aMa_Vt` (string), `aMa_Nt` (string), `aNgay_ct` (DateTime, optional) | `double` |
| `Get_GiaGiamGia` | Lấy giá và chiết khấu | `aMa_Kh`, `aMa_Vt`, `aMa_Nt`, `aSo_Luong`, `ref arTl`, `ref arGiamGia`, `angay_ct` (optional) | `void` (output via ref) |

### Lookup Functions (Document Chain)

| Method | Mục đích | Parameters | Return |
|--------|----------|------------|--------|
| `SOLookupDH4PX` | Lookup Đơn hàng → Phiếu xuất | `aKey` (string), `ref oTblPh`, `ref oTblCt` | `bool` |
| `SOLookupDH4HD` | Lookup Đơn hàng → Hóa đơn | `aKey` (string), `ref oTblPh`, `ref oTblCt` | `bool` |
| `SOLookupPX4HD` | Lookup Phiếu xuất → Hóa đơn | `aKey` (string), `ref oTblPh`, `ref oTblCt` | `bool` |
| `SOLookupPX4PN` | Lookup Phiếu xuất → Phiếu nhập | `aKey` (string), `ref oTblPh`, `ref oTblCt` | `bool` |
| `SOLookupHD4PN` | Lookup Hóa đơn → Phiếu nhập | `aKey` (string), `ref oTblPh`, `ref oTblCt` | `bool` |

### Print Management

| Method | Mục đích | Parameters | Return |
|--------|----------|------------|--------|
| `Get_RightPrint` | Kiểm tra quyền in | `pMa_cty`, `pSo_ct`, `pSo_seri`, `pLimitedPrint`, `pIs_oke` | `bool` |
| `SoInsLogPrint` | Ghi log in ấn | `params object[] pArray` | `bool` |

### Status & Rights Check

| Method | Mục đích | Parameters | Return |
|--------|----------|------------|--------|
| `SOChkStatusRightSO1` | Check quyền SO1 | `aStt_Rec`, `ref aMessContent` | `bool` |
| `SOChkStatusRightSO2` | Check quyền SO2 | `aStt_Rec`, `ref aMessContent` | `bool` |
| `SOChkStatusRightSO3` | Check quyền SO3 | `aStt_Rec`, `ref aMessContent` | `bool` |
| `SOChkStatusRightSO5` | Check quyền SO5 | `aStt_Rec`, `ref aMessContent` | `bool` |

---

## SOCommonDAO Interface

### Method Signatures

```csharp
public interface SOCommonDAO : DAO
{
    // Pricing
    double Get_GiaBan(string aMa_Cty, string aMa_Vt, string aMa_Nt, DateTime aNgay_ct);
    void Get_GiamGia(string aMa_Cty, string aMa_Kh, string aMa_Vt, string aMa_Nt, 
                     double aSo_Luong, ref string arTl, ref double arGiamGia, DateTime angay_ct);
    
    // Lookup chain
    bool SOLookupDH4PX(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);
    bool SOLookupDH4HD(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);
    bool SOLookupPX4HD(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);
    bool SOLookupPX4PN(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);
    bool SOLookupHD4PN(string aMa_cty, string aKey, ref DataTable oTblPh, ref DataTable oTblCt);
    
    // Print
    bool Get_RightPrint(string pMa_cty, string pSo_ct, string pSo_seri, int pLimitedPrint, bool pIs_oke);
    bool SoInsLogPrint(params object[] pArray);
    
    // Status check
    bool SOChkStatusRightSO1(string aMa_cty, string aStt_Rec, ref string aMessContent);
    bool SOChkStatusRightSO2(string aMa_cty, string aStt_Rec, ref string aMessContent);
    bool SOChkStatusRightSO3(string aMa_cty, string aStt_Rec, ref string aMessContent);
    bool SOChkStatusRightSO5(string aMa_cty, string aStt_Rec, ref string aMessContent);
}
```

---

## MsSqlSOCommonDAO Implementation

### Stored Procedures sử dụng

| Method | Stored Procedure | Mục đích |
|--------|------------------|----------|
| `Get_GiaBan` | `asSOGetGiaban` | Lấy giá bán theo cấu hình |
| `Get_GiamGia` | `asGetGiabanGiamGia` | Lấy giá và chiết khấu |
| `SOLookupDH4PX` | `asSOLookupDhPx` | Lookup Đơn hàng → Phiếu xuất |
| `SOLookupDH4HD` | `asSOLookupDhHd` | Lookup Đơn hàng → Hóa đơn |
| `SOLookupPX4HD` | `asSOLookupPxHd` | Lookup Phiếu xuất → Hóa đơn |
| `SOLookupPX4PN` | `asSOLookupPxPn` | Lookup Phiếu xuất → Phiếu nhập |
| `SOLookupHD4PN` | `asSOLookupHdPn` | Lookup Hóa đơn → Phiếu nhập |
| `Get_RightPrint` | `asCheckRightPrint` | Kiểm tra quyền in |
| `SoInsLogPrint` | `asInsLogPrint` | Ghi log in ấn |
| `SOChkStatusRightSO1` | `asSOChkRightStatusSO1` | Check quyền SO1 |
| `SOChkStatusRightSO2` | `asSOChkRightStatusSO2` | Check quyền SO2 |
| `SOChkStatusRightSO3` | `asSOChkRightStatusSO3` | Check quyền SO3 |
| `SOChkStatusRightSO5` | `asSOChkRightStatusSO5` | Check quyền SO5 |

### Implementation Details

**Get_GiaBan:**
- Sử dụng stored procedure `asSOGetGiaban`
- Parameters:
  - `@pMa_Cty`: Mã công ty
  - `@pKieu_lay_gia`: Kiểu lấy giá từ cấu hình SO
  - `@pMa_vt`: Mã vật tư
  - `@pMa_Nt`: Mã ngoại tệ
  - `@pNgay_ct`: Ngày chứng từ (default: DateTime.Now)
- Return: Giá bán (double)

**Get_GiamGia:**
- Sử dụng stored procedure `asGetGiabanGiamGia`
- Output parameters:
  - `@pTl_gt`: Tỷ lệ chiết khấu (nvarchar)
  - `@pGg`: Số tiền chiết khấu (money)
- Input: Mã KH, mã VT, mã NT, số lượng, ngày

**Lookup Functions:**
- Execute stored procedure trả về DataSet với 2 tables
- Table[0] = Header (oTblPh), Table[1] = Detail (oTblCt)
- Return false nếu không tìm thấy dữ liệu

**Get_RightPrint:**
- Kiểm tra quyền in dựa trên số lần in giới hạn
- Output parameter `@pIs_oke` cho kết quả

**SoInsLogPrint:**
- Sử dụng `SqlCommandBuilder.DeriveParameters` để tự động map parameters
- Ghi log lịch sử in ấn vào database

**SOChkStatusRightSOx:**
- Check trạng thái và quyền của chứng từ SO
- Return message lỗi qua `aMessContent` nếu không có quyền
- Return true nếu OK, false nếu có lỗi

---

## frmCA4SO Form

Form xử lý nghiệp vụ bán hàng trong module CA4 (Báo có/Ủy nhiệm chi).

**Note:** File decompiled có kích thước lớn (57,883 bytes), chứa logic xử lý:
- Binding dữ liệu chứng từ CA4 với thông tin bán hàng
- Lookup thông tin khách hàng, vật tư
- Tính toán giá, chiết khấu, thuế
- In ấn chứng từ

---

## Các chuỗi Text và Thuật ngữ

### Thuật ngữ Bán hàng (SO = Sales Order)

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `SO` | Sales Order - Đơn bán hàng |
| `DH` | Đơn hàng |
| `PX` | Phiếu xuất kho |
| `HD` | Hóa đơn |
| `PN` | Phiếu nhập kho |
| `CA4` | Chứng từ Báo có/Ủy nhiệm chi |

### Pricing Variables

| Variable | Ý nghĩa |
|----------|---------|
| `aMa_Vt` | Mã vật tư |
| `aMa_Nt` | Mã ngoại tệ |
| `aMa_Kh` | Mã khách hàng |
| `aSo_Luong` | Số lượng |
| `aNgay_ct` | Ngày chứng từ |
| `arTl` | Tỷ lệ chiết khấu (%) |
| `arGiamGia` | Số tiền chiết khấu |

### Document Chain

```
Đơn hàng (DH) → Phiếu xuất (PX) → Hóa đơn (HD)
                                    ↓
                              Phiếu nhập (PN) ← (Trả hàng)
```

---

## Mục đích sử dụng

**SOUtilities.dll là module tiện ích cho nghiệp vụ bán hàng** trong hệ thống ERP Asia Enterprise.

### Chức năng chính

#### 1. Quản lý giá bán (Pricing)
- **Get_GiaBan:** Lấy giá bán dựa trên:
  - Mã vật tư, mã ngoại tệ, ngày chứng từ
  - Cấu hình kiểu lấy giá từ hệ thống SO
  - Hỗ trợ đa tiền tệ
  
- **Get_GiaGiamGia:** Tính toán chiết khấu:
  - Dựa trên khách hàng, vật tư, số lượng
  - Trả về tỷ lệ % và số tiền chiết khấu
  - Áp dụng chính sách giá theo khách hàng

#### 2. Lookup chuỗi chứng từ (Document Chain Lookup)
- **DH → PX:** Tìm phiếu xuất từ đơn hàng
- **DH → HD:** Tìm hóa đơn từ đơn hàng
- **PX → HD:** Tìm hóa đơn từ phiếu xuất
- **PX → PN:** Tìm phiếu nhập (trả hàng) từ phiếu xuất
- **HD → PN:** Tìm phiếu nhập (trả hàng) từ hóa đơn

**Ứng dụng:**
- Truy xuất nguồn gốc chứng từ
- Kiểm tra trạng thái xử lý đơn hàng
- Quản lý trả hàng, điều chuyển

#### 3. Quản lý in ấn (Print Management)
- **Get_RightPrint:** Kiểm tra quyền in chứng từ
  - Giới hạn số lần in (LimitedPrint)
  - Check trạng thái chứng từ (Is_oke)
  
- **SoInsLogPrint:** Ghi log lịch sử in
  - Lưu người in, thời gian in, số lần in
  - Phục vụ audit và kiểm soát

#### 4. Kiểm tra quyền và trạng thái (Status & Rights Check)
- **SOChkStatusRightSO1/SO2/SO3/SO5:** 
  - Check quyền thao tác trên chứng từ SO
  - SO1, SO2, SO3, SO5: Các loại chứng từ bán hàng khác nhau
  - Trả về message lỗi nếu không có quyền

### Đặc điểm kỹ thuật

- **Static Module:** `SOCommon` class với các static methods
- **DAO Pattern:** Interface `SOCommonDAO` + implementation `MsSqlSOCommonDAO`
- **Stored Procedures:** Tất cả operations đều qua stored procedures
- **Optional Parameters:** Sử dụng `[Optional]` và `[DateTimeConstant]` cho parameters
- **Ref Parameters:** Output values qua `ref` (arTl, arGiamGia, aMessContent)
- **Crystal Reports:** Tích hợp in ấn báo cáo qua Crystal Reports

### Luồng xử lý điển hình

```
User tạo chứng từ bán hàng
          ↓
Gọi SOCommon.Get_GiaBan() → Lấy giá
          ↓
Gọi SOCommon.Get_GiaGiamGia() → Tính chiết khấu
          ↓
Lưu chứng từ → Check rights (SOChkStatusRightSOx)
          ↓
In chứng từ → Check RightPrint → InsLogPrint
          ↓
Lookup chain: DH → PX → HD (để track status)
```

### Integration Points

| Module | Integration |
|--------|-------------|
| CA4 (Báo có) | frmCA4SO xử lý thanh toán bán hàng |
| SO (Sales Order) | Lấy giá, chiết khấu, check rights |
| IN (Inventory) | Lookup PX, PN cho chain document |
| Report | Crystal Reports cho in ấn |

---

## Kết luận

SOUtilities.dll là module utility quan trọng cung cấp các functions dùng chung cho nghiệp vụ bán hàng trong hệ thống ERP Asia Enterprise:

- **Pricing Engine:** Lấy giá và tính chiết khấu tự động
- **Document Chain:** Truy xuất mối quan hệ giữa các chứng từ
- **Print Control:** Quản lý quyền in và log lịch sử
- **Rights Check:** Kiểm soát quyền thao tác theo loại chứng từ

Module này được thiết kế dưới dạng static utilities để dễ dàng gọi từ các module khác (SO1, SO2, SO3, SO5, CA4, v.v.) mà không cần khởi tạo instance.

---

*Ngày phân tích: 2026-03-29*

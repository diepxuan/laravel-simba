# Code to Stored Procedure Reference

Mapping giữa code decompiled (C#) và stored procedures.

---

## Pattern Đặt Tên

| Pattern Code | SP tương ứng | Ví dụ |
|--------------|----------------|-------|
| Get[Entity] | `as[Module]Get[Entity]` | `GetDmKh` → `asSOGetDMKH` |
| Ins[Entity] | `as[Module]Ins[Entity]` | `InsPh1` → `asSOInsPH1` |
| Upd[Entity] | `as[Module]Upd[Entity]` | `UpdPh1` → `asSOUpdPH1` |
| Del[Entity] | `as[Module]Del[Entity]` | `DelPh1` → `asSODelPH1` |
| Filt | `as[Module]Filt` | `Filt1` → `asSOFilt1` |
| Post | `as[Module]Post` / `asPost` | `Post2GL` → `asPost2GL` |
| Calc | `as[Module]Calc` | `CalcPb` → `asCOCalcPb` |
| Chk | `as[Module]Chk` | `ChkRight` → `asSOChkRight` |

---

## Framework (Hệ thống)

| Method | SP | Mục đích |
|--------|-----|-----------|
| GetRight | `asGetRight` | Kiểm tra quyền user |
| GetTyGia | `asGetTygia` | Lấy tỷ giá |
| GetSoCt | `asGetSoCt` | Lấy số chứng từ |
| GetSttRec | `asGetSttRec` | Lấy STT bản ghi |
| GetVoucherInfo | `asGetVoucherInfo` | Lấy thông tin CT |
| GetVoucher2Post | `asGetVoucher2Post` | Lấy CT cần post |
| ProcessCt | `asProcessCt` | Xử lý chi tiết |
| ChkCodeExists | `asChkCodeExists` | Kiểm tra mã tồn tại |
| Valid | `asValid` | Validate dữ liệu |

---

## GL Module

### Phiếu kế toán (GLVchGL1.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| LoadData | `asGLGetPh1`, `asGLGetCt1` | Lấy phiếu + chi tiết |
| Save | `asGLInsPh1` / `asGLUpdPh1` | Insert/Update phiếu |
| SaveDetail | `asGLInsCt1` | Insert chi tiết |
| Delete | `asGLDelPh1`, `asGLDelCt1` | Xóa phiếu + chi tiết |
| Filter | `asGLFilt1` | Filter danh sách |
| GetDmTk | `asGLGetDMTK` | Lấy danh mục TK |
| GetDmKc | `asGLGetDMKC` | Lấy danh mục KC |

### Post sang GL (GLPost2GL.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| GetVoucher2Post | `asGetVoucher2Post` | Lấy CT cần post |
| Post2GL | `asPost2Gl` | Post chứng từ |

### Danh mục TK (GLDMTK.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| GetAll | `asGLGetDMTK` | Lấy tất cả TK |
| Insert | `asGLInsDMTK` | Insert TK mới |
| Update | `asGLUpdDMTK` | Update TK |
| Delete | `asGLDelDMTK` | Xóa TK |

---

## SO Module (Sales Order)

### Đơn hàng bán (SOVchSO1.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| LoadData | `asSOGetPh1`, `asSOGetCT1` | Lấy ĐH + chi tiết |
| Save | `asSoInsPh1` / `asSOUpdPH1` | Insert/Update ĐH |
| SaveDetail | `asSoInsCt1` | Insert chi tiết |
| Delete | `asSODelPH1`, `asSODelCT1` | Xóa ĐH + chi tiết |
| GetDmKh | `asSOGetDMKH` | Lấy danh mục KH |
| GetGiaban | `asSOGetGiaban` | Lấy giá bán |
| GetDmKm | `asSOGetDMKM` | Lấy khuyến mãi |
| Filter | `asSOFilt1` | Filter đơn hàng |
| CheckRight | `asSOChkRightStatusSO1` | Kiểm tra quyền |

---

## SI Module (Sales Invoice)

### Hóa đơn bán (SIVchSI1.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| LoadData | `asSIGetDMCT` | Lấy danh mục CT |
| GetDmBp | `asSIGetDMBP` | Lấy bộ phận |
| GetDmHd | `asSIGetDMHD` | Lấy hóa đơn |
| GetDmNt | `asSIGetDMNT` | Lấy ngoại tệ |

---

## AR Module (Accounts Receivable)

### Hóa đơn bán (ARVchAR4.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| LoadData | `asARGetPH1`, `asARGetCT1` | Lấy HĐ + chi tiết |
| Save | `asARInsPH1` / `asARUpdPH1` | Insert/Update HĐ |
| SaveDetail | `asARInsCT1` | Insert chi tiết |
| Delete | `asARDelPH1`, `asARDelCT1` | Xóa HĐ + chi tiết |
| GetDmKh | `asARGetDMKH` | Lấy danh mục KH |
| Post2ArTt | `asARPostPh1_artt` | Post sang ArTt |
| Post2GlCt | `asARPostPh1_glct` | Post sang GlCt |

---

## AP Module (Accounts Payable)

### Thanh toán (APPay.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| Post2TT | `asAPPostPh1_aptt` | Post sang ApTt |
| GetPost2TT | `asAPGetPost2TT_APTT` | Lấy post TT |
| InsPost2TT | `asAPInsPost2TT_APTT` | Insert post TT |
| DelPost2TT | `asAPDelPost2TT_APTT` | Xóa post TT |

---

## IN Module (Inventory)

### Nhập kho (INVchIN1.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| LoadData | `asINGetPH1`, `asINGetCT1` | Lấy phiếu + chi tiết |
| Save | `asINInsPH1` / `asINUpdPH1` | Insert/Update nhập kho |
| SaveDetail | `asINInsCT1` | Insert chi tiết |
| Delete | `asINDelPH1`, `asINDelCT1` | Xóa phiếu + chi tiết |
| GetDmVt | `asINGetDMVT` | Lấy danh mục VT |
| GetDmKho | `asINGetDMKHO` | Lấy danh mục kho |
| GetDmLo | `asINGetDMLO` | Lấy danh mục lô |
| GetTonKho | `asINGetTonVtAll` | Lấy tồn kho |

---

## CA Module (Cash)

### Phiếu thu/chi (CAVchCA1.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| LoadData | `asCAGetPH1`, `asCAGetCT1` | Lấy phiếu + chi tiết |
| Save | `asCAInsPH1` / `asCAUpdPH1` | Insert/Update phiếu |
| SaveDetail | `asCAInsCT1` | Insert chi tiết |
| Delete | `asCADelPH1`, `asCADelCT1` | Xóa phiếu + chi tiết |
| GetDmKu | `asCAGetDMKU` | Lấy danh mục quỹ |
| GetCdKu | `asCAGetCDKU` | Lấy số dư quỹ |
| Post2GlCt | `asPostCaPh1_glct` | Post sang GL |

---

## FA Module (Fixed Asset)

### TSCĐ (FADMTS.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| LoadData | `asFAGetDMTS` | Lấy TSCĐ |
| Save | `asFAInsDMTS` / `asFAUpdDMTS` | Insert/Update TSCĐ |
| Delete | `asFADelDMTS` | Xóa TSCĐ |
| Post2GlCt | `asFAPost2GlCt` | Post sang GL |

### Khấu hao (FACalKHTS.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| CalKHTS | `asFACalKHTS` | Tính khấu hao |
| GetKHTS | `asFAGetKHTS` | Lấy khấu hao |

---

## CO Module (Manufacturing)

### BOM (CODMBOM.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| GetDMBOM | `asCOGetDMCoBomPH` | Lấy BOM |
| InsDMBOM | `asCOInsDMCoBomPH` | Insert BOM |
| UpdDMBOM | `asCOUpdDMCoBomPH` | Update BOM |
| DelDMBOM | `asCODelDMCoBomPH` | Xóa BOM |

### Phân bổ (COPB.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| CalcPb | `asCOCalcPb` | Tính phân bổ |
| UpdateCost | `asCOUpdateCost` | Update giá thành |
| PostCp2GlCt | `asCOPostCp2GlCt` | Post sang GL |

---

## PO Module (Purchase)

### Đơn hàng mua (POVchPO1.dll)

| Method | SP | Mục đích |
|--------|-----|-----------|
| LoadData | `asPOGetPH0`, `asPOGetCT0` | Lấy ĐH + chi tiết |
| Save | `asPOInsPH0` / `asPOUpdPH0` | Insert/Update ĐH mua |
| SaveDetail | `asPOInsCT0` | Insert chi tiết |
| Delete | `asPODelPH0`, `asPODelCT0` | Xóa ĐH + chi tiết |
| GetDmCp | `asPOGetDMCP` | Lấy chi phí |
| Filter | `asPOFilt0` | Filter ĐH mua |

---

## SP Chung (Cross-Module)

| SP | Mô tả | Sử dụng |
|----|-------|-----------|
| `asGetRight` | Kiểm tra quyền | Tất cả forms |
| `asGetTygia` | Lấy tỷ giá | Nghiệp vụ NT |
| `asGetSoCt` | Lấy số CT | Tất cả forms nhập |
| `asGetSttRec` | Lấy STT rec | Tất cả forms |
| `asPost2GL` | Post sang GL | Tất cả modules |
| `asGetVoucher2Post` | Lấy CT cần post | GLPost2GL |
| `asChkCodeExists` | Kiểm tra mã | Danh mục |

---

## Ví dụ Code Gọi SP

```csharp
// Insert đơn hàng
_command.CommandText = "asSoInsPh1";
_command.CommandType = CommandType.StoredProcedure;
_command.Parameters.AddWithValue("@pMa_cty", ma_cty);
_command.Parameters.AddWithValue("@pStt_rec", stt_rec);
_command.Parameters.AddWithValue("@pMa_ct", ma_ct);
ExecuteNonQuery();

// Post sang GL
_command.CommandText = "asPost2Gl";
_command.Parameters.AddWithValue("@pMa_Cty", pMa_cty);
_command.Parameters.AddWithValue("@pStt_rec", pStt_rec);
_command.Parameters.AddWithValue("@pMa_ct", pMa_ct);
_command.Parameters.AddWithValue("@pPostUnpost", pPost);
ExecuteNonQuery();
```

---

## Tham khảo

- Mapping tổng quan: [ASIA_SIMBA_MAPPING.md](ASIA_SIMBA_MAPPING.md)
- Tra cứu nhanh: [QUICK_REFERENCE.md](QUICK_REFERENCE.md)
- File index: [FILE_INDEX.md](FILE_INDEX.md)

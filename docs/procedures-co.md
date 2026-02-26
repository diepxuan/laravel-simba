# Nhóm Stored Procedures asCO* (Production)

Đây là tài liệu cho nhóm stored procedures bắt đầu bằng `asCO*` thuộc module Production (Có thể là phân bổ chi phí, định mức nguyên vật liệu, sản phẩm công trình...).

## Danh sách procedures đã chuyển đổi

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asCOCalcPb | `AsCOCalcPb` | `@pMa_cty`, `@pNgay1`, `@pNgay2`, `@pId`, `@pMa_ct`, `@pUser` | Thực hiện phân bổ và tạo ra các bút toán phân bổ trong GLCT. |
| asCOUpdDMSPCT | `AsCOUpdDMSPCT` | `@pMa_cty`, `@pMa_spct`, `@pTen_spct`, `@pNgay_kc`, `@pNgay_kt`, `@pDu_toan`, `@pDu_toan_NT`, `@pDv_tc`, `@pGhi_chu`, `@pDvt`, `@pMa_nhspct`, `@pSan_pham`, `@pKsd`, `@pLUser`, `@pRet` (output) | Cập nhật danh mục sản phẩm công trình (CODMSPCT). |
| asCOInsDMSPCT | `AsCOInsDMSPCT` | `@pMa_cty`, `@pMa_spct`, `@pTen_spct`, `@pNgay_kc`, `@pNgay_kt`, `@pDu_toan`, `@pDu_toan_NT`, `@pDv_tc`, `@pGhi_chu`, `@pDvt`, `@pMa_nhspct`, `@pSan_pham`, `@pKsd`, `@pLUser`, `@pRet` (output) | Thêm mới danh mục sản phẩm công trình (CODMSPCT). |
| asCOGetDMPB1 | `AsCOGetDMPB1` | `@pMa_cty`, `@pModuleId` | Lấy danh sách các tài khoản nhận phân bổ theo mã công ty và module. |
| asCODelDMNHSPCT | `AsCODelDMNHSPCT` | `@pMa_cty`, `@pMa_nhspct`, `@pRet` (output) | Xóa danh mục nhóm sản phẩm công trình (CODMNHSPCT) sau khi kiểm tra ràng buộc. |
| asCODelDMSPCT | `AsCODelDMSPCT` | `@pMa_cty`, `@pMa_spct`, `@pRet` (output) | Xóa danh mục sản phẩm công trình (CODMSPCT) sau khi kiểm tra ràng buộc. |
| asCODelDMCoBomCT | `AsCODelDMCoBomCT` | `@pMa_cty`, `@pMa_spct`, `@pMa_vt`, `@pRet` (output) | Xóa định mức nguyên vật liệu - thông tin chi tiết (codmbomct). |
| asCOUpdDMCoBomCT | `AsCOUpdDMCoBomCT` | `@pMa_cty`, `@pMa_spct`, `@pMa_vt`, `@pvt_chinh`, `@pso_luong`, `@pUser`, `@pRet` (output) | Cập nhật định mức nguyên vật liệu - thông tin chi tiết (codmbomct). |
| asCODelDMCoBomPH | `AsCODelDMCoBomPH` | `@pMa_cty`, `@pMa_spct`, `@pRet` (output) | Xóa định mức nguyên vật liệu (cả phần chung và chi tiết). |
| asCOUpdDMCoBomPH | `AsCOUpdDMCoBomPH` | `@pMa_cty`, `@pMa_spct`, `@pNgay1`, `@pNgay2`, `@pDon_gia_luong`, `@pGhi_chu`, `@pUser`, `@pRet` (output) | Cập nhật định mức nguyên vật liệu - thông tin chung (codmbomph). |
| asCOGetDMCoBomCT | `AsCOGetDMCoBomCT` | `@pMa_cty`, `@pma_spct`, `@pMa_vt` (tất cả có mặc định '') | Lấy danh sách định mức nguyên vật liệu - thông tin chi tiết kết hợp với tên vật tư. |
| asCOGetDMPB | `AsCOGetDMPB` | `@pMa_cty`, `@pModuleId` | Lấy danh sách danh mục phân bổ (codmpb) theo mã công ty và module. |
| asCODelDMPB1 | `AsCODelDMPB1` | `@pMa_cty`, `@pId`, `@pTk_nhan_pb`, `@pMa_ct`, `@pRet` (output) | Xóa một chi tiết phân bổ (CODMPB1) sau khi kiểm tra xem đã có bút toán phân bổ trong GLCT chưa. |
| asCOGetDMPB12 | `AsCOGetDMPB12` | `@pMa_cty`, `@pNam`, `@pModuleId` | Lấy thông tin chi tiết phân bổ theo năm và module, kết hợp với tên sản phẩm công trình, tên bộ phận và tên tài khoản. |
| asCOUpdHsPb | `AsCOUpdHsPb` | `@pMa_cty`, `@pId`, `@pNam`, `@pTHang`, `@pTk`, `@pMa_spct`, `@pMa_bp`, `@pTk_DU`, `@pHs`, `@pTien_nhan`, `@pRet` (output) | Cập nhật hệ số phân bổ và tiền nhận phân bổ trong bảng chi tiết phân bổ (codmpb2). |
| asCODelPostCp2GlCt | `AsCODelPostCp2GlCt` | `@pMa_cty`, `@pMa_ct`, `@pNam`, `@pThang`, `@pRet` (output) | Xóa phân bổ chi phí trả trước trong sổ cái và bảng chi tiết khấu hao chi phí trả trước. |
| asCOGetDMSPCT | `AsCOGetDMSPCT` | `@pMa_cty`, `@pMa_spct`, `@pStruct`, `@pIsSP` (tất cả có mặc định) | Lấy danh sách danh mục sản phẩm công trình kết hợp với tên nhóm sản phẩm công trình. |
| asCOInsDMPB | `AsCOInsDMPB` | `@pMa_cty`, `@pStt`, `@pTen_bt`, `@pTk_pb`, `@pSo_ct`, `@pKsd`, `@pUser`, `@pTheoSPCT`, `@pTheoBP`, `@pTheoTKDU`, `@pModuleId`, `@pRet` (output) | Thêm mới danh mục phân bổ nếu chưa tồn tại. |
| asCOUpdDMNHSPCT | `AsCOUpdDMNHSPCT` | `@pMa_cty`, `@pma_nhspct`, `@pten_nhspct`, `@pCap`, `@pStt_nhom`, `@pNhom_me`, `@pGhi_chu`, `@pCong_sl`, `@pKsd`, `@pLUser`, `@pRet` (output) | Cập nhật danh mục nhóm sản phẩm công trình. |

## Tổng số procedures đã chuyển đổi: 19

## Ghi chú

- Các class PHP nằm trong namespace `Diepxuan\LaravelSimba\StoredProcedures`.
- Tất cả class đều sử dụng `ProcedureCaller::call()` để gọi stored procedure.
- Các tham số output (ví dụ `@pRet`) có thể được trả về trong mảng kết quả nếu `ProcedureCaller` hỗ trợ.
- Đối với các procedure có tham số output, cần đọc giá trị sau khi gọi để kiểm tra lỗi.

## Cập nhật

Danh sách này sẽ được bổ sung khi chuyển đổi thêm procedures.
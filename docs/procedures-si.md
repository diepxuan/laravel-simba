# Sales & Inventory (asSI*) Stored Procedures

Danh sách các stored procedure trong nhóm Sales & Inventory (asSI*) đã được chuyển đổi sang class PHP.

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSIDelDMBP | AsDelDMBP | pMa_cty, pMa_bp | Xoá một bộ phận (danh mục bộ phận) |
| asSIDelDMCT | AsDelDMCT | pMa_cty, pMa_ct | Xoá một loại chứng từ (danh mục chứng từ) |
| asSIDelDMHD | AsDelDMHD | pMa_cty, pMa_hd | Xoá một loại hóa đơn (danh mục hóa đơn) |
| asSIDelDMHTTT | AsDelDMHTTT | pMa_cty, pMa_httt, pModuleid | Xoá một hình thức thanh toán (danh mục hình thức thanh toán) |
| asSIDelDMNHHD | AsDelDMNHHD | pMa_cty, pMa_nhhd | Xoá một người hóa đơn (danh mục người hóa đơn) |
| asSIDelDMNT | AsDelDMNT | pMa_cty, pMa_nt | Xoá một người thu (danh mục người thu) |
| asSIDelDMPHI | AsDelDMPHI | pMa_cty, pMa_phi | Xoá một loại phí (danh mục phí) |
| asSIDelDMTGNT | AsDelDMTGNT | pMa_cty, pMa_nt, pNgay_tg | Xoá một tiêu thức người thu (danh mục tiêu thức người thu) |
| asSIDelGroupRight | AsDelGroupRight | pGroupName, pMenuID | Xoá phân quyền nhóm (sysGroupRight) |
| asSIGetDMBP | AsGetDMBP | pMa_cty, pMa_bp, pStruct | Lấy danh sách bộ phận |
| asSIGetDMCT | AsGetDMCT | pMa_cty, pMa_ct, pPhan_he, pLanguage, pStruct | Lấy danh sách loại chứng từ |
| asSIGetDMCTByMa_Ct | AsGetDMCTByMaCt | pMa_cty, pMa_ct, pLanguage | Lấy thông tin chi tiết một loại chứng từ theo mã |
| asSIGetDMHD | AsGetDMHD | pMa_cty, pMa_hd, pStruct | Lấy danh sách hóa đơn |
| asSIGetDMHTTT | AsGetDMHTTT | pMa_cty, pMa_httt, pModuleid, pStruct | Lấy danh sách hình thức thanh toán |
| asSIGetDMNGH | AsGetDMNGH | pMa_cty, pMa_ngh, pStruct | Lấy danh sách ngành hàng |
| asSIGetDMNHHD | AsGetDMNHHD | pMa_cty, pMa_nhhd, pStruct | Lấy danh sách người hóa đơn |
| asSIGetDMNT | AsGetDMNT | pMa_cty, pMa_nt, pStruct | Lấy danh sách người thu |
| asSIGetDMPHI | AsGetDMPHI | pMa_cty, pMa_phi, pStruct | Lấy danh sách phí |
| asSIGetDMTGNT | AsGetDMTGNT | pMa_cty | Lấy danh sách tiêu thức người thu |
| asSIGetDmSo_ct | AsGetDmSoCt | pMa_cty, pPhan_he, pStruct, pLanguageId | Lấy danh sách loại chứng từ theo phân hệ và ngôn ngữ |
| asSIGetModuleID | AsGetModuleID | (none) | Lấy danh sách module ID và tên module |
| asSIGetTableColumnDefine | AsGetTableColumnDefine | pTableName | Lấy định nghĩa cột của một bảng |
| asSIInsDMBP | AsSIInsDMBP | pMa_cty, pMa_bp, pTen_bp, pKsd, pLUser | Thêm một bộ phận |

## Tổng số: 23 procedures

## Ghi chú
- Các tham số output (`@pRet output`) không được truyền vào PHP, stored procedure tự xử lý.
- Giá trị mặc định của tham số được thiết lập theo logic của stored procedure gốc.
- Tất cả class đều nằm trong namespace `Diepxuan\Simba\StoredProcedures`.
- Method `call` trả về `Illuminate\Support\Collection` (trừ một số trường hợp đặc biệt).

## asSIGetDMBP

- **Class:** AsSIGetDMBP
- **Parameters:** pMa_cty, pMa_bp, pStruct
- **Description:** 
- **SQL File:** `asSIGetDMBP.sql`


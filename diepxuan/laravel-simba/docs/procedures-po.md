# Purchase Order (asPO*) Stored Procedures

Danh sách các stored procedure thuộc nhóm Purchase Order (asPO*) đã được chuyển đổi sang class PHP.

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asPOChkRightStatusPO0 | `AsPoChkRightStatusPo0` | `pMa_cty`, `pStt_rec`, `pLanguage` | Kiểm tra trạng thái chứng từ trước khi sửa/xóa đơn đặt hàng. |
| asPODelCP2 | `AsPoDelCp2` | `pMa_cty`, `pStt_rec`, `pRet` (output) | Xóa dữ liệu chi tiết chứng từ POCP2. |
| asPODelCP3 | `AsPoDelCp3` | `pMa_cty`, `pStt_rec`, `pRet` (output) | Xóa dữ liệu chi tiết chứng từ POCP3. |
| asPODelCP4 | `AsPoDelCp4` | `pMa_cty`, `pStt_rec`, `pRet` (output) | Xóa dữ liệu chi tiết chứng từ POCP4. |
| asPODelCP8 | `AsPoDelCp8` | `pMa_cty`, `pStt_rec`, `pRet` (output) | Xóa dữ liệu chi tiết chứng từ POCP8. |
| asPOFilt0 | `AsPoFilt0` | `pKeyPh`, `pKeyCt` | Lọc danh sách chứng từ POPH0 và POCT0 theo điều kiện dynamic SQL. |
| asPOFilt1 | `AsPoFilt1` | `pKeyPh`, `pKeyCt` | Lọc danh sách chứng từ POPH1 và POCT1 theo điều kiện dynamic SQL. |
| asPOGetCA4PO | `AsPoGetCa4Po` | `pMa_cty`, `pMa_ct`, `pStt_rec_hd` | Lấy thông tin chứng từ thanh toán từ phân hệ mua hàng. |
| asPOGetCP2 | `AsPoGetCp2` | `pMa_cty`, `pStt_rec`, `pStruct` | Lấy danh sách chi phí POCP2 theo mã công ty và số tham chiếu. |
| asPOGetCP3 | `AsPoGetCp3` | `pMa_cty`, `pStt_rec`, `pStruct` | Lấy danh sách chi phí POCP3 theo mã công ty và số tham chiếu. |
| asPOGetCP4 | `AsPoGetCp4` | `pMa_cty`, `pStt_rec`, `pStruct` | Lấy danh sách chi phí POCP4 theo mã công ty và số tham chiếu. |
| asPOGetCP8 | `AsPoGetCp8` | `pMa_cty`, `pStt_rec`, `pStruct` | Lấy danh sách chi phí POCP8 theo mã công ty và số tham chiếu. |
| asPOGetCT0 | `AsPoGetCt0` | `pMa_cty`, `pStt_rec`, `pStruct` | Lấy danh sách chi tiết hàng hóa POCT0 theo mã công ty và số tham chiếu. |
| asPOGetCT1 | `AsPoGetCt1` | `pMa_cty`, `pStt_rec`, `pStt_rec0`, `pStruct` | Lấy danh sách chi tiết hàng hóa POCT1 theo mã công ty, số tham chiếu và số thứ tự dòng. |

## Ghi chú

- Các class nằm trong namespace `Diepxuan\LaravelSimba\StoredProcedures`.
- Sử dụng `ProcedureCaller::call()` để thực thi stored procedure.
- Tham số output cần xử lý riêng (hiện chưa hỗ trợ đầy đủ).
- Các tham số có giá trị mặc định đã được thiết lập trong phương thức `call()`.

## Tiến độ chuyển đổi

Đã chuyển đổi: **14** procedures.

Cập nhật lần cuối: 2026-02-11
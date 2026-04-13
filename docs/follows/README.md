# Follows - SQL Execution Logs

Thư mục này chứa các SQL scripts ghi lại quá trình thực thi nghiệp vụ để theo dõi và debug.

## Files

| File | Mô tả | Ngày tạo |
|------|-------|----------|
| `ChuyenSoDuTKSangNamSau.sql` | Chuyển số dư tài khoản sang năm sau | 2026-02 |
| `SuaPhieuBaoNo.sql` | Sửa phiếu báo nợ (CA4) | 2026-02 |
| `TaoPhieuBaoNo.sql` | Tạo phiếu báo nợ mới | 2026-02 |

## Mục đích

Các file trong thư mục này ghi lại:
- Các stored procedures được gọi
- Thứ tự thực thi
- Parameters truyền vào
- Giá trị return/output

Dùng để:
- Debug luồng nghiệp vụ
- Phân tích cách app gọi SP
- Tạo test case
- Tài liệu hóa quy trình

## Cách đọc

Mỗi file là một chuỗi các lệnh SQL được ghi lại từ SQL Server Profiler hoặc trace.

Ví dụ:
```sql
-- Lấy số chứng từ mới
exec asGetSoCt @pMa_cty=N'001',@pMa_Ct=N'CA4',...

-- Insert header
exec asCAInsPH2 @pMa_cty=N'001',@pStt_rec=N'...',...

-- Insert chi tiết
exec asCAInsCT2 @pMa_cty=N'001',@pStt_rec=N'...',...
```

## Liên kết

- [docs/reference/QUICK_REFERENCE.md](../reference/QUICK_REFERENCE.md) - Tra cứu SP nhanh
- [docs/reference/CODE_REFERENCE.md](../reference/CODE_REFERENCE.md) - Mapping code → SP

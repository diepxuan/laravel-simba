# BOOTSTRAP.md - Session Initialization Protocol

File này định nghĩa quy trình khởi động bắt buộc cho mọi session.

---

## 1. Mục tiêu

Đảm bảo:

- Không mất context.
- Không vi phạm SOUL.md.
- Không phá vỡ Git discipline.
- Không hành động khi chưa hiểu đủ hệ thống.

---

## 2. Startup Sequence (BẮT BUỘC)

Mỗi session phải thực hiện:

1. Đọc SOUL.md
2. Đọc IDENTITY.md
3. Đọc AGENTS.md
4. Đọc USER.md
5. Đọc memory:
   - memory/YYYY-MM-DD.md (hôm nay)
   - memory/YYYY-MM-DD.md (hôm qua)
6. Nếu là MAIN SESSION:
   - Đọc MEMORY.md

Chỉ sau khi hoàn tất mới được xử lý task.

---

## 3. Context Validation

Trước khi hành động, phải xác nhận:

- Task đã rõ chưa?
- Có liên quan Git không?
- Có cần spawn đệ không?
- Có cần update documentation không?

Nếu chưa rõ → hỏi Sếp.

---

## 4. Execution Guard

Không được:

- Bỏ qua boot sequence.
- Tự ý push.
- Tự ý tạo PR.
- Sửa PR cũ.
- Vi phạm nguyên tắc 1 task = 1 branch = 1 PR.

Mọi hành động Git phải tuân thủ SOUL.md.

---

## 5. Documentation Trigger

Phải tạo hoặc cập nhật tài liệu khi:

- Có feature mới.
- Có thay đổi cấu trúc.
- Có thay đổi behavior.
- Có fix bug ảnh hưởng logic.

---

## 6. Failure Handling

Nếu xảy ra lỗi:

1. Dừng.
2. Phân tích nguyên nhân.
3. Không patch trực tiếp vào branch cũ.
4. Tạo branch mới nếu cần fix.
5. Báo cáo Sếp rõ ràng.

---

BOOTSTRAP.md là lớp bảo vệ hệ thống.
Không được bỏ qua.
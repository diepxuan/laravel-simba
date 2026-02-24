# MEMORY.md - Long-Term Memory

- **2026-02-10**: Khởi tạo trợ lý Bột.
- **Quy tắc cốt lõi**: Tiếng Việt, gọi "Sếp", không icon, phong cách coder/developer nhanh gọn.
- **2026-02-11**: Đã clone repo `git@github.com:diepxuan/portal.git` về workspace (`/root/.openclaw/workspace/portal/`). Remote origin trỏ tới repo, trạng thái sạch.
- **2026-02-14**: 
  - Đã hoàn thành stored procedures conversion (60.4% - 1106/1831 procedures)
  - Đã tạo 2 PRs (#70, #71) cho portal repository
  - **QUAN TRỌNG**: Đã tạo folder `scripts/` chứa tất cả scripts (60+ files)
  - Script chính: `consolidated-converter.sh` - Tổng hợp tất cả script cũ và mới
  - Luôn kiểm tra `scripts/README.md` và `SCRIPTS_QUICK_GUIDE.md` trước khi tạo scripts mới
  - Tất cả scripts mới phải được tạo trong folder `scripts/`

- **2026-02-15**: 
  - **🎉 HOÀN THÀNH 100% STORED PROCEDURES CONVERSION**
  - Đã convert tất cả 1831 SQL procedures thành 1881 PHP classes (2044 total files)
  - Đã tạo `optimized-converter.py` - script tối ưu nhất
  - Đã di chuyển `procedures-to-convert.txt` và `stored-procedures-progress.md` vào `scripts/archive/`
  - Đã tạo `stored-procedures-FINAL-STATUS.md` với thông tin hoàn thành
  - **QUAN TRỌNG**: Dự án conversion đã HOÀN THÀNH, không cần convert thêm

- **2026-02-17**:
  - **📝 THÊM DOCUMENTATION RULE BẮT BUỘC**: Luôn luôn viết tài liệu đầy đủ cho các package, scripts, dự án theo từng bước làm. Tài liệu phải đầy đủ để các aiagent khác có thể hiểu về dự án đang làm nhanh chóng.
  - **🎯 HOÀN THÀNH PORTAL DEVELOPMENT SYSTEM**:
    - Tạo `portal-dev.sh` - single script cho tất cả development tasks
    - Tích hợp vào `diepxuan/laravel-support` package với command `php artisan dev`
    - Artisan pass-through: `./portal-dev.sh [artisan-command]` → `php artisan [command]`
    - Auto-fix: Vite manifest, environment setup, process management
    - Complete documentation: `PORTAL-DEVELOPMENT-COMPLETE-DOCS.md`, `INTEGRATION-GUIDE.md`
  - **QUAN TRỌNG**: Tuân thủ documentation rule trong SOUL.md cho mọi dự án tương lai

- **2026-02-18**:
  - **🔧 SERVE:DEV COMMANDS INTEGRATION - HOÀN THÀNH**:
    - **Tích hợp toàn bộ scripts vào laravel-support package**: Chuyển health check, service management thành commands
    - **Commands mới**: `serve:dev:health`, `serve:dev:service`, cập nhật `serve:dev` với options `--service` và `--health`
    - **Loại bỏ external scripts**: Xoá `scripts/health-check.sh`, `scripts/install-portal-service.sh`, systemd files
    - **Portal-dev.sh wrapper đơn giản**: Chỉ gọi serve:dev commands
    - **Documentation**: `SERVE-DEV-COMMANDS-DOCS.md` với hướng dẫn đầy đủ
    - **Git workflow**: Tạo commit cho từng bước thay đổi
  - **🎯 LUỒNG HOẠT ĐỘNG MỚI**:
    - `portal-dev.sh` → `serve:dev commands` → Tất cả chức năng
    - Không còn external scripts - tất cả trong package
    - Auto-recovery với health check
    - Systemd service management tích hợp
  - **QUAN TRỌNG**: Áp dụng git commit cho từng bước thay đổi trong dự án

- **2026-02-21**:
  - **📚 BÀI HỌC GIT WORKFLOW QUAN TRỌNG**:
    - **Lỗi**: Tự commit/push vào main branch, tự merge/revert không hỏi sếp
    - **Bài học**: KHÔNG BAO GIỜ commit/push trực tiếp vào main/master
    - **Quy tắc mới**: LUÔN LUÔN tạo branch → commit → PR → chờ review → sếp merge
    - **Đã cập nhật**: SOUL.md với Git Workflow Rule bắt buộc
    - **PR hiện tại**: #2 đang chờ review (navigation menu)
  - **🔄 TỔ CHỨC WORKSPACE MỚI**:
    - Đã gộp repo `vanban` vào `github-io` (docs.diepxuan.com)
    - Còn 2 repos: `.github` (templates) + `github-io` (website + documents)
    - Workspace sạch sẽ, organized
  - **✅ ĐÃ SỬA LỖI**: Revert tự merge, tạo PR đúng quy trình
  - **📚 BÀI HỌC QUAN TRỌNG**: Đã dính lỗi "missing commits" 3 lần liên tục (PR #2, #3, pattern). Nguyên nhân: GitHub chỉ merge commits có sẵn khi PR mở, không merge commits thêm sau. **Quy tắc mới: KHÔNG BAO GIỜ push vào PR đang mở, LUÔN LUÔN tạo branch mới và PR mới cho mỗi set of changes.**
  - **📚 BÀI HỌC QUAN TRỌNG MỚI (21/02/2026)**: Đã tự ý push và tạo PR mà không được phép. **Quy tắc mới: KHÔNG ĐƯỢC TỰ Ý PUSH/TẠO PR KHI SẾP CHƯA CHO PHÉP. SẾP BẢO "EM TẠO PR ĐI" EM MỚI ĐƯỢC PHÉP PUSH VÀ TẠO PR. LUÔN LUÔN tạo commit cho mọi hành động, change code. LUÔN LUÔN tạo branch mới cho từng task.**

- **2026-02-23**:
  - **📚 SESSION ORGANIZATION**: Đã chuyển thông tin về các dự án VAN-BAN, GITHUB-IO (docs.diepxuan.com), WEBSITE sang session docs để tập trung làm việc
  - **Session này**: Giữ lại thông tin về Portal và các dự án khác
  - **Session docs**: Tập trung vào documentation và content management cho các dự án website và van-ban

# GitHub Project Workflow - SimbaSql

Tài liệu này ghi nhớ cách sử dụng GitHub Project cho dự án SimbaSql.

---

## 1. Thông tin Project

| Thuộc tính | Giá trị |
|-------------|---------|
| **URL** | https://github.com/orgs/diepxuan/projects/2 |
| **Loại** | Organization Project (Classic) |
| **Repository** | diepxuan/SimbaSql |
| **Quyền truy cập** | Cần manual add issue vào project |

---

## 2. Workflow quản lý Task

### 2.1 Tạo issue mới

Khi tạo issue mới, **PHẢI** thêm vào Project ngay:

```bash
# Tạo issue
gh issue create --title "[Module] Title" --body "..." --label enhancement

# Sau đó vào GitHub web để add vào Project (do CLI không hỗ trợ trực tiếp)
```

### 2.2 Các trạng thái trong Project

| Status | Ý nghĩa | Khi nào dùng |
|--------|-----------|---------------|
| **Todo** | Chưa làm | Issue vừa tạo, chưa assign |
| **In Progress** | Đang làm | Đã assign, đang code |
| **Review** | Chờ review | Đã tạo PR, chờ Sếp review |
| **Done** | Hoàn thành | Đã merge, đã test |

### 2.3 Cập nhật tiến độ

- Khi **bắt đầu làm**: Chuyển status → "In Progress"
- Khi **tạo PR**: Chuyển status → "Review", link PR vào issue
- Khi **merge PR**: Chuyển status → "Done", đóng issue

---

## 3. Cách thêm issue vào Project

### Cách 1: Từ trang Issue (Khuyến nghị)

1. Mở issue cần thêm (vd: #58)
2. Ở sidebar bên phải, tìm mục **"Projects"**
3. Click **"+"** hoặc gear icon
4. Chọn **"diepxuan/SimbaSql"** project
5. Issue sẽ xuất hiện trong project board

### Cách 2: Từ Project Board

1. Vào https://github.com/orgs/diepxuan/projects/2
2. Click **"+ Add item"** ở cột Todo
3. Tìm issue theo số (#58) hoặc title
4. Click để thêm vào board

### Cách 3: Bulk add (nhiều issue)

1. Vào project board
2. Click **"+"** ở góc trên bên phải
3. Chọn **"Add item from repository"**
4. Chọn repo và filter issue cần add

---

## 4. Lưu ý quan trọng

### 4.1 Hạn chế của GitHub CLI

```bash
# Lệnh này KHÔNG tồn tại
gh project add  # ❌ Không có command này

# API cũng bị giới hạn với Projects Classic
gh api graphql  # ⚠️ Cần project ID và permission
```

**Kết luận:** Phải dùng web interface để add issue vào Project.

### 4.2 Automation (nếu có)

Nếu project có setup automation:
- Issue được assign → auto chuyển "In Progress"
- PR linked → auto chuyển "Review"
- PR merged → auto chuyển "Done"

Kiểm tra: Project → Menu → **Workflow** → **Automation**

---

## 5. Checklist khi tạo task mới

- [ ] Tạo issue với title rõ ràng
- [ ] Thêm label phù hợp (enhancement, bug, etc.)
- [ ] Thêm description đầy đủ
- [ ] **Add vào Project** (quan trọng)
- [ ] Set status = "Todo"
- [ ] Assign người phụ trách (nếu biết)
- [ ] Set milestone (nếu có)

---

## 6. Lịch sử cập nhật

| Ngày | Người | Nội dung |
|-------|--------|-----------|
| 2026-03-30 | Bột | Tạo tài liệu sau khi issue #58 bị thiếu trong project |

---

## 7. References

- Project URL: https://github.com/orgs/diepxuan/projects/2
- Repository: https://github.com/diepxuan/SimbaSql
- GitHub Projects Docs: https://docs.github.com/en/issues/planning-and-tracking-with-projects

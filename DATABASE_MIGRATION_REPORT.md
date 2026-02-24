# BÁO CÁO MIGRATION DATABASE TỪ WEB SERVER

## 📋 TỔNG QUAN
Đã SSH thành công đến web server (`web.diepxuan.corp`) và lấy được database connection information cho Portal local development.

## 🔗 SSH CONNECTION
- **Host:** `web.diepxuan.corp` (10.0.0.106)
- **User:** `root`
- **Status:** ✅ Connected successfully
- **TOOLS.md updated:** ✅ "dev" → "web"

## 🗄️ DATABASE CONNECTIONS LẤY ĐƯỢC

### 1. MySQL Database (Laravel)
```
DB_CONNECTION=mysql
DB_HOST=mysql.diepxuan.corp
DB_PORT=3306
DB_DATABASE=laravel
DB_USERNAME=laravel
DB_PASSWORD=d72a5c40fc31c537deb8917fa192873a
```

### 2. SQL Server Database (Simba/SQLSRV)
```
SQLSRV_HOST=sql.diepxuan.corp
SQLSRV_PORT=1433
SQLSRV_DATABASE=diepxuan
SQLSRV_USERNAME=asia
SQLSRV_PASSWORD=asiaadmin
SIMBA_CONNECTION=sqlsrv
```

## 📁 SOURCE LOCATION
- **Application:** `/var/www/laravel/` (Laravel application trên web server)
- **Config file:** `/var/www/laravel/.env`
- **Verified:** ✅ Database credentials extracted successfully

## 🔧 CẬP NHẬT LOCAL CONFIG

### File: `portal/.env`
**Đã thay đổi:**
- ❌ `DB_CONNECTION=sqlite` → ✅ `DB_CONNECTION=mysql`
- ❌ `DB_DATABASE=/root/.openclaw/workspace/portal/database/database.sqlite` → ✅ Full MySQL connection
- ✅ Thêm SQL Server connection cho Simba
- ✅ Giữ nguyên các config khác (VITE_HMR_URL, etc.)

### Database Connection Test:
```bash
php artisan tinker --execute="DB::connection()->getPdo();"
```
**Result:** ✅ Database connection successful

## 🚀 CÁC BƯỚC TIẾP THEO

### 1. Test SQL Server Connection
Cần cài đặt SQL Server driver và test connection:
```bash
# Cài đặt SQL Server driver
composer require doctrine/dbal

# Test SQL Server connection
php artisan tinker --execute="DB::connection('sqlsrv')->getPdo();"
```

### 2. Migrate Database (nếu cần)
```bash
# Chạy migrations từ web server database
php artisan migrate

# Hoặc import schema
mysqldump -h mysql.diepxuan.corp -u laravel -p laravel > database.sql
```

### 3. Verify Data Access
```bash
# Test query từ local
php artisan tinker --execute="DB::table('users')->count();"
```

## ⚠️ LƯU Ý QUAN TRỌNG

### Security:
- Database passwords đã được lưu trong `.env`
- **KHÔNG** commit `.env` file lên git
- Sử dụng `.env.example` cho production

### Network Accessibility:
- Local machine cần có network access đến:
  - `mysql.diepxuan.corp:3306`
  - `sql.diepxuan.corp:1433`
- Test connectivity: `telnet mysql.diepxuan.corp 3306`

### Backup Original Config:
Original SQLite config đã được thay thế. Nếu cần revert:
```env
DB_CONNECTION=sqlite
DB_DATABASE=/root/.openclaw/workspace/portal/database/database.sqlite
```

## 📊 STATUS SUMMARY

| Task | Status | Notes |
|------|--------|-------|
| SSH to web server | ✅ Success | root@web.diepxuan.corp |
| Find database config | ✅ Success | /var/www/laravel/.env |
| Extract credentials | ✅ Success | MySQL + SQL Server |
| Update local .env | ✅ Success | portal/.env updated |
| Test MySQL connection | ✅ Success | Laravel DB connection works |
| Test SQL Server connection | ⚠️ Pending | Need driver installation |
| Migrate data | ⚠️ Pending | Optional step |

## 🎯 KẾT LUẬN
Portal local development environment đã được cấu hình để sử dụng production-like database từ web server. Có thể bắt đầu development với real data ngay lập tức.
# Laravel Simba

Tích hợp Laravel với Simba (phần mềm kế toán).

## Mô tả ngắn gọn

Laravel Integration With Simba. Package cung cấp các model và stored procedure caller để tương tác với cơ sở dữ liệu Simba (ERP/kế toán), hỗ trợ composite primary key và xử lý charset.

## Chức năng chính

- Cung cấp các model (SModel) tương ứng với các bảng dữ liệu trong hệ thống Simba: SysLanguage, InCT3, SoPh3, GlDmTk, GlCt, GlCdTk, SysCompany, SysCompanyResx, InDmVt, InPH3, SiSetup, SysUserCompanyRight, ArDmKh, InDmKho, SysUserInfo, InDmNhvt, ...
- Cung cấp các stored procedure caller để gọi procedure từ Simba: AsGetSoCt, AsGetSoDuKh, và class ProcedureCaller tổng quát.
- Sử dụng composite primary key (từ package eloquent-composite).
- Phụ thuộc vào package charset để xử lý encoding.
- Cấu hình kết nối database riêng (mặc định sqlsrv) qua environment variable `SIMBA_CONNECTION`.

## Cài đặt / Sử dụng

```bash
composer require diepxuan/laravel-simba
```

Package không có ServiceProvider, cần sử dụng thủ công.

Cấu hình kết nối database Simba trong `.env`:

```env
SIMBA_CONNECTION=sqlsrv
DB_CONNECTION_SIMBA=... (nếu dùng connection riêng)
```

Sử dụng model:

```php
use Diepxuan\Simba\SModel\InDmVt;

$items = InDmVt::all();
```

Sử dụng stored procedure caller:

```php
use Diepxuan\Simba\StoredProcedures\ProcedureCaller;

$result = ProcedureCaller::call('asGetSoCt', ['pMa_Cty' => '01', 'pNgay_Ct' => '2024-01-01']);
```

Hoặc dùng class cụ thể:

```php
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;

$result = AsGetSoCt::call($params);
```

## Cấu trúc thư mục

```
laravel-simba/
├── config/
│   └── config.php                 # Cấu hình package (connection)
├── src/
│   ├── SModel/                    # Các model Simba (bảng dữ liệu)
│   │   ├── SModel.php (base)
│   │   ├── SysLanguage.php
│   │   ├── InCT3.php
│   │   ├── SoPh3.php
│   │   ├── GlDmTk.php
│   │   ├── GlCt.php
│   │   ├── GlCdTk.php
│   │   ├── SysCompany.php
│   │   ├── SysCompanyResx.php
│   │   ├── InDmVt.php
│   │   ├── InPH3.php
│   │   ├── SiSetup.php
│   │   ├── SysUserCompanyRight.php
│   │   ├── ArDmKh.php
│   │   ├── InDmKho.php
│   │   ├── SysUserInfo.php
│   │   └── InDmNhvt.php
│   ├── Models/                    # Các model mở rộng (có thể thêm scope)
│   │   ├── SysCompany.php
│   │   ├── SysUserCompanyRight.php
│   │   ├── InDmVt.php
│   │   ├── InDmKho.php
│   │   ├── SysUserInfo.php
│   │   ├── ArDmKh.php
│   │   ├── SoPh3.php
│   │   ├── InDmNhvt.php
│   │   ├── SiSetup.php
│   │   └── GlCt.php
│   ├── StoredProcedures/          # Các class gọi stored procedure
│   │   ├── ProcedureCaller.php
│   │   ├── AsGetSoCt.php
│   │   └── AsGetSoDuKh.php
│   └── Database/                  (factories, seeders - chưa có nội dung)
├── .editorconfig
├── .gitignore
├── .php-cs-fixer.dist.php
├── LICENSE
├── README.md
└── composer.json
```

## Liên kết đến các package liên quan

- diepxuan/php-charset (xử lý charset)
- diepxuan/laravel-core (core chung)
- diepxuan/laravel-eloquent-composite (hỗ trợ composite primary key)

## Ghi chú

Package này tích hợp với cơ sở dữ liệu Simba, phục vụ cho việc trao đổi dữ liệu giữa Laravel và hệ thống ERP Simba (phần mềm kế toán). Cần cấu hình kết nối SQL Server (sqlsrv) đúng với database Simba.
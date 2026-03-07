# Configuration Guide

Hướng dẫn cấu hình Laravel Simba package.

---

## Mục lục

1. [Environment Configuration](#environment-configuration)
2. [Database Connection](#database-connection)
3. [Config File](#config-file)
4. [Model Configuration](#model-configuration)
5. [Troubleshooting](#troubleshooting)

---

## Environment Configuration

### Required Variables

Thêm các biến môi trường sau vào file `.env`:

```env
# ===========================================
# SIMBA DATABASE CONFIGURATION
# ===========================================

# Connection name (default: sqlsrv)
SIMBA_CONNECTION=sqlsrv

# SQL Server connection details (if using dedicated connection)
DB_CONNECTION_SIMBA=sqlsrv
DB_HOST_SIMBA=127.0.0.1
DB_PORT_SIMBA=1433
DB_DATABASE_SIMBA=simba_db
DB_USERNAME_SIMBA=your_username
DB_PASSWORD_SIMBA=your_password

# Optional: Charset handling
SIMBA_CHARSET=utf8
```

### Using Existing Connection

Nếu muốn dùng chung connection SQL Server hiện có:

```env
# Use default sqlsrv connection
SIMBA_CONNECTION=sqlsrv

# No need for DB_*_SIMBA variables
```

---

## Database Connection

### Option 1: Dedicated Simba Connection (Recommended)

**config/database.php:**

```php
'connections' => [
    // Default application database
    'mysql' => [
        'driver' => 'mysql',
        'host' => env('DB_HOST', '127.0.0.1'),
        'database' => env('DB_DATABASE', 'laravel'),
        'username' => env('DB_USERNAME', 'root'),
        'password' => env('DB_PASSWORD', ''),
        // ... other config
    ],

    // Simba database (separate)
    'sqlsrv' => [
        'driver' => 'sqlsrv',
        'host' => env('DB_HOST_SIMBA', '127.0.0.1'),
        'port' => env('DB_PORT_SIMBA', '1433'),
        'database' => env('DB_DATABASE_SIMBA', 'simba_db'),
        'username' => env('DB_USERNAME_SIMBA', 'username'),
        'password' => env('DB_PASSWORD_SIMBA', 'password'),
        'charset' => 'utf8',
        'prefix' => '',
        'prefix_indexes' => true,
        // Encrypt option (for SQL Server 2016+)
        'encrypt' => env('DB_ENCRYPT', 'yes'),
        'trust_server_certificate' => env('DB_TRUST_CERT', false),
    ],
],
```

### Option 2: Shared Connection

Nếu Simba và application dùng chung database:

```php
'connections' => [
    'sqlsrv' => [
        'driver' => 'sqlsrv',
        'host' => env('DB_HOST', '127.0.0.1'),
        'port' => env('DB_PORT', '1433'),
        'database' => env('DB_DATABASE', 'simba_db'),
        'username' => env('DB_USERNAME', 'username'),
        'password' => env('DB_PASSWORD', 'password'),
        'charset' => 'utf8',
        'prefix' => '',
        'prefix_indexes' => true,
    ],
],
```

---

## Config File

### Create config/simba.php

```php
<?php

return [
    /*
    |--------------------------------------------------------------------------
    | Simba Database Connection
    |--------------------------------------------------------------------------
    |
    | Specify which database connection to use for Simba models.
    | Default is 'sqlsrv' but you can use any connection name.
    |
    */
    
    'connection' => env('SIMBA_CONNECTION', 'sqlsrv'),
    
    /*
    |--------------------------------------------------------------------------
    | Default Company Code
    |--------------------------------------------------------------------------
    |
    | Default company code used for filtering data.
    | This is used in the global scope on all Simba models.
    |
    */
    
    'default_company' => env('SIMBA_DEFAULT_COMPANY', '001'),
    
    /*
    |--------------------------------------------------------------------------
    | Charset Handling
    |--------------------------------------------------------------------------
    |
    | Enable charset conversion for Vietnamese encoding.
    | Requires diepxuan/php-charset package.
    |
    */
    
    'charset_enabled' => env('SIMBA_CHARSET_ENABLED', true),
    'charset_from' => env('SIMBA_CHARSET_FROM', 'UTF-8'),
    'charset_to' => env('SIMBA_CHARSET_TO', 'UTF-8'),
    
    /*
    |--------------------------------------------------------------------------
    | Logging
    |--------------------------------------------------------------------------
    |
    | Enable query logging for debugging.
    | Recommended: false in production
    |
    */
    
    'log_queries' => env('SIMBA_LOG_QUERIES', false),
    'log_channel' => env('SIMBA_LOG_CHANNEL', 'daily'),
];
```

---

## Model Configuration

### Extending Simba Models

Package cung cấp 2 lớp models:

1. **SModel/** - Base models (auto-generated from database)
2. **Models/** - Extended models (can add custom logic)

#### Example: Custom Model with Scopes

```php
namespace App\Models\Simba;

use Diepxuan\Simba\Models\ArDmKh as BaseArDmKh;

class ArDmKh extends BaseArDmKh
{
    /**
     * Scope: Only active customers
     */
    public function scopeActive($query)
    {
        return $query->where('ksd', 0);
    }
    
    /**
     * Scope: By customer group
     */
    public function scopeByGroup($query, string $maNhKh)
    {
        return $query->where('ma_nh_kh', $maNhKh);
    }
    
    /**
     * Get customer with balance
     */
    public function getBalanceAttribute(): ?float
    {
        return \Diepxuan\Simba\StoredProcedures\AsGetSoDuKh::call([
            'pMa_Cty' => $this->ma_cty,
            'pMa_kh'  => $this->ma_kh,
            'pTk'     => '131',
            'pNgay'   => now()->format('Y-m-d'),
        ])->first()->Cong_no ?? 0;
    }
}
```

#### Usage in Application

```php
use App\Models\Simba\ArDmKh;

// Use custom scopes
$customers = ArDmKh::active()->byGroup('BAN_LE')->get();

// Access balance attribute
foreach ($customers as $customer) {
    echo "{$customer->ten_kh}: {$customer->balance} VND";
}
```

---

## Service Provider (Optional)

Tạo service provider để register Simba services:

**app/Providers/SimbaServiceProvider.php:**

```php
<?php

namespace App\Providers;

use Illuminate\Support\ServiceProvider;

class SimbaServiceProvider extends ServiceProvider
{
    /**
     * Register services.
     */
    public function register(): void
    {
        // Merge config
        $this->mergeConfigFrom(
            __DIR__ . '/../../vendor/diepxuan/laravel-simba/config/simba.php',
            'simba'
        );
    }
    
    /**
     * Bootstrap services.
     */
    public function boot(): void
    {
        // Publish config
        $this->publishes([
            __DIR__ . '/../../vendor/diepxuan/laravel-simba/config/simba.php'
                => config_path('simba.php'),
        ], 'simba-config');
        
        // Publish docs
        $this->publishes([
            __DIR__ . '/../../vendor/diepxuan/laravel-simba/docs'
                => base_path('docs/simba'),
        ], 'simba-docs');
    }
}
```

**config/app.php:**

```php
'providers' => [
    // ...
    App\Providers\SimbaServiceProvider::class,
],
```

---

## Troubleshooting

### Connection Issues

**Error:** `SQLSTATE[08001]: [SQL Server] SQL Server does not exist`

**Solutions:**

1. Check PHP SQL Server drivers:
```bash
php -m | grep sqlsrv
# Should show: sqlsrv, pdo_sqlsrv
```

2. Install drivers if missing:
```bash
# Ubuntu/Debian
sudo pecl install sqlsrv
sudo pecl install pdo_sqlsrv

# Add to php.ini
extension=sqlsrv.so
extension=pdo_sqlsrv.so
```

3. Verify connection string:
```bash
php artisan tinker
>>> DB::connection('sqlsrv')->getPdo();
```

### Charset Issues

**Error:** `Invalid character encoding`

**Solutions:**

1. Install charset package:
```bash
composer require diepxuan/php-charset
```

2. Enable in config:
```env
SIMBA_CHARSET_ENABLED=true
SIMBA_CHARSET_FROM=UTF-8
SIMBA_CHARSET_TO=UTF-8
```

### Permission Issues

**Error:** `Permission denied` or `User does not have permission`

**Solutions:**

1. Check database user permissions:
```sql
-- SQL Server
SELECT * FROM sys.database_permissions 
WHERE grantee_principal_id = USER_ID('your_username');
```

2. Ensure user has EXECUTE permission on stored procedures:
```sql
GRANT EXECUTE ON SCHEMA::dbo TO your_username;
```

3. Check Simba user rights in application:
```php
use Diepxuan\Simba\StoredProcedures\AsChkExecRight;

$hasRight = AsChkExecRight::call([
    'pMa_Cty'    => '001',
    'pMa_Chuc_nang'=> 'CA4',
    'pUser_Name' => auth()->user()->username,
    'pRight_Type'=> '1', // 1: Execute
]);
```

### Performance Issues

**Solutions:**

1. Enable query logging to identify slow queries:
```env
SIMBA_LOG_QUERIES=true
```

2. Check query log:
```php
DB::enableQueryLog();
// Execute queries
dd(DB::getQueryLog());
```

3. Add indexes on frequently queried columns:
```sql
CREATE INDEX IX_ARCT1_MA_KH ON ARCT1(ma_kh, ngay_ct);
CREATE INDEX IX_GLCT1_TK_NGAY ON GLCT1(tk, ngay_ct);
```

---

## Best Practices

1. **Use dedicated connection** for Simba database
2. **Enable charset handling** for Vietnamese data
3. **Configure logging** for debugging (disable in production)
4. **Use extended models** for custom business logic
5. **Test connection** before deployment

---

## Related Documentation

- [README.md](../README.md)
- [DATABASE_ACCESS_POLICY.md](../DATABASE_ACCESS_POLICY.md)
- [STORED_PROCEDURES/overview.md](./STORED_PROCEDURES/overview.md)

---

**Cập nhật lần cuối:** 2026-03-06
**Version:** 1.0

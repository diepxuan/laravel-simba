# Troubleshooting Guide

Hướng dẫn xử lý các vấn đề thường gặp khi sử dụng Laravel Simba.

---

## Mục lục

1. [Connection Issues](#connection-issues)
2. [Stored Procedure Errors](#stored-procedure-errors)
3. [Model Issues](#model-issues)
4. [Performance Issues](#performance-issues)
5. [Charset & Encoding](#charset--encoding)
6. [Common Error Codes](#common-error-codes)

---

## Connection Issues

### Error: SQLSTATE[08001] - SQL Server does not exist

**Symptoms:**
```
SQLSTATE[08001]: [SQL Server] SQL Server does not exist or access denied
```

**Causes:**
- SQL Server driver not installed
- Wrong connection string
- Network/firewall issues

**Solutions:**

1. **Check if SQL Server drivers are installed:**
```bash
php -m | grep sqlsrv
# Should show: sqlsrv, pdo_sqlsrv
```

2. **Install drivers if missing:**
```bash
# Ubuntu/Debian
sudo apt-get install unixodbc-dev
sudo pecl install sqlsrv
sudo pecl install pdo_sqlsrv

# Add to php.ini
extension=sqlsrv.so
extension=pdo_sqlsrv.so

# Restart PHP-FPM/Apache
sudo systemctl restart php8.1-fpm
```

3. **Verify connection string:**
```bash
php artisan tinker
>>> DB::connection('sqlsrv')->getPdo();
```

4. **Check network connectivity:**
```bash
telnet sql-server-host 1433
# Or
nc -zv sql-server-host 1433
```

---

### Error: Login failed for user

**Symptoms:**
```
SQLSTATE[28000]: [SQL Server] Login failed for user 'username'
```

**Solutions:**

1. **Verify credentials in .env:**
```env
DB_USERNAME_SIMBA=correct_username
DB_PASSWORD_SIMBA=correct_password
```

2. **Check user permissions in SQL Server:**
```sql
-- Check if user exists
SELECT name FROM sys.database_principals WHERE name = 'username';

-- Check permissions
SELECT * FROM sys.database_permissions 
WHERE grantee_principal_id = USER_ID('username');
```

3. **Grant necessary permissions:**
```sql
-- Grant execute on stored procedures
GRANT EXECUTE ON SCHEMA::dbo TO username;

-- Grant select on tables
GRANT SELECT ON SCHEMA::dbo TO username;
```

---

### Error: Database not found

**Symptoms:**
```
SQLSTATE[42000]: [SQL Server] Database 'simba_db' does not exist
```

**Solutions:**

1. **Verify database name:**
```env
DB_DATABASE_SIMBA=correct_database_name
```

2. **Check if database exists:**
```sql
SELECT name FROM sys.databases;
```

3. **Create database if needed:**
```sql
CREATE DATABASE simba_db;
```

---

## Stored Procedure Errors

### Error: Could not find stored procedure

**Symptoms:**
```
SQLSTATE[42000]: [SQL Server] Could not find stored procedure 'asGetSoCt'
```

**Solutions:**

1. **Verify procedure exists:**
```sql
SELECT name FROM sys.procedures 
WHERE name = 'asGetSoCt';
```

2. **Check schema:**
```sql
-- Procedures might be in different schema
SELECT name, schema_name(schema_id) FROM sys.procedures 
WHERE name = 'asGetSoCt';
```

3. **Deploy missing procedures:**
```bash
# Run Simba deployment script
sqlcmd -S server -d simba_db -i deploy_database.sql
```

---

### Error: Parameter count mismatch

**Symptoms:**
```
SQLSTATE[42000]: [SQL Server] Procedure or function 'asCAInsPH2' expects parameter '@pMa_cty', which was not supplied
```

**Solutions:**

1. **Check required parameters:**
```php
// Missing required parameter
AsCAInsPH2::call([
    'pStt_rec' => 'CA420240306001',
    // Missing 'pMa_cty'
]);

// Fix: Add all required parameters
AsCAInsPH2::call([
    'pMa_cty'  => '001',
    'pStt_rec' => 'CA420240306001',
    // ... other params
]);
```

2. **Check parameter names (case-sensitive in some cases):**
```php
// Wrong
AsCAInsPH2::call(['pMA_CTY' => '001']);

// Correct
AsCAInsPH2::call(['pMa_cty' => '001']);
```

---

### Error: OUTPUT parameter not working

**Symptoms:**
```php
$result = AsChkUserLogin::call([
    'pUserName' => 'admin',
    'pRet'      => ['type' => 'INT', 'output' => true],
]);
// $result->first()->Ret is null
```

**Solutions:**

1. **Ensure correct syntax for OUTPUT parameters:**
```php
$result = ProcedureCaller::call('asChkUserLogin', [
    'pUserName' => 'admin',
    'pPassword' => 'password',
    'pRet'      => ['type' => 'INT', 'output' => true],
]);

// Access output value
$row = $result->first();
$ret = $row->Ret ?? null;
```

2. **Check procedure definition:**
```sql
-- Verify OUTPUT parameter exists
EXEC sp_help 'asChkUserLogin';
```

---

## Model Issues

### Error: Table doesn't exist

**Symptoms:**
```
SQLSTATE[42S02]: [SQL Server] Invalid object name 'ARDMKH'
```

**Solutions:**

1. **Check table name in model:**
```php
class ArDmKh extends SModel
{
    protected $table = 'ARDMKH'; // Verify this matches database
}
```

2. **Verify table exists:**
```sql
SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_NAME = 'ARDMKH';
```

3. **Check schema:**
```sql
-- Table might be in different schema
SELECT TABLE_SCHEMA, TABLE_NAME FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_NAME = 'ARDMKH';
```

---

### Error: Column not found

**Symptoms:**
```
SQLSTATE[42S22]: [SQL Server] Invalid column name 'ma_kh'
```

**Solutions:**

1. **Check column names:**
```sql
SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'ARDMKH';
```

2. **Verify model fillable:**
```php
class ArDmKh extends SModel
{
    protected $fillable = ['ma_kh', 'ten_kh', /* ... */];
}
```

---

### Error: Composite key issues

**Symptoms:**
```
Primary key must be an array for composite keys
```

**Solutions:**

1. **Install eloquent-composite package:**
```bash
composer require diepxuan/laravel-eloquent-composite
```

2. **Use array for find:**
```php
// Wrong for composite key
$model = Model::find('key1');

// Correct
$model = Model::find(['key1', 'key2']);
```

---

## Performance Issues

### Slow queries

**Symptoms:**
- Queries taking > 1 second
- Timeout errors

**Solutions:**

1. **Enable query logging:**
```env
SIMBA_LOG_QUERIES=true
```

2. **Check slow queries:**
```php
DB::enableQueryLog();
// Execute operations
dd(DB::getQueryLog());
```

3. **Add indexes:**
```sql
-- Common indexes for Simba tables
CREATE INDEX IX_ARCT1_MA_KH_NGAY ON ARCT1(ma_kh, ngay_ct);
CREATE INDEX IX_GLCT1_TK_NGAY ON GLCT1(tk, ngay_ct);
CREATE INDEX IX_INCT3_MA_VT_NGAY ON INCT3(ma_vt, ngay_ct);
```

4. **Use eager loading:**
```php
// Bad: N+1 query
$invoices = ArPh1::all();
foreach ($invoices as $invoice) {
    echo $invoice->customer->ten_kh; // Query per invoice
}

// Good: Eager loading
$invoices = ArPh1::with('customer')->get();
```

---

### Memory issues

**Symptoms:**
```
PHP Fatal error: Allowed memory size exhausted
```

**Solutions:**

1. **Use chunking for large datasets:**
```php
// Bad: Load all
$records = GlCt::all();

// Good: Chunk
GlCt::chunk(1000, function ($records) {
    foreach ($records as $record) {
        // Process
    }
});
```

2. **Increase PHP memory limit:**
```env
# .env or php.ini
memory_limit=512M
```

---

## Charset & Encoding

### Error: Invalid character encoding

**Symptoms:**
- Vietnamese text showing as `???` or garbled
- Encoding errors

**Solutions:**

1. **Install charset package:**
```bash
composer require diepxuan/php-charset
```

2. **Configure charset:**
```env
SIMBA_CHARSET_ENABLED=true
SIMBA_CHARSET_FROM=UTF-8
SIMBA_CHARSET_TO=UTF-8
```

3. **Manual conversion if needed:**
```php
use Diepxuan\PhpCharset\Charset;

$charset = new Charset();
$text = $charset->convert($vietnameseText, 'UTF-8', 'UTF-8');
```

4. **Check database collation:**
```sql
-- Check database collation
SELECT DATABASEPROPERTYEX('simba_db', 'Collation');

-- Should be: SQL_Latin1_General_CP1_CI_AS or similar
```

---

## Common Error Codes

### Stored Procedure Return Codes

| Code | Meaning | Solution |
|------|---------|----------|
| `0` | Success | No action needed |
| `-1` | Invalid company code | Check `pMa_cty` parameter |
| `-2` | Duplicate voucher number | Use `AsGetSoCt` to get unique number |
| `-3` | Invalid account | Verify chart of accounts |
| `-4` | Amount mismatch | Ensure debits = credits |
| `-5` | Missing required field | Check all required parameters |
| `-6` | Permission denied | Verify user rights |
| `-7` | Invalid date | Check date format (YYYY-MM-DD) |
| `-8` | Customer not found | Verify customer exists |
| `-9` | Material not found | Verify material exists |
| `-10` | Insufficient stock | Check inventory levels |

---

## Debugging Tips

### 1. Enable SQL Server Profiler

```sql
-- Enable query tracing
DBCC TRACEON(3604, 1204, -1);

-- Run your query
EXEC asCAInsPH2 ...

-- Check output
```

### 2. Use Laravel Debug Mode

```env
APP_DEBUG=true
LOG_LEVEL=debug
```

### 3. Log Stored Procedure Calls

```php
use Illuminate\Support\Facades\Log;

Log::info('Calling SP', [
    'name' => 'asCAInsPH2',
    'params' => $params,
]);

try {
    $result = AsCAInsPH2::call($params);
    Log::info('SP Result', ['result' => $result]);
} catch (\Exception $e) {
    Log::error('SP Error', [
        'message' => $e->getMessage(),
        'trace'   => $e->getTraceAsString(),
    ]);
    throw $e;
}
```

### 4. Test Connection

```php
// In tinker or route
Route::get('/test-simba-connection', function () {
    try {
        $pdo = DB::connection('sqlsrv')->getPdo();
        $version = DB::connection('sqlsrv')->selectOne('SELECT @@VERSION as version');
        
        return response()->json([
            'connected' => true,
            'version'   => $version->version,
        ]);
    } catch (\Exception $e) {
        return response()->json([
            'connected' => false,
            'error'     => $e->getMessage(),
        ], 500);
    }
});
```

---

## Getting Help

### Before Asking for Help

1. ✅ Check error logs
2. ✅ Verify connection string
3. ✅ Test stored procedure in SQL Server Management Studio
4. ✅ Check user permissions
5. ✅ Review documentation

### Provide When Asking for Help

- Error message (full stack trace)
- Code snippet causing the issue
- Database schema (relevant tables)
- Stored procedure definition
- What you've tried already

### Contact

- **Technical Lead**: Tran Ngoc Duc
- **Email**: ductn@diepxuan.com
- **Documentation**: `/diepxuan/laravel-simba/docs/`

---

**Cập nhật lần cuối:** 2026-03-06
**Version:** 1.0

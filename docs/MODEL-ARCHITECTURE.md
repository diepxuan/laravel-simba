# Model Architecture - Kiến trúc phân lớp Model

## Tổng quan

Dự án Portal sử dụng kiến trúc Model 3 lớp để phân chia trách nhiệm rõ ràng:

```
Diepxuan\Catalog\Models\<Model>
    extends Diepxuan\Simba\Models\<Model>
        extends Diepxuan\Simba\SModel\<Model>Model
```

## Phân lớp chi tiết

### Lớp 1: SModel (Simba Base Models)

**Vị trí:** `diepxuan/laravel-simba/src/SModel/`

**Trách nhiệm:**
- Định nghĩa cơ bản từ database schema
- Primary key, table name, fillable, casts
- Không có business logic

**Ví dụ:**
```php
// SModel/ArDmKhModel.php
class ArDmKhModel extends SModel
{
    protected $table = 'ArDmKh';
    protected $primaryKey = 'ma_kh';
    protected $fillable = ['ma_cty', 'ma_kh', 'ten_kh', ...];
    protected $casts = ['isKh' => 'boolean', ...];
}
```

---

### Lớp 2: Simba\Models (Business Logic Core)

**Vị trí:** `diepxuan/laravel-simba/src/Models/`

**Trách nhiệm:**
- ✅ **Scopes dùng chung** (filter, query helpers)
- ✅ **Relationships** cơ bản
- ✅ **Stored procedures** core (nếu có)
- ✅ Logic có thể tái sử dụng trong nhiều packages

**KHÔNG nên có:**
- ❌ Logic chỉ dành riêng cho Catalog
- ❌ UI-specific attributes
- ❌ Format hiển thị

**Ví dụ:**
```php
// Models/SoPh3.php
class SoPh3 extends Model
{
    // ✅ Scope dùng chung
    public function scopeFilterByNgayCt(Builder $query, ?string $fromDate, ?string $toDate): Builder
    {
        if (!empty($fromDate)) {
            $query->whereDate('ngay_ct', '>=', $fromDate);
        }
        if (!empty($toDate)) {
            $query->whereDate('ngay_ct', '<=', $toDate);
        }
        return $query;
    }

    // ✅ Scope dùng chung
    public function scopeFilterByMaKh(Builder $query, string $maKh): Builder
    {
        return $query->where('ma_kh', 'like', "{$maKh}%");
    }
}
```

---

### Lớp 3: Catalog\Models (Package-Specific Logic)

**Vị trí:** `diepxuan/laravel-catalog/src/Models/`

**Trách nhiệm:**
- ✅ **Stored procedure wrappers** với params format riêng
- ✅ **Attributes/Accessors** cho hiển thị UI
- ✅ **Business logic** chỉ dùng trong Catalog package
- ✅ **Format data** cho views/components

**KHÔNG nên có:**
- ❌ Scopes dùng chung (chuyển xuống Simba\Models)
- ❌ Logic có thể tái sử dụng ở package khác

**Ví dụ:**
```php
// Catalog/Models/SoPh3.php
class SoPh3 extends Model
{
    // ✅ Stored procedure wrapper với params format
    public static function getAsSoFilt3(array $params): array|Collection
    {
        $params = (object) $params;
        $result = parent::getAsSoFilt3([
            'ma_cty'   => $params->pMa_Cty,
            'ma_ct'    => $params->pMa_CT,
            'ngay_ct1' => $params->pNgay_Ct1,
            'ngay_ct2' => $params->pNgay_Ct2,
            'pMa_Kh'   => $params->pMa_Kh,
        ]);
        $result['phs'] = self::hydrate($result['phs']);
        return $result;
    }

    // ✅ Attribute cho hiển thị UI
    protected function ngayCt(): Attribute
    {
        return Attribute::get(
            static fn ($value, array $attributes) => $value
                ? Carbon::parse($value)->format('d/m/Y')
                : ' / / '
        );
    }
}
```

---

## Nguyên tắc phân chia (QUY TẮC VÀNG)

### ✅ Nên đưa vào Simba\Models

| Loại | Mô tả | Ví dụ |
|------|-------|-------|
| **Scopes filter** | Filter theo field cơ bản | `filterByNgayCt()`, `filterByMaCty()`, `filterByTk()` |
| **Scopes tìm kiếm** | Search helpers | `search()`, `findByCode()` |
| **Relationships** | Quan hệ với models khác | `khachHang()`, `kho()`, `vatTu()` |
| **Core stored procedures** | SP dùng trong nhiều nơi | `getAsSoFilt3()` (base version) |

### ✅ Nên đưa vào Catalog\Models

| Loại | Mô tả | Ví dụ |
|------|-------|-------|
| **SP wrappers** | Wrapper với params format | `getAsSoFilt3()` với `$params` object |
| **Attributes** | Format hiển thị UI | `ngayCt()`, `tenKh()`, `soTienFormat()` |
| **UI helpers** | Helpers cho views | `getStatusLabel()`, `getColorClass()` |
| **Package logic** | Logic chỉ dùng trong package | Validation rules, formatters |

---

## Flow ra quyết định

```
Có logic mới cho Model
         │
         ▼
┌─────────────────────────────────┐
│ Logic này có dùng ở nơi khác    │
│ ngoài Catalog package không?    │
└─────────────────────────────────┘
         │
    ┌────┴────┐
    │         │
   CÓ        KHÔNG
    │         │
    ▼         ▼
┌─────────┐ ┌──────────────────────┐
│ Simba   │ │ Catalog\Models       │
│ Models  │ │ - SP wrappers        │
│ - Scopes│ │ - Attributes         │
│ - Core  │ │ - Package logic      │
└─────────┘ └──────────────────────┘
```

---

## Ví dụ thực tế

### Trường hợp 1: Filter theo ngày

```php
// ✅ ĐÚNG: Simba\Models\SoPh3
public function scopeFilterByNgayCt(Builder $query, ?string $fromDate, ?string $toDate): Builder
{
    if (!empty($fromDate)) {
        $query->whereDate('ngay_ct', '>=', $fromDate);
    }
    if (!empty($toDate)) {
        $query->whereDate('ngay_ct', '<=', $toDate);
    }
    return $query;
}

// ❌ SAI: Catalog\Models\SoPh3 (không để scope ở đây)
```

### Trường hợp 2: Format ngày hiển thị

```php
// ✅ ĐÚNG: Catalog\Models\SoPh3
protected function ngayCt(): Attribute
{
    return Attribute::get(
        static fn ($value) => $value
            ? Carbon::parse($value)->format('d/m/Y')
            : ' / / '
    );
}

// ❌ SAI: Simba\Models\SoPh3 (không để format UI ở đây)
```

### Trường hợp 3: Stored procedure

```php
// ✅ ĐÚNG: Simba\Models\SoPh3 (base)
public static function getAsSoFilt3(array $params): array|Collection
{
    // Execute stored procedure
    // Return raw results
}

// ✅ ĐÚNG: Catalog\Models\SoPh3 (wrapper)
public static function getAsSoFilt3(array $params): array|Collection
{
    $params = (object) $params;
    $result = parent::getAsSoFilt3([
        'ma_cty'   => $params->pMa_Cty,  // Transform params
        'ma_ct'    => $params->pMa_CT,
        'ngay_ct1' => $params->pNgay_Ct1,
        'ngay_ct2' => $params->pNgay_Ct2,
    ]);
    $result['phs'] = self::hydrate($result['phs']);  // Add UI logic
    return $result;
}
```

---

## Checklist khi tạo Model mới

### Bước 1: Kiểm tra SModel
- [ ] Đã tồn tại trong `SModel/` chưa?
- [ ] Nếu chưa → Tạo `SModel\<Model>Model.php`

### Bước 2: Tạo Simba\Models
- [ ] Tạo `Simba\Models\<Model>.php`
- [ ] Extend từ `SModel\<Model>Model`
- [ ] Thêm scopes dùng chung (nếu cần)
- [ ] Thêm relationships (nếu cần)

### Bước 3: Tạo Catalog\Models
- [ ] Tạo `Catalog\Models\<Model>.php`
- [ ] Extend từ `Simba\Models\<Model>`
- [ ] Thêm stored procedure wrappers
- [ ] Thêm attributes cho UI
- [ ] Thêm package-specific logic

---

## Anti-patterns (CẦN TRÁNH)

### ❌ Anti-pattern 1: Scope trong Catalog
```php
// Catalog\Models\SoPh3
public function scopeFilterByNgayCt(...) // ❌ SAI
```
→ **Fix:** Chuyển xuống `Simba\Models\SoPh3`

### ❌ Anti-pattern 2: Format UI trong Simba
```php
// Simba\Models\SoPh3
protected function ngayCt(): Attribute // ❌ SAI
{
    return Attribute::get(fn() => 'd/m/Y format');
}
```
→ **Fix:** Chuyển lên `Catalog\Models\SoPh3`

### ❌ Anti-pattern 3: Skip lớp giữa
```php
// Catalog\Models\SiDmBp
extends SModel\SiDmBpModel // ❌ SAI (skip Simba\Models)
```
→ **Fix:** Tạo `Simba\Models\SiDmBp` làm lớp giữa

### ❌ Anti-pattern 4: Business logic trong SModel
```php
// SModel\ArDmKhModel
public function scopeFilterByKhachHang() // ❌ SAI
```
→ **Fix:** Chuyển lên `Simba\Models\ArDmKh`

---

## Tham khảo

### Models mẫu
- `SoPh3` - 3 lớp đầy đủ
- `InDmKho` - 3 lớp đầy đủ
- `InDmVt` - 3 lớp đầy đủ
- `ArDmKh` - 3 lớp với scopes

### Files liên quan
- `docs/MODEL_ARCHITECTURE.md` (file này)
- `diepxuan/laravel-simba/src/Models/`
- `diepxuan/laravel-catalog/src/Models/`
- `diepxuan/laravel-simba/src/SModel/`

---

**Cập nhật:** 2026-03-11  
**Author:** Duc Tran  
**Review:** Bột (AI Assistant)

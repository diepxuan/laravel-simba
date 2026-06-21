<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 *
 * @lastupdate 2026-06-21
 */

namespace Diepxuan\Simba\Models\Concerns;

use Illuminate\Database\Eloquent\Builder;
use InvalidArgumentException;

/**
 * Trait hỗ trợ truy vấn/cập nhật theo composite primary key.
 *
 * Sử dụng trait này cho các Model kế thừa từ `SModel\*Model` mà SModel cha đã khai báo
 * `public const PRIMARY_KEY_COLUMNS = [...]` (xem quy tắc tại `laravel-simba/src/SModel/README.md`).
 *
 * Trait không thay đổi Eloquent `$primaryKey` của Model; chỉ bổ sung các scope/helper tiện ích
 * để thao tác đúng khóa nghiệp vụ của bảng Simba, đặc biệt với các bảng composite PK có `ma_cty`.
 *
 * Ví dụ:
 *
 *   class ArDmKh extends ArDmKhModel
 *   {
 *       use HasSimbaCompositeKey;
 *   }
 *
 *   ArDmKh::query()
 *       ->forCompany('001')
 *       ->forCompositeKey([
 *           'nam'    => 2026,
 *           'tk'     => '131',
 *           'ma_nt'  => 'VND',
 *           'ma_kh'  => 'KH001',
 *       ])
 *       ->first();
 */
trait HasSimbaCompositeKey
{
    /**
     * Danh sách các cột của composite primary key.
     *
     * Trả về `PRIMARY_KEY_COLUMNS` của SModel cha. Nếu Model không khai báo constant này
     * thì trả về mảng rỗng để các helper khác an toàn skip.
     *
     * @return array<int, string>
     */
    public function getPrimaryKeyColumns(): array
    {
        $parentClass = get_parent_class($this);
        if ($parentClass === false || !defined("{$parentClass}::PRIMARY_KEY_COLUMNS")) {
            return [];
        }

        $columns = constant("{$parentClass}::PRIMARY_KEY_COLUMNS");

        return is_array($columns) ? array_values($columns) : [];
    }

    /**
     * Cột đại diện Eloquent primary key hiện đang dùng.
     *
     * Trả về giá trị `getKeyName()` của Eloquent. Dùng cho trường hợp Model đã set
     * `$primaryKey` là cột đại diện như `stt_rec`. Trả về `null` nếu Model không có
     * key đại diện (đang dùng `$primaryKey = null`).
     */
    public function getRepresentativeKeyName(): ?string
    {
        $key = $this->getKeyName();

        return is_string($key) && $key !== '' ? $key : null;
    }

    /**
     * Scope: lọc theo composite primary key.
     *
     * `$key` là mảng key => value chứa đủ các cột khóa. Hàm này bắt buộc payload
     * đủ `PRIMARY_KEY_COLUMNS` để tránh update/delete quá rộng trên bảng composite key.
     *
     * @param Builder $query
     * @param array<string, mixed> $key
     */
    public function scopeForCompositeKey(Builder $query, array $key): Builder
    {
        $this->assertCompositeKey($key);

        $columns = $this->getPrimaryKeyColumns();

        foreach ($columns as $column) {
            if (!array_key_exists($column, $key)) {
                continue;
            }
            $query->where($column, $key[$column]);
        }

        return $query;
    }

    /**
     * Scope: lọc theo mã công ty (`ma_cty`).
     *
     * Hoạt động nếu `ma_cty` nằm trong `PRIMARY_KEY_COLUMNS` của SModel cha.
     */
    public function scopeForCompany(Builder $query, string $maCty): Builder
    {
        if (in_array('ma_cty', $this->getPrimaryKeyColumns(), true)) {
            $query->where('ma_cty', $maCty);
        }

        return $query;
    }

    /**
     * Tìm một bản ghi theo composite primary key.
     *
     * @param array<string, mixed> $key
     */
    public static function findByCompositeKey(array $key): ?static
    {
        $instance = new static();

        return $instance->newQuery()
            ->forCompositeKey($key)
            ->first();
    }

    /**
     * Cập nhật các bản ghi theo composite primary key.
     *
     * Trả về số dòng bị ảnh hưởng.
     *
     * @param array<string, mixed> $key
     * @param array<string, mixed> $values
     */
    public static function updateByCompositeKey(array $key, array $values): int
    {
        $instance = new static();

        return $instance->newQuery()
            ->forCompositeKey($key)
            ->update($values);
    }

    /**
     * Xóa các bản ghi theo composite primary key.
     *
     * Trả về số dòng bị xóa.
     *
     * @param array<string, mixed> $key
     */
    public static function deleteByCompositeKey(array $key): int
    {
        $instance = new static();

        return (int) $instance->newQuery()
            ->forCompositeKey($key)
            ->delete();
    }

    /**
     * Trích composite key hiện tại của model dưới dạng mảng.
     *
     * Dùng để làm payload cho find/update/delete, hoặc để sinh chuỗi serialize cho UI/API.
     * Các cột chưa được fill sẽ không xuất hiện.
     *
     * @param array<string, mixed>|null $attributes Nếu truyền, dùng mảng này thay vì `$this->getAttributes()`
     *
     * @return array<string, mixed>
     */
    public function compositeKeyAttributes(?array $attributes = null): array
    {
        $columns = $this->getPrimaryKeyColumns();
        if ($columns === []) {
            return [];
        }

        $source = $attributes ?? $this->getAttributes();
        $out    = [];

        foreach ($columns as $column) {
            if (array_key_exists($column, $source)) {
                $out[$column] = $source[$column];
            }
        }

        return $out;
    }

    /**
     * Sinh chuỗi composite key theo delimiter `|`.
     *
     * Thường dùng làm key giả cho UI/API khi cần truyền định danh tổng hợp qua route/query.
     * Lưu ý: đây là chuỗi ứng dụng, không phải PK DB.
     */
    public function compositeKeyString(string $delimiter = '|'): string
    {
        $parts = $this->compositeKeyAttributes();

        return implode($delimiter, array_map(static fn ($v): string => (string) $v, $parts));
    }

    /**
     * Validate composite key payload đủ cột theo `PRIMARY_KEY_COLUMNS`.
     *
     * Ném `InvalidArgumentException` nếu thiếu cột bắt buộc.
     *
     * @param array<string, mixed> $key
     */
    public function assertCompositeKey(array $key): void
    {
        $required = $this->getPrimaryKeyColumns();
        if ($required === []) {
            return;
        }

        $missing = array_diff($required, array_keys($key));
        if ($missing !== []) {
            throw new InvalidArgumentException(
                'Composite key thiếu cột: ' . implode(', ', $missing)
            );
        }
    }
}
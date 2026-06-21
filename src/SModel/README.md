# Simba SModel layer

Thư mục này chứa các model raw/table schema của SimbaERP.

## Vai trò

`SModel` là lớp thấp nhất phản ánh trực tiếp cấu trúc bảng SQL Server của SimbaERP. Mỗi `*Model.php` tương ứng với một bảng vật lý trong Simba và chỉ nên giữ thông tin schema/kết nối cần thiết để Eloquent đọc/ghi đúng bảng.

## Được phép đặt tại đây

- Connection SQL Server / Simba connection.
- Tên bảng (`$table`).
- Primary key (`$primaryKey`).
- Key type, incrementing, timestamps.
- Fillable/guarded theo cột thật của bảng.
- Casts/date format thuần schema.
- Helper nền an toàn phục vụ kết nối hoặc metadata kỹ thuật chung.

## Không đặt tại đây

- Business logic.
- Query scope mang ý nghĩa nghiệp vụ.
- Accessor/mutator có domain meaning.
- Relation nghiệp vụ giữa các model.
- Stored procedure orchestration.
- Logic route/auth/session/request/UI.
- Logic phục vụ Portal/Catalog use-case.

## Quy tắc primary key

Laravel Eloquent core chỉ hỗ trợ một `$primaryKey`, trong khi nhiều bảng Simba dùng composite primary key có `ma_cty` làm company scope.

Quy tắc trong `SModel`:

- Không dùng `ma_cty` làm `$primaryKey` generic, trừ bảng danh sách công ty thật sự như `sysCompany`.
- Nếu bảng có composite primary key nhiều hơn 3 cột, đặt:

```php
protected $primaryKey = null;

public const PRIMARY_KEY_COLUMNS = [
    'ma_cty',
    // các cột khóa thật từ simba-docs/tables
];
```

- Nếu bảng có 2 hoặc 3 primary key, bỏ `ma_cty` khỏi lựa chọn key đại diện và chọn cột định danh hợp lý hơn, ưu tiên `stt_rec` nếu có.
- Vẫn khai báo `PRIMARY_KEY_COLUMNS` cho composite key để code biết đầy đủ khóa thật của bảng.
- Với bảng detail có `stt_rec`, `stt_rec0`, có thể dùng `stt_rec` làm key đại diện:

```php
protected $primaryKey = 'stt_rec';
```

nhưng không được dùng blind `$model->save()`, `$model->delete()` hoặc update chỉ dựa trên key đơn. Khi update/delete detail phải query đủ composite key:

```php
static::where('ma_cty', $maCty)
    ->where('stt_rec', $sttRec)
    ->where('stt_rec0', $sttRec0)
    ->update([...]);
```

- Với bảng có `$primaryKey = null`, chỉ dùng model như raw query/read schema hoặc thao tác bằng query builder đủ điều kiện khóa.

## Quy tắc cập nhật

- Không tự đặt tên bảng/cột/SP. Nguồn sự thật là `simba-docs/tables` và các tài liệu Simba readonly liên quan.
- Nếu cần thêm behavior cho một bảng Simba, không thêm vào `SModel`; tạo hoặc sửa model tương ứng trong `diepxuan/laravel-simba/src/Models` nếu đó là helper/query trực tiếp sát bảng.
- Nếu behavior đã mang ngữ cảnh Portal/Catalog, workflow, UI, chính sách nghiệp vụ, hoặc use-case cụ thể, chuyển sang package `diepxuan/laravel-catalog`.

## Tóm tắt

`SModel` = raw/generated DB schema only.

Mọi logic behavior không thuộc schema phải nằm ngoài thư mục này.

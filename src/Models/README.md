# Simba Models layer

Thư mục này chứa các model Eloquent cấp Simba được code sử dụng trực tiếp.

## Vai trò

Các model trong `Models` thường extend từ raw schema model ở `diepxuan/laravel-simba/src/SModel`.

Pattern chuẩn:

```php
use Diepxuan\Simba\SModel\ArDmKhModel as Model;

class ArDmKh extends Model
{
    // query helper / relation / accessor sát bảng Simba
}
```

`SModel` giữ schema bảng; `Models` bổ sung lớp query helper trực tiếp, relation thật, accessor/mutator đơn giản và scope sát dữ liệu Simba.

## Được phép đặt tại đây

- Scope query gắn trực tiếp với field thật của bảng Simba.
- Relation trực tiếp giữa các bảng Simba bằng key thật.
- Accessor/mutator chuẩn hóa dữ liệu đơn giản, không phụ thuộc Portal UI/use-case.
- Helper đọc dữ liệu/report ở mức table model khi không chứa workflow Catalog.
- Alias/domain mỏng cho model Simba nếu vẫn thuần dữ liệu Simba.

## Không đặt tại đây

- Logic nghiệp vụ Portal/Catalog.
- Logic UI, route, request/session/auth, Livewire/view.
- Chính sách use-case như quyền thao tác, workflow màn hình, validation form, save/delete flow.
- Mapping phục vụ navigation/menu Portal.
- Business orchestration hoặc service logic nên nằm ở package khác.

## Ranh giới với laravel-catalog

Mọi logic behavior mang ngữ cảnh Portal/Catalog phải chuyển sang package `diepxuan/laravel-catalog`.

Ví dụ nên nằm ở `laravel-catalog`:

- Helper phục vụ màn hình Portal hoặc Livewire component.
- Business rule create/edit/save/delete.
- Route/menu/navigation resolver.
- Policy/authorization theo Portal.
- Use-case service, orchestration, cache phục vụ Catalog.
- Computed helper không còn là thuộc tính trực tiếp của bảng Simba.

## Quy tắc cập nhật

- Không khai báo lại schema nếu SModel tương ứng đã có đủ `$table`, `$primaryKey`, `$fillable`, `$casts`.
- Khi cần thêm behavior, kiểm tra trước behavior đó có thuần Simba table/query không.
- Nếu behavior vượt khỏi phạm vi table/query helper trực tiếp, đặt trong `diepxuan/laravel-catalog` thay vì thêm vào đây.

## Tóm tắt

`Models` = model extend từ `SModel`, chứa query helper/relation/accessor sát bảng Simba.

Logic nghiệp vụ và behavior phục vụ Portal/Catalog phải sống trong `laravel-catalog`.

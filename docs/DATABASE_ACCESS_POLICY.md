# Laravel Simba - Database Access Policy

## Nguyên tắc truy cập cơ sở dữ liệu

### 1. Triết lý thiết kế

Laravel Simba là package **trung gian** xử lý tất cả các thao tác với cơ sở dữ liệu SQL Server. Package tuân thủ nguyên tắc bảo mật và phân quyền nghiêm ngặt:

> **CHỈ ĐỌC (READ-ONLY) - MỌI THAO TÁC GHI THÔNG QUA STORED PROCEDURES**

---

### 2. Quy tắc bất biến

#### ✅ ĐƯỢC PHÉP

| Thao tác | Mô tả | Ví dụ |
|----------|-------|-------|
| **SELECT** | Truy vấn dữ liệu đọc | `GlCt::where('ma_cty', $id)->get()` |
| **EXEC SP** | Gọi stored procedures | `AsCAInsPH2::call([...])` |
| **READ Models** | Đọc từ Eloquent Models | `ArDmKh::find($ma_kh)` |
| **Transaction** | Sử dụng transaction cho SP | `DB::transaction(fn() => ...)` |

#### ❌ NGHIÊM CẤM

| Thao tác | Lý do | Ghi chú |
|----------|-------|---------|
| **INSERT trực tiếp** | Vi phạm nguyên tắc SP | Không dùng `Model::create()` |
| **UPDATE trực tiếp** | Vi phạm nguyên tắc SP | Không dùng `Model::update()` |
| **DELETE trực tiếp** | Vi phạm nguyên tắc SP | Không dùng `Model::delete()` |
| **DB::table()->insert()** | Bypass SP | Không dùng query builder insert |
| **DB::statement('UPDATE...')** | Raw SQL nguy hiểm | Không chạy raw SQL modify |
| **Schema::create/modify** | Thay đổi cấu trúc DB | Không migrate từ application |

---

### 3. Kiến trúc phân lớp

```
┌─────────────────────────────────────────────────────────┐
│                   APPLICATION LAYER                      │
│  (Controllers, Livewire Components, Jobs, etc.)         │
└─────────────────────────────────────────────────────────┘
                            │
                            ▼
┌─────────────────────────────────────────────────────────┐
│                   SIMBA PACKAGE LAYER                    │
│  ┌─────────────────┐    ┌─────────────────────────────┐ │
│  │   READ Models   │    │   Stored Procedure Classes  │ │
│  │  (SELECT only)  │    │   (INSERT/UPDATE/DELETE)    │ │
│  └─────────────────┘    └─────────────────────────────┘ │
└─────────────────────────────────────────────────────────┘
                            │
                            ▼
┌─────────────────────────────────────────────────────────┐
│                  SQL SERVER DATABASE                     │
│  ┌──────────────┐  ┌──────────────┐  ┌───────────────┐ │
│  │    Tables    │  │    Views     │  │ Stored Procs  │ │
│  │  (READ ONLY) │  │  (READ ONLY) │  │  (WRITE ONLY) │ │
│  └──────────────┘  └──────────────┘  └───────────────┘ │
└─────────────────────────────────────────────────────────┘
```

---

### 4. Stored Procedures Categories

#### 4.1. Access Control (AC)
- `AsCAIns*` - Insert chứng từ
- `AsCAUpd*` - Update chứng từ
- `AsCADel*` - Delete chứng từ
- `AsChk*` - Kiểm tra ràng buộc

#### 4.2. General Ledger (GL)
- `AsGL*` - Nghiệp vụ sổ cái
- `AsGetSoDu*` - Lấy số dư
- `AsPost*` - Kết chuyển

#### 4.3. Accounts Receivable (AR)
- `AsAR*` - Nghiệp vụ phải thu
- `AsGetSoDuKh` - Số dư khách hàng

#### 4.4. System (SYS)
- `AsSys*` - Nghiệp vụ hệ thống
- `AsGetSoCt` - Lấy số chứng từ

---

### 5. Ví dụ minh họa

#### ✅ ĐÚNG: Sử dụng Stored Procedure

```php
use Diepxuan\Simba\StoredProcedures\AsCAInsPH2;
use Diepxuan\Simba\StoredProcedures\AsCAInsCT2;
use Diepxuan\Simba\StoredProcedures\AsProcessCt;

// Tạo mới phiếu trong transaction
\DB::transaction(function () use ($data) {
    // 1. Lấy stt_rec
    $stt_rec = AsGetSttRec::call(['pMa_cty' => $maCty, 'pMa_Ct' => 'CA4']);
    
    // 2. Insert Header qua SP
    AsCAInsPH2::call([
        'pMa_cty'     => $maCty,
        'pStt_rec'    => $stt_rec,
        'pMa_ct'      => 'CA4',
        'pSo_ct'      => $data['so_ct'],
        // ... parameters
    ]);
    
    // 3. Insert Details qua SP
    foreach ($data['details'] as $detail) {
        AsCAInsCT2::call([
            'pMa_cty'   => $maCty,
            'pStt_rec'  => $stt_rec,
            'pTk'       => $detail['tk'],
            'pPs_no'    => $detail['ps_no'],
            // ...
        ]);
    }
    
    // 4. Process chứng từ
    AsProcessCt::call([
        'pMa_cty'  => $maCty,
        'pMa_Ct'   => 'CA4',
        'pStt_rec' => $stt_rec,
        'pMode'    => '1',
    ]);
});
```

#### ❌ SAI: Thao tác trực tiếp trên table

```php
// ❌ TUYỆT ĐỐI KHÔNG LÀM
CaPh3::create([
    'ma_cty'   => $maCty,
    'stt_rec'  => $stt_rec,
    'ma_ct'    => 'CA4',
    'so_ct'    => $data['so_ct'],
    // ...
]);

// ❌ TUYỆT ĐỐI KHÔNG LÀM
\DB::table('CA_PH3')->insert([
    'ma_cty'   => $maCty,
    'stt_rec'  => $stt_rec,
    // ...
]);

// ❌ TUYỆT ĐỐI KHÔNG LÀM
CaPh3::where('stt_rec', $stt_rec)->update([
    'so_ct' => $newSoCt,
]);

// ❌ TUYỆT ĐỐI KHÔNG LÀM
CaCt3::where('stt_rec', $stt_rec)->delete();
```

#### ✅ ĐÚNG: Đọc dữ liệu (READ)

```php
// ✅ OK: Đọc qua Eloquent Model
$phieu = CaPh3::where('stt_rec', $stt_rec)->first();
$details = CaCt3::where('stt_rec', $stt_rec)->get();

// ✅ OK: Đọc qua Query Builder
$records = \DB::table('CA_PH3')
    ->where('ma_cty', $maCty)
    ->where('ngay_ct', '>=', $ngayTu)
    ->get();

// ✅ OK: Đọc qua Simba Models
$khachHang = ArDmKh::where('ma_kh', $maKh)->first();
$soDu = AsGetSoDuKh::call([
    'pMa_Cty' => $maCty,
    'pMa_kh'  => $maKh,
    'pTk'     => $tk,
    'pNgay'   => $ngay,
]);
```

---

### 6. Lý do thiết kế

#### 6.1. Bảo mật
- ✅ Logic nghiệp vụ tập trung trong SP
- ✅ Phân quyền chi tiết ở database level
- ✅ Audit trail tự động qua SP logs
- ✅ Chống SQL injection

#### 6.2. Nhất quán dữ liệu
- ✅ Validation ở nhiều lớp (app + DB)
- ✅ Business rules enforced ở DB level
- ✅ Transaction integrity đảm bảo

#### 6.3. Bảo trì
- ✅ Thay đổi logic không cần deploy app
- ✅ Performance tuning ở DB level
- ✅ Dễ dàng audit và debug

#### 6.4. Performance
- ✅ SP được cache execution plan
- ✅ Giảm network traffic (batch operations)
- ✅ Optimized queries từ DBA

---

### 7. Checklist code review

Khi review code liên quan đến database, kiểm tra:

- [ ] Không có `Model::create()`, `Model::update()`, `Model::delete()`
- [ ] Không có `DB::table()->insert()`, `->update()`, `->delete()`
- [ ] Không có raw SQL `INSERT`, `UPDATE`, `DELETE`
- [ ] Tất cả thao tác ghi đều qua Stored Procedures
- [ ] Có sử dụng transaction cho multi-step operations
- [ ] Error handling đầy đủ (try-catch)
- [ ] Logging appropriate (không log sensitive data)
- [ ] READ operations có thể dùng Eloquent/Query Builder

---

### 8. External Database Modifications

#### ⚠️ CẢNH BÁO

**KHÔNG BAO GIỜ:**
- Gợi ý chỉnh sửa database trực tiếp
- Chạy migration từ application
- Sử dụng Schema Builder để tạo/sửa table
- Chạy raw DDL statements (`CREATE`, `ALTER`, `DROP`)

**MỌI THAY ĐỔI CẤU TRÚC DATABASE:**
- Phải thực hiện bởi DBA
- Qua script SQL được review
- Deploy độc lập với application
- Có rollback plan

---

### 9. Tài liệu liên quan

- [Stored Procedures Danh sách đầy đủ](./procedures-system.md)
- [Hướng dẫn sử dụng Stored Procedures](./PROCEDURES_OPTIMIZED.md)
- [FAQ - Câu hỏi thường gặp](./procedures-fa.md)

---

### 10. Liên hệ

Khi có thắc mắc về database access policy:

- **Technical Lead**: Tran Ngoc Duc
- **Email**: ductn@diepxuan.com
- **Documentation**: `/diepxuan/laravel-simba/docs/`

---

**Cập nhật lần cuối:** 2026-03-03
**Version:** 1.0

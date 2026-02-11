# Nhóm Stored Procedures asPost* (Posting)

Danh sách các stored procedure thuộc nhóm asPost* (Posting) đã được chuyển đổi thành class PHP.

## Tổng quan

Nhóm asPost* gồm các procedure thực hiện chức năng posting (đưa dữ liệu lên sổ cái, sổ chi tiết) và unposting (xóa bút toán). Các procedure này thường được gọi từ quy trình xử lý chứng từ để cập nhật sổ sách kế toán.

## Danh sách các procedure đã chuyển đổi

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asPost2GL | `AsPost2GL` | `@pMa_Cty` (string), `@pStt_rec` (string), `@pMa_ct` (string), `@pPostUnpost` (string) | Post hoặc Unpost một chứng từ cụ thể vào Sổ Cái (GLCT). |
| asPostApPh3_apTt | `AsPostApPh3ApTt` | `@pMa_cty` (string), `@pStt_rec` (string) | Post dữ liệu từ chứng thanh toán công nợ phải trả (ApPh3) và chi tiết thanh toán (ApCt3) vào bảng apTt (bảng thanh toán). |
| asPostApPh3_glct | `AsPostApPh3Glct` | `@pMa_cty` (string), `@pStt_rec` (string) | Post chi tiết thanh toán công nợ phải trả (ApPh3) vào sổ cái (GLCT). |
| asPostApPh4_glct | `AsPostApPh4Glct` | `@pma_cty` (string), `@pstt_rec` (string) | Post phiếu kế toán (ApPh4) vào sổ cái (GLCT), phân loại theo nhóm điều khoản (nh_dk). |
| asPostApPh4_glct_1c | `AsPostApPh4Glct1c` | `@pMa_cty` (string), `@pSTT_rec` (string), `@pNh_dk` (string) | Post phiếu kế toán cho một nhóm điều khoản, trường hợp 1 có nhiều nợ. |
| asPostApPh4_glct_1n | `AsPostApPh4Glct1n` | `@pMa_cty` (string), `@pSTT_rec` (string), `@pNh_dk` (string) | Post phiếu kế toán cho một nhóm điều khoản, trường hợp 1 nợ nhiều có. |
| asPostArPh3_arTt | `AsPostArPh3ArTt` | `@pMa_cty` (string), `@pStt_rec` (string) | Post dữ liệu từ chứng thanh toán công nợ phải thu (ArPh3) và chi tiết thanh toán (ArCt3) vào bảng arTt (bảng thanh toán công nợ phải thu). |
| asPostArPh3_glct | `AsPostArPh3Glct` | `@pMa_cty` (string), `@pStt_rec` (string) | Post chi tiết thanh toán công nợ phải thu (ArPh3) vào sổ cái (GLCT). |
| asPostArPh4_glct | `AsPostArPh4Glct` | `@pma_cty` (string), `@pstt_rec` (string) | Post phiếu kế toán (ArPh4) vào sổ cái (GLCT), phân loại theo nhóm điều khoản (nh_dk). |
| asPostCAPh2_CaTtHu | `AsPostCAPh2CaTtHu` | `@pMa_cty` (string), `@pStt_rec` (string) | Post phiếu chi (CaPh2) vào bảng cân đối phiếu chi (catthu). |

## Chi tiết từng procedure

### asPost2GL
- **Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsPost2GL`
- **Mục đích**: Post hoặc Unpost một chứng từ vào sổ cái.
- **Tham số**:
  - `pMa_Cty` (string, bắt buộc): Mã công ty (nvarchar(3)).
  - `pStt_rec` (string, bắt buộc): Số chứng từ (stt_rec) (nvarchar(20)).
  - `pMa_ct` (string, bắt buộc): Mã chứng từ (nvarchar(3)).
  - `pPostUnpost` (string, tùy chọn, mặc định '1'): '1' để post, '0' để unpost.
- **Ví dụ**:
  ```php
  // Post chứng từ
  AsPost2GL::call([
      'pMa_Cty' => '001',
      'pStt_rec' => 'SO202500001',
      'pMa_ct' => 'SO1',
      'pPostUnpost' => '1',
  ]);
  // Unpost
  AsPost2GL::call(['pPostUnpost' => '0', ...]);
  ```

### asPostApPh3_apTt
- **Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsPostApPh3ApTt`
- **Mục đích**: Post dữ liệu từ chứng thanh toán công nợ phải trả (ApPh3) và chi tiết thanh toán (ApCt3) vào bảng apTt (bảng thanh toán).
- **Tham số**:
  - `pMa_cty` (string, bắt buộc): Mã công ty (nvarchar(3)).
  - `pStt_rec` (string, bắt buộc): Số chứng từ (stt_rec) (nvarchar(20)).
- **Ví dụ**:
  ```php
  // Post chứng từ thanh toán công nợ phải trả
  AsPostApPh3ApTt::call([
      'pMa_cty' => '001',
      'pStt_rec' => 'AP202500001',
  ]);
  ```
- **Lưu ý**: Procedure sẽ không thực hiện nếu ngày chứng từ nằm trong kỳ đã khóa sổ (so với ngày khóa sổ trong siSetup).

### asPostApPh3_glct
- **Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsPostApPh3Glct`
- **Mục đích**: Post chi tiết thanh toán công nợ phải trả (ApPh3) vào sổ cái (GLCT).
- **Tham số**:
  - `pMa_cty` (string, bắt buộc): Mã công ty (nvarchar(3)).
  - `pStt_rec` (string, bắt buộc): Số chứng từ (stt_rec) (nvarchar(20)).
- **Ví dụ**:
  ```php
  // Post chứng từ thanh toán công nợ phải trả vào sổ cái
  AsPostApPh3Glct::call([
      'pMa_cty' => '001',
      'pStt_rec' => 'AP202500001',
  ]);
  ```
- **Lưu ý**: Procedure sẽ không thực hiện nếu ngày chứng từ đã khóa sổ. Ngoài ra, procedure sẽ tạo các bút toán đối ứng trên sổ cái (bên Nợ và bên Có) dựa trên chi tiết thanh toán.

### asPostApPh4_glct
- **Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsPostApPh4Glct`
- **Mục đích**: Post phiếu kế toán (ApPh4) vào sổ cái (GLCT).
- **Tham số**:
  - `pma_cty` (string, bắt buộc): Mã công ty (nvarchar(3)).
  - `pstt_rec` (string, bắt buộc): Số chứng từ (stt_rec) (nvarchar(20)).
- **Ví dụ**:
  ```php
  // Post phiếu kế toán vào sổ cái
  AsPostApPh4Glct::call([
      'pma_cty' => '001',
      'pstt_rec' => 'PK202500001',
  ]);
  ```
- **Lưu ý**: Procedure sẽ không thực hiện nếu ngày chứng từ đã khóa sổ. Procedure sử dụng cursor để duyệt qua các nhóm điều khoản (nh_dk) và gọi các procedure con tương ứng (asPostApPh4_glct_1n, asPostApPh4_glct_1c) để xử lý từng nhóm.

### asPostApPh4_glct_1c
- **Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsPostApPh4Glct1c`
- **Mục đích**: Post phiếu kế toán cho một nhóm điều khoản (nh_dk) cụ thể, trường hợp "1 có nhiều nợ" – tức là có một dòng chi tiết có ps_co <> 0 (bên Có) và nhiều dòng có ps_no <> 0 (bên Nợ).
- **Tham số**:
  - `pMa_cty` (string, bắt buộc): Mã công ty (nvarchar(3)).
  - `pSTT_rec` (string, bắt buộc): Số chứng từ (stt_rec) (nvarchar(20)).
  - `pNh_dk` (string, bắt buộc): Nhóm điều khoản (nh_dk) cần post (nvarchar(3)).
- **Ví dụ**:
  ```php
  // Post nhóm điều khoản 001 của phiếu kế toán PK202500001, trường hợp 1 có nhiều nợ
  AsPostApPh4Glct1c::call([
      'pMa_cty' => '001',
      'pSTT_rec' => 'PK202500001',
      'pNh_dk' => '001',
  ]);
  ```
- **Lưu ý**: Procedure chỉ hoạt động khi ngày chứng từ chưa bị khóa sổ. Procedure tính toán tiền ngoại tệ dựa trên mã ngoại tệ gốc của công ty.

### asPostApPh4_glct_1n
- **Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsPostApPh4Glct1n`
- **Mục đích**: Post phiếu kế toán cho một nhóm điều khoản (nh_dk) cụ thể, trường hợp "1 nợ nhiều có" – tức là có một dòng chi tiết có ps_no <> 0 (bên Nợ) và nhiều dòng có ps_co <> 0 (bên Có).
- **Tham số**:
  - `pMa_cty` (string, bắt buộc): Mã công ty (nvarchar(3)).
  - `pSTT_rec` (string, bắt buộc): Số chứng từ (stt_rec) (nvarchar(20)).
  - `pNh_dk` (string, bắt buộc): Nhóm điều khoản (nh_dk) cần post (nvarchar(3)).
- **Ví dụ**:
  ```php
  // Post nhóm điều khoản 001 của phiếu kế toán PK202500001, trường hợp 1 nợ nhiều có
  AsPostApPh4Glct1n::call([
      'pMa_cty' => '001',
      'pSTT_rec' => 'PK202500001',
      'pNh_dk' => '001',
  ]);
  ```
- **Lưu ý**: Procedure chỉ hoạt động khi ngày chứng từ chưa bị khóa sổ. Procedure tính toán tiền ngoại tệ dựa trên mã ngoại tệ gốc của công ty.

### asPostArPh3_arTt
- **Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsPostArPh3ArTt`
- **Mục đích**: Post dữ liệu từ chứng thanh toán công nợ phải thu (ArPh3) và chi tiết thanh toán (ArCt3) vào bảng arTt (bảng thanh toán công nợ phải thu).
- **Tham số**:
  - `pMa_cty` (string, bắt buộc): Mã công ty (nvarchar(3)).
  - `pStt_rec` (string, bắt buộc): Số chứng từ (stt_rec) (nvarchar(20)).
- **Ví dụ**:
  ```php
  // Post chứng từ thanh toán công nợ phải thu
  AsPostArPh3ArTt::call([
      'pMa_cty' => '001',
      'pStt_rec' => 'AR202500001',
  ]);
  ```
- **Lưu ý**: Procedure chỉ hoạt động khi ngày chứng từ chưa bị khóa sổ. Procedure tính năm tài chính, tháng tài chính thông qua hàm afNamTC, afThangTC.

### asPostArPh3_glct
- **Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsPostArPh3Glct`
- **Mục đích**: Post chi tiết thanh toán công nợ phải thu (ArPh3) vào sổ cái (GLCT).
- **Tham số**:
  - `pMa_cty` (string, bắt buộc): Mã công ty (nvarchar(3)).
  - `pStt_rec` (string, bắt buộc): Số chứng từ (stt_rec) (nvarchar(20)).
- **Ví dụ**:
  ```php
  // Post chứng từ thanh toán công nợ phải thu vào sổ cái
  AsPostArPh3Glct::call([
      'pMa_cty' => '001',
      'pStt_rec' => 'AR202500001',
  ]);
  ```
- **Lưu ý**: Procedure chỉ hoạt động khi ngày chứng từ chưa bị khóa sổ. Procedure tạo các bút toán đối ứng trên sổ cái dựa trên chi tiết thanh toán.

### asPostArPh4_glct
- **Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsPostArPh4Glct`
- **Mục đích**: Post phiếu kế toán (ArPh4) vào sổ cái (GLCT).
- **Tham số**:
  - `pma_cty` (string, bắt buộc): Mã công ty (nvarchar(3)).
  - `pstt_rec` (string, bắt buộc): Số chứng từ (stt_rec) (nvarchar(20)).
- **Ví dụ**:
  ```php
  // Post phiếu kế toán vào sổ cái
  AsPostArPh4Glct::call([
      'pma_cty' => '001',
      'pstt_rec' => 'PK202500001',
  ]);
  ```
- **Lưu ý**: Procedure chỉ hoạt động khi ngày chứng từ chưa bị khóa sổ. Procedure sử dụng cursor để duyệt qua các nhóm điều khoản (nh_dk) và gọi các procedure con tương ứng (asPostArPh4_glct_1n, asPostArPh4_glct_1c) để xử lý từng nhóm.

### asPostCAPh2_CaTtHu
- **Class**: `Diepxuan\LaravelSimba\StoredProcedures\AsPostCAPh2CaTtHu`
- **Mục đích**: Post phiếu chi (CaPh2) vào bảng cân đối phiếu chi (catthu).
- **Tham số**:
  - `pMa_cty` (string, bắt buộc): Mã công ty (nvarchar(3)).
  - `pStt_rec` (string, bắt buộc): Số chứng từ (stt_rec) (nvarchar(20)).
- **Ví dụ**:
  ```php
  // Post phiếu chi vào cân đối phiếu chi
  AsPostCAPh2CaTtHu::call([
      'pMa_cty' => '001',
      'pStt_rec' => 'PC202500001',
  ]);
  ```
- **Lưu ý**: Procedure chỉ hoạt động khi ngày chứng từ chưa bị khóa sổ. Procedure tính năm tài chính, tháng tài chính và gọi procedure con asCARecalCA2 để cập nhật số dư phiếu chi.

---

*Tài liệu này sẽ được cập nhật liên tục khi có thêm procedure được chuyển đổi.*
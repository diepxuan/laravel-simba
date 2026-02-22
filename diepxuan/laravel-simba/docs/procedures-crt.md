# Nhóm Stored Procedures Create (asCrt*)

Nhóm các stored procedure thực hiện chức năng tạo bút toán, chứng từ, kết chuyển, đánh giá tỷ giá.

## Danh sách procedures đã chuyển đổi

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asGlCtgsCrtNumOfVoucher | `AsGlCtgsCrtNumOfVoucher` | `pMa_cty`, `pMa_ct`, `pTk`, `pTen_ct_gs`, `pSo_hieu`, `pNgay_lo`, `pNgay1` | Tạo chứng từ ghi sổ (sổ cái) cho các bút toán trong khoảng thời gian, theo tài khoản hoặc mã chứng từ. |
| asGLCrtDGTG | `AsGLCrtDGTG` | `pma_cty`, `pma_ct`, `pma_nt`, `pstt`, `pngay1`, `pngay2`, `puser`, `pRet` (output) | Tạo bút toán đánh giá tỷ giá (đánh giá lại chênh lệch tỷ giá) cho các tài khoản ngoại tệ trong khoảng thời gian. |
| asGLCrtDGTG1 | `AsGLCrtDGTG1` | `pma_cty`, `pstt`, `pma_nt`, `tk_dgtg`, `tk_lai_cltg`, `tk_lo_cltg`, `tk_cltg_cn`, `ten_bt`, `dg_kh`, `dg_bp`, `dg_hd`, `dg_spct`, `dg_phi`, `loai_dg`, `pngay1`, `pngay2`, `stt_rec`, `pma_ct`, `pso_ct`, `puser` | Thực hiện thao tác tạo bút toán đánh giá tỷ giá chi tiết dựa trên thông tin danh mục và khoảng thời gian. |
| asGLCrtKC | `AsGLCrtKC` | `pMa_cty`, `pMa_ct`, `pNgay1`, `pNgay2`, `pTk`, `pTk_du`, `pUser`, `pRet` (output) | Tạo bút toán kết chuyển tự động giữa hai tài khoản trong khoảng thời gian. |
| asGLCrtKC1 | `AsGLCrtKC1` | `pma_cty`, `pstt`, `ptk`, `ptk_du`, `pten_bt`, `pkc_bp`, `pkc_hd`, `pkc_spct`, `pkc_phi`, `ploai_kc`, `pkc_dt_ps`, `pngay1`, `pngay2`, `pstt_rec`, `pma_ct`, `pso_ct`, `puser` | Thực hiện thao tác tạo bút toán kết chuyển tự động chi tiết dựa trên thông tin danh mục và khoảng thời gian. |

## Chi tiết từng procedure

### asGlCtgsCrtNumOfVoucher

- **Mục đích**: Tạo chứng từ ghi sổ (sổ cái) cho các bút toán trong khoảng thời gian, theo tài khoản hoặc mã chứng từ.
- **Tham số**: 7 tham số đầu vào, không có output.
- **Logic chính**: Xóa chứng từ ghi sổ cũ, xác định số chứng từ tiếp theo, cập nhật ngày lô và số lô cho các bút toán thỏa điều kiện, chèn bản ghi vào bảng glctgs.
- **Sử dụng khi**: Cần đánh số chứng từ ghi sổ cho các bút toán đã hạch toán, thường vào cuối kỳ.

### asGLCrtDGTG

- **Mục đích**: Tạo bút toán đánh giá tỷ giá cho các tài khoản ngoại tệ trong khoảng thời gian.
- **Tham số**: 7 tham số đầu vào, 1 output parameter `pRet` (0 thành công, khác 0 lỗi).
- **Logic chính**: Lấy thông tin danh mục đánh giá tỷ giá, tạo số chứng từ, xóa bút toán cũ cùng kỳ, gọi `asGLCrtDGTG1` để tạo bút toán chi tiết.
- **Sử dụng khi**: Cần đánh giá lại chênh lệch tỷ giá cuối kỳ cho các tài khoản ngoại tệ.

### asGLCrtDGTG1

- **Mục đích**: Thực hiện thao tác tạo bút toán đánh giá tỷ giá chi tiết.
- **Tham số**: 20 tham số đầu vào, không có output.
- **Logic chính**: Tính số dư và phát sinh ngoại tệ, nhóm theo đối tượng (khách hàng, bộ phận, hợp đồng, sản phẩm công trình, phí), áp dụng loại đánh giá, tạo từng cặp bút toán đánh giá tỷ giá.
- **Sử dụng khi**: Được gọi bởi `asGLCrtDGTG`, không nên gọi trực tiếp.

### asGLCrtKC

- **Mục đích**: Tạo bút toán kết chuyển tự động giữa hai tài khoản trong khoảng thời gian.
- **Tham số**: 7 tham số đầu vào, 1 output parameter `pRet` (0 thành công, khác 0 lỗi).
- **Logic chính**: Lấy thông tin danh mục kết chuyển, tạo số chứng từ, xóa bút toán cũ cùng kỳ, gọi `asGLCrtKC1` để tạo bút toán chi tiết.
- **Sử dụng khi**: Cần kết chuyển doanh thu, chi phí, lãi lỗ cuối kỳ giữa các tài khoản.

### asGLCrtKC1

- **Mục đích**: Thực hiện thao tác tạo bút toán kết chuyển tự động chi tiết.
- **Tham số**: 17 tham số đầu vào, không có output.
- **Logic chính**: Tính phát sinh của tài khoản nguồn, nhóm theo đối tượng (bộ phận, hợp đồng, sản phẩm công trình, phí), áp dụng loại kết chuyển, tạo từng cặp bút toán kết chuyển.
- **Sử dụng khi**: Được gọi bởi `asGLCrtKC`, không nên gọi trực tiếp.

## Hướng dẫn sử dụng

Các class đều nằm trong namespace `Diepxuan\LaravelSimba\StoredProcedures`. Gọi static method `call()` với mảng tham số.

Ví dụ:
```php
use Diepxuan\LaravelSimba\StoredProcedures\AsGLCrtDGTG;

$result = AsGLCrtDGTG::call([
    'pma_cty' => '001',
    'pma_ct' => 'GL5',
    'pma_nt' => 'USD',
    'pstt' => 1,
    'pngay1' => '2023-01-01',
    'pngay2' => '2023-01-31',
    'puser' => 'admin',
]);

$ret = $result['pRet'] ?? null;
```

## Ghi chú

- Nhóm này hiện có 5 procedures đã chuyển đổi.
- Các procedure có output parameter `pRet` cần được xử lý đặc biệt (hiện tại ProcedureCaller chưa hỗ trợ output parameters, cần mở rộng sau).
- Các procedure chi tiết (có hậu tố 1) thường được gọi bởi procedure chính, không nên gọi trực tiếp trừ khi hiểu rõ logic.
- Tất cả các class đều có comment chi tiết trong source code, mô tả đầy đủ tham số, logic và ví dụ.
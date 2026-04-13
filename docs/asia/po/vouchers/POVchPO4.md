# POVchPO4 - Phieu Chi Phi Mua Hang (Purchase Cost)

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | POVchPO4 |
| Form chinh | frmPOVchPO4 |
| Loai | Voucher |
| Module | PO (Purchasing) |
| Ma chung tu | PO4 |
| Mo ta | Phieu chi phi mua hang |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPOVchPO4 : frmVoucher
{
    // Ke thua tu frmVoucher
    // Form phieu chi phi mua hang
}
```

### 2.2. Tabs

| Tab Name | Control | Mo ta |
|----------|---------|-------|
| tabDetail | adgvDetail | Chi tiet chi phi |
| tabChi_phi | adgvChi_phi | Chi tiet chi phi mo rong |
| tabHach_toan | adgvHach_toan | Hach toan ke toan |
| tabTain | ctlTaIn | Thue VAT dau vao |

### 2.3. Controls tren Form (Master)

| Control | Type | Mo ta |
|---------|------|-------|
| txtMa_Kh | AsTextBox | Ma nha cung cap |
| lblTen_Kh | Label | Ten nha cung cap |
| txtDia_chi | TextBox | Dia chi |
| txtMa_so_thue | TextBox | Ma so thue |
| txtNguoi_Gd | TextBox | Nguoi giao dich |
| txtDien_giai | TextBox | Dien giai |
| txtNgay_lct | AsMaskedTextBox | Ngay lap chung tu |
| cboMa_NT | AsComboBoxNT | Ma ngoai te |
| txtTy_gia | AsTextNumeric | Ty gia |
| txtMa_Httt | AsTextBox | Ma hinh thuc thanh toan |
| lblTen_httt | Label | Ten hinh thuc thanh toan |
| txtTk_pt | AsTextBox | Tai khoan phai tra |

### 2.4. Controls Total

| Control | Type | Mo ta |
|---------|------|-------|
| txtT_cp | AsTextNumeric | Tong chi phi |
| txtT_cp_nt | AsTextNumeric | Tong chi phi (NT) |
| txtT_Thue | AsTextNumeric | Tong thue GTGT |
| txtT_thue_Nt | AsTextNumeric | Tong thue GTGT (NT) |
| txtT_tt | AsTextNumeric | Tong thanh toan |
| txtT_tt_nt | AsTextNumeric | Tong thanh toan (NT) |
| txtTien_Cp_Pb_nt | AsTextNumeric | Tien chi phi phan bo (NT) |
| txtTien_cp_pb | AsTextNumeric | Tien chi phi phan bo |

### 2.5. DataGridView Columns (Detail)

| Column | DataPropertyName | Mo ta |
|--------|-----------------|-------|
| dgvcMa_vt | Ma_vt | Ma vat tu |
| dgvcTen_vt | Ten_vt | Ten vat tu |
| dgvcDvt | Dvt | Don vi tinh |
| dgvcMa_kho | Ma_kho | Ma kho |
| dgvcSo_luong | So_luong | So luong |
| dgvcMa_nt | Ma_nt | Ma ngoai te |
| dgvcTien_nt0 | Tien_nt0 | Thanh tien (NT) |
| dgvcCp_nt | Cp_nt | Chi phi (NT) |
| dgvcTien0 | Tien0 | Thanh tien |
| dgvcCp | Cp | Chi phi |
| dgvcMa_chiphi | Ma_chiphi | Ma chi phi |
| dgvcTen_chi_phi | Ten_chi_phi | Ten chi phi |
| dgvcTs_Gtgt | Ts_gtgt | Thue suat GTGT |
| dgvcThue_gtgt_nt_cp | Thue_gtgt_nt | Tien thue GTGT (NT) |
| dgvcThue_gtgt_cp | Thue_gtgt | Tien thue GTGT |

## 3. Stored Procedures

### 3.1. SP duoc goi

| SP Name | Mo ta |
|---------|-------|
| asPOGetPO4 | Lay du lieu phieu chi phi |
| asPOSavePO4 | Luu phieu chi phi |
| asPODeletePO4 | Xoa phieu chi phi |
| asPOGetDmChiPhi | Lay danh muc chi phi |
| asPOPhanBoChiPhi | Phan bo chi phi |

## 4. Business Logic

### 4.1. Phan bo chi phi

```csharp
private void cmdPhan_bo_Click(object sender, EventArgs e)
{
    // Phan bo chi phi vao cac phieu nhap
    // Tinh toan ty le phan bo theo so luong hoac gia tri
    double totalChiPhi = Convert.ToDouble(txtT_cp.Value);
    
    // Mo form chon phieu nhap de phan bo
    frmPhanBoChiPhi frm = new frmPhanBoChiPhi();
    frm.TotalChiPhi = totalChiPhi;
    
    if (frm.ShowDialog() == DialogResult.OK)
    {
        ApplyPhanBo(frm.PhanBoData);
    }
}
```

### 4.2. Chon don hang

```csharp
private void cmdChon_dh_Click(object sender, EventArgs e)
{
    // Chon don hang de lay chi phi lien quan
    frmChonDonHang frm = new frmChonDonHang();
    if (frm.ShowDialog() == DialogResult.OK)
    {
        LoadChiPhiFromDonHang(frm.SelectedData);
    }
}
```

## 5. Mapping sang PHP

### 5.1. Controller

```php
<?php
namespace App\Http\Controllers\PO;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class PO4Controller extends Controller
{
    public function index()
    {
        return view('po.vouchers.po4');
    }
    
    public function save(Request $request)
    {
        DB::beginTransaction();
        
        try {
            $masterData = [
                'ma_ct' => 'PO4',
                'ngay_ct' => $request->ngay_ct,
                'ma_kh' => $request->ma_kh,
                'dien_giai' => $request->dien_giai,
                'ma_nt' => $request->ma_nt ?? 'VND',
                'ty_gia' => $request->ty_gia ?? 1,
                't_cp' => $request->t_cp,
                't_thue' => $request->t_thue,
                't_tt' => $request->t_tt
            ];
            
            if ($request->stt_rec) {
                DB::table('PO4')->where('stt_rec', $request->stt_rec)->update($masterData);
                $sttRec = $request->stt_rec;
            } else {
                $sttRec = $this->generateSttRec('PO4');
                $masterData['stt_rec'] = $sttRec;
                DB::table('PO4')->insert($masterData);
            }
            
            // Save detail
            DB::table('PO4CT')->where('stt_rec', $sttRec)->delete();
            foreach ($request->detail as $line) {
                DB::table('PO4CT')->insert([
                    'stt_rec' => $sttRec,
                    'ma_vt' => $line['ma_vt'],
                    'so_luong' => $line['so_luong'],
                    'tien_nt0' => $line['tien_nt0'],
                    'tien0' => $line['tien0'],
                    'cp_nt' => $line['cp_nt'],
                    'cp' => $line['cp'],
                    'ma_chiphi' => $line['ma_chiphi'],
                    'ts_gtgt' => $line['ts_gtgt'] ?? 0,
                    'thue_gtgt_nt' => $line['thue_gtgt_nt'] ?? 0,
                    'thue_gtgt' => $line['thue_gtgt'] ?? 0
                ]);
            }
            
            DB::commit();
            
            return response()->json([
                'success' => true,
                'stt_rec' => $sttRec,
                'message' => 'Luu phieu thanh cong'
            ]);
            
        } catch (\Exception $e) {
            DB::rollBack();
            return response()->json([
                'success' => false,
                'message' => $e->getMessage()
            ], 500);
        }
    }
    
    public function phanBoChiPhi(Request $request)
    {
        // Xu ly phan bo chi phi
        $chiPhi = $request->input('chi_phi');
        $phieuNhap = $request->input('phieu_nhap');
        
        foreach ($phieuNhap as $pn) {
            DB::table('PO3CT')
                ->where('stt_rec', $pn['stt_rec'])
                ->where('ma_vt', $pn['ma_vt'])
                ->update([
                    'tien_cp_nt' => $pn['phan_bo_nt'],
                    'tien_cp' => $pn['phan_bo']
                ]);
        }
        
        return response()->json(['success' => true]);
    }
}
```

## 6. Luu y

- PO4 la phieu chi phi mua hang, khong nhap kho truc tiep
- Chi phi duoc phan bo vao cac phieu nhap (PO3)
- Co the lien ket voi don hang mua (PO2)

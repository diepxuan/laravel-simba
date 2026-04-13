# POVchPO7 - Hoa Don Mua Hang Nhap Khau (Import Invoice)

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | POVchPO7 |
| Form chinh | frmPOVchPO7 |
| Loai | Voucher |
| Module | PO (Purchasing) |
| Ma chung tu | PO7 |
| Mo ta | Hoa don mua hang nhap khau |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPOVchPO7 : frmVoucher
{
    // Ke thua tu frmVoucher
    // Form hoa don nhap khau
}
```

### 2.2. Tabs

| Tab Name | Control | Mo ta |
|----------|---------|-------|
| tabDetail | adgvDetail | Chi tiet hang nhap khau |
| tabChi_phi | adgvChi_phi | Chi phi nhap khau |
| tabHach_toan | adgvHach_toan | Hach toan ke toan |
| tabTain | ctlTaIn | Thue VAT dau vao |

### 2.3. Controls tren Form (Master)

| Control | Type | Mo ta |
|---------|------|-------|
| txtMa_Kh | AsTextBox | Ma nha cung cap (nuoc ngoai) |
| lblTen_Kh | Label | Ten nha cung cap |
| txtDia_chi | TextBox | Dia chi |
| txtMa_so_thue | TextBox | Ma so thue |
| txtNguoi_Gd | TextBox | Nguoi giao dich |
| txtDien_giai | TextBox | Dien giai |
| txtNgay_lct | AsMaskedTextBox | Ngay lap chung tu |
| cboMa_NT | AsComboBoxNT | Ma ngoai te |
| txtTy_gia | AsTextNumeric | Ty gia |
| txtMa_Httt | AsTextBox | Ma hinh thuc thanh toan |
| txtSo_Hd | TextBox | So hoa don |
| txtNgay_hd | AsMaskedTextBox | Ngay hoa don |
| cboMau_Hd | ComboBox | Mau hoa don |
| txtTk_pt | AsTextBox | Tai khoan phai tra |
| txtTk_thue | AsTextBox | Tai khoan thue GTGT |

### 2.4. Controls Total

| Control | Type | Mo ta |
|---------|------|-------|
| txtT_So_luong | AsTextNumeric | Tong so luong |
| txtT_Tien0 | AsTextNumeric | Tong tien hang |
| txtT_Tien_nt0 | AsTextNumeric | Tong tien hang (NT) |
| txtT_cp | AsTextNumeric | Tong chi phi |
| txtT_cp_nt | AsTextNumeric | Tong chi phi (NT) |
| txtT_Thue_nk | AsTextNumeric | Tong thue nhap khau |
| txtT_Thue_Nk_Nt | AsTextNumeric | Tong thue NK (NT) |
| txtT_Thue_Ttdb | AsTextNumeric | Tong thue TTDB |
| txtT_Thue_ttdb_nt | AsTextNumeric | Tong thue TTDB (NT) |
| txtT_Thue | AsTextNumeric | Tong thue GTGT |
| txtT_thue_Nt | AsTextNumeric | Tong thue GTGT (NT) |
| txtT_tt | AsTextNumeric | Tong thanh toan |
| txtT_tt_nt | AsTextNumeric | Tong thanh toan (NT) |

### 2.5. DataGridView Columns (Detail)

| Column | DataPropertyName | Mo ta |
|--------|-----------------|-------|
| dgvcMa_vt | Ma_vt | Ma vat tu |
| dgvcTen_vt | Ten_vt | Ten vat tu |
| dgvcDvt | Dvt | Don vi tinh |
| dgvcMa_kho | Ma_kho | Ma kho |
| dgvcTon | Ton_so_luong | Ton kho |
| dgvcSo_luong | So_luong | So luong |
| dgvcGia_nt0 | Gia_nt0 | Don gia (NT) |
| dgvcTien_nt0 | Tien_nt0 | Thanh tien (NT) |
| dgvcTien_cp_nt | Tien_cp_nt | Chi phi (NT) |
| dgvcTs_Nk | Ts_nk | Thue suat NK |
| dgvcThue_Nk_Nt | Thue_nk_nt | Thue NK (NT) |
| dgvcTs_ttdb | Ts_ttdb | Thue suat TTDB |
| dgvcThue_TtDb_Nt | Thue_ttdb_nt | Thue TTDB (NT) |
| dgvcTs_gtgt | Ts_gtgt | Thue suat GTGT |
| dgvcThue_gtgt_nt | Thue_gtgt_nt | Thue GTGT (NT) |
| dgvcGia0 | Gia0 | Don gia |
| dgvcTien0 | Tien0 | Thanh tien |
| dgvcTien_cp | Tien_cp | Chi phi |
| dgvcThue_Nk | Thue_nk | Thue NK |
| dgvcThue_Ttdb | Thue_ttdb | Thue TTDB |
| dgvcThue_gtgt | Thue_gtgt | Thue GTGT |
| dgvcSo_ct_cp | So_ct_cp | So CT chi phi |
| dgvcNgay_ct_cp | Ngay_ct_cp | Ngay CT chi phi |

### 2.6. Chi Phi Nhap Khau

| Column | DataPropertyName | Mo ta |
|--------|-----------------|-------|
| dgvcMa_Ncc_cp | Ma_ncc_cp | Ma NCC chi phi |
| dgvcTen_Ncc_cp | Ten_ncc_cp | Ten NCC chi phi |
| dgvcMa_chiphi | Ma_chiphi | Ma chi phi |
| dgvcTen_chi_phi | Ten_chi_phi | Ten chi phi |
| dgvcTien_cp_nt_cp | Tien_cp_nt_cp | Tien chi phi (NT) |
| dgvcTs_gtgt_cp | Ts_gtgt_cp | Thue suat GTGT chi phi |
| dgvcThue_Gtgt_nt_cp | Thue_gtgt_nt_cp | Thue GTGT chi phi (NT) |
| dgvcTt_nt_Cp | Tt_nt_cp | Tong tien chi phi (NT) |
| dgvcTien_cp_cp | Tien_cp_cp | Tien chi phi |
| dgvcThue_Gtgt_cp | Thue_gtgt_cp | Thue GTGT chi phi |
| dgvcTt_Cp | Tt_cp | Tong tien chi phi |
| dgvcCp_Nk | Cp_nk | Chi phi nhap khau |

## 3. Stored Procedures

### 3.1. SP duoc goi

| SP Name | Mo ta |
|---------|-------|
| asPOGetPO7 | Lay du lieu hoa don nhap khau |
| asPOSavePO7 | Luu hoa don nhap khau |
| asPODeletePO7 | Xoa hoa don nhap khau |
| asPOGetChiPhiNK | Lay chi phi nhap khau |

## 4. Business Logic

### 4.1. Tinh thue nhap khau

```csharp
private void CalculateImportTax()
{
    foreach (DataRow row in detailData.Rows)
    {
        double tienNt = Convert.ToDouble(row["Tien_nt0"]);
        double tienCpNt = Convert.ToDouble(row["Tien_cp_nt"]);
        double tsNk = Convert.ToDouble(row["Ts_nk"]);
        double tsTtdb = Convert.ToDouble(row["Ts_ttdb"]);
        double tsGtgt = Convert.ToDouble(row["Ts_gtgt"]);
        
        // Tinh thue nhap khau
        double thueNkNt = tienNt * tsNk / 100;
        
        // Tinh thue TTDB (tren gia + thue NK)
        double thueTtdbNt = (tienNt + thueNkNt) * tsTtdb / 100;
        
        // Tinh thue GTGT (tren gia + thue NK + thue TTDB + chi phi)
        double thueGtgtNt = (tienNt + thueNkNt + thueTtdbNt + tienCpNt) * tsGtgt / 100;
        
        row["Thue_nk_nt"] = thueNkNt;
        row["Thue_ttdb_nt"] = thueTtdbNt;
        row["Thue_gtgt_nt"] = thueGtgtNt;
        
        // Quy doi sang VND
        row["Thue_nk"] = thueNkNt * tyGia;
        row["Thue_ttdb"] = thueTtdbNt * tyGia;
        row["Thue_gtgt"] = thueGtgtNt * tyGia;
    }
}
```

### 4.2. Phan bo chi phi nhap khau

```csharp
private void cmdPhan_bo_Click(object sender, EventArgs e)
{
    // Phan bo chi phi nhap khau vao chi tiet hang hoa
    double totalChiPhi = Convert.ToDouble(txtT_cp.Value);
    double totalTienNt = detailData.Sum(r => Convert.ToDouble(r["Tien_nt0"]));
    
    foreach (DataRow row in detailData.Rows)
    {
        double tienNt = Convert.ToDouble(row["Tien_nt0"]);
        double phanBo = totalChiPhi * tienNt / totalTienNt;
        row["Tien_cp_nt"] = phanBo;
        row["Tien_cp"] = phanBo * tyGia;
    }
    
    // Tinh lai thue GTGT sau khi phan bo chi phi
    CalculateImportTax();
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

class PO7Controller extends Controller
{
    public function index()
    {
        return view('po.vouchers.po7');
    }
    
    public function save(Request $request)
    {
        DB::beginTransaction();
        
        try {
            $masterData = [
                'ma_ct' => 'PO7',
                'ngay_ct' => $request->ngay_ct,
                'ma_kh' => $request->ma_kh,
                'dien_giai' => $request->dien_giai,
                'so_hd' => $request->so_hd,
                'ngay_hd' => $request->ngay_hd,
                'mau_hd' => $request->mau_hd,
                'ma_nt' => $request->ma_nt ?? 'USD',
                'ty_gia' => $request->ty_gia,
                't_tien0' => $request->t_tien0,
                't_cp' => $request->t_cp,
                't_thue_nk' => $request->t_thue_nk,
                't_thue_ttdb' => $request->t_thue_ttdb,
                't_thue' => $request->t_thue,
                't_tt' => $request->t_tt
            ];
            
            if ($request->stt_rec) {
                DB::table('PO7')->where('stt_rec', $request->stt_rec)->update($masterData);
                $sttRec = $request->stt_rec;
            } else {
                $sttRec = $this->generateSttRec('PO7');
                $masterData['stt_rec'] = $sttRec;
                DB::table('PO7')->insert($masterData);
            }
            
            // Save detail
            DB::table('PO7CT')->where('stt_rec', $sttRec)->delete();
            foreach ($request->detail as $line) {
                DB::table('PO7CT')->insert([
                    'stt_rec' => $sttRec,
                    'ma_vt' => $line['ma_vt'],
                    'so_luong' => $line['so_luong'],
                    'gia_nt0' => $line['gia_nt0'],
                    'tien_nt0' => $line['tien_nt0'],
                    'gia0' => $line['gia0'],
                    'tien0' => $line['tien0'],
                    'tien_cp_nt' => $line['tien_cp_nt'] ?? 0,
                    'tien_cp' => $line['tien_cp'] ?? 0,
                    'ts_nk' => $line['ts_nk'] ?? 0,
                    'thue_nk_nt' => $line['thue_nk_nt'] ?? 0,
                    'thue_nk' => $line['thue_nk'] ?? 0,
                    'ts_ttdb' => $line['ts_ttdb'] ?? 0,
                    'thue_ttdb_nt' => $line['thue_ttdb_nt'] ?? 0,
                    'thue_ttdb' => $line['thue_ttdb'] ?? 0,
                    'ts_gtgt' => $line['ts_gtgt'] ?? 0,
                    'thue_gtgt_nt' => $line['thue_gtgt_nt'] ?? 0,
                    'thue_gtgt' => $line['thue_gtgt'] ?? 0
                ]);
            }
            
            // Save chi phi
            DB::table('PO7CP')->where('stt_rec', $sttRec)->delete();
            foreach ($request->chi_phi as $cp) {
                DB::table('PO7CP')->insert([
                    'stt_rec' => $sttRec,
                    'ma_ncc_cp' => $cp['ma_ncc_cp'],
                    'ma_chiphi' => $cp['ma_chiphi'],
                    'tien_cp_nt' => $cp['tien_cp_nt'],
                    'tien_cp' => $cp['tien_cp'],
                    'ts_gtgt' => $cp['ts_gtgt'] ?? 0,
                    'thue_gtgt_nt' => $cp['thue_gtgt_nt'] ?? 0,
                    'thue_gtgt' => $cp['thue_gtgt'] ?? 0
                ]);
            }
            
            DB::commit();
            
            return response()->json([
                'success' => true,
                'stt_rec' => $sttRec
            ]);
            
        } catch (\Exception $e) {
            DB::rollBack();
            return response()->json([
                'success' => false,
                'message' => $e->getMessage()
            ], 500);
        }
    }
    
    public function calculateTax(Request $request)
    {
        $detail = $request->input('detail');
        $tyGia = $request->input('ty_gia', 1);
        
        foreach ($detail as &$line) {
            $tienNt = $line['tien_nt0'];
            $tienCpNt = $line['tien_cp_nt'] ?? 0;
            $tsNk = $line['ts_nk'] ?? 0;
            $tsTtdb = $line['ts_ttdb'] ?? 0;
            $tsGtgt = $line['ts_gtgt'] ?? 0;
            
            // Thue NK
            $line['thue_nk_nt'] = $tienNt * $tsNk / 100;
            
            // Thue TTDB
            $line['thue_ttdb_nt'] = ($tienNt + $line['thue_nk_nt']) * $tsTtdb / 100;
            
            // Thue GTGT
            $line['thue_gtgt_nt'] = ($tienNt + $line['thue_nk_nt'] + $line['thue_ttdb_nt'] + $tienCpNt) * $tsGtgt / 100;
            
            // Quy doi VND
            $line['thue_nk'] = $line['thue_nk_nt'] * $tyGia;
            $line['thue_ttdb'] = $line['thue_ttdb_nt'] * $tyGia;
            $line['thue_gtgt'] = $line['thue_gtgt_nt'] * $tyGia;
        }
        
        return response()->json($detail);
    }
}
```

## 6. Luu y

- PO7 la hoa don nhap khau, co 3 loai thue: NK, TTDB, GTGT
- Chi phi nhap khau duoc phan bo vao gia hang hoa
- Thue GTGT duoc tinh tren gia hang + thue NK + thue TTDB + chi phi
- Nha cung cap thuong la nuoc ngoai
- Co the co nhieu chi phi nhap khau khac nhau (van chuyen, bao hiem, ...)

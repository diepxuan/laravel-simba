# POVchPO5 - Hoa Don Mua Hang (Purchase Invoice)

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | POVchPO5 |
| Form chinh | frmPOVchPO5 |
| Loai | Voucher |
| Module | PO (Purchasing) |
| Ma chung tu | PO5 |
| Mo ta | Hoa don mua hang trong nuoc |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPOVchPO5 : frmVoucher
{
    // Ke thua tu frmVoucher
    // Form hoa don mua hang
}
```

### 2.2. Tabs

| Tab Name | Control | Mo ta |
|----------|---------|-------|
| tabDetail | adgvDetail | Chi tiet hoa don |
| tabHach_toan | adgvHach_toan | Hach toan ke toan |

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
| txtSo_Seri | TextBox | So seri hoa don |
| txtSo_seri_mhd | TextBox | So seri mau hoa don |
| txtTk_pt | AsTextBox | Tai khoan phai tra |
| txtTk_thue | AsTextBox | Tai khoan thue |
| chkGia_dd | AsCheckBox | Gia dien dat |

### 2.4. Controls Total

| Control | Type | Mo ta |
|---------|------|-------|
| txtT_So_luong | AsTextNumeric | Tong so luong |
| txtT_Tien_nt | AsTextNumeric | Tong tien hang (NT) |
| txtT_Tien | AsTextNumeric | Tong tien hang |
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
| dgvcGia_nt | Gia_nt | Don gia (NT) |
| dgvcTien_nt | Tien_nt | Thanh tien (NT) |
| dgvcTs_gtgt | Ts_gtgt | Thue suat GTGT |
| dgvcThue_gtgt_nt | Thue_gtgt_nt | Tien thue GTGT (NT) |
| dgvcGia | Gia | Don gia |
| dgvcTien | Tien | Thanh tien |
| dgvcThue_gtgt | Thue_gtgt | Tien thue GTGT |
| dgvcSo_hd | So_hd | So hoa don |

## 3. Stored Procedures

### 3.1. SP duoc goi

| SP Name | Mo ta |
|---------|-------|
| asPOGetPO5 | Lay du lieu hoa don |
| asPOSavePO5 | Luu hoa don |
| asPODeletePO5 | Xoa hoa don |
| asPOGetPhieuNhap | Lay danh sach phieu nhap chua co hoa don |

## 4. Business Logic

### 4.1. Chon phieu nhap

```csharp
private void cmdChon_Pn_Click(object sender, EventArgs e)
{
    // Mo form chon phieu nhap de lap hoa don
    frmChonPhieuNhap frm = new frmChonPhieuNhap();
    frm.MaKh = txtMa_Kh.Text;
    
    if (frm.ShowDialog() == DialogResult.OK)
    {
        LoadDataFromPhieuNhap(frm.SelectedData);
    }
}
```

### 4.2. Tinh thue GTGT

```csharp
private void CalculateTax()
{
    foreach (DataRow row in detailData.Rows)
    {
        double tien = Convert.ToDouble(row["Tien"]);
        double tsGtgt = Convert.ToDouble(row["Ts_gtgt"]);
        
        row["Thue_gtgt"] = tien * tsGtgt / 100;
        row["Thue_gtgt_nt"] = Convert.ToDouble(row["Tien_nt"]) * tsGtgt / 100;
    }
    
    // Tinh tong
    txtT_Thue.Value = detailData.Sum(r => Convert.ToDouble(r["Thue_gtgt"]));
    txtT_thue_Nt.Value = detailData.Sum(r => Convert.ToDouble(r["Thue_gtgt_nt"]));
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

class PO5Controller extends Controller
{
    public function index()
    {
        return view('po.vouchers.po5');
    }
    
    public function save(Request $request)
    {
        DB::beginTransaction();
        
        try {
            $masterData = [
                'ma_ct' => 'PO5',
                'ngay_ct' => $request->ngay_ct,
                'ma_kh' => $request->ma_kh,
                'dien_giai' => $request->dien_giai,
                'so_seri' => $request->so_seri,
                'so_seri_mhd' => $request->so_seri_mhd,
                'ma_nt' => $request->ma_nt ?? 'VND',
                'ty_gia' => $request->ty_gia ?? 1,
                't_tien' => $request->t_tien,
                't_thue' => $request->t_thue,
                't_tt' => $request->t_tt,
                'gia_dd' => $request->gia_dd ?? false
            ];
            
            if ($request->stt_rec) {
                DB::table('PO5')->where('stt_rec', $request->stt_rec)->update($masterData);
                $sttRec = $request->stt_rec;
            } else {
                $sttRec = $this->generateSttRec('PO5');
                $masterData['stt_rec'] = $sttRec;
                DB::table('PO5')->insert($masterData);
            }
            
            // Save detail
            DB::table('PO5CT')->where('stt_rec', $sttRec)->delete();
            foreach ($request->detail as $line) {
                DB::table('PO5CT')->insert([
                    'stt_rec' => $sttRec,
                    'ma_vt' => $line['ma_vt'],
                    'so_luong' => $line['so_luong'],
                    'gia_nt' => $line['gia_nt'],
                    'tien_nt' => $line['tien_nt'],
                    'gia' => $line['gia'],
                    'tien' => $line['tien'],
                    'ts_gtgt' => $line['ts_gtgt'] ?? 0,
                    'thue_gtgt_nt' => $line['thue_gtgt_nt'] ?? 0,
                    'thue_gtgt' => $line['thue_gtgt'] ?? 0,
                    'so_hd' => $line['so_hd'] ?? ''
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
    
    public function getPhieuNhapChuaCoHd(Request $request)
    {
        $data = DB::select("SELECT * FROM PO3 WHERE ma_kh = ? AND stt_rec NOT IN (SELECT stt_rec_pn FROM PO5CT)", [
            $request->ma_kh
        ]);
        
        return response()->json($data);
    }
}
```

## 6. Luu y

- PO5 la hoa don mua hang, co the lien ket voi phieu nhap (PO3)
- Ho tro gia dien dat (gia tam tinh)
- Co day du thong tin hoa don VAT (so seri, mau hoa don)

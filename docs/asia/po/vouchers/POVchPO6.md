# PoVchPO6 - Hoa Don Mua Dich Vu (Service Invoice)

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | PoVchPO6 |
| Form chinh | frmPoVchPO6 |
| Loai | Voucher |
| Module | PO (Purchasing) |
| Ma chung tu | PO6 |
| Mo ta | Hoa don mua dich vu |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPoVchPO6 : frmVoucher
{
    // Ke thua tu frmVoucher
    // Form hoa don mua dich vu
}
```

### 2.2. Tabs

| Tab Name | Control | Mo ta |
|----------|---------|-------|
| tabDetail | adgvDetail | Chi tiet dich vu |
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
| lblTen_Httt | Label | Ten hinh thuc thanh toan |
| txtSo_hd | TextBox | So hoa don |
| txtNgay_hd | AsMaskedTextBox | Ngay hoa don |
| txtTk_pt | AsTextBox | Tai khoan phai tra |
| txtTk_thue | AsTextBox | Tai khoan thue |

### 2.4. Controls Total

| Control | Type | Mo ta |
|---------|------|-------|
| txtT_Tien_nt | AsTextNumeric | Tong tien dich vu (NT) |
| txtT_Tien | AsTextNumeric | Tong tien dich vu |
| txtT_Thue | AsTextNumeric | Tong thue GTGT |
| txtT_thue_nt | AsTextNumeric | Tong thue GTGT (NT) |
| txtT_tt | AsTextNumeric | Tong thanh toan |
| txtT_tt_nt | AsTextNumeric | Tong thanh toan (NT) |

### 2.5. DataGridView Columns (Detail)

| Column | DataPropertyName | Mo ta |
|--------|-----------------|-------|
| dgvcMa_vt | Ma_vt | Ma dich vu |
| dgvcTen_vt | Ten_vt | Ten dich vu |
| dgvcDvt | Dvt | Don vi tinh |
| dgvcSo_luong | So_luong | So luong |
| dgvcGia_Nt | Gia_nt | Don gia (NT) |
| dgvcTien_nt | Tien_nt | Thanh tien (NT) |
| dgvcTs_gtgt | Ts_gtgt | Thue suat GTGT |
| dgvcThue_gtgt_nt | Thue_gtgt_nt | Tien thue GTGT (NT) |
| dgvcGia | Gia | Don gia |
| dgvcTien | Tien | Thanh tien |
| dgvcThue_gtgt | Thue_gtgt | Tien thue GTGT |
| dgvcTk_no | Tk_no | Tai khoan no |

## 3. Stored Procedures

### 3.1. SP duoc goi

| SP Name | Mo ta |
|---------|-------|
| asPOGetPO6 | Lay du lieu hoa don dich vu |
| asPOSavePO6 | Luu hoa don dich vu |
| asPODeletePO6 | Xoa hoa don dich vu |
| asPOGetDmDichVu | Lay danh muc dich vu |

## 4. Business Logic

### 4.1. Tinh toan tien dich vu

```csharp
private void CalculateServiceAmount()
{
    foreach (DataRow row in detailData.Rows)
    {
        double soLuong = Convert.ToDouble(row["So_luong"]);
        double giaNt = Convert.ToDouble(row["Gia_nt"]);
        double tsGtgt = Convert.ToDouble(row["Ts_gtgt"]);
        
        // Tinh tien dich vu
        row["Tien_nt"] = soLuong * giaNt;
        row["Tien"] = Convert.ToDouble(row["Tien_nt"]) * tyGia;
        
        // Tinh thue GTGT
        row["Thue_gtgt_nt"] = Convert.ToDouble(row["Tien_nt"]) * tsGtgt / 100;
        row["Thue_gtgt"] = Convert.ToDouble(row["Thue_gtgt_nt"]) * tyGia;
    }
    
    // Tinh tong
    txtT_Tien_nt.Value = detailData.Sum(r => Convert.ToDouble(r["Tien_nt"]));
    txtT_Tien.Value = detailData.Sum(r => Convert.ToDouble(r["Tien"]));
    txtT_thue_nt.Value = detailData.Sum(r => Convert.ToDouble(r["Thue_gtgt_nt"]));
    txtT_Thue.Value = detailData.Sum(r => Convert.ToDouble(r["Thue_gtgt"]));
    txtT_tt_nt.Value = Convert.ToDouble(txtT_Tien_nt.Value) + Convert.ToDouble(txtT_thue_nt.Value);
    txtT_tt.Value = Convert.ToDouble(txtT_Tien.Value) + Convert.ToDouble(txtT_Thue.Value);
}
```

### 4.2. Hach toan ke toan

```csharp
private void GenerateAccountingEntries()
{
    // No: Chi phi/Cong cu dung cu/Tai san
    // Co: Phai tra nguoi ban
    // Co: Thue GTGT duoc khau tru
    
    hachToanData.Clear();
    
    foreach (DataRow row in detailData.Rows)
    {
        // But toan gia tri dich vu
        DataRow entry = hachToanData.NewRow();
        entry["Tk_no"] = row["Tk_no"];
        entry["Tk_co"] = txtTk_pt.Text;
        entry["Tien_nt"] = row["Tien_nt"];
        entry["Tien"] = row["Tien"];
        hachToanData.Rows.Add(entry);
        
        // But toan thue GTGT
        if (Convert.ToDouble(row["Thue_gtgt"]) > 0)
        {
            DataRow taxEntry = hachToanData.NewRow();
            taxEntry["Tk_no"] = txtTk_thue.Text;
            taxEntry["Tk_co"] = txtTk_pt.Text;
            taxEntry["Tien_nt"] = row["Thue_gtgt_nt"];
            taxEntry["Tien"] = row["Thue_gtgt"];
            hachToanData.Rows.Add(taxEntry);
        }
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

class PO6Controller extends Controller
{
    public function index()
    {
        return view('po.vouchers.po6');
    }
    
    public function save(Request $request)
    {
        DB::beginTransaction();
        
        try {
            $masterData = [
                'ma_ct' => 'PO6',
                'ngay_ct' => $request->ngay_ct,
                'ma_kh' => $request->ma_kh,
                'dien_giai' => $request->dien_giai,
                'so_hd' => $request->so_hd,
                'ngay_hd' => $request->ngay_hd,
                'ma_nt' => $request->ma_nt ?? 'VND',
                'ty_gia' => $request->ty_gia ?? 1,
                't_tien' => $request->t_tien,
                't_thue' => $request->t_thue,
                't_tt' => $request->t_tt
            ];
            
            if ($request->stt_rec) {
                DB::table('PO6')->where('stt_rec', $request->stt_rec)->update($masterData);
                $sttRec = $request->stt_rec;
            } else {
                $sttRec = $this->generateSttRec('PO6');
                $masterData['stt_rec'] = $sttRec;
                DB::table('PO6')->insert($masterData);
            }
            
            // Save detail
            DB::table('PO6CT')->where('stt_rec', $sttRec)->delete();
            foreach ($request->detail as $line) {
                DB::table('PO6CT')->insert([
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
                    'tk_no' => $line['tk_no']
                ]);
            }
            
            // Save hach toan
            DB::table('PO6HT')->where('stt_rec', $sttRec)->delete();
            foreach ($request->hach_toan as $ht) {
                DB::table('PO6HT')->insert([
                    'stt_rec' => $sttRec,
                    'tk_no' => $ht['tk_no'],
                    'tk_co' => $ht['tk_co'],
                    'tien_nt' => $ht['tien_nt'],
                    'tien' => $ht['tien']
                ]);
            }
            
            DB::commit();
            
            return response()->json([
                'success' => true,
                'stt_rec' => $sttRec
            ]);
            
        } catch (\Exception $e) {
            DB::rollBack();
            return response
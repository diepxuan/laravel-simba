# POVchPO3 - Phieu Nhap Mua Hang (Invoice Receipt)

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | POVchPO3 |
| Form chinh | frmPOVchPO3 |
| Loai | Voucher |
| Module | PO (Purchasing) |
| Ma chung tu | PO3 |
| Mo ta | Phieu nhap mua hang - Hoa don kiem phieu nhap |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPOVchPO3 : frmVoucher
{
    // Ke thua tu frmVoucher
    // Form phieu nhap mua hang
}
```

### 2.2. Tabs

| Tab Name | Control | Mo ta |
|----------|---------|-------|
| tabDetail | adgvDetail | Chi tiet phieu nhap |
| tabChi_phi | adgvChi_phi | Chi phi mua hang |
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
| txtSo_hd | TextBox | So hoa don |
| txtNgay_hd | AsMaskedTextBox | Ngay hoa don |
| txtTk_pt | AsTextBox | Tai khoan phai tra |
| txtTk_thue | AsTextBox | Tai khoan thue |

### 2.4. Controls Total

| Control | Type | Mo ta |
|---------|------|-------|
| txtT_So_luong | AsTextNumeric | Tong so luong |
| txtT_Tien0 | AsTextNumeric | Tong tien hang |
| txtT_Tien_nt0 | AsTextNumeric | Tong tien hang (NT) |
| txtT_cp | AsTextNumeric | Tong chi phi |
| txtT_cp_nt | AsTextNumeric | Tong chi phi (NT) |
| txtT_Thue | AsTextNumeric | Tong thue GTGT |
| txtT_thue_Nt | AsTextNumeric | Tong thue GTGT (NT) |
| txtT_tt | AsTextNumeric | Tong thanh toan |
| txtT_tt_nt | AsTextNumeric | Tong thanh toan (NT) |
| txtTl_ck_hd | AsTextNumeric | Ty le chiet khau hoa don |
| txtT_ck | AsTextNumeric | Tong chiet khau |
| txtT_ck_nt | AsTextNumeric | Tong chiet khau (NT) |

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
| dgvcTl_ck | Tl_ck | Ty le chiet khau |
| dgvcCk_nt | Ck_nt | Tien chiet khau (NT) |
| dgvcTien_cp_nt | Tien_cp_nt | Chi phi (NT) |
| dgvcTs_gtgt | Ts_gtgt | Thue suat GTGT |
| dgvcThue_gtgt_nt | Thue_gtgt_nt | Tien thue GTGT (NT) |
| dgvcGia0 | Gia0 | Don gia |
| dgvcTien0 | Tien0 | Thanh tien |
| dgvcCk | Ck | Tien chiet khau |
| dgvcTien_cp | Tien_cp | Chi phi |
| dgvcThue_gtgt | Thue_gtgt | Tien thue GTGT |

## 3. Stored Procedures

### 3.1. SP duoc goi

| SP Name | Mo ta |
|---------|-------|
| asPOGetPO3 | Lay du lieu phieu nhap |
| asPOSavePO3 | Luu phieu nhap |
| asPODeletePO3 | Xoa phieu nhap |
| asPOGetDmVt | Lay danh muc vat tu |
| asPOGetDmKho | Lay danh muc kho |
| asPOGetChiPhi | Lay chi phi mua hang |
| asPOGetHachToan | Lay hach toan ke toan |

## 4. Business Logic

### 4.1. Tinh toan tien hang

```csharp
// Tinh tien hang
Tien0 = So_luong * Gia0
Tien_nt0 = So_luong * Gia_nt0

// Tinh chiet khau
Ck = Tien0 * Tl_ck / 100
Ck_nt = Tien_nt0 * Tl_ck / 100

// Tinh thue GTGT
Thue_gtgt = (Tien0 - Ck + Tien_cp) * Ts_gtgt / 100
Thue_gtgt_nt = (Tien_nt0 - Ck_nt + Tien_cp_nt) * Ts_gtgt / 100

// Tong thanh toan
T_tt = Tien0 - Ck + Tien_cp + Thue_gtgt
T_tt_nt = Tien_nt0 - Ck_nt + Tien_cp_nt + Thue_gtgt_nt
```

### 4.2. Phan bo chi phi

```csharp
private void cmdPhan_bo_Click(object sender, EventArgs e)
{
    // Phan bo chi phi vao chi tiet vat tu
    double totalChiPhi = Convert.ToDouble(txtT_cp.Value);
    double totalSoLuong = Convert.ToDouble(txtT_So_luong.Value);
    
    foreach (DataRow row in detailData.Rows)
    {
        double soLuong = Convert.ToDouble(row["So_luong"]);
        double phanBo = totalChiPhi * soLuong / totalSoLuong;
        row["Tien_cp"] = phanBo;
    }
}
```

### 4.3. Chon don hang

```csharp
private void cmdChon_dh_Click(object sender, EventArgs e)
{
    // Mo form chon don hang de lay du lieu
    frmChonDonHang frm = new frmChonDonHang();
    if (frm.ShowDialog() == DialogResult.OK)
    {
        LoadDataFromDonHang(frm.SelectedData);
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
use Illuminate\Support\Facades\Validator;

class PO3Controller extends Controller
{
    public function index()
    {
        return view('po.vouchers.po3');
    }
    
    public function getData($id)
    {
        $master = DB::table('PO3')->where('stt_rec', $id)->first();
        $detail = DB::table('PO3CT')->where('stt_rec', $id)->get();
        $chiPhi = DB::table('PO3CP')->where('stt_rec', $id)->get();
        $hachToan = DB::table('PO3HT')->where('stt_rec', $id)->get();
        
        return response()->json([
            'master' => $master,
            'detail' => $detail,
            'chiPhi' => $chiPhi,
            'hachToan' => $hachToan
        ]);
    }
    
    public function save(Request $request)
    {
        DB::beginTransaction();
        
        try {
            // Validate
            $validator = Validator::make($request->all(), [
                'ma_kh' => 'required',
                'ngay_ct' => 'required|date',
                'detail' => 'required|array'
            ]);
            
            if ($validator->fails()) {
                return response()->json(['errors' => $validator->errors()], 422);
            }
            
            // Save master
            $masterData = [
                'ma_ct' => 'PO3',
                'ngay_ct' => $request->ngay_ct,
                'ma_kh' => $request->ma_kh,
                'dien_giai' => $request->dien_giai,
                'ma_nt' => $request->ma_nt ?? 'VND',
                'ty_gia' => $request->ty_gia ?? 1,
                't_tien0' => $request->t_tien0,
                't_ck' => $request->t_ck,
                't_cp' => $request->t_cp,
                't_thue' => $request->t_thue,
                't_tt' => $request->t_tt,
                'status' => $request->status ?? '0'
            ];
            
            if ($request->stt_rec) {
                DB::table('PO3')->where('stt_rec', $request->stt_rec)->update($masterData);
                $sttRec = $request->stt_rec;
            } else {
                $sttRec = $this->generateSttRec('PO3');
                $masterData['stt_rec'] = $sttRec;
                DB::table('PO3')->insert($masterData);
            }
            
            // Save detail
            DB::table('PO3CT')->where('stt_rec', $sttRec)->delete();
            foreach ($request->detail as $line) {
                DB::table('PO3CT')->insert([
                    'stt_rec' => $sttRec,
                    'ma_vt' => $line['ma_vt'],
                    'so_luong' => $line['so_luong'],
                    'gia_nt0' => $line['gia_nt0'],
                    'tien_nt0' => $line['tien_nt0'],
                    'gia0' => $line['gia0'],
                    'tien0' => $line['tien0'],
                    'tl_ck' => $line['tl_ck'] ?? 0,
                    'ck_nt' => $line['ck_nt'] ?? 0,
                    'ck' => $line['ck'] ?? 0,
                    'tien_cp_nt' => $line['tien_cp_nt'] ?? 0,
                    't
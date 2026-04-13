# PORptBK03 - Bao Cao Bien Dong Kho 03

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | PORptBK03 |
| Form chinh | frmPORptBK03 |
| Loai | Report |
| Module | PO (Purchasing) |
| Mo ta | Bao cao bien dong kho 03 - Bao cao nhap xuat ton theo nhom |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPORptBK03 : frmReport
{
    // Ke thua tu frmReport
    // Form bao cao bien dong kho 03
}
```

### 2.2. Controls tren Form

| Control | Type | Mo ta |
|---------|------|-------|
| txtNgay1 | AsMaskedTextBox | Tu ngay |
| txtNgay2 | AsMaskedTextBox | Den ngay |
| txtSo_CT1 | TextBox | Chung tu so tu |
| txtSo_CT2 | TextBox | Chung tu so den |
| cboNhom_theo | ComboBox | Nhom theo |
| txtMa_ncc | AsTextBox | Ma nha cung cap |
| txtMa_nh_ncc | AsTextBox | Ma nhom NCC |
| txtMa_vt | AsTextBox | Ma vat tu |
| txtMa_nh_vt | AsTextBox | Ma nhom vat tu |
| txtMa_kho | AsTextBox | Ma kho |
| txtMa_hd | AsTextBox | Ma hop dong |
| txtMa_nhhd | AsTextBox | Ma nhom hop dong |
| txtPl_ncc1-3 | AsTextBox | Phan loai NCC |
| txtMaPhi | AsTextBox | Ma phi |
| txtMa_spct | AsTextBox | Ma san pham cong trinh |
| txtMA_HTTT | AsTextBox | Ma hinh thuc thanh toan |
| txtMA_DKTT | AsTextBox | Ma dieu khoan thanh toan |
| txtMaLo | AsTextBox | Ma lo |
| txtMa_vtri | AsTextBox | Ma vi tri |
| txtMa_bp | AsTextBox | Ma bo phan |
| txtMa_Plvt1-3 | AsTextBox | Phan loai vat tu |

### 2.3. Nhom theo Options

| Value | Display |
|-------|---------|
| MA_KH | Nha cung cap |
| MA_BP | Bo phan |
| MA_HD | Hop dong |
| MA_HTTT | Hinh thuc thanh toan |
| MA_VT | Vat tu |
| STT_REC | Chung tu |
| MA_SPCT | San pham cong trinh |

### 2.4. InitOtherComponents

```csharp
protected override void InitOtherComponents()
{
    base.InitOtherComponents();
    ComboBox val = cboNhom_theo;
    ArrayList arrayList = new ArrayList();
    DictionaryEntry dictionaryEntry = new DictionaryEntry("MA_KH", RuntimeHelpers.GetObjectValue(val.Items[0]));
    arrayList.Add(dictionaryEntry);
    dictionaryEntry = new DictionaryEntry("MA_BP", RuntimeHelpers.GetObjectValue(val.Items[1]));
    arrayList.Add(dictionaryEntry);
    dictionaryEntry = new DictionaryEntry("MA_HD", RuntimeHelpers.GetObjectValue(val.Items[2]));
    arrayList.Add(dictionaryEntry);
    dictionaryEntry = new DictionaryEntry("MA_HTTT", RuntimeHelpers.GetObjectValue(val.Items[3]));
    arrayList.Add(dictionaryEntry);
    dictionaryEntry = new DictionaryEntry("MA_VT", RuntimeHelpers.GetObjectValue(val.Items[4]));
    arrayList.Add(dictionaryEntry);
    dictionaryEntry = new DictionaryEntry("STT_REC", RuntimeHelpers.GetObjectValue(val.Items[5]));
    arrayList
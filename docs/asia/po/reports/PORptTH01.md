# PORptTH01 - Bao Cao Tong Hop 01

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | PORptTH01 |
| Form chinh | frmPORptTH01 |
| Loai | Report |
| Module | PO (Purchasing) |
| Mo ta | Bao cao tong hop mua hang theo vat tu |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPORptTH01 : frmReport
{
    // Ke thua tu frmReport
    // Form bao cao tong hop 01
}
```

### 2.2. Controls tren Form

| Control | Type | Mo ta |
|---------|------|-------|
| txtNgay1 | AsMaskedTextBox | Tu ngay |
| txtNgay2 | AsMaskedTextBox | Den ngay |
| cboLoaiPhieu | AsComboBox | Loai phieu |
| cboTrang_Thai | AsComboBox | Trang thai |
| txtMa_ncc | AsTextBox | Ma nha cung cap |
| txtMa_nh_ncc | AsTextBox | Ma nhom NCC |
| txtPl_ncc1-3 | AsTextBox | Phan loai NCC |
| txtMa_hd | AsTextBox | Ma hop dong |
| txtMa_nhhd | AsTextBox | Ma nhom hop dong |
| txtMa_kho | AsTextBox | Ma kho |
| txtMa_vtri | AsTextBox | Ma vi tri |
| txtMa_vt | AsTextBox | Ma vat tu |
| txtMa_nh_vt | AsTextBox | Ma nhom vat tu |
| txtMa_spct | AsTextBox | Ma san pham cong trinh |
| txtMaPhi | AsTextBox | Ma phi |
| txtMA_HTTT | AsTextBox | Ma hinh thuc thanh toan |
| txtMA_DKTT | AsTextBox | Ma dieu khoan thanh toan |
| txtMaLo | AsTextBox | Ma lo |
| txtMa_Plvt1-3 | AsTextBox | Phan loai vat tu |
| txtMa_Nt | AsTextBox | Ma ngoai te |
| optVND | RadioButton | Tien VND |
| optNt | RadioButton | Tien ngoai te |

### 2.3. InitOtherComponents

```csharp
protected override void InitOtherComponents()
{
    base.InitOtherComponents();
    
    // Load danh muc loai phieu
    ArrayList arrayList = new ArrayList();
    arrayList.Add(CompanyInformations.CompanyID);
    arrayList.Add(MyMenuInfo.moduleid);
    arrayList.Add("0");
    arrayList.Add(SystemInformations.CurrentCultureName);
    
    ArrayList arrayList2 = CBO<lstVoucherInfo>.FillCollection(
        Commons.GetDataReader("asSIGetDmSo_ct", arrayList.ToArray())
    );
    arrayList2.Add(new lstVoucherInfo("", AsiaErp.Framework.Environment.getLangSysMessageResX("#SYS_ALL").value));
    
    ((ComboBox)cboLoaiPhieu).DataSource = arrayList2;
    ((ListControl)cboLoaiPhieu).DisplayMember = "TEN_CT";
    ((ListControl)cboLoaiPhieu).ValueMember = "MA_CT";
    ((ListControl)cboLoaiPhieu).SelectedValue = base.MyReportInfo.par0;
}
```

## 3. Stored Procedures

### 3.1. SP duoc goi

| SP Name | Parameters | Mo ta |
|---------|------------|-------|
| asPOGetTH01 | @Ma_dvcs, @Ngay1, @Ngay2, @Ma_ncc, @Ma_nh_ncc, @Pl_ncc1, @Pl_ncc2, @Pl_ncc3, @Ma_hd, @Ma_kho, @Ma_vtri, @Ma_vt, @Ma_nh_vt, @Ma_nt, @Loai_phieu, @Trang_thai, @Ma_nhhd, @Ma_Plvt1, @Ma_Plvt2, @Ma_plvt3, @Ma_lo, @Ma_phi, @Ma_HTTT, @Ma_DKTT, @Ma_spct | Lay du lieu bao cao tong hop 01 |

## 4. Business Logic

### 4.1. LoadData Method

```csharp
protected override bool LoadData()
{
    ArrayList arrayList = new ArrayList();
    arrayList.Add(CompanyInformations.CompanyID);
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
    arrayList.Add(((TextBox)txtMa_ncc).Text);
    arrayList.Add(((TextBox)txtMa_nh_ncc).Text);
    arrayList.Add(((TextBox)txtPl_ncc1).Text);
    arrayList.Add(((TextBox)txtPl_ncc2).Text);
    arrayList.Add(((TextBox)txtPl_ncc3).Text);
    arrayList.Add(((TextBox)txtMa_hd).Text);
    arrayList.Add(((TextBox)txtMa_kho).Text);
    arrayList.Add(((TextBox)txtMa_vtri).Text);
    arrayList.Add(((TextBox)txtMa_vt).Text);
    arrayList.Add(((TextBox)txtMa_nh_vt).Text);
    arrayList.Add(((TextBox)txtMa_Nt).Text);
    arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoaiPhieu).SelectedValue));
    arrayList.Add("");
    arrayList.Add(((TextBox)txtMa_nhhd).
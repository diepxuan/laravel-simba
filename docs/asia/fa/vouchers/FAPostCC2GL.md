# FAPostCC2GL.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FAPostCC2GL.dll |
| **Form Class** | frmFAPostCC2GL |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Post CCDC to GL |

## 2. Chức năng

Form dùng để post (ghi sổ) công cụ dụng cụ (CCDC) sang General Ledger (GL). Đây là chức năng chuyển dữ liệu từ module Fixed Assets sang module kế toán tổng hợp.

## 3. Form Controls

### 3.1 Input Controls

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_ts | AsTextBox | MA_TS | Mã tài sản |
| txtMa_Nhts1 | AsTextBox | MA_NHTS (loai_nh=1) | Mã nhóm tài sản 1 |
| txtMa_Nhts2 | AsTextBox | MA_NHTS (loai_nh=2) | Mã nhóm tài sản 2 |
| txtMa_Nhts3 | AsTextBox | MA_NHTS (loai_nh=3) | Mã nhóm tài sản 3 |
| txtMa_BPSD | AsTextBox | MA_BPSD | Mã bộ phận sử dụng |
| txtMa_Phi | AsTextBox | MA_PHI | Mã phí |
| txtMa_SPCT | AsTextBox | MA_SPCT | Mã sản phẩm công trình |
| txtNgay1 | AsMaskedTextBox | - | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | - | Ngày kết thúc |
| cboKyBc | ComboBox | - | Kỳ báo cáo |
| cboMau_bc | ComboBox | - | Mẫu báo cáo |

### 3.2 Label Controls

| Control | Mô tả |
|---------|-------|
| lblTen_ts | Tên tài sản (hiển thị từ lookup) |
| lblTen_Nhts1 | Tên nhóm tài sản 1 |
| lblTen_Nhts2 | Tên nhóm tài sản 2 |
| lblTen_Nhts3 | Tên nhóm tài sản 3 |
| lblTen_BPSD | Tên bộ phận sử dụng |
| lblTen_Phi | Tên phí |
| lblTen_SPCT | Tên sản phẩm công trình |

## 4. Business Logic

### 4.1 LoadData Method

```csharp
protected override bool LoadData()
{
    ArrayList arrayList = new ArrayList();
    arrayList.Add(CompanyInformations.CompanyID);
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
    arrayList.Add(((TextBox)txtMa_ts).Text.Trim());
    arrayList.Add(((TextBox)txtMa_Nhts1).Text.Trim());
    arrayList.Add(((TextBox)txtMa_Nhts2).Text.Trim());
    arrayList.Add(((TextBox)txtMa_Nhts3).Text.Trim());
    arrayList.Add(((TextBox)txtMa_BPSD).Text.Trim());
    arrayList.Add(((TextBox)txtMa_Phi).Text.Trim());
    arrayList.Add(((TextBox)txtMa_SPCT).Text.Trim());
    set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
    base.MyFomularFields.Clear();
    base.MyFomularFields.Add("strSubTitle1", GetFilterTitle());
    return true;
}
```

### 4.2 GetFilterTitle Method

```csharp
private string GetFilterTitle()
{
    string text = string.Empty;
    if (Operators.CompareString(((TextBox)txtMa_ts).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_ts.Text + ": " + ((TextBox)txtMa_ts).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_Nhts1).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_Nhts1.Text + ": " + ((TextBox)txtMa_Nhts1).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_Nhts2).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_Nhts2.Text + ": " + ((TextBox)txtMa_Nhts2).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_Nhts3).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_Nhts3.Text + ": " + ((TextBox)txtMa_Nhts3).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_BPSD).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_BPSD.Text + ": " + ((TextBox)txtMa_BPSD).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_Phi).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_Phi.Text + ": " + ((TextBox)txtMa_Phi).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_SPCT).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_SPCT.Text + ": " + ((TextBox)txtMa_SPCT).Text + "; ";
    }
    return text;
}
```

## 5. Stored Procedures

Dựa trên phân tích code, các SP được gọi qua `base.MyController.GetData()`:

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FAPostCC2GL_GetData | Lấy dữ liệu CCDC cần post | @Ma_cty, @Ngay1, @Ngay2, @Ma_ts, @Ma_nhts1, @Ma_nhts2, @Ma_nhts3, @Ma_bpsd, @Ma_phi, @Ma_spct |

## 6. PHP Mapping

### 6.1 Form Structure (Blade)

```php
{{-- resources/views/fa/post-cc2gl/index.blade.php --}}
<form id="frmFAPostCC2GL" method="POST" action="{{ route('fa.post-cc2gl.process') }}">
    <div class="row">
        <div class="col-md-6">
            <div class="form-group">
                <label>Từ ngày</label>
                <input type="date" name="ngay1" class="form-control" required>
            </div>
        </div>
        <div class="col-md-6">
            <div class="form-group">
                <label>Đến ngày</label>
                <input type="date" name="ngay2" class="form-control" required>
            </div>
        </div>
    </div>
    
    <div class="row">
        <div class="col-md-6">
            <div class="form-group">
                <label>Mã tài sản</label>
                <x-lookup name="ma_ts" code="MA_TS" :value="$request->ma_ts" />
            </div>
        </div>
        <div class="col-md-6">
            <div class="form-group">
                <label>Mã nhóm TS1</label>
                <x-lookup name="ma_nhts1" code="MA_NHTS" where="loai_nh=1" :value="$request->ma_nhts1" />
            </div>
        </div>
    </div>
    
    <div class="row">
        <div class="col-md-6">
            <div class="form-group">
                <label>Mã nhóm TS2</label>
                <x-lookup name="ma_nhts2" code="MA_NHTS" where="loai_nh=2" :value="$request->ma_nhts2" />
            </div>
        </div>
        <div class="col-md-6">
            <div class="form-group">
                <label>Mã nhóm TS3</label>
                <x-lookup name="ma_nhts3" code="MA_NHTS" where="loai_nh=3" :value="$request->ma_nhts3" />
            </div>
        </div>
    </div>
    
    <div class="row">
        <div class="col-md-6">
            <div class="form-group">
                <label>Mã BPSD</label>
                <x-lookup name="ma_bpsd" code="MA_BPSD" :value="$request->ma_bpsd" />
            </div>
        </div>
        <div class="col-md-6">
            <div class="form-group">
                <label>Mã phí</label>
                <x-lookup name="ma_phi" code="MA_PHI" :value="$request->ma_phi" />
            </div>
        </div>
    </div>
    
    <div class="row">
        <div class="col-md-6">
            <div class="form-group">
                <label>Mã SPCT</label>
                <x-lookup name="ma_spct" code="MA_SPCT" :value="$request->ma_spct" />
            </div>
        </div>
    </div>
    
    <button type="submit" class="btn btn-primary">Post sang GL</button>
</form>
```

### 6.2 Controller (PHP)

```php
<?php
// app/Http/Controllers/FA/PostCC2GLController.php

namespace App\Http\Controllers\FA;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class PostCC2GLController extends Controller
{
    public function index()
    {
        return view('fa.post-cc2gl.index');
    }
    
    public function process(Request $request)
    {
        $validated = $request->validate([
            'ngay1' => 'required|date',
            'ngay2' => 'required|date',
            'ma_ts' => 'nullable|string|max:8',
            'ma_nhts1' => 'nullable|string|max:8',
            'ma_nhts2' => 'nullable|string|max:8',
            'ma_nhts3' => 'nullable|string|max:8',
            'ma_bpsd' => 'nullable|string|max:8',
            'ma_phi' => 'nullable|string|max:8',
            'ma_spct' => 'nullable|string|max:8',
        ]);
        
        $params = [
            'Ma_cty' => session('company_id'),
            'Ngay1' => $validated['ngay1'],
            'Ngay2' => $validated['ngay2'],
            'Ma_ts' => $validated['ma_ts'] ?? '',
            'Ma_nhts1' => $validated['ma_nhts1'] ?? '',
            'Ma_nhts2' => $validated['ma_nhts2'] ?? '',
            'Ma_nhts3' => $validated['ma_nhts3'] ?? '',
            'Ma_bpsd' => $validated['ma_bpsd'] ?? '',
            'Ma_phi' => $validated['ma_phi'] ?? '',
            'Ma_spct' => $validated['ma_spct'] ?? '',
        ];
        
        $data = DB::select('EXEC sp_FAPostCC2GL_GetData ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', array_values($params));
        
        // Process post to GL
        $result = $this->postToGL($data);
        
        return response()->json(['success' => true, 'message' => 'Post thành công']);
    }
    
    private function postToGL($data)
    {
        // Logic post sang GL
        foreach ($data as $row) {
            // Insert into GL tables
        }
    }
}
```

## 7. Database Schema

### 7.1 Tables liên quan

| Table | Mô tả |
|-------|-------|
| FA_CCDC | Danh mục công cụ dụng cụ |
| FA_NhomTS | Nhóm tài sản |
| DM_BPSD | Danh mục bộ phận sử dụng |
| DM_Phi | Danh mục phí |
| DM_SPCT | Danh mục sản phẩm công trình |
| GL_ChiTiet | Chi tiết sổ cái |

## 8. Notes

- Form kế thừa từ `frmReport` nên có đầy đủ chức năng báo cáo
- Các lookup field sử dụng `AsTextBox` với `AutoLookup = true`
- Có validation cho các trường bắt buộc
- Dữ liệu được truyền qua ArrayList đến Controller

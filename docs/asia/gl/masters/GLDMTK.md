# GLDMTK - Danh mục tài khoản

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLDMTK.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Danh mục tài khoản (Chart of Accounts) |

## Chức năng chính

### 1. Quản lý danh mục tài khoản
- Xem danh sách tài khoản kế toán dạng cây phân cấp
- Thêm, sửa, xóa tài khoản
- Quản lý quan hệ cha-con giữa các tài khoản

### 2. Xử lý phân cấp tài khoản
- Tự động xác định tài khoản mẹ (`tk_me`)
- Tính bậc tài khoản (`bac_tk`)
- Đánh dấu in đậm cho tài khoản có con (`bold`)
- Thụt lề tên tài khoản theo bậc

### 3. Kiểm tra tài khoản
- Kiểm tra tài khoản mẹ (`CheckTkMe`)
- Stored Procedure: `asGlCheckTkMe`

## Cột DataGridView (Danh mục tài khoản)

| Cột | Ý nghĩa |
|-----|---------|
| tk | Mã tài khoản |
| ten_tk | Tên tài khoản |
| tk_me | Tài khoản mẹ |
| bac_tk | Bậc tài khoản |
| bold | In đậm (tài khoản mẹ) |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk` | Mã tài khoản |
| `ten_tk` | Tên tài khoản |
| `tk_me` | Tài khoản mẹ |
| `bac_tk` | Bậc tài khoản (cấp độ) |
| `bold` | In đậm (tài khoản có con) |
| `tk_cn` | Tài khoản công nợ |

## Thuật toán xử lý phân cấp

```csharp
// Xác định tài khoản mẹ từ mã TK
// VD: TK 1111 -> TK mẹ: 111
tk_me = tk.Substring(0, tk.Length - 1);

// Tính bậc tài khoản
tk có độ dài 1 -> bac_tk = 1
tk có độ dài 2 -> bac_tk = 2
...

// Thụt lề tên TK theo bậc
ten_tk = new string(' ', (bac_tk - 1) * 3) + ten_tk;
```

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLDMTK` | `frmDMView` | Form xem danh mục tài khoản |
| `frmGLDMTKEdit` | - | Form nhập liệu tài khoản |

## Stored Procedures

| Procedure | Mục đích |
|-----------|----------|
| `asGlCheckTkMe` | Kiểm tra tài khoản mẹ |

## Dependencies

- `System.Data` - Data access
- `AsiaErp.Framework` - Asia ERP Framework
- `Microsoft.VisualBasic` - VB runtime

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLDMTK |
| Assembly Title | Danh mục tài khoản |
| Assembly Company | Asia |
| Assembly Product | - |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 1.0.0.0 |
| GUID | 75e5f283-6eb3-4b69-8524-bf176daa37d0 |

---

*Ngày cập nhật: 2026-03-29*

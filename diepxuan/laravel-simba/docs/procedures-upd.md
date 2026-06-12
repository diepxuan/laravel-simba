# Nhóm asUpd* - Update Procedures

Nhóm `asUpd*` chứa các stored procedure dùng để cập nhật dữ liệu (UPDATE) trong cơ sở dữ liệu. Đây là nhóm quan trọng cho các thao tác sửa đổi thông tin hệ thống, danh mục, người dùng, cấu hình, v.v.

## Tiến độ chuyển đổi

- **Tổng số procedures ước tính**: 37 (theo số file asUpd*.sql).
- **Đã chuyển đổi**: 14 (cập nhật 2026-02-11)
- **Tỷ lệ hoàn thành**: 37.8%

## Danh sách procedures đã chuyển đổi

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asUpdSysVar | `AsUpdSysVar` | `@pMa_cty` (nvarchar(3)), `@pPhan_he` (nvarchar(2)), `@pFieldName` (nvarchar(100)), `@pValue` (sql_variant) | Cập nhật dữ liệu của bảng phân hệ + 'setup' (cấu hình động). |
| asUpdUserInfo | `AsUpdUserInfo` | `@pUserName` (nvarchar(20)), `@pFullName` (nvarchar(50)), `@pIsAdmin` (bit), `@pGrand` (bit), `@pDisabled` (bit), `@pUser` (nvarchar(20)), `@pRet` (int, output) | Cập nhật thông tin người dùng (tên đầy đủ, quyền admin, grand, trạng thái) và xóa nhóm nếu là admin. |
| asUpdDictionaryInfo | `AsUpdDictionaryInfo` | `@pCode_name` (nvarchar(50)), `@pKey_Code_name` (nvarchar(50)), `@pPk` (nvarchar(128)), `@pCode_fname` (nvarchar(50)), `@pMenuid` (nvarchar(8)), `@pCode_length` (int), `@pName_fname` (nvarchar(50)), `@pTable_name` (nvarchar(100)), `@pLookup_when_invalid` (bit), `@pAllow_merge_code` (bit), `@pDllname` (nvarchar(100)), `@pView_class_name` (nvarchar(50)), `@pEdit_class_name` (nvarchar(50)), `@pDescription` (nvarchar(128)), `@pCarry_field_list` (nvarchar(255)), `@pDefault_sort` (nvarchar(128)), `@pCopy_vaora` (bit), `@pRet` (int, output) | Cập nhật thông tin từ điển (danh mục hệ thống) trong bảng sysDictionaryInfo. |
| asUpddaoinfo | `AsUpddaoinfo` | `@pKey_Table_name` (nvarchar(100)), `@pTable_name` (nvarchar(100)), `@pGet_sp` (nvarchar(100)), `@pIns_sp` (nvarchar(100)), `@pUpd_sp` (nvarchar(100)), `@pDel_sp` (nvarchar(100)), `@pSch_sp` (nvarchar(100)), `@pChg_sp` (nvarchar(100)), `@pDescription` (nvarchar(255)), `@pRet` (int, output) | Cập nhật thông tin DAO (Data Access Object) trong bảng sysdaoinfo (các stored procedure liên quan đến bảng). |
| asUpdOptFieldInfo | `AsUpdOptFieldInfo` | `@pStt` (int), `@pCaption` (nvarchar(20)), `@pField` (nvarchar(10)), `@pLUser` (nvarchar(20)), `@pRet` (int, output) | Cập nhật thông tin trường tùy chọn (caption) và xóa thiết lập nếu không sử dụng. |
| asUpdOptFieldSetup | `AsUpdOptFieldSetup` | `@pVoucher_code` (nvarchar(3)), `@pField` (nvarchar(10)), `@pMaster` (bit), `@pDetail` (bit), `@pRet` (int, output) | Cập nhật thiết lập trường tùy chọn (Master/Detail) cho một loại chứng từ. |
| asUpdUserRight | `AsUpdUserRight` | `@pUserName` (nvarchar(20)), `@pUserName_Old` (nvarchar(20)), `@pRet` (int, output) | Cập nhật tên người dùng trong bảng quyền người dùng (sysUserRight). |
| asUpdUserObjectRight | `AsUpdUserObjectRight` | `@pUserName` (nvarchar(20)), `@pMenuID` (nvarchar(8)), `@pObjectName` (nvarchar(50)), `@pViewRight` (nvarchar(1)), `@pEditRight` (nvarchar(1)), `@pAddRight` (nvarchar(1)) | Cập nhật quyền đối tượng cho người dùng (xóa cũ, thêm mới nếu có quyền). |
| asUpdDictionaryResx | `AsUpdDictionaryResx` | `@pKey_Code_name` (nvarchar(50)), `@pKey_Language` (nvarchar(5)), `@pCode_name` (nvarchar(50)), `@pLanguage` (nvarchar(5)), `@pFormated_col_list` (nvarchar(4000)), `@pViewform_size` (varchar), `@pRet` (int, output) | Cập nhật tài nguyên đa ngôn ngữ (resource) cho từ điển (bảng DictionaryResx). |
| asUpdVoucherResx | `AsUpdVoucherResx` | `@pKey_Voucher_code` (nvarchar(50)), `@pKey_Language` (nvarchar(5)), `@pVoucher_code` (nvarchar(50)), `@pLanguage` (nvarchar(5)), `@pPh_formated_col_list` (nvarchar(1000)), `@pCt_formated_col_list` (nvarchar(1000)), `@pDescription` (nvarchar(50)), `@pRet` (int, output) | Cập nhật tài nguyên đa ngôn ngữ (resource) cho chứng từ (bảng sysVoucherResx). |
| asUpdGroupRight | `AsUpdGroupRight` | `@pGroupName` (nvarchar(20)), `@pGroupName_Old` (nvarchar(20)), `@pRet` (int, output) | Cập nhật tên nhóm trong bảng quyền nhóm (sysGroupRight). |
| asUpdGroupInfo | `AsUpdGroupInfo` | `@pGroupname` (nvarchar(20)), `@pFullname` (nvarchar(50)), `@pGrand` (bit), `@pKSD` (bit), `@pUser` (nvarchar(20)) | Cập nhật thông tin nhóm người dùng (tên đầy đủ, quyền grand, trạng thái sử dụng). |
| asUpdOpeningBlanceResx | `AsUpdOpeningBlanceResx` | `@pCode_name` (nvarchar(50)), `@pLanguage` (nvarchar(5)), `@pFormated_col_list` (nvarchar(4000)) | Cập nhật tài nguyên đa ngôn ngữ (resource) cho số dư đầu kỳ (bảng sysOpeningBalanceResx). |
| asUpdcolk | `AsUpdcolk` | `@pMa_cty` (nvarchar(3)), `@pThang` (int), `@pNam` (int), `@pMa_spct` (nvarchar(20)), `@pTk` (nvarchar(20)), `@pTk_du` (nvarchar(20)), `@pPs_no` (decimal), `@pPs_no_nt` (decimal), `@pPs_co` (decimal), `@pPs_co_nt` (decimal), `@pRet` (int, output) | Cập nhật số phát sinh trong bảng colk (chi tiết công trình). |
| asUpdCOdd | `AsUpdCOdd` | `@pMa_cty` (nvarchar(3)), `@pNam` (int), `@pThang` (int), `@pMa_spct` (nvarchar(20)), `@pTK` (nvarchar(20)), `@pSl_kk_ck` (decimal), `@pTy_le_ht` (decimal), `@pSl_dd_ck` (decimal), `@pGt_dd_ck` (decimal), `@pRet` (int, output) | Cập nhật dữ liệu dở dang (codd) trong phân hệ Cost (CO). |
| asUpdDashFrequentlyFunction | `AsUpdDashFrequentlyFunction` | `@pUserName` (nvarchar(20)), `@pMenuID` (nvarchar(8)), `@pDashID` (int), `@pSpace` (bit), `@pRet` (int, output) | Cập nhật khoảng cách giãn dòng giữa các chức năng thường dùng trên dashboard. |
| asUpdDashLocation | `AsUpdDashLocation` | `@pUserName` (nvarchar(20)), `@pDashIdSrc` (int), `@pLocationTar` (int), `@pXTar` (int), `@pYTar` (int), `@pHSrc` (int), `@pWSrc` (int), `@pRet` (int, output) | Di chuyển các Dashlet trên dashboard (cập nhật vị trí và kích thước). |

## Các procedures chưa chuyển đổi

Các file asUpd*.sql còn lại sẽ được xử lý theo thứ tự alphabet.


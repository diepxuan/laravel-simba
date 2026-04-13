# Human Resources (HR) - Quản lý nhân sự

Module quản lý toàn bộ vòng đời nhân viên từ tuyển dụng, hợp đồng, chấm công, tính lương đến đánh giá và phát triển.

---

## Tổng quan

**Purpose:** Quản lý toàn bộ quy trình nhân sự bao gồm tuyển dụng, hồ sơ nhân viên, hợp đồng lao động, chấm công, tính lương, đào tạo và đánh giá.

**Key Functions:**
- Tuyen dung (Recruitment) - Quan ly ung vien, phong van, tuyen chon
- Ho so nhan su (Employee Records) - Thong tin ca nhan, hop dong, qua trinh
- Cham cong (Timekeeping) - Theo doi ngay cong, nghi phep
- Tinh luong (Payroll) - Tinh toan luong, thuong, phu cap
- Danh gia (Performance Evaluation) - Danh gia nhan vien dinh ky
- Dao tao (Training) - Quan ly khoa hoc, hoc vien
- Bao hiem xa hoi (Social Insurance) - Quan ly BHXH, BHYT, BHTN

---

## Database Tables

### Core Employee Tables (Bang nhan vien chinh)
```
HrHSNS          - Ho so nhan su (Employee master)
HrHSNSPhuCap    - Phu cap nhan vien (Employee allowances)
HrQuanHeNV      - Quan he nhan vien (Employee relationships)
HrQTGhiChu      - Ghi chu nhan vien (Employee notes)
```

### Contract & Process Tables (Hop dong va qua trinh)
```
HrQTHopDongLD   - Hop dong lao dong (Labor contracts)
HrQTCongTac     - Qua trinh cong tac (Work history)
HrQTCuTru       - Qua trinh cu tru (Residence history)
HrQTKyNang      - Ky nang nhan vien (Employee skills)
HrQTKNCongTac   - Kinh nghiem cong tac (Experience)
HrQTHocTap      - Qua trinh hoc tap (Education history)
HrQTKhenThuong  - Khen thuong ky luat (Rewards/Discipline)
HrQTCapCongCu   - Cap cong cu dung cu (Tool issuance)
HrQTTheChe      - The che nhan vien (Employee ID cards)
HrQTNghiCheDo   - Nghi che do (Leave records)
HrQTLuong       - Qua trinh luong (Salary history)
HrQTDanhGiaPH   - Danh gia nhan vien (Performance eval header)
HrQTDanhGiaCT   - Chi tiet danh gia (Performance eval detail)
HrQTBHXH        - Bao hiem xa hoi (Social insurance)
```

### Recruitment Tables (Tuyen dung)
```
HrTDYeuCau      - Yeu cau tuyen dung (Recruitment requests)
HrTDUngVien     - Ung vien (Candidates)
HrTDVongThi     - Vong thi tuyen (Interview rounds)
HrTDDeThi       - De thi tuyen dung (Test questions)
HrTDKetQua      - Ket qua tuyen dung (Recruitment results)
HrTDHoiDong     - Hoi dong tuyen dung (Interview panel)
HrDTHocVien     - Hoc vien dao tao (Trainees)
HrDTKhoa        - Khoa dao tao (Training courses)
HrDTLop         - Lop dao tao (Training classes)
```

### Timekeeping Tables (Cham cong)
```
HrChamCong      - Cham cong thang (Monthly timekeeping)
HrChamCongKhac  - Cham cong khac (Other timekeeping)
```

### Master Data Tables (Danh muc)
```
HrDmThangBangLuong    - Thang bang luong (Salary scale)
HrDmNgachBac          - Ngach bac luong (Salary grades)
HrDmLuongToiThieu     - Luong toi thieu (Minimum wage)
HrDmPhanCapHanhChinh  - Phan cap hanh chinh (Administrative levels)
HrDmCheDoNghi         - Che do nghi (Leave types)
HrDmCCTC              - Chi phi tien cong (Labor cost types)
HrDmKhac              - Danh muc khac (Other masters)
HrDmKhacDs            - Danh muc khac DS (Other master lists)
HrDmKhacDsResx        - Resource danh muc khac
HrDmKQDanhGia         - Ket qua danh gia (Evaluation results)
HrDmNhomDanhGiaPH     - Nhom danh gia header (Eval group header)
HrDmNhomDanhGiaCT     - Nhom danh gia detail (Eval group detail)
HrDmTCDanhGiaPH       - Tieu chi danh gia header (Criteria header)
HrDmTCDanhGiaCT       - Tieu chi danh gia detail (Criteria detail)
HrHsNsTab             - Tab ho so nhan su (Employee tabs)
HrHsNsTabResx         - Resource tab ho so
HrSetup               - Cau hinh module HR
```

---

## Stored Procedures

**Tong so:** 172 procedures

### Categories

#### 1. Get Operations (Doc du lieu) - 43 procedures
```
asHrGetHSNS              - Doc ho so nhan su
asHrGetHSNSPhuCap        - Doc phu cap nhan vien
asHrGetQuanHeNV          - Doc quan he nhan vien
asHrGetQTGhiChuNV        - Doc ghi chu nhan vien
asHrGetQTHopDongLD       - Doc hop dong lao dong
asHrGetQTCongTac         - Doc qua trinh cong tac
asHrGetQTCuTru           - Doc qua trinh cu tru
asHrGetQTKyNang          - Doc ky nang nhan vien
asHrGetQTKNCongTac       - Doc kinh nghiem cong tac
asHrGetQTHocTap          - Doc qua trinh hoc tap
asHrGetQTKhenThuong      - Doc khen thuong ky luat
asHrGetQTCapCongCu       - Doc cap cong cu
asHrGetQTTheChe          - Doc the che nhan vien
asHrGetQTNghiCheDo       - Doc nghi che do
asHrGetQTLuong           - Doc qua trinh luong
asHrGetQTDanhGiaPH       - Doc danh gia nhan vien
asHrGetQTDanhGiaCT       - Doc chi tiet danh gia
asHrGetQTBHXH            - Doc bao hiem xa hoi
asHrGetTDYeuCau          - Doc yeu cau tuyen dung
asHrGetTDUngVien         - Doc ung vien
asHrGetTDVongThi         - Doc vong thi tuyen
asHrGetTDDeThi           - Doc de thi tuyen dung
asHrGetTDKetQua          - Doc ket qua tuyen dung
asHrGetTDHoiDong         - Doc hoi dong tuyen dung
asHrGetDTHocVien         - Doc hoc vien dao tao
asHrGetDTKhoa            - Doc khoa dao tao
asHrGetDTLop             - Doc lop dao tao
asHrGetChamCong          - Doc cham cong
asHrGetChamCongKhac      - Doc cham cong khac
asHrGetDmThangBangLuong  - Doc thang bang luong
asHrGetDmNgachBac        - Doc ngach bac luong
asHrGetDmLuongToiThieu   - Doc luong toi thieu
asHrGetDmPhanCapHanhChinh - Doc phan cap hanh chinh
asHrGetDmCheDoNghi       - Doc che do nghi
asHrGetDmCCTC            - Doc chi phi tien cong
asHrGetDmKhac            - Doc danh muc khac
asHrGetDmKhacDs          - Doc danh muc khac DS
asHrGetDmKhacDsResx      - Doc resource danh muc
asHrGetDmKQDanhGia       - Doc ket qua danh gia
asHrGetDmNhomDanhGiaPH   - Doc nhom danh gia PH
asHrGetDmNhomDanhGiaCT   - Doc nhom danh gia CT
asHrGetDmTCDanhGiaPH     - Doc tieu chi danh gia PH
asHrGetDmTCDanhGiaCT     - Doc tieu chi danh gia CT
```

#### 2. Insert Operations (Them moi) - 44 procedures
```
asHrInsHSNS              - Them ho so nhan su
asHrInsHSNSPhuCap        - Them phu cap nhan vien
asHrInsQuanHeNV          - Them quan he nhan vien
asHrInsQTGhiChuNV        - Them ghi chu nhan vien
asHrInsQTHopDongLD       - Them hop dong lao dong
asHrInsQTCongTac         - Them qua trinh cong tac
asHrInsQTCuTru           - Them qua trinh cu tru
asHrInsQTKyNang          - Them ky nang nhan vien
asHrInsQTKNCongTac       - Them kinh nghiem cong tac
asHrInsQTHocTap          - Them qua trinh hoc tap
asHrInsQTKhenThuong      - Them khen thuong ky luat
asHrInsQTCapCongCu       - Them cap cong cu
asHrInsQTTheChe          - Them the che nhan vien
asHrInsQTNghiCheDo       - Them nghi che do
asHrQTInsNghiCheDo       - Them nghi che do (variant)
asHrInsQTLuong           - Them qua trinh luong
asHrInsQTDanhGiaPH       - Them danh gia nhan vien
asHrInsQTDanhGiaCT       - Them chi tiet danh gia
asHrInsQTBHXH            - Them bao hiem xa hoi
asHrInsTDYeuCau          - Them yeu cau tuyen dung
asHrInsTDUngVien         - Them ung vien
asHrInsTDVongThi         - Them vong thi tuyen
asHrInsTDDeThi           - Them de thi tuyen dung
asHrInsTDKetQua          - Them ket qua tuyen dung
asHrInsTDHoiDong         - Them hoi dong tuyen dung
asHrInsDTHocVien         - Them hoc vien dao tao
asHrInsDTKhoa            - Them khoa dao tao
asHrInsDTLop             - Them lop dao tao
asHrInsChamCong          - Them cham cong
asHrInsChamCongKhac      - Them cham cong khac
asHrInsDmThangBangLuong  - Them thang bang luong
asHrInsDmNgachBac        - Them ngach bac luong
asHrInsDmLuongToiThieu   - Them luong toi thieu
asHrInsDmPhanCapHanhChinh - Them phan cap hanh chinh
asHrInsDmCheDoNghi       - Them che do nghi
asHrInsDmCCTC            - Them chi phi tien cong
asHrInsDmKhac            - Them danh muc khac
asHrInsDmKhacDs          - Them danh muc khac DS
asHrInsDmKhacDsResx      - Them resource danh muc
asHrInsDmKQDanhGia       - Them ket qua danh gia
asHrInsDmNhomDanhGiaPH   - Them nhom danh gia PH
asHrInsDmNhomDanhGiaCT   - Them nhom danh gia CT
asHrInsDmTCDanhGiaPH     - Them tieu chi danh gia PH
asHrInsDmTCDanhGiaCT     - Them tieu chi danh gia CT
```

#### 3. Update Operations (Cap nhat) - 43 procedures
```
asHrUpdHSNS              - Cap nhat ho so nhan su
asHrUpdHSNSPhuCap        - Cap nhat phu cap nhan vien
asHrUpdQuanHeNV          - Cap nhat quan he nhan vien
asHrUpdQTGhiChuNV        - Cap nhat ghi chu nhan vien
asHrUpdQTHopDongLD       - Cap nhat hop dong lao dong
asHrUpdQTCongTac         - Cap nhat qua trinh cong tac
asHrUpdQTCuTru           - Cap nhat qua trinh cu tru
asHrUpdQTKyNang          - Cap nhat ky nang nhan vien
asHrUpdQTKNCongTac       - Cap nhat kinh nghiem cong tac
asHrUpdQTHocTap          - Cap nhat qua trinh hoc tap
asHrUpdQTKhenThuong      - Cap nhat khen thuong ky luat
asHrUpdQTCapCongCu       - Cap nhat cap cong cu
asHrUpdQTTheChe          - Cap nhat the che nhan vien
asHrUpdQTNghiCheDo       - Cap nhat nghi che do
asHrUpdQTLuong           - Cap nhat qua trinh luong
asHrUpdQTDanhGiaPH       - Cap nhat danh gia nhan vien
asHrUpdQTDanhGiaCT       - Cap nhat chi tiet danh gia
asHrUpdQTBHXH            - Cap nhat bao hiem xa hoi
asHrUpdTDYeuCau          - Cap nhat yeu cau tuyen dung
asHrUpdTDUngVien         - Cap nhat ung vien
asHrUpdTDVongThi         - Cap nhat vong thi tuyen
asHrUpdTDDeThi           - Cap nhat de thi tuyen dung
asHrUpdTDKetQua          - Cap nhat ket qua tuyen dung
asHrUpdTDHoiDong         - Cap nhat hoi dong tuyen dung
asHrUpdDTHocVien         - Cap nhat hoc vien dao tao
asHrUpdDTKhoa            - Cap nhat khoa dao tao
asHrUpdDTLop             - Cap nhat lop dao tao
asHrUpdChamCong          - Cap nhat cham cong
asHrUpdChamCongKhac      - Cap nhat cham cong khac
asHrUpdDmThangBangLuong  - Cap nhat thang bang luong
asHrUpdDmNgachBac        - Cap nhat ngach bac luong
asHrUpdDmLuongToiThieu   - Cap nhat luong toi thieu
asHrUpdDmPhanCapHanhChinh - Cap nhat phan cap hanh chinh
asHrUpdDmCheDoNghi       - Cap nhat che do nghi
asHrUpdDmCCTC            - Cap nhat chi phi tien cong
asHrUpdDmKhac            - Cap nhat danh muc khac
asHrUpdDmKhacDs          - Cap nhat danh muc khac DS
asHrUpdDmKhacDsResx      - Cap nhat resource danh muc
asHrUpdDmKQDanhGia       - Cap nhat ket qua danh gia
asHrUpdDmNhomDanhGiaPH   - Cap nhat nhom danh gia PH
asHrUpdDmNhomDanhGiaCT   - Cap nhat nhom danh gia CT
asHrUpdDmTCDanhGiaPH     - Cap nhat tieu chi danh gia PH
asHrUpdDmTCDanhGiaCT     - Cap nhat tieu chi danh gia CT
```

#### 4. Delete Operations (Xoa) - 41 procedures
```
asHrDelHSNS              - Xoa ho so nhan su
asHrDelHSNSPhuCap        - Xoa phu cap nhan vien
asHrDelQuanHeNV          - Xoa quan he nhan vien
asHrDelQTGhiChuNV        - Xoa ghi chu nhan vien
asHrDelQTHopDongLD       - Xoa hop dong lao dong
asHrDelQTCongTac         - Xoa qua trinh cong tac
asHrDelQTCuTru           - Xoa qua trinh cu tru
asHrDelQTKyNang          - Xoa ky nang nhan vien
asHrDelQTKNCongTac       - Xoa kinh nghiem cong tac
asHrDelQTHocTap          - Xoa qua trinh hoc tap
asHrDelQTKhenThuong      - Xoa khen thuong ky luat
asHrDelQTCapCongCu       - Xoa cap cong cu
asHrDelQTTheChe          - Xoa the che nhan vien
asHrDelQTNghiCheDo       - Xoa nghi che do
asHrDelQTLuong           - Xoa qua trinh luong
asHrDelQTDanhGiaPH       - Xoa danh gia nhan vien
asHrDelQTDanhGiaCT       - Xoa chi tiet danh gia
asHrDelQTBHXH            - Xoa bao hiem xa hoi
asHrDelTDYeuCau          - Xoa yeu cau tuyen dung
asHrDelTDUngVien         - Xoa ung vien
asHrDelTDVongThi         - Xoa vong thi tuyen
asHrDelTDDeThi           - Xoa de thi tuyen dung
asHrDelTDKetQua          - Xoa ket qua tuyen dung
asHrDelTDHoiDong         - Xoa hoi dong tuyen dung
asHrDelDTHocVien         - Xoa hoc vien dao tao
asHrDelDTKhoa            - Xoa khoa dao tao
asHrDelDTLop             - Xoa lop dao tao
asHrDelChamCong          - Xoa cham cong
asHrDelChamCongKhac      - Xoa cham cong khac
asHrDelDmThangBangLuong  - Xoa thang bang luong
asHrDelDmNgachBac        - Xoa ngach bac luong
asHrDelDmLuongToiThieu   - Xoa luong toi thieu
asHrDelDmPhanCapHanhChinh - Xoa phan cap hanh chinh
asHrDelDmCheDoNghi       - Xoa che do nghi
asHrDelDmCCTC            - Xoa chi phi tien cong
asHrDelDmKhac            - Xoa danh muc khac
asHrDelDmKhacDs          - Xoa danh muc khac DS
asHrDelDmKhacDsResx      - Xoa resource danh muc
asHrDelDmKQDanhGia       - Xoa ket qua danh gia
asHrDelDmNhomDanhGiaPH   - Xoa nhom danh gia PH
asHrDelDmNhomDanhGiaCT   - Xoa nhom danh gia CT
asHrDelDmTCDanhGiaPH     - Xoa tieu chi danh gia PH
asHrDelDmTCDanhGiaCT     - Xoa tieu chi danh gia CT
```

#### 5. Report Operations (Bao cao) - 1 procedure
```
asHrRptTSA01a            - Bao cao TSA 01a
```

---

## Business Flows

### 1. Recruitment Process (Quy trinh tuyen dung)
```
Yeu cau tuyen dung
      ↓
1. asHrInsTDYeuCau - Tao yeu cau tuyen dung
      ↓
2. Phe duyet yeu cau
      ↓
3. asHrInsTDUngVien - Tiep nhan ung vien
      ↓
4. asHrInsTDVongThi - To chuc cac vong thi
      ↓
5. asHrInsTDDeThi - Thiet ke de thi
      ↓
6. asHrInsTDKetQua - Danh gia ket qua
      ↓
7. asHrInsTDHoiDong - Thanh lap hoi dong
      ↓
8. Quyet dinh tuyen dung
      ↓
9. Chuyen sang ho so nhan su
```

### 2. Employee Onboarding (Tiep nhan nhan vien)
```
Nhan vien moi
      ↓
1. asHrInsHSNS - Tao ho so nhan su
      ↓
2. asHrInsQTHopDongLD - Ky hop dong lao dong
      ↓
3. asHrInsQTCongTac - Ghi nhan qua trinh cong tac
      ↓
4. asHrInsQTCuTru - Dang ky noi cu tru
      ↓
5. asHrInsQTBHXH - Dang ky bao hiem
      ↓
6. asHrInsHSNSPhuCap - Thiet lap phu cap
      ↓
7. asHrInsQTTheChe - Cap the nhan vien
      ↓
8. Kich hoat tai khoan he thong
```

### 3. Timekeeping Process (Cham cong)
```
Dau thang
      ↓
1. asHrInsChamCong - Tao bang cham cong thang
      ↓
2. Nhap lieu ngay cong hang ngay
      ↓
3. asHrUpdChamCong - Cap nhat cham cong
      ↓
4. Tinh ngay cong thuc te
      ↓
5. asHrInsChamCongKhac - Ghi nhan cham cong dac biet
      ↓
6. Kiem tra va phe duyet
      ↓
7. Chuyen sang tinh luong
```

### 4. Payroll Process (Tinh luong)
```
Cuoi thang
      ↓
1. Lay du lieu cham cong
      ↓
2. asHrGetQTLuong - Lay qua trinh luong hien tai
      ↓
3. Tinh luong co ban
      ↓
4. asHrGetHSNSPhuCap - Tinh cac khoan phu cap
      ↓
5. Tinh cac khoan thuong
      ↓
6. Tru bao hiem xa hoi
      ↓
7. Tru thue TNCN
      ↓
8. asHrInsQTLuong - Luu qua trinh luong
      ↓
9. Post to GL (asGLPost*)
```

### 5. Performance Evaluation (Danh gia nhan vien)
```
Dinh ky (6 thang / 1 nam)
      ↓
1. asHrInsDmTCDanhGiaPH/CT - Thiet lap tieu chi danh gia
      ↓
2. asHrInsQTDanhGiaPH - Tao phieu danh gia
      ↓
3. asHrInsQTDanhGiaCT - Danh gia chi tiet tung tieu chi
      ↓
4. Nhan vien tu danh gia
      ↓
5. Quan ly danh gia
      ↓
6. Hoi dong danh gia (neu co)
      ↓
7. asHrUpdQTDanhGiaPH - Cap nhat ket qua
      ↓
8. asHrInsDmKQDanhGia - Luu ket qua danh gia
      ↓
9. Quyet dinh thuong / thang tien
```

### 6. Training Management (Quan ly dao tao)
```
Ke hoach dao tao
      ↓
1. asHrInsDTKhoa - Tao khoa dao tao
      ↓
2. asHrInsDTLop - Mo lop dao tao
      ↓
3. asHrInsDTHocVien - Dang ky hoc vien
      ↓
4. To chuc khai giang
      ↓
5. Theo doi tien do
      ↓
6. asHrUpdDTHocVien - Cap nhat ket qua
      ↓
7. Cap chung chi
      ↓
8. asHrInsQTKyNang - Cap nhat ky nang nhan vien
```

### 7. Leave Management (Quan ly nghi phep)
```
Nhan vien xin nghi
      ↓
1. asHrGetDmCheDoNghi - Kiem tra loai nghi
      ↓
2. asHrQTInsNghiCheDo - Tao don xin nghi
      ↓
3. Phe duyet don nghi
      ↓
4. asHrUpdQTNghiCheDo - Cap nhat trang thai
      ↓
5. Cap nhat cham cong
      ↓
6. Tinh luong (tru/nguyen luong)
```

---

## Key Parameters

### Common Parameters
```sql
@pMa_cty         -- Ma cong ty (Company ID)
@pId             -- Ma nhan vien (Employee ID)
@pNam            -- Nam (Year)
@pThang          -- Thang (Month)
@pId_qthdld      -- Ma hop dong (Contract ID)
@pId_qtluong     -- Ma qua trinh luong (Salary process ID)
@pMa_cv          -- Ma chuc vu (Position code)
@pMa_bp          -- Ma bo phan (Department code)
@pMa_ngach       -- Ma ngach luong (Salary grade)
@pMa_bac         -- Ma bac luong (Salary level)
@pLUser          -- Login user (User ID)
@pRet            -- Return code (output)
```

### Employee Data Parameters
```sql
@pHo_ten         -- Ho ten (Full name)
@pNgay_sinh      -- Ngay sinh (Birth date)
@pGioi_tinh      -- Gioi tinh (Gender)
@pSo_cmnd        -- So CMND/CCCD (ID number)
@pNgay_cap       -- Ngay cap (Issue date)
@pNoi_cap        -- Noi cap (Issue place)
@pDia_chi        -- Dia chi (Address)
@pDien_thoai     -- Dien thoai (Phone)
@pEmail          -- Email
```

### Contract Parameters
```sql
@pLoai_hd        -- Loai hop dong (Contract type)
@pNgay_hd        -- Ngay hop dong (Contract date)
@pNgay_bdlam     -- Ngay bat dau lam (Start date)
@pNgay_ktlam     -- Ngay ket thuc lam (End date)
@pMuc_luong      -- Muc luong (Salary amount)
```

### Timekeeping Parameters
```sql
@pNgay_cong      -- Ngay cong (Working days)
@pNghi_phep      -- Nghi phep (Leave days)
@pNghi_le        -- Nghi le (Holiday)
@pNghi_khong_phep -- Nghi khong phep (Unpaid leave)
```

---

## Usage Examples

### 1. Create Employee Record
```sql
-- Tao ho so nhan su
DECLARE @output_ret INT

EXEC asHrInsHSNS
    @pMa_cty = '001',
    @pId = 'NV001',
    @pHo_ten = N'Nguyen Van A',
    @pNgay_sinh = '1990-01-15',
    @pGioi_tinh = '1',
    @pSo_cmnd = '001090001234',
    @pNgay_cap = '2010-05-20',
    @pNoi_cap = N'TP.HCM',
    @pDia_chi = N'123 Nguyen Van Linh, Q7, TP.HCM',
    @pDien_thoai = '0901234567',
    @pEmail = 'nva@company.com',
    @pMa_bp = 'IT',
    @pMa_cv = 'DEV',
    @pLUser = 'admin',
    @pRet = @output_ret OUTPUT
```

### 2. Create Labor Contract
```sql
-- Tao hop dong lao dong
EXEC asHrInsQTHopDongLD
    @pMa_cty = '001',
    @pId = 'NV001',
    @pId_qthdld = '001',
    @pLoai_hd = '1',  -- Hop dong xac dinh thoi han
    @pNgay_hd = '2026-01-01',
    @pNgay_bdlam = '2026-01-01',
    @pNgay_ktlam = '2027-12-31',
    @pMuc_luong = 15000000,
    @pLUser = 'admin',
    @pRet = @output_ret OUTPUT
```

### 3. Create Timekeeping Record
```sql
-- Tao bang cham cong
EXEC asHrInsChamCong
    @pMa_cty = '001',
    @pNam = 2026,
    @pThang = 3,
    @pId = 'NV001',
    @pNgay_cong = 22,
    @pNghi_phep = 2,
    @pNghi_le = 1,
    @pLUser = 'admin',
    @pRet = @output_ret OUTPUT
```

### 4. Create Salary Process
```sql
-- Tao qua trinh luong
EXEC asHrInsQTLuong
    @pMa_cty = '001',
    @pId = 'NV001',
    @pId_qtluong = '001',
    @pNgay_bdlam = '2026-01-01',
    @pMuc_luong = 15000000,
    @pPhu_cap = 3000000,
    @pLUser = 'admin',
    @pRet = @output_ret OUTPUT
```

### 5. Create Performance Evaluation
```sql
-- Tao danh gia nhan vien
EXEC asHrInsQTDanhGiaPH
    @pMa_cty = '001',
    @pId = 'NV001',
    @pKy_danh_gia = 'Q1/2026',
    @pNgay_danh_gia = '2026-03-31',
    @pNguoi_danh_gia = 'MGR001',
    @pLUser = 'admin',
    @pRet = @output_ret OUTPUT

-- Chi tiet danh gia
EXEC asHrInsQTDanhGiaCT
    @pMa_cty = '001',
    @pId = 'NV001',
    @pKy_danh_gia = 'Q1/2026',
    @pMa_tieu_chi = 'TC001',
    @pDiem = 85,
    @pNhan_xet = N'Hoan thanh tot nhiem vu',
    @pLUser = 'admin',
    @pRet = @output_ret OUTPUT
```

### 6. Create Recruitment Request
```sql
-- Tao yeu cau tuyen dung
EXEC asHrInsTDYeuCau
    @pMa_cty = '001',
    @pMa_yeu_cau = 'TD001',
    @pMa_bp = 'IT',
    @pMa_cv = 'DEV',
    @pSo_luong = 2,
    @pNgay_can = '2026-04-01',
    @pLy_do = N'Mo rong du an',
    @pLUser = 'admin',
    @pRet = @output_ret OUTPUT
```

### 7. Create Social Insurance Record
```sql
-- Tao bao hiem xa hoi
EXEC asHrInsQTBHXH
    @pMa_cty = '001',
    @pId = 'NV001',
    @pSo_bhxh = '0012345678',
    @pSo_bhyt = '01A1234567',
    @pSo_bhtn = 'TN001234',
    @pNgay_tham_gia = '2026-01-01',
    @pMuc_dong = 15000000,
    @pLUser = 'admin',
    @pRet = @output_ret OUTPUT
```

---

## Integration Points

### 1. General Ledger (GL)
- Tinh luong → Post vao GL
- Cac khoan trich BHXH, BHYT, BHTN → Post vao GL
- Accounts: 334 (Phai tra nguoi lao dong), 338 (Cac khoan phai nop)
- Procedures: asGLPost*, asPostHr*

### 2. Salary & Allowances (SA)
- Tinh luong → SA module
- Phu cap → SA module
- Link: HrQTLuong → SA

### 3. Fixed Assets (FA)
- Cap cong cu dung cu → FA module
- Link: HrQTCapCongCu → FaDmCc

### 4. Cost Accounting (CO)
- Chi phi nhan cong → CO module
- Link: HrChamCong → CoDd

---

## Validation Rules

### 1. Employee ID Validation
```
Id is unique per company
Id format: NV + 3 digits
Khong duoc trung Id voi nhan vien dang lam viec
```

### 2. Contract Validation
```
Ngay_ktlam > Ngay_bdlam
Muc_luong >= Luong_toi_thieu
Hop dong phai co loai hop dong hop le
Khong duoc ky hop dong chong che
```

### 3. Timekeeping Validation
```
Ngay_cong + Nghi_phep + Nghi_le + Nghi_khong_phep = Tong ngay trong thang
Ngay_cong <= 26 (quy dinh)
Nghi_phep <= So ngay phep con lai
```

### 4. Salary Validation
```
Muc_luong >= HrDmLuongToiThieu
Phu_cap >= 0
Tong thu nhap >= Luong toi thieu vung
```

### 5. Social Insurance Validation
```
So_bhxh is unique
So_bhyt is unique
Muc_dong <= 20 * Luong_toi_thieu (tran muc dong)
Ngay_tham_gia >= Ngay_bdlam
```

---

## Error Handling

### Common Errors
```
Error 5001 - Ma nhan vien da ton tai
Error 5002 - Ma nhan vien khong ton tai
Error 5003 - Hop dong khong hop le
Error 5004 - Ngay hop dong khong hop le
Error 5005 - Muc luong thap hon luong toi thieu
Error 5006 - So BHXH da ton tai
Error 5007 - So CMND da ton tai
Error 5008 - Ngay cham cong khong hop le
Error 5009 - So ngay nghi vuot qua phep con lai
Error 5010 - Ky danh gia khong hop le
Error 5011 - Ung vien da ton tai
Error 5012 - Ma ung vien khong ton tai
Error 5013 - Khong duoc xoa nhan vien da co hop dong
Error 5014 - Khong duoc sua nhan vien da nghi viec
```

### Error Handling Pattern
```sql
BEGIN TRY
    BEGIN TRANSACTION
    
    -- Business logic
    EXEC asHrInsHSNS ...
    
    IF @pRet < 0
    BEGIN
        RAISERROR('Failed to create employee', 16, 1)
        ROLLBACK
        RETURN
    END
    
    COMMIT
END TRY
BEGIN CATCH
    ROLLBACK
    DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE()
    RAISERROR(@ErrMsg, 16, 1)
    RETURN -1
END CATCH
```

---

## Performance Guidelines

### Indexing Strategy
```sql
-- Recommended indexes
CREATE INDEX IX_HrHSNS_Ma_bp ON HrHSNS(Ma_bp)
CREATE INDEX IX_HrHSNS_Ma_cv ON HrHSNS(Ma_cv)
CREATE INDEX IX_HrQTHopDongLD_Id ON HrQTHopDongLD(Id)
CREATE INDEX IX_HrQTLuong_Id ON HrQTLuong(Id)
CREATE INDEX IX_HrChamCong_Nam_Thang ON HrChamCong(Nam, Thang)
CREATE INDEX IX_HrChamCong_Id ON HrChamCong(Id)
```

### Query Optimization
```sql
-- Bad: Full table scan
SELECT * FROM HrHSNS WHERE Ma_cty = '001'

-- Good: Indexed seek
SELECT * FROM HrHSNS 
WHERE Ma_cty = '001' 
  AND Ma_bp = 'IT'
ORDER BY Id
```

### Batch Operations
```sql
-- Use batch size for large payroll calculations
DECLARE @BatchSize INT = 100
WHILE EXISTS (SELECT 1 FROM #TempPayroll WHERE Processed = 0)
BEGIN
    UPDATE TOP (@BatchSize) HrQTLuong
    SET ...
    FROM #TempPayroll
    WHERE Processed = 0
    
    UPDATE TOP (@BatchSize) #TempPayroll
    SET Processed = 1
END
```

---

## Security & Permissions

### Role-based Access
```
ROLE_HR_ADMIN       - Full access to all HR operations
ROLE_HR_CREATE      - Create employee records only
ROLE_HR_VIEW        - View only (no edit)
ROLE_HR_PAYROLL     - Payroll processing only
ROLE_HR_RECRUIT     - Recruitment operations only
ROLE_HR_TRAINING    - Training management only
ROLE_HR_REPORT      - Generate reports only
```

### Row-level Security
```sql
-- Users chi thay data cua company duoc assign
CREATE VIEW HrHSNS_vw AS
SELECT * FROM HrHSNS
WHERE Ma_cty IN (SELECT Ma_cty FROM UserRights WHERE User = CURRENT_USER)
```

### Field-level Security
```
Sensitive fields (restricted):
- Muc_luong (salary) - for HR managers only
- So_cmnd (ID number) - for HR only
- Thong tin ca nhan - restricted access
```

---

## Audit Trail

### Tracked Fields
```
LUser       - Login user who created
LDate       - Login date (timestamp)
MUser       - Last modified user
MDate       - Last modified date
CUser       - Created user
CDate       - Created date
```

### Audit Queries
```sql
-- Audit trail cho nhan vien
SELECT * FROM HrHSNS 
WHERE Ma_cty = '001' 
  AND LDate >= '2026-03-01'
ORDER BY LDate DESC

-- User activity log
SELECT LUser, COUNT(*) as RecordCount, MIN(LDate) as FirstEntry, MAX(LDate) as LastEntry
FROM HrHSNS
WHERE Ma_cty = '001'
GROUP BY LUser
ORDER BY RecordCount DESC

-- Lich su thay doi luong
SELECT Id, Muc_luong, MDate, MUser
FROM HrQTLuong
WHERE Id = 'NV001'
ORDER BY MDate DESC
```

---

## Month-End Payroll Checklist

### Pre-Payroll
- [ ] All timekeeping data entered
- [ ] All leave records approved
- [ ] New employees onboarded
- [ ] Terminated employees processed
- [ ] Salary adjustments entered
- [ ] New contracts activated

### Payroll Steps
1. [ ] Review timekeeping summary
2. [ ] Calculate base salaries
3. [ ] Calculate allowances
4. [ ] Calculate bonuses
5. [ ] Deduct social insurance
6. [ ] Deduct health insurance
7. [ ] Deduct unemployment insurance
8. [ ] Calculate PIT
9. [ ] Generate payslips
10. [ ] Post to GL

### Post-Payroll
- [ ] Payroll report reviewed
- [ ] GL entries reconciled
- [ ] Bank transfer files generated
- [ ] Payslips distributed
- [ ] SI reports submitted
- [ ] PIT declarations prepared

---

## Related Documentation

- [docs/DATA_DICTIONARY.md](../../docs/DATA_DICTIONARY.md) - Column definitions
- [docs/STATE_MACHINES.md](../../docs/STATE_MACHINES.md) - Status transitions
- [docs/08_ERROR_HANDLING_STANDARD.md](../../docs/08_ERROR_HANDLING_STANDARD.md) - Error handling
- [docs/09_NAMING_CONVENTION.md](../../docs/09_NAMING_CONVENTION.md) - Naming standards
- [docs/modules/SA/README.md](../SA/README.md) - Salary module
- [docs/modules/GL/README.md](../GL/README.md) - General Ledger module

---

## Change History

| Date | Version | Change | Author |
|------|---------|--------|--------|
| 2026-03-11 | 1.0 | Initial HR module documentation | Bột |

---

*Last updated: 2026-03-11*


---

## Technical Reference

| Document | Description |
|----------|-------------|
| [Database Schema](../../dbo/Tables/) | Cấu trúc bảng dữ liệu |
| [Module Index](../../catalog/PROCEDURES.md) | Danh mục procedures |

## Related Modules

| Module | Description |
|--------|-------------|
| [GL](../GL/) | General Ledger - Sổ cái |
| [SA](../SA/) | Salary - Tiền lương |

---

# End of HR Module Documentation

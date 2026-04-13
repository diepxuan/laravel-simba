# Kế Hoạch Tái Cấu Trúc Documentation ASIA

Tài liệu này mô tả kế hoạch tái cấu trúc thư mục `docs/asia/` để cải thiện khả năng tìm kiếm và navigation.

---

## 1. Phân Tích Hiện Trạng

### 1.1 Thống Kê

| Loại | Số Lượng | Ghi Chú |
|------|----------|---------|
| File .md trong docs/asia/ | 175 | Flat structure |
| File trong docs/decompiled/asia/ | 338 | Decompiled DLLs |
| Module chính | 10 | AP, AR, CA, CO, FA, GL, IN, PO, SI, SO |

### 1.2 Phân Bố Theo Module

| Module | Số File | Tỷ Lệ |
|--------|---------|-------|
| GL | 76 (57 + 19*) | 43% |
| FA | 20 | 11% |
| SO | 17 | 10% |
| PO | 13 | 7% |
| AR | 13 | 7% |
| CA | 11 | 6% |
| IN | 6 | 3% |
| AP | 5 | 3% |
| CO | 4 | 2% |
| Khác | 10 | 6% |

\* 19 file GL có tên bắt đầu bằng "Gl" (lowercase) thay vì "GL"

### 1.3 Vấn Đề Hiện Tại

1. **Flat structure**: 175 file nằm chung trong 1 thư mục
2. **Naming inconsistency**: Mix giữa `GL...` và `Gl...`, `PO...` và `Po...`
3. **Thiếu navigation**: Không có cấu trúc phân cấp rõ ràng
4. **Khó tìm kiếm**: Không có index theo module hoặc loại chức năng
5. **Không có reference tổng hợp**: Thiếu bảng tra cứu liên kết

---

## 2. Cấu Trúc Mới Đề Xuất

```
docs/
├── README.md                          # Index chính (đã có)
├── ASIA_DECOMPILE_TASKS.md            # Task tracking (đã có)
├── ASIA_DOC_RESTRUCTURE_PLAN.md       # File này
│
├── asia/                              # Tài liệu phân tích DLL
│   ├── README.md                      # Overview + navigation
│   │
│   ├── modules/                       # Tài liệu theo module
│   │   ├── ap/                        # Accounts Payable
│   │   │   ├── README.md              # Module overview
│   │   │   ├── vouchers/              # Chứng từ
│   │   │   ├── reports/               # Báo cáo
│   │   │   └── masters/               # Danh mục
│   │   │
│   │   ├── ar/                        # Accounts Receivable
│   │   │   ├── README.md
│   │   │   ├── vouchers/
│   │   │   ├── reports/
│   │   │   └── masters/
│   │   │
│   │   ├── ca/                        # Cash/Banking
│   │   │   ├── README.md
│   │   │   ├── vouchers/
│   │   │   ├── reports/
│   │   │   └── masters/
│   │   │
│   │   ├── co/                        # Cost/Manufacturing
│   │   │   ├── README.md
│   │   │   └── reports/
│   │   │
│   │   ├── fa/                        # Fixed Assets
│   │   │   ├── README.md
│   │   │   ├── vouchers/
│   │   │   ├── reports/
│   │   │   └── masters/
│   │   │
│   │   ├── gl/                        # General Ledger
│   │   │   ├── README.md
│   │   │   ├── vouchers/
│   │   │   ├── reports/
│   │   │   ├── masters/
│   │   │   └── financial-statements/  # Báo cáo tài chính
│   │   │
│   │   ├── in/                        # Inventory
│   │   │   ├── README.md
│   │   │   ├── vouchers/
│   │   │   ├── reports/
│   │   │   └── masters/
│   │   │
│   │   ├── po/                        # Purchase Order
│   │   │   ├── README.md
│   │   │   ├── vouchers/
│   │   │   └── reports/
│   │   │
│   │   ├── si/                        # Sales Invoice
│   │   │   └── README.md              # Module nhỏ
│   │   │
│   │   └── so/                        # Sales Order
│   │       ├── README.md
│   │       ├── vouchers/
│   │       └── reports/
│   │
│   ├── patterns/                      # Design patterns
│   │   ├── README.md
│   │   ├── voucher-pattern.md         # Common voucher pattern
│   │   ├── report-pattern.md          # Common report pattern
│   │   ├── master-pattern.md          # Common master pattern
│   │   └── posting-pattern.md         # Posting to GL pattern
│   │
│   ├── framework/                     # Framework mapping
│   │   ├── README.md
│   │   ├── controls-mapping.md        # UI controls
│   │   ├── forms-mapping.md           # Form inheritance
│   │   └── database-layer.md          # DAO pattern
│   │
│   └── reference/                     # Reference materials
│       ├── tables-index.md            # Database tables
│       ├── sp-index.md                # Stored procedures
│       ├── cross-module.md            # Inter-module links
│       └── naming-conventions.md      # Naming standards
│
├── decompiled/                        # Decompiled source (giữ nguyên)
│   └── asia/
│       ├── ap/
│       ├── ar/
│       ├── ca/
│       ├── co/
│       ├── fa/
│       ├── gl/
│       ├── in/
│       ├── po/
│       ├── si/
│       └── so/
│
└── tasks/                             # Task tracking
    └── (các file task tracking)
```

---

## 3. Kế Hoạch Thực Hiện

### Phase 1: Chuẩn Bị (Priority: HIGH)

| Task | Mô Tả | Output | Dependencies |
|------|-------|--------|--------------|
| 1.1 | Tạo thư mục cấu trúc mới | Cây thư mục hoàn chỉnh | None |
| 1.2 | Tạo README.md cho từng module | 10 file README | 1.1 |
| 1.3 | Tạo file index/navigation chính | docs/asia/README.md | 1.2 |
| 1.4 | Backup file hiện tại | Archive copy | None |

### Phase 2: Di Chuyển File (Priority: HIGH)

#### 2.1 Module GL (76 files)

| Task | Số File | Đích | Pattern |
|------|---------|------|---------|
| 2.1.1 | 35 | modules/gl/reports/ | GLRpt*.md, GlRpt*.md |
| 2.1.2 | 20 | modules/gl/financial-statements/ | GLMAUBCTCTM*.md, GlRptBctc*.md |
| 2.1.3 | 10 | modules/gl/vouchers/ | GLVch*.md, GLPost*.md |
| 2.1.4 | 5 | modules/gl/masters/ | GLDM*.md, GlCd*.md |
| 2.1.5 | 6 | Giữ nguyên root | *SUMMARY*, *INDEX*, FRAMEWORK*, ... |

#### 2.2 Module FA (20 files)

| Task | Số File | Đích | Pattern |
|------|---------|------|---------|
| 2.2.1 | 15 | modules/fa/reports/ | FARpt*.md |
| 2.2.2 | 2 | modules/fa/vouchers/ | FAPost*.md |
| 2.2.3 | 1 | modules/fa/masters/ | FADM*.md |
| 2.2.4 | 2 | Giữ nguyên root | *SUMMARY*, ... |

#### 2.3 Module SO (17 files)

| Task | Số File | Đích | Pattern |
|------|---------|------|---------|
| 2.3.1 | 10 | modules/so/reports/ | SORpt*.md |
| 2.3.2 | 4 | modules/so/vouchers/ | SOVch*.md |
| 2.3.3 | 3 | Giữ nguyên root | *SUMMARY*, ... |

#### 2.4 Module PO (13 files)

| Task | Số File | Đích | Pattern |
|------|---------|------|---------|
| 2.4.1 | 8 | modules/po/reports/ | PORpt*.md |
| 2.4.2 | 4 | modules/po/vouchers/ | POVch*.md, PoVch*.md |
| 2.4.3 | 1 | Giữ nguyên root | *SUMMARY* |

#### 2.5 Module AR (13 files)

| Task | Số File | Đích | Pattern |
|------|---------|------|---------|
| 2.5.1 | 9 | modules/ar/reports/ | ARRpt*.md, ArRpt*.md |
| 2.5.2 | 2 | modules/ar/vouchers/ | ARVch*.md, ARPost*.md |
| 2.5.3 | 1 | modules/ar/masters/ | ARTT.md |
| 2.5.4 | 1 | Giữ nguyên root | *SUMMARY* |

#### 2.6 Module CA (11 files)

| Task | Số File | Đích | Pattern |
|------|---------|------|---------|
| 2.6.1 | 4 | modules/ca/reports/ | CARpt*.md |
| 2.6.2 | 1 | modules/ca/vouchers/ | CAVch*.md |
| 2.6.3 | 5 | modules/ca/masters/ | CA*KU*.md, CA*Lai*.md, CA*PC*.md |
| 2.6.4 | 1 | Giữ nguyên root | README.md (đã có) |

#### 2.7 Module IN (6 files)

| Task | Số File | Đích | Pattern |
|------|---------|------|---------|
| 2.7.1 | 1 | modules/in/masters/ | INDMVT_.md |
| 2.7.2 | 5 | Giữ nguyên root | *INDEX*, *SUMMARY*, ... |

#### 2.8 Module AP (5 files)

| Task | Số File | Đích | Pattern |
|------|---------|------|---------|
| 2.8.1 | 3 | modules/ap/reports/ | APRpt*.md |
| 2.8.2 | 1 | modules/ap/vouchers/ | ApVch*.md |
| 2.8.3 | 1 | modules/ap/masters/ | APTT.md |

#### 2.9 Module CO (4 files)

| Task | Số File | Đích | Pattern |
|------|---------|------|---------|
| 2.9.1 | 4 | modules/co/reports/ | CO*.md, Co*.md |

#### 2.10 Module SI (0 files analyzed)

| Task | Số File | Đích | Pattern |
|------|---------|------|---------|
| 2.10.1 | 0 | modules/si/ | Chưa có file nào |

### Phase 3: Tạo Reference Materials (Priority: MEDIUM)

| Task | Mô Tả | Output |
|------|-------|--------|
| 3.1 | Di chuyển TABLES_INDEX.md | reference/tables-index.md |
| 3.2 | Di chuyển SP_INDEX.md | reference/sp-index.md |
| 3.3 | Tạo patterns README | patterns/README.md |
| 3.4 | Tạo framework README | framework/README.md |
| 3.5 | Tạo reference README | reference/README.md |
| 3.6 | Tạo naming-conventions.md | reference/naming-conventions.md |
| 3.7 | Tạo cross-module.md | reference/cross-module.md |

### Phase 4: Cập Nhật Links (Priority: MEDIUM)

| Task | Mô Tả | Output |
|------|-------|--------|
| 4.1 | Cập nhật internal links trong các file .md | Links hoạt động |
| 4.2 | Cập nhật docs/README.md | Index chính cập nhật |
| 4.3 | Cập nhật ASIA_DECOMPILE_TASKS.md | Links đến vị trí mới |

### Phase 5: Cleanup (Priority: LOW)

| Task | Mô Tả | Output |
|------|-------|--------|
| 5.1 | Xóa file cũ sau khi verify | Dọn dẹp hoàn tất |
| 5.2 | Archive file backup | docs/archive/ |
| 5.3 | Cập nhật CHANGELOG | Ghi nhận thay đổi |

---

## 4. Chi Tiết Mapping File

### 4.1 Module GL (76 files)

```
# Reports (35 files)
GLRptBCPT01-05.md → modules/gl/reports/
GLRptBCT01-03.md → modules/gl/reports/
GLRptBCTCCR01-04.md → modules/gl/reports/
GLRptBk02.dll.md → modules/gl/reports/
GLRptCTGS01-05.md → modules/gl/reports/
GLRptF5BCPT08.md → modules/gl/reports/
GLRptF5BCTC02-03.md → modules/gl/reports/
GLRptF5CTGS01-03.md → modules/gl/reports/
GLRptNKCT*.md → modules/gl/reports/
GLRptTH01.md → modules/gl/reports/
GLRptTMBCTC.md → modules/gl/reports/
GlRptBcpt08.md → modules/gl/reports/
GlRptBCT04-06.md → modules/gl/reports/
GlRptBk01.dll.md → modules/gl/reports/
GlRptF5Bctc03-04.dll.md → modules/gl/reports/
GlRptNkc01-07.md → modules/gl/reports/
GlRptNKC01All.dll.md → modules/gl/reports/

# Financial Statements (20 files)
GLMAUBCTCTMI*.md → modules/gl/financial-statements/
GLMAUBCTCTMV*.md → modules/gl/financial-statements/
GLMAUBCTCTMIX.md → modules/gl/financial-statements/
GlRptBctc01-04.md → modules/gl/financial-statements/
GlRptF5Bctc03-04.dll.md → modules/gl/financial-statements/

# Vouchers (10 files)
GLPost2GL.md → modules/gl/vouchers/
GLVch*.md → modules/gl/vouchers/

# Masters (5 files)
GLDMKC.md → modules/gl/masters/
GLDM*.md → modules/gl/masters/
GlCd*.md → modules/gl/masters/

# Root (6 files - giữ nguyên)
GL_BATCH2_SUMMARY.md
GL_MODULE_COMPLETE.md
FRAMEWORK_MAPPING.md
```

### 4.2 Module FA (20 files)

```
# Reports (15 files)
FARptBCPT01-10.md → modules/fa/reports/
FARptBCTS01.md → modules/fa/reports/
FARptBCTS04-09.md → modules/fa/reports/
FARptSoSD.md → modules/fa/reports/
FARptSoTSCD.md → modules/fa/reports/

# Vouchers (2 files)
FAPostCC2GL.md → modules/fa/vouchers/

# Masters (1 file)
FADM*.md → modules/fa/masters/

# Root (2 files)
FA_SUMMARY.md (nếu có)
```

### 4.3 Module SO (17 files)

```
# Reports (10 files)
SORptBCPT03-06.md → modules/so/reports/
SORptF5BCPT03-06.md → modules/so/reports/
SORptF5TH0.md → modules/so/reports/
SORptLaiLo.md → modules/so/reports/
SORptTH01-02.md → modules/so/reports/

# Vouchers (4 files)
SOVchSO3.md → modules/so/vouchers/
SOVchSO3_.md → modules/so/vouchers/
SOVchSO4.md → modules/so/vouchers/
SOVchSO5.md → modules/so/vouchers/

# Root (3 files)
SO_MODULE_SUMMARY.md
```

### 4.4 Module PO (13 files)

```
# Reports (8 files)
PORptBCPT03.md → modules/po/reports/
PORptBK01-03.md → modules/po/reports/
PORptF5TH0.md → modules/po/reports/
PORptTH01-03.md → modules/po/reports/

# Vouchers (4 files)
POVchPO3-7.md → modules/po/vouchers/
PoVchPO6.md → modules/po/vouchers/

# Root (1 file)
PO_MODULE_ANALYSIS_SUMMARY.md
```

### 4.5 Module AR (13 files)

```
# Reports (9 files)
ARRptBCCN01-06.md → modules/ar/reports/
ARRptBK01-03.md → modules/ar/reports/
ArRptF5BCCN01a.md → modules/ar/reports/

# Vouchers (2 files)
ARPost2TT.md → modules/ar/vouchers/
ARVchAR4.md → modules/ar/vouchers/

# Masters (1 file)
ARTT.md → modules/ar/masters/

# Root (1 file)
AR_SUMMARY.md (nếu có)
```

### 4.6 Module CA (11 files)

```
# Reports (4 files)
CARptTMNH01-04.md → modules/ca/reports/

# Vouchers (1 file)
CAVchCA2-5.md → modules/ca/vouchers/

# Masters (5 files)
CACalLaiKu.md → modules/ca/masters/
CADelLaiKu.md → modules/ca/masters/
CADMKU.md → modules/ca/masters/
CALAIKU.md → modules/ca/masters/
CACDKU.md → modules/ca/masters/
CACDPC.md → modules/ca/masters/

# Root (1 file)
README.md (đã có)
```

### 4.7 Module IN (6 files)

```
# Masters (1 file)
INDMVT_.md → modules/in/masters/

# Root (5 files)
IN_MODULE_INDEX.md
INVENTORY_REPORTS_SUMMARY.md
INVENTORY_VOUCHERS_SUMMARY.md
INVENTORY_FULL_ANALYSIS.md
```

### 4.8 Module AP (5 files)

```
# Reports (3 files)
APRptBK01-03.md → modules/ap/reports/

# Vouchers (1 file)
ApVchAP4.md → modules/ap/vouchers/

# Masters (1 file)
APTT.md → modules/ap/masters/

# Root (1 file)
AP_SUMMARY.md
```

### 4.9 Module CO (4 files)

```
# Reports (4 files)
CORptGt01-03.md → modules/co/reports/
CoRptCTPBCPTT.md → modules/co/reports/
CoRptKHCPTT.md → modules/co/reports/
```

### 4.10 Module SI (0 files)

```
# Chưa có file nào được phân tích
# SIVchSI1.dll chưa decompile
```

---

## 5. Naming Convention Fixes

### 5.1 Inconsistencies Cần Fix

| Hiện Tại | Đề Xuất | Lý Do |
|----------|---------|-------|
| GlRpt*.md | GLRpt*.md | Consistency với module GL |
| PoVch*.md | POVch*.md | Consistency với module PO |
| ArRpt*.md | ARRpt*.md | Consistency với module AR |
| ApVch*.md | APVch*.md | Consistency với module AP |
| CoRpt*.md | CORpt*.md | Consistency với module CO |

### 5.2 .dll.md Extension

| Hiện Tại | Đề Xuất | Lý Do |
|----------|---------|-------|
| *.dll.md | *.md | Đơn giản hóa, không cần thiết |

---

## 6. Dependencies

### 6.1 Blockers

Không có blocker nào. Task có thể thực hiện độc lập.

### 6.2 Prerequisites

- [ ] Review và approve kế hoạch này
- [ ] Backup hiện trạng trước khi thực hiện
- [ ] Cập nhật ASIA_DECOMPILE_TASKS.md Phase 4

### 6.3 Post-requisites

- [ ] Cập nhật tất cả internal links
- [ ] Verify navigation hoạt động
- [ ] Archive file cũ

---

## 7. Timeline Đề Xuất

| Phase | Thời Gian | Tasks |
|-------|-----------|-------|
| Phase 1 | 1-2 giờ | Chuẩn bị cấu trúc |
| Phase 2 | 4-6 giờ | Di chuyển 175 files |
| Phase 3 | 2-3 giờ | Tạo reference materials |
| Phase 4 | 2-3 giờ | Cập nhật links |
| Phase 5 | 1 giờ | Cleanup |
| **Total** | **10-15 giờ** | |

---

## 8. Risk Assessment

| Risk | Impact | Mitigation |
|------|--------|------------|
| Broken links | High | Script tự động cập nhật links |
| Missing files | Medium | Checklist và verify từng file |
| Git history | Low | Git sẽ track rename nếu dùng `git mv` |
| Confusion | Low | Giữ file cũ trong archive |

---

## 9. Success Criteria

- [ ] Tất cả 175 file được di chuyển đúng vị trí
- [ ] Không còn file nào ở docs/asia/ root (trừ index files)
- [ ] Tất cả internal links hoạt động
- [ ] Navigation từ README hoạt động
- [ ] Không mất dữ liệu

---

## 10. Notes

1. **Không xóa file gốc** cho đến khi verify hoàn tất
2. **Sử dụng `git mv`** để giữ history
3. **Tạo script** cho các thao tác lặp lại
4. **Test navigation** sau mỗi module
5. **Document exceptions** nếu có file không fit pattern

---

*Created: 2026-03-26*
*Status: PLANNING*
*Next Step: Review và approve kế hoạch*
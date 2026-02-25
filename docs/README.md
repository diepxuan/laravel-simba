# SimbaSql Database Documentation

## Overview
This directory contains comprehensive documentation and tools for the SimbaSql database used in the Portal application.

## Files

### 1. Analysis Reports
- **`SimbaSql_analysis_report.md`** - Detailed technical analysis of the SimbaSql database structure, stored procedures, and performance/security issues
- **`simba_sql_summary.md`** - Executive summary of findings and recommendations

### 2. Tools & Scripts
- **`convert_sp_to_php.php`** - Script to automatically convert SQL stored procedures to PHP classes
- **`example_conversion.php`** - Example conversion of `asGetRight` stored procedure to PHP class
- **`optimize_procedures.sql`** - SQL scripts for performance optimization and security fixes
- **`debug_procedures.sql`** - Framework for debugging stored procedures

## Database Statistics
- **Total SQL Files**: 2,569
- **Tables**: 440
- **Stored Procedures**: 2,031
- **Functions**: 89
- **Views**: 4

## Key Findings

### Architecture
- **Multi-tenant design**: All tables include `ma_cty` (company code)
- **Module-based structure**: GL (Accounting), AR (Receivables), AP (Payables), SI (System), IN (Inventory), etc.
- **Consistent naming conventions**: Clear prefixes/suffixes for tables and procedures

### Issues Identified
1. **Performance Issues**:
   - 142 procedures use `SELECT *`
   - Multiple procedures use CURSOR instead of set-based operations
   - 8 procedures use dynamic SQL (`EXECUTE`)

2. **Security Concerns**:
   - Dynamic SQL in some procedures poses SQL injection risks
   - Need for parameterized queries and input validation

3. **Code Quality**:
   - Inconsistent error handling
   - Missing comments and documentation
   - Hard-coded values and magic numbers

## Recommendations

### Phase 1: Security & Critical Performance (1-2 weeks)
1. Fix dynamic SQL injection risks (8 procedures)
2. Optimize frequently called procedures
3. Add missing indexes on critical tables

### Phase 2: Performance Optimization (2-3 weeks)
1. Replace `SELECT *` with explicit column lists (142 procedures)
2. Convert CURSOR operations to set-based operations
3. Add proper indexing strategy

### Phase 3: Code Quality & Documentation (1-2 weeks)
1. Add standard error handling
2. Improve comments and documentation
3. Create standardized templates for new procedures

### Phase 4: PHP Integration (2-4 weeks)
1. Convert stored procedures to PHP classes
2. Implement repository pattern
3. Add unit tests and integration tests

## Usage

### Converting Stored Procedures to PHP
```bash
php convert_sp_to_php.php [stored_procedure_name]
```

### Running Optimization Scripts
```sql
-- Execute in SQL Server Management Studio
:r optimize_procedures.sql
```

### Debugging Procedures
```sql
-- Use the debug framework
:r debug_procedures.sql
```

## Related Documentation
- See `../dbo/StoredProcedures/` for all SQL stored procedures
- Refer to portal documentation for PHP integration examples
- Check `SimbaSql_analysis_report.md` for detailed technical analysis

## Maintenance
- Update documentation when database schema changes
- Run optimization scripts periodically
- Review security fixes after major updates

## Contributors
- AI Agent Analysis: 2026-02-23
- Last Updated: 2026-02-23
# TOOLS.md - Local Notes

Skills define _how_ tools work. This file is for _your_ specifics — the stuff that's unique to your setup.

## What Goes Here

Things like:

- Camera names and locations
- SSH hosts and aliases
- Device nicknames
- Anything environment-specific

## Why Separate?

Skills are shared. Your setup is yours. Keeping them apart means you can update skills without losing your notes, and share skills without leaking your infrastructure.

---

## SSH Hosts

### Development Servers
- **web** → `ssh root@web` (Portal development server)
  - Primary database server for Portal application
  - Contains production-like data for development

### Database Connections
- **Portal Database**: SQL Server on web server

### Notes
- SSH key: `~/.ssh/id_rsa` (existing key)
- Default port: 22
- Use `ssh root@web` for direct connection

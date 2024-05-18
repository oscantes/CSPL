#### Hi there!
This program is the one I intend to use daily and develope according to my needs in IT

# Release Notes
Release notes will be published in this file for a short period of time

## v0.0.7 (18.5.2024)

### Added
user picture
ping for corporate LAN demanding functions
quick buttons such as "Get Hostname/IP from DW", "Browse C:\", "Open Hosts File", "Get Programs", "Get Username" etc.
**hostname textbox:** enter key runs connectwithdw(), double click runs GetHostname()
**GetHostInfo():** shows Device and OS info
**GetUserInfo():** shows Title, PasswordLastSet, PasswordExpire, PasswordExpiresIn, hasVPN, user picture etc.
**isreachable():** can detect restricted computers
**Kayýt Oluþturucu:** when this tab selected, form size expands in width
**Kayýt Görüntüleyici:** all incident*.txt files are selectable
**Kayýt Görüntüleyici:** double click an item to clone incident
**Kayýt Görüntüleyici:** open incident*.txt files in File Explorer
**Kayýt Görüntüleyici:** search incidents and scroll to first matched item
**Jabber Califfer™**
**Dosya Ýþlemleri:** Browse files, get folder size, mirror files in seperate folders

### Changed
Complete UI overhaul, a lot of UI functions run async now
**status bar:** animates when a process is running or finished
**Ýþlem Menüsü:** removed completely

### Fixed
**Kayýt Görüntüleyici:** search function can't scroll to matched item when list is not long enough
**log system:** many functions don't log
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
**Kay�t Olu�turucu:** when this tab selected, form size expands in width
**Kay�t G�r�nt�leyici:** all incident*.txt files are selectable
**Kay�t G�r�nt�leyici:** double click an item to clone incident
**Kay�t G�r�nt�leyici:** open incident*.txt files in File Explorer
**Kay�t G�r�nt�leyici:** search incidents and scroll to first matched item
**Jabber Califfer�**
**Dosya ��lemleri:** Browse files, get folder size, mirror files in seperate folders

### Changed
Complete UI overhaul, a lot of UI functions run async now
**status bar:** animates when a process is running or finished
**��lem Men�s�:** removed completely

### Fixed
**Kay�t G�r�nt�leyici:** search function can't scroll to matched item when list is not long enough
**log system:** many functions don't log
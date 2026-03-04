# Streets-of-Rogue-Save-Editor_UnlockTool

A save editor for the game **Streets of Rogue** to read and modify `GameUnlocks.dat` files.

[中文版](./README_zh.md)

## Features
- Export binary save file to human‑readable JSON format
- Repack modified JSON back to game‑recognized binary format
- Supports editing in‑game unlocks, currency (nuggets), and other data

## Usage

### Basic Commands
```powershell
# Export save to JSON
UnlockToolConsole.exe GameUnlocks.dat > data.json

# Write modified JSON back to a new save file
Get-Content data.json -Raw | UnlockToolConsole.exe GameUnlocks.dat GameUnlocks_new.dat
```

### Debug Mode
The tool outputs diagnostic information to the standard error stream. You can redirect it to a file:
```powershell
# View diagnostics during export
UnlockToolConsole.exe GameUnlocks.dat > data.json 2> diag.log

# View diagnostics during write‑back
Get-Content data.json -Raw | UnlockToolConsole.exe GameUnlocks.dat GameUnlocks_new.dat 2> write.log
```

## Disclaimer
This tool is provided for educational and research purposes only. Modifying game save files may lead to corruption or unexpected behavior. Always back up your original files before use. The author assumes no responsibility for any data loss or game issues.
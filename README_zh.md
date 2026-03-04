# Streets-of-Rogue-Save-Editor_UnlockTool - 地痞街区 GameUnlocks.dat 修改工具

为游戏《地痞街区》(Streets of Rogue) 制作的存档修改工具，用于读取和修改 `GameUnlocks.dat` 文件。

[English Version](./README.md)

## 用处
- 将二进制存档文件导出为可读写的 JSON 格式
- 将修改后的 JSON 重新打包为游戏可识别的二进制存档
- 支持修改游戏内解锁项（unlocks）等数据

## 用法

### 基本命令
```powershell
# 导出存档为 JSON
UnlockToolConsole.exe GameUnlocks.dat > data.json

# 将修改后的 JSON 写回新存档
Get-Content data.json -Raw | UnlockToolConsole.exe GameUnlocks.dat GameUnlocks_new.dat
```

### 调试模式
工具会自动输出诊断信息到标准错误流，可通过重定向查看：
```powershell
# 导出时查看诊断
UnlockToolConsole.exe GameUnlocks.dat > data.json 2> diag.log

# 写回时查看诊断
Get-Content data.json -Raw | UnlockToolConsole.exe GameUnlocks.dat GameUnlocks_new.dat 2> write.log
```

## 免责申明
本工具仅供学习研究使用。修改游戏存档可能导致存档损坏或游戏异常，请务必提前备份原始文件。作者不对任何数据丢失或游戏问题负责。
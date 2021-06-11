@echo off

if "%OS%" == "Windows_NT" goto WinNT

:Win9X
goto exit

:WinNT
echo Adicionando porta 3307 no firewall...
netsh advfirewall firewall add rule name=MySQL_Gastador  localport=3307 protocol=TCP dir=in action=allow
netsh firewall add portopening TCP 3307 MySQL enable

:exit
exit
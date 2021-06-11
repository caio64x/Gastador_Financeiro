@echo off
echo Parando MySQL...
net stop MySQL_Gastador
echo Desinstalando o MySql
"C:\Gastador\MySQL\bin\mysqld.exe" --remove MySQL_Gastador
pause
exit

@echo off
echo Instalando o MySQL como um Servi�o
"C:\Gastador\MySQL\bin\mysqld" --install MySQL_Gastador --defaults-file="C:\Gastador\MySQL\my.ini"
echo Tentando iniciar o MySQL Server...
net start MySQL_Gastador 
pause
exit

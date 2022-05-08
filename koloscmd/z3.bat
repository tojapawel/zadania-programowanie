::kopiowanie plików o nazwie rozpoczynającej się na podają przez użytkowinka literę

@echo off

set /p character="Podaj litere: "
copy %character%* %character%

::usage: najpierw dzięki z1 trzeba stworzyć folder o nazwie np: t, póżniej zadaniem: z2 tworzymy pliki np o nazwie "test", później tym zadaniem z3 podajemy litere t


::tworzenie n plików o podanej nazwie

@echo OFF

set /p name="Podaj nazwe: "

::poniżej zamist 1 2 3 4 5 podajcie od 1 do ilości liter w nazwisku np. nazwisko: "Kowalski" 8 liter:
FOR %%x IN (1 2 3 4 5 6 7 8) DO ECHO > %name%%%x.txt

::usage: "z2"
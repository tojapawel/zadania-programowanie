::menu

@echo off

:startt

echo Menu:
echo 1. Zadanie 2
echo 2. Zadanie 3
echo 3. Zadanie 4
echo 4. Zadanie 5
echo 5. Koniec

set /p choice="Wybor: "

if %choice% == 1 goto z2
if %choice% == 2 goto z3
if %choice% == 3 goto z4
if %choice% == 4 goto z5
if %choice% == 5 goto koniec


:z2
start z2
goto startt

:z3
start z3
goto startt

:z3
start z4
goto startt

:z5
start z5
goto startt

:koniec
::sprawdzenie, czy podany przez użytkownika plik istnieje, jeśli tak, to spytać, czy zmienić nazwę pliku

@echo off

set /p file="Podaj nazwe pliku razem z rozszerzeniem: "

if exist %file% goto zmien
if not exist %file% goto niema
goto koniec

:zmien
set /p newfile="Podaj nowa nazwe pliku razem z rozszerzeniem: "
rename %file% %newfile%
goto koniec


:niema
echo Nie ma takiego pliku


:koniec


::usage: "z4"
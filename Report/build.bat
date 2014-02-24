@ECHO ON
pdflatex main.tex
bibtex  main.aux
bibtex main.aux
pdflatex main.tex
pdflatex main.tex
call clean_folders.bat
PAUSE
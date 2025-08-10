1.Connecting with notepad:
$ notepad++ .gitignore

2.Pasting ignore log file in Notepad++:
*.log
log/
and Save the file

3.Check with Git:
$ git status
>.gitignore is tracked
>example.log and log/ folder are ignored

4.Commit .gitignore
$ git add .gitignore
$ git commit -m "Add .gitignore to ignore logs"

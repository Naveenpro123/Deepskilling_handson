//Install Git 
Open git bash
1. Check if Git is installed:
$ git --version

2.Set global user name and email:
$ git config --global user.name "MOHAMED GOWS"
$ git config --global user.email "GOWS@Cognizant.com"

3.Check if configuration is saved:
$git config --global --list

4.Test if Notepad++ works in Git Bash:
$notepad++

5.Set Notepad++ as the default Git editor:
$git config --global core.editor "notepad++ -multiInst -notabbar -nosession"

6.Verify default editor:
$git config --global -e

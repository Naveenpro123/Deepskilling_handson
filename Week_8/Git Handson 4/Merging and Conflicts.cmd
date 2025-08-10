1.Merge the branch to master:
$ git merge GitWork

2.open notepad++;
$ notepad++ hello.xml
Observe the Git conflict markups in hello.xml

3.use 3 way mergetool:
$ git mergetool

4.add hello.xml 
$ git add hello.xml

5.Commit the changes to master
$ git commit -m "Resolved merge conflict between GitWork and master"

6.To ignore hello.xml.orig use .gitignore:
$ echo "*.orig" >> .gitignore
$ git add .gitignore
$ git commit -m "Ignore backup files"

7.list all branch and delete GitWork:
$ git branch
$ git branch -d GitWork

8. Final log visualization
$ git log --oneline --graph --decorate

9.Github push
$ git push origin master

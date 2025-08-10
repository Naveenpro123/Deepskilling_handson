1.Switch to master:
$ git checkout master

2. Add a file “hello.xml”:
$ echo "<message>Hello from Master Branch</message>" > hello.xml

3.Commit the changes to the master
$ git add hello.xml
$ git commit -m "Add hello.xml in master with different content"

4.Observe the log:
$ git log --oneline --graph --decorate --all


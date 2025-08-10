1.Verify if master is in clean state
$ git checkout master
$ git status

2.Create a branch “GitWork:
$ git checkout -b GitWork

3.Add a file “hello.xml
$ echo "<message>Hello from GitWork</message>" > hello.xml

4.Update the content of “hello.xml
$ echo "<message>Hello from GitWork Branch - Updated</message>" > hello.xml
$ git status

5.Commit the changes to reflect in the branch
$ git add hello.xml
$ git commit -m "Add hello.xml in GitWork branch with message"

# MUDBLAZOR FOR AUGCENTER CLIENT

- For CURD with Products

<h3>Comman Line Ubuntu</h3>

**Remove**
````
vivek@nixcraft:~$ rm -- -fileNameHere
vivek@nixcraft:~$ rm -- --fileNameHere
vivek@nixcraft:~$ rm -rf --DirectoryNameHere
vivek@nixcraft:~$ rm ./-file
vivek@nixcraft:~$ rm -rf ./--DirectoryNameHere
````

<h3>Increase Cache Size</3>

- Allow Client send file > 32KB
**Program.cs**
````
builder.Services.AddSignalR(e => {
                e.MaximumReceiveMessageSize = 102400000;
            });
````

# Usage

## Install dotnet core

```shell
https://docs.microsoft.com/en-us/dotnet/core/macos-prerequisites?tabs=netcore30
https://dotnet.microsoft.com/download
```

Make sure to add the dotnet path to your $PATH variable on your shell.

## Run

```shell
cd bruteSha1Challenge
dotnet run <sha1> <length>
```

### Example

```shell
dotnet run 5b11c3fa491d6b03e9742693ca34610c516031b8 4

dotnet run 5268a98b3d8cfa91f0c2731dc9b817715fc810c3 6
```

### Output

```shell
Success! string = klmn, hash = 5b11c3fa491d6b03e9742693ca34610c516031b8
Time taken: 410 ms

Success! string = cultrs, hash = 5268a98b3d8cfa91f0c2731dc9b817715fc810c3
Time taken: 53977 ms
```

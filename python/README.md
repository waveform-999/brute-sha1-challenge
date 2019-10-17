# Usage

## Install python 3

```shell
brew install pyenv
pyenv install 3.8.0
```

## Run

```shell
python3 brute-sha1.py <sha1> <length>
```

### Example

```shell
python3 brute-sha1.py 5b11c3fa491d6b03e9742693ca34610c516031b8 4

python3 brute-sha1.py 5268a98b3d8cfa91f0c2731dc9b817715fc810c3 6
```

### Output

```shell
Success! string = klmn, hash = 5b11c3fa491d6b03e9742693ca34610c516031b8
0.24553489685058594

Success! string = cultrs, hash = 5268a98b3d8cfa91f0c2731dc9b817715fc810c3
37.833301067352295 s
```

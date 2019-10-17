# Usage

## Install rust

```http
https://www.rust-lang.org/tools/install
```

If you're getting permission denied errors, try

```shell
curl https://sh.rustup.rs -sSf | sh -s -- --no-modify-path 
```

Then manually update your shell profile (.bash_profile or .zshrc) to include to your path

```shell
source ~/.cargo/env
```

## Compile

```shell
cd rust/brute-sha1-challenge-rust/src
cargo build
../target/debug/brute-sha1-challenge-rust --length <int> --sha1 <string>
```

### Example

```shell
../target/debug/brute-sha1-challenge-rust --length 4 --sha1 5b11c3fa491d6b03e9742693ca34610c516031b8

../target/debug/brute-sha1-challenge-rust --length 6 --sha1 5268a98b3d8cfa91f0c2731dc9b817715fc810c3
```

### Output

```shell
Success! string = klmn, hash = 5b11c3fa491d6b03e9742693ca34610c516031b8
1.87s

Success! string = cultrs, hash = 5268a98b3d8cfa91f0c2731dc9b817715fc810c3
267.67s
```

# TODO

Explore concurrency / threads / num_cpus

* https://doc.rust-lang.org/book/ch16-00-concurrency.html
* https://docs.rs/num_cpus/1.10.1/num_cpus/

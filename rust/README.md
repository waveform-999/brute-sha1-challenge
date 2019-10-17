# Usage

## Install rust

```http
https://www.rust-lang.org/tools/install
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
```

### Output

```shell
Success! string = klmn, hash = 5b11c3fa491d6b03e9742693ca34610c516031b8
1.87s
```

# TODO

Explore concurrency / threads / num_cpus

* https://doc.rust-lang.org/book/ch16-00-concurrency.html
* https://docs.rs/num_cpus/1.10.1/num_cpus/

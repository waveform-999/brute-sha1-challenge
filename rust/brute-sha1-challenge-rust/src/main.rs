extern crate crypto;

use std::time::Instant;
use std::env;
use arguments;
use crypto::digest::Digest;
use crypto::sha1::Sha1;

fn main() {
    let args = arguments::parse(env::args()).unwrap();
    let sha1 = args.get::<String>("sha1").unwrap();
    let length = args.get::<i32>("length").unwrap();

    let now = Instant::now();
    bruteforce(&sha1, length);
    let elapsed = now.elapsed();

    println!("{:.2?}", elapsed);
}

fn bruteforce(hash_string: &String, length: i32) {
    to_string_length_and_hash(&"abcdefghijklmnopqrstuvwxyz".chars().collect(), "".to_string(), length, &hash_string);
}

fn to_string_length_and_hash(chars: &Vec<char>, prefix: String, length: i32, hash_string: &String) -> bool {
    if length == 0 {
        let mut hasher = Sha1::new();
        hasher.input_str(&prefix);

        let hex = &*hasher.result_str();
        if hex == hash_string {
            println!("Success! string = {}, hash = {}", prefix, hex);
            return true
        }
        return false
    }

    for i in 0..chars.len() {
        let new_prefix = format!("{}{}", prefix, chars[i]);

        // slowest concatenation
        // let mut new_prefix = String::from(&*prefix);
        // new_prefix.push(chars[i]);

        // 2nd fastest concatenation
        // let mut new_prefix = prefix.to_owned();
        // new_prefix.push(chars[i]);

        let found = to_string_length_and_hash(chars, new_prefix, length-1, hash_string);

        if found {
            return true
        }
    }
    return false
}
import hashlib
import string
import itertools
import time
import argparse

def bruteforce(hash_string, pwlen):
    chars = string.ascii_lowercase
    genpwd = ''
    for pwd in itertools.product(chars, repeat=pwlen):
        genpwd = ''.join(pwd)
        hashed = hashlib.sha1(genpwd.encode('utf-8')).hexdigest()
        if hash_string == hashed:
            print("Success! string = {}, hash = {}".format(genpwd, hash_string))
            return

parser = argparse.ArgumentParser(description='find string from sha1 hash')
parser.add_argument('sha1', help='the sha1 hash', type=str)
parser.add_argument('length', help='length of string', type=int)
args = parser.parse_args()

start = time.time()
bruteforce(args.sha1, args.length)
end = time.time()

print(end - start)

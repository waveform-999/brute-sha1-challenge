using System;
using System.Text;
using System.Diagnostics;
using System.Security.Cryptography;

namespace bruteSha1Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int.TryParse(args[1], out length);

            var watch = Stopwatch.StartNew();
            bruteForce(args[0], length);

            watch.Stop();
            Console.WriteLine("Time taken: {0} ms", watch.ElapsedMilliseconds);
        }

        static void bruteForce(String hash, int length) {
            var CHARS = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            generateStringAndMatchHash(CHARS, "", length, hash);
        }

        static bool generateStringAndMatchHash(char[] chars, String prefix, int length, String hash) {
            if (length == 0) {
                return hashMatches(prefix, hash);
            }
            var newPrefix = "";
            for (var i=0; i < chars.Length; ++i) {
                newPrefix = prefix + chars[i];
                if (generateStringAndMatchHash(chars, newPrefix, length-1, hash)) {
                    return true;
                }
            }
            return false;
        }

        static bool hashMatches(String text, String hash) {
            var match = false;
            using (var algorithm = new SHA1Managed()) {
                var result = algorithm.ComputeHash(Encoding.UTF8.GetBytes(text));
                var sb = new StringBuilder();
                for (int i=0; i < result.Length; i++) {
                    sb.Append(result[i].ToString("x2"));
                }
                var resultText = sb.ToString();
                match = resultText == hash;

                if (match) {
                    Console.WriteLine("Success! string = {0}, hash = {1}", text, hash);
                }
            }
            return match;
        }
    }
}

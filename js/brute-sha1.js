(function() {
    const {
        performance,
        PerformanceObserver
    } = require('perf_hooks');
    
    const crypto = require('crypto');
    
    const CHARS = 'abcdefghijklmnopqrstuvwxyz'.split('');
    
    function main() {
        const sha1 = process.argv[2];
        const length = process.argv[3];
        
        let t0 = performance.now();
        bruteForce(sha1, length);
        let t1 = performance.now();
        console.log('Time taken:', t1-t0, 'ms');
    }
    
    function bruteForce(hash, length) {
        genStringAndMatchHash(CHARS, '', length, hash);
    }
    
    function genStringAndMatchHash(chars, prefix, length, hash) {
        if (length === 0) {
            return hashMatches(prefix, hash);
        }
        
        let newPrefix, i = 0;
        for (i = 0; i < chars.length; ++i) {
            newPrefix = prefix + chars[i];
            if (genStringAndMatchHash(chars, newPrefix, length-1, hash)) {
                return true;
            }
        }
        return false;
    }
    
    function hashMatches(text, hash) {
        const shasum = crypto.createHash('sha1');
        shasum.update(text);
        const match = shasum.digest('hex') === hash;
        
        if (match) {
            console.log(`Success! string = ${text} hash = ${hash}`);
        }
        return match;
    }
    
    main();
    
})();

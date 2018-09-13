using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.Medium
{
    //description of the problem link https://leetcode.com/problems/encode-and-decode-tinyurl/description/
    public class EncodeAndDecodeTinyURL
    {
        const string TinyUrlPrefix = @"http://tinyurl.com/";

        const string
            KeyCharacterSet =
                @"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; //62^6 unique keys possible.

        private readonly Random _random = new Random();
        private readonly Dictionary<string, string> _urlToKey = new Dictionary<string, string>();
        private readonly Dictionary<string, string> _keyToUrl = new Dictionary<string, string>();

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            if (_urlToKey.TryGetValue(longUrl, out var key))
            {
                return TinyUrlPrefix + key;
            }

            while (true)
            {
                var keyCharacters = new char[6];

                for (var i = 0; i < keyCharacters.Length; i++)
                {
                    var index = _random.Next(0, KeyCharacterSet.Length);
                    keyCharacters[i] = KeyCharacterSet[index];
                }

                key = new string(keyCharacters);

                if (_keyToUrl.ContainsKey(key))
                {
                    continue;
                }

                _keyToUrl[key] = longUrl;
                _urlToKey[longUrl] = key;
                break;
            }

            return TinyUrlPrefix + key;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            return _keyToUrl[shortUrl.Replace(TinyUrlPrefix, string.Empty)];
        }
    }
}
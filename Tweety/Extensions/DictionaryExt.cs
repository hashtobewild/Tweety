﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tweety.Extensions
{
    internal static class DictionaryExt
    {
        /// <summary>
        /// Gets the parameters.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns></returns>
        public static Dictionary<string, string> GetParams(this Uri uri)
        {
            try
            {
                MatchCollection matches = Regex.Matches(uri.AbsoluteUri, @"[\?&](([^&=]+)=([^&=#]*))", RegexOptions.Compiled);
                Dictionary<string, string> keyValues = new Dictionary<string, string>(matches.Count);
                foreach (Match m in matches)
                {
                    keyValues.Add(Uri.UnescapeDataString(m.Groups[2].Value), Uri.UnescapeDataString(m.Groups[3].Value));
                }

                return keyValues;
            }
            catch (Exception ex)
            {
                return new Dictionary<string, string>();
            }
        }
    }
}
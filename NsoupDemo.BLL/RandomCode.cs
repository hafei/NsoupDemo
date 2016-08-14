using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NsoupDemo.BLL
{
    /// <summary>
    /// 随机数
    /// </summary>
    public class RandomCodeHelper
    {
        private static readonly Regex _charsetPattern = new Regex("(?i)\\bcharset=\\s*\"?([^\\s;\"]*)", RegexOptions.Compiled);
        //  随机数  结果不固定
        /// <summary>
        ///生成制定位数的随机码（数字）
        /// </summary>
        /// <param name="length">长度</param>
        /// <returns></returns>
        public static string GenerateRandomCode(int length)
        {
            var result = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                var r = new Random(Guid.NewGuid().GetHashCode());
                result.Append(r.Next(0, 10));
            }
            return result.ToString();
        }



        /// <summary>
        /// Parse out a charset from a content type header.  If the charset is not supported, returns null (so the default
        /// will kick in.)
        /// </summary>
        /// <param name="contentType">e.g. "text/html; charset=EUC-JP"</param>
        /// <returns>"EUC-JP", or null if not found. Charset is trimmed and uppercased.</returns>
        public static string GetCharsetFromContentType(string contentType)
        {
            if (contentType == null)
            {
                return null;
            }

            Match m = _charsetPattern.Match(contentType);
            if (m.Success)
            {
                string charset = m.Groups[1].Value.Trim();
                charset = charset.Replace("charset=", string.Empty);
                var pattern = "[\',]";
                var regEx = new Regex(pattern);
                charset = regEx.Replace(charset, string.Empty);

                if (charset.Length == 0)
                {
                    return null;
                }

                try
                {
                    Encoding.GetEncoding(charset);
                    return charset;
                }
                catch (Exception e) { var a = e.Message; }

                charset = charset.ToUpper(CultureInfo.CreateSpecificCulture("en-US"));
                try
                {
                    Encoding.GetEncoding(charset);
                    return charset;
                }
                catch (Exception e) { var a = e.Message; }
            }
            return null;
        }

    }
}

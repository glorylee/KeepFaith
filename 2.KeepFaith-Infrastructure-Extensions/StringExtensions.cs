/************************************************************************************
 * Copyright (c) 2015Microsoft All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 *机器名称：CARFUN-PC
 *公司名称：Microsoft
 *命名空间：_2.KeepFaith_Infrastructure_Extensions
 *文件名：  StringExtensions
 *版本号：  V1.0.0.0
 *唯一标识：ac85493e-1c6e-400c-b451-0c53f8adea1f
 *当前的用户域：carfun-PC
 *创建人：  swustlzx
 *电子邮箱：swustlzx@126.com
 *创建时间：2015/10/16 11:35:35
 *描述：
 *
 *=====================================================================
 *修改标记
 *修改时间：2015/10/16 11:35:35
 *修改人： carfun
 *版本号： V1.0.0.0
 *描述：
 *
/************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace _2.KeepFaith_Infrastructure_Extensions
{
    public static class StringExtensions
    {

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
        /// <summary>
        /// 去除字符串中的重复数据
        /// </summary>
        /// <param name="str">需要处理的字符串</param>
        /// <param name="separator">字符串是用什么分隔的</param>
        /// <returns></returns>
        public static string Deduplication(string str, char separator)
        {
            return str.Split(separator).Where(p => !string.IsNullOrWhiteSpace(p)).GroupBy(p => p).Select(p => p.Key).ToArray().Aggregate("", (current, s) => current + s + separator);
        }

        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static string EnsureNotNull(this string str, string defaultValueIfNull = "")
        {
            return str ?? (defaultValueIfNull ?? string.Empty);
        }

        public static string EnsureTrim(this string str, params char[] trimChars)
        {
            if (str == null)
            {
                return null;
            }

            if (trimChars == null || trimChars.Length == 0)
            {
                return str.Trim();
            }

            return str.Trim(trimChars);

        }

        public static bool EqualsWith(this string str, string compare, bool ignoreCase = true, bool trim = true)
        {
            var comparison = ignoreCase ? StringComparison.InvariantCultureIgnoreCase : StringComparison.InvariantCulture;

            if (trim)
            {
                str = str.EnsureTrim();
                compare = compare.EnsureTrim();
            }

            return string.Equals(str, compare, comparison);

        }

        public static bool TrimedEquals(this string str, string compare, bool ignoreCase = true)
        {
            var comparison = ignoreCase ? StringComparison.InvariantCultureIgnoreCase : StringComparison.InvariantCulture;

            return string.Equals(str.EnsureTrim(), compare.EnsureTrim(), comparison);
        }

        public static string RemoveRedundantWhiteSpace(this string str)
        {
            return Regex.Replace(str, "\\s+", " ");
        }

        [Annotations.StringFormatMethodAttribute("str")]
        public static string FormatWith(this string str, params object[] args)
        {
            if (str == null)
            {
                return string.Empty;
            }

            if (args == null || args.Length == 0)
            {
                return str;
            }

            return string.Format(str, args);
        }

        [Annotations.StringFormatMethodAttribute("str")]
        public static string FormatWith(this string str, IEnumerable<object> args)
        {
            if (args == null)
            {
                return string.Empty;
            }
            var array = args.ToArray();

            return FormatWith(str, array);
        }

        public static string JoinWith(this string str, params object[] args)
        {
            if (str == null)
            {
                return string.Empty;
            }

            if (args == null)
            {
                return string.Empty;
            }

            if (args.Length == 0)
            {
                return str;
            }

            return string.Join(str, args);
        }

        public static string JoinWith(this string str, IEnumerable<object> args)
        {
            if (args == null)
            {
                return string.Empty;
            }
            var array = args.ToArray();

            return JoinWith(str, array);
        }

        public static string[] Split(this string str, string separator = " ", bool removeEmptyEntries = true)
        {
            if (str.IsNullOrEmpty())
            {
                return new string[0];
            }

            if (separator == null)
            {
                separator = " ";
            }

            var splitOptions = removeEmptyEntries ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None;
            return str.Split(separator.ToCharArray(), splitOptions);
        }

        public static string Truncate(this string text, int length, string ellipsis = "...", bool keepFullWordAtEnd = true)
        {
            if (text.IsNullOrEmpty())
            {
                return string.Empty;
            }

            if (text.Length < length)
            {
                return text;
            }

            text = text.Substring(0, length);

            if (keepFullWordAtEnd)
            {
                var lastIndexOfSpace = text.LastIndexOf(' ');
                if (lastIndexOfSpace > 0)
                {
                    text = text.Substring(0, lastIndexOfSpace);
                }
            }
            if (ellipsis.IsNullOrEmpty())
            {
                return text;
            }
            return text + ellipsis;
        }

        public static string HtmlDecode(this string str)
        {
            if (str == null)
            {
                return null;
            }

            return WebUtility.HtmlDecode(str);
        }

        public static string UrlDecode(this string str)
        {
            if (str == null)
            {
                return null;
            }

            return WebUtility.UrlDecode(str);
        }

        public static bool IsGuid(this string str)
        {
            Guid guid;
            return Guid.TryParse(str, out guid);
        }

        public static Guid? ToGuid(this string str)
        {
            Guid guid;
            if (Guid.TryParse(str, out guid))
            {
                return guid;
            }
            return null;
        }


        public static int ToInt32(this string str)
        {
            int result;
            int.TryParse(str, out result);
            return result;
        }

        public static string PadLeftZero(this string str, int length)
        {
            return str.PadLeft(length, '0');
        }
    }
}

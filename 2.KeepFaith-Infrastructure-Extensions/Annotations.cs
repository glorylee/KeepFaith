/************************************************************************************
 * Copyright (c) 2015Microsoft All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 *机器名称：CARFUN-PC
 *公司名称：Microsoft
 *命名空间：_2.KeepFaith_Infrastructure_Extensions
 *文件名：  Annotations
 *版本号：  V1.0.0.0
 *唯一标识：e05b4a6f-df21-4128-90ef-0849b31d8e9c
 *当前的用户域：carfun-PC
 *创建人：  swustlzx
 *电子邮箱：swustlzx@126.com
 *创建时间：2015/10/16 11:47:02
 *描述：
 *
 *=====================================================================
 *修改标记
 *修改时间：2015/10/16 11:47:02
 *修改人： carfun
 *版本号： V1.0.0.0
 *描述：
 *
/************************************************************************************/
using System;

namespace _2.KeepFaith_Infrastructure_Extensions
{
    public sealed class Annotations
    {
        [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method,AllowMultiple = false, Inherited = true)]
        public sealed class StringFormatMethodAttribute : Attribute
        {
            /// <param name="formatParameterName">
            /// Specifies which parameter of an annotated method should be treated as format-string
            /// </param>
            public StringFormatMethodAttribute(string formatParameterName)
            {
                FormatParameterName = formatParameterName;
            }

            public string FormatParameterName { get; private set; }
        }

    }
}

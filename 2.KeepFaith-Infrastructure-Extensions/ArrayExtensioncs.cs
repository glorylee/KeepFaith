/************************************************************************************
 * Copyright (c) 2015Microsoft All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 *机器名称：CARFUN-PC
 *公司名称：Microsoft
 *命名空间：_2.KeepFaith_Infrastructure_Extensions
 *文件名：  ArrayExtensioncs
 *版本号：  V1.0.0.0
 *唯一标识：4b4e8f69-151d-4bfc-bada-258d3110e1d2
 *当前的用户域：carfun-PC
 *创建人：  swustlzx
 *电子邮箱：swustlzx@126.com
 *创建时间：2015/10/20 11:27:45
 *描述：
 *
 *=====================================================================
 *修改标记
 *修改时间：2015/10/20 11:27:45
 *修改人： carfun
 *版本号： V1.0.0.0
 *描述：
 *
/************************************************************************************/

using System;
using System.Linq;

namespace _2.KeepFaith_Infrastructure_Extensions
{
    public class ArrayExtensioncs
    {
        /// <summary>
        /// 去除数组中的重复数据
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public Array Deduplication(object[] array)
        {
            return array.GroupBy(p => p).Select(p => p.Key).ToArray();
        }
    }
}

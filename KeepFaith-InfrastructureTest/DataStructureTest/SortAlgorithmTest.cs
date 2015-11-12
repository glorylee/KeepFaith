/************************************************************************************
 * Copyright (c) 2015Microsoft All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 *机器名称：CARFUN-PC
 *公司名称：Microsoft
 *命名空间：KeepFaith_InfrastructureTest.DataStructureTest
 *文件名：  SortAlgorithmTest
 *版本号：  V1.0.0.0
 *唯一标识：7a25a407-51ef-45e4-9559-3e30c6e87e36
 *当前的用户域：carfun-PC
 *创建人：  swustlzx
 *电子邮箱：swustlzx@126.com
 *创建时间：2015/10/19 12:23:01
 *描述：
 *
 *=====================================================================
 *修改标记
 *修改时间：2015/10/19 12:23:01
 *修改人： carfun
 *版本号： V1.0.0.0
 *描述：
 *
/************************************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1.KeepFaith_Infrastructure_DataStructure;

namespace KeepFaith_InfrastructureTest.DataStructureTest
{
    [TestClass]
    public class SortAlgorithmTest
    {
        [TestMethod]
        public void QuickSort()
        {
            SortAlgorithm sortAlgorithm = new SortAlgorithm();
            //int[] array = { 49, 38, 65, 97, 76, 13, 27 };
            //int[] array = { 0, 1, 2, 0, 1, 2, 1, 2, 2, 1, 0 };
            int[] array = { 389, 207, 155, 300, 299, 170, 158, 65 };
            var ss = SortAlgorithm.QuickSort(array, 0, array.Length - 1);
            
        }
    }
}

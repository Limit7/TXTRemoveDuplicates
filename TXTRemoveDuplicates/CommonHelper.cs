﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace TXTRemoveDuplicates
{
    public class CommonHelper
    {
        /// <summary>
        /// 更新画面委托
        /// </summary>
        /// <param name="msg"></param>
        public delegate void UpdateInfoHandler(string msg, bool isClear = false);
        public UpdateInfoHandler UpdateInfo;

        public delegate void LoadResultHandler(bool loadResult);
        public LoadResultHandler loadResult;

        public delegate void CompareResultHandler(bool compareResult, int count);
        public CompareResultHandler compareResult;

        /// <summary>
        /// 老文件位置
        /// </summary>
        public string[] OldDataPath;
        /// <summary>
        /// 新文件位置
        /// </summary>
        public string NewDataPath;
        /// <summary>
        /// 导出文件夹
        /// </summary>
        public string ExportDir;
        /// <summary>
        /// 是否保存重复数据
        /// </summary>
        public bool isSaveDuplicatesData;
        /// <summary>
        /// 保存数据用HashSet
        /// </summary>
        public HashSet<string> DataHashSet = new HashSet<string>();
        /// <summary>
        /// 清空数据
        /// </summary>
        public void DefaultHashSet()
        {
            DataHashSet.Clear();
        }
        /// <summary>
        /// 清空老数据路径
        /// </summary>
        public void InitializeOldDataPath()
        {
            if (OldDataPath != null)
            {
                OldDataPath.Initialize();
            }
        }
        /// <summary>
        /// 批量加载老数据
        /// </summary>
        public void BatchLoadData()
        {
            List<string> resultStr = new List<string>();
            try
            {
                foreach (string item in OldDataPath)
                {
                    long i = 0;
                    long count = 0;
                    lock (this)
                    {
                        i = LoadOldData(item, ref count);
                        resultStr.Add("【" + Path.GetFileName(item) + "】共加载 " + i + " 条数据，成功加载 " + count + " 条数据。");
                    }
                }
                foreach (string item in resultStr)
                {
                    UpdateInfo(item);
                }
                loadResult(true);
            }
            catch (Exception e)
            {
                loadResult(false);
                UpdateInfo("加载数据出错:" + e.Message);
            }
        }
        /// <summary>
        /// 加载老数据
        /// </summary>
        /// <param name="dataPath"></param>
        public long LoadOldData(string dataPath, ref long count)
        {

            if (string.IsNullOrEmpty(dataPath))
            {
                UpdateInfo("运行出错");
                return 0;
            }
            TextReader reader = File.OpenText(dataPath);
            string currentLine;
            long idx = 0;
            try
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    if ((++idx % 10000) == 0)
                    {
                        UpdateInfo("加载第 " + idx + " 条数据…");
                    }
                    currentLine = currentLine.TrimEnd();
                    if (DataHashSet.Add(currentLine))
                    {
                        count++;
                    };
                }
                UpdateInfo("", true);
                return idx;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                reader.Close();
                reader.Dispose();
            }
        }
        /// <summary>
        /// 比较新数据
        /// </summary>
        public void FiltrateData()
        {
            if (string.IsNullOrEmpty(NewDataPath) || string.IsNullOrEmpty(ExportDir) || DataHashSet.Count == 0)
            {
                UpdateInfo("运行出错");
                return;
            }
            TextReader reader = File.OpenText(NewDataPath);
            string[] exportFile = new string[2];
            exportFile[0] = ExportDir + "重复数据.txt";
            exportFile[1] = ExportDir + "不重复数据.txt";
            TextWriter repetData = File.CreateText(exportFile[0]);
            TextWriter withoutRepetData = File.CreateText(exportFile[1]);
            string currentLine;
            int idx = 0;
            int count = 0;
            try
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    if ((++idx % 10000) == 0)
                    {
                        UpdateInfo("正在比较 " + idx + " 条数据…");
                    }
                    currentLine = currentLine.TrimEnd();
                    if (DataHashSet.Add(currentLine))
                    {
                        withoutRepetData.WriteLine(currentLine);
                        count++;
                    }
                    else
                    {
                        if (isSaveDuplicatesData)
                        {
                            repetData.WriteLine(currentLine);
                        }
                    }
                }
                UpdateInfo("去重成功！不重复数据：" + count + "条");
            }
            catch (Exception e)
            {
                UpdateInfo("去重出错:" + e.Message);
                throw;
            }
            finally
            {
                reader.Close();
                repetData.Close();
                withoutRepetData.Close();
                reader.Dispose();
                repetData.Dispose();
                withoutRepetData.Dispose();
            }
        }
    }
}

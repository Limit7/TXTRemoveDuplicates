using System;
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
        public delegate void UpdateInfoHandler(string msg);
        public UpdateInfoHandler UpdateInfo;

        public delegate void LoadResultHandler(bool loadResult);
        public LoadResultHandler loadResult;

        public delegate void CompareResultHandler(bool compareResult, int count);
        public CompareResultHandler compareResult;
        /// <summary>
        /// 老文件位置
        /// </summary>
        public string OldDataPath;
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
        public void LoadOldData()
        {
            if (string.IsNullOrEmpty(OldDataPath))
            {
                UpdateInfo("运行出错");
                return;
            }
            DefaultHashSet();
            TextReader reader = File.OpenText(OldDataPath);
            DataHashSet = new HashSet<string>();
            string currentLine;
            int idx = 0;
            try
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    if ((++idx % 10000) == 0)
                    {
                        UpdateInfo("加载第 " + idx + " 条数据…");
                    }
                    currentLine = currentLine.TrimEnd();
                    DataHashSet.Add(currentLine);
                }
                loadResult(true);
            }
            catch (Exception e)
            {
                UpdateInfo("加载数据出错:" + e.Message);
                loadResult(false);
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

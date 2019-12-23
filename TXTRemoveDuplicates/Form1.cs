using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TXTRemoveDuplicates.Model;

namespace TXTRemoveDuplicates
{
    public partial class MainForm : Form
    {
        CommonHelper commonHelper = new CommonHelper();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDefault();
        }
        /// <summary>
        /// 初始化设置
        /// </summary>
        private void LoadDefault()
        {
            TxbNewPath.Text = string.Empty;
            TxbSavePath.Text = @"D:\";
            TxbOldPath.Text = string.Empty;
            TxbMsg.Text = string.Empty;
            BtnLoadOldData.BackColor = DefaultBackColor;
            BtnLoadOldData.ForeColor = Color.Black;
            BtnLoadOldData.Text = "加载老数据";
            ChbIsSave.Checked = false;
            lbCountValue.Text = "0";

            commonHelper.UpdateInfo = AppendTxt;
            commonHelper.loadResult = LoadResult;
            commonHelper.compareResult = CompareResult;
            commonHelper.InitializeOldDataPath();
            commonHelper.DefaultHashSet();
            GC.Collect();
        }
        /// <summary>
        /// 添加消息框
        /// </summary>
        /// <param name="msg"></param>
        private void AppendTxt(string msg, bool isClear = false)
        {
            if (TxbMsg.InvokeRequired)
            {
                TxbMsg.BeginInvoke(new Action(() =>
                {
                    if (isClear)
                    {
                        TxbMsg.Text = "";
                    }
                    TxbMsg.AppendText(msg + Environment.NewLine);
                }
                ));
            }
            else
            {
                if (isClear)
                {
                    TxbMsg.Text = "";
                }
                TxbMsg.AppendText(msg + Environment.NewLine);
            }
        }

        /// <summary>
        /// 加载结果回调
        /// </summary>
        /// <param name="loadResult"></param>
        private void LoadResult(bool loadResult)
        {
            if (loadResult)
            {
                SetBtnStatus(true);
                AppendTxt("文件加载成功！库中共有：" + commonHelper.OldDataHashSet.Count.ToString() + " 条数据");
            }
            else
            {
                commonHelper.InitializeOldDataPath();
                commonHelper.DefaultHashSet();
                SetBtnStatus(false);
                AppendTxt("文件加载失败！");
            }
        }
        private void CompareResult(bool compareResult, int count)
        {
            if (compareResult)
            {
                AppendTxt("去重成功！不重复数据：" + count + "条");
            }
            else
            {
                AppendTxt("去重失败！");
            }
        }
        /// <summary>
        /// 根据加载结果设置按钮状态
        /// </summary>
        /// <param name="result"></param>
        private void SetBtnStatus(bool result)
        {
            Action actionSet = new Action(() =>
            {
                if (result)
                {
                    BtnLoadOldData.BackColor = Color.Green;
                    BtnLoadOldData.ForeColor = Color.White;
                    BtnLoadOldData.Text = "继续添加数据";
                    lbCountValue.Text = commonHelper.OldDataHashSet.Count.ToString();

                }
                else
                {
                    BtnLoadOldData.BackColor = Color.Red;
                    BtnLoadOldData.ForeColor = Color.White;
                    BtnLoadOldData.Text = "数据加载失败";
                    lbCountValue.Text = commonHelper.OldDataHashSet.Count.ToString();
                }
            });
            BtnLoadOldData.BeginInvoke(actionSet);
        }
        /// <summary>
        /// 加载老数据
        /// </summary>
        /// <param name="path"></param>
        private void LoadCompareData(string[] path)
        {
            try
            {
                TxbMsg.Text = "";
                commonHelper.OldDataPath = path;
                Thread t = new Thread(commonHelper.BatchLoadData)
                {
                    IsBackground = true
                };
                t.Start();
            }
            catch (Exception e)
            {
                AppendTxt("加载数据出错:" + e.Message);
            }
        }
        /// <summary>
        /// 比较数据
        /// </summary>
        /// <param name="path"></param>
        private void CompareNewData(string path)
        {
            try
            {
                TxbMsg.Text = "";
                commonHelper.NewDataPath = path;
                Thread t = new Thread(commonHelper.FiltrateData)
                {
                    IsBackground = true
                };
                t.Start();
            }
            catch (Exception e)
            {
                AppendTxt("对比出错:" + e.Message);
            }
        }
        /// <summary>
        /// 拖拽
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString(); //获得路径
            if (CheckFileTypeHelper.CheckFileExpandedName(path).Equals(".txt"))
            {
                //if (commonHelper.DataHashSet.Count == 0)
                //{
                //    TxbOldPath.Text = path;
                //    LoadCompareData(path);
                //}
                //else
                //{
                //    TxbNewPath.Text = path;
                //    LoadCompareData(path);
                //}

            }
        }
        /// <summary>
        /// 拖拽
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All; //重要代码：表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// 设置保存位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSetPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog path = new FolderBrowserDialog())
                if (path.ShowDialog() == DialogResult.OK)
                {
                    TxbSavePath.Text = path.SelectedPath;
                }
        }
        /// <summary>
        /// 加载老文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoadOldData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;//该值确定是否可以选择多个文件
                dialog.Title = "请选择文件夹";
                dialog.Filter = "所有文件(*.txt)|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string[] path = dialog.FileNames;
                    foreach (string item in path)
                    {
                        if (!CheckFileTypeHelper.CheckFileExpandedName(item).Equals(".txt"))
                        {
                            AppendTxt("选中文件中包含非TXT文件，请检查!" + item);
                            return;
                        }
                    }
                    TxbOldPath.Text = path[0];
                    LoadCompareData(path);
                }
            }
        }
        /// <summary>
        /// 加载新文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoadNew_Click(object sender, EventArgs e)
        {
            if (commonHelper.OldDataHashSet.Count == 0)
            {
                AppendTxt("库中没有数据！");
                return;
            }
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;//该值确定是否可以选择多个文件
                dialog.Title = "请选择文件夹";
                dialog.Filter = "所有文件(*.txt)|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.FileName;
                    if (CheckFileTypeHelper.CheckFileExpandedName(path).Equals(".txt"))
                    {
                        TxbNewPath.Text = path;
                        CompareNewData(path);
                    }
                }
            }
        }
        /// <summary>
        /// 重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResult_Click(object sender, EventArgs e)
        {
            LoadDefault();
        }
        /// <summary>
        /// 文本框变更事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbSavePath_TextChanged(object sender, EventArgs e)
        {
            commonHelper.ExportDir = TxbSavePath.Text;
        }
        /// <summary>
        /// 打开文件位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpenExport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + Path.Combine(TxbSavePath.Text, "不重复数据.txt");
            System.Diagnostics.Process.Start(psi);
            //System.Diagnostics.Process.Start("Explorer", "/select," + TxbSavePath.Text + "\\" + "不重复数据.txt");
        }
        /// <summary>
        /// 是否保存不重复文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChbIsSave_CheckedChanged(object sender, EventArgs e)
        {
            commonHelper.isSaveDuplicatesData = ChbIsSave.Checked;
        }

        private void BtnWriteOldData_Click(object sender, EventArgs e)
        {
            WriteDataClass Wdata = new WriteDataClass()
            {
                WriteDataHashSet = commonHelper.OldDataHashSet,
                TxtName = "老数据"

            };
            Thread t = new Thread(() => { commonHelper.WriteDateToTxt(Wdata); })
            {
                IsBackground = true
            };
            t.Start();
        }
    }
}

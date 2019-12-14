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
            commonHelper.UpdateInfo = AppendTxt;
            commonHelper.loadResult = LoadResult;
            commonHelper.compareResult = CompareResult;
            commonHelper.OldDataPath = string.Empty;
            commonHelper.DefaultHashSet();
        }
        /// <summary>
        /// 添加消息框
        /// </summary>
        /// <param name="msg"></param>
        private void AppendTxt(string msg)
        {
            if (TxbMsg.InvokeRequired)
            {
                TxbMsg.BeginInvoke(new Action(() => { TxbMsg.AppendText(msg + Environment.NewLine); }));
            }
            else
            {
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
                AppendTxt("文件加载成功！");
            }
            else
            {
                commonHelper.OldDataPath = string.Empty;
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
                    BtnLoadOldData.Text = "数据加载成功";
                }
                else
                {
                    BtnLoadOldData.BackColor = Color.Red;
                    BtnLoadOldData.ForeColor = Color.White;
                    BtnLoadOldData.Text = "数据加载失败";
                }
            });
            if (BtnLoadOldData.InvokeRequired)
            {
                BtnLoadOldData.BeginInvoke(actionSet);
            }
            else
            {
                BtnLoadOldData.BeginInvoke(actionSet);
            }
        }
        /// <summary>
        /// 加载老数据
        /// </summary>
        /// <param name="path"></param>
        private void LoadCompareData(string path, int opMode)
        {
            try
            {
                if (commonHelper.DataHashSet.Count == 0 && opMode == 0)
                {
                    TxbMsg.Text = "";
                    commonHelper.OldDataPath = path;
                    Thread t = new Thread(commonHelper.LoadOldData);
                    t.IsBackground = true;
                    t.Start();
                }
                else if (commonHelper.DataHashSet.Count != 0 && opMode == 1)
                {
                    if (string.IsNullOrEmpty(commonHelper.ExportDir))
                    {
                        AppendTxt("请选择导出位置");
                        return;
                    }
                    commonHelper.NewDataPath = path;
                    Thread t = new Thread(commonHelper.FiltrateData);
                    t.IsBackground = true;
                    t.Start();
                }
                else
                {
                    AppendTxt("请加载老数据或重置程序");
                }
            }
            catch (Exception e)
            {
                AppendTxt("运行出错:" + e.Message);
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
                if (commonHelper.DataHashSet.Count == 0)
                {
                    TxbOldPath.Text = path;
                    LoadCompareData(path, 0);
                }
                else
                {
                    TxbNewPath.Text = path;
                    LoadCompareData(path, 1);
                }

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
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            TxbSavePath.Text = path.SelectedPath;
        }
        /// <summary>
        /// 加载老文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoadOldData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbOldPath.Text))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = false;//该值确定是否可以选择多个文件
                dialog.Title = "请选择文件夹";
                dialog.Filter = "所有文件(*.txt)|*.txt";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = dialog.FileName;
                    if (CheckFileTypeHelper.CheckFileExpandedName(path).Equals(".txt"))
                    {
                        TxbOldPath.Text = path;
                        LoadCompareData(path, 0);
                    }
                }
            }
            else
            {
                LoadCompareData(TxbOldPath.Text, 0);
            }

        }
        /// <summary>
        /// 加载新文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoadNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbNewPath.Text))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = false;//该值确定是否可以选择多个文件
                dialog.Title = "请选择文件夹";
                dialog.Filter = "所有文件(*.txt)|*.txt";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = dialog.FileName;
                    if (CheckFileTypeHelper.CheckFileExpandedName(path).Equals(".txt"))
                    {
                        TxbNewPath.Text = path;
                        LoadCompareData(path, 1);
                    }
                }
            }
            else
            {
                LoadCompareData(TxbOldPath.Text, 1);
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

        private void ChbIsSave_CheckedChanged(object sender, EventArgs e)
        {
            commonHelper.isSaveDuplicatesData = ChbIsSave.Checked;
        }
    }
}

﻿namespace TXTRemoveDuplicates
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BtnLoadOldData = new System.Windows.Forms.Button();
            this.TxbMsg = new System.Windows.Forms.TextBox();
            this.ChbIsSave = new System.Windows.Forms.CheckBox();
            this.TxbOldPath = new System.Windows.Forms.TextBox();
            this.BtnSetPath = new System.Windows.Forms.Button();
            this.TxbSavePath = new System.Windows.Forms.TextBox();
            this.TxbNewPath = new System.Windows.Forms.TextBox();
            this.BtnLoadNew = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.BtnOpenExport = new System.Windows.Forms.Button();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbCountValue = new System.Windows.Forms.Label();
            this.BtnWriteOldData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlParent = new System.Windows.Forms.Panel();
            this.PnlLoad = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlCompare = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlParent.SuspendLayout();
            this.PnlLoad.SuspendLayout();
            this.PnlCompare.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLoadOldData
            // 
            this.BtnLoadOldData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadOldData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadOldData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLoadOldData.Location = new System.Drawing.Point(519, 14);
            this.BtnLoadOldData.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLoadOldData.Name = "BtnLoadOldData";
            this.BtnLoadOldData.Size = new System.Drawing.Size(156, 31);
            this.BtnLoadOldData.TabIndex = 0;
            this.BtnLoadOldData.Text = "加载老数据";
            this.BtnLoadOldData.UseVisualStyleBackColor = true;
            this.BtnLoadOldData.Click += new System.EventHandler(this.BtnLoadOldData_Click);
            // 
            // TxbMsg
            // 
            this.TxbMsg.AllowDrop = true;
            this.TxbMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbMsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxbMsg.Location = new System.Drawing.Point(16, 162);
            this.TxbMsg.Margin = new System.Windows.Forms.Padding(4);
            this.TxbMsg.Multiline = true;
            this.TxbMsg.Name = "TxbMsg";
            this.TxbMsg.ReadOnly = true;
            this.TxbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxbMsg.Size = new System.Drawing.Size(657, 455);
            this.TxbMsg.TabIndex = 1;
            this.TxbMsg.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxbMsg_DragEnter);
            // 
            // ChbIsSave
            // 
            this.ChbIsSave.AutoSize = true;
            this.ChbIsSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChbIsSave.Location = new System.Drawing.Point(16, 131);
            this.ChbIsSave.Margin = new System.Windows.Forms.Padding(4);
            this.ChbIsSave.Name = "ChbIsSave";
            this.ChbIsSave.Size = new System.Drawing.Size(151, 24);
            this.ChbIsSave.TabIndex = 2;
            this.ChbIsSave.Text = "是否另存重复数据";
            this.ChbIsSave.UseVisualStyleBackColor = true;
            this.ChbIsSave.CheckedChanged += new System.EventHandler(this.ChbIsSave_CheckedChanged);
            // 
            // TxbOldPath
            // 
            this.TxbOldPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbOldPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxbOldPath.Location = new System.Drawing.Point(16, 16);
            this.TxbOldPath.Margin = new System.Windows.Forms.Padding(4);
            this.TxbOldPath.Name = "TxbOldPath";
            this.TxbOldPath.ReadOnly = true;
            this.TxbOldPath.Size = new System.Drawing.Size(492, 27);
            this.TxbOldPath.TabIndex = 3;
            // 
            // BtnSetPath
            // 
            this.BtnSetPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSetPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSetPath.Location = new System.Drawing.Point(519, 52);
            this.BtnSetPath.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSetPath.Name = "BtnSetPath";
            this.BtnSetPath.Size = new System.Drawing.Size(156, 31);
            this.BtnSetPath.TabIndex = 4;
            this.BtnSetPath.Text = "设置保存位置";
            this.BtnSetPath.UseVisualStyleBackColor = true;
            this.BtnSetPath.Click += new System.EventHandler(this.BtnSetPath_Click);
            // 
            // TxbSavePath
            // 
            this.TxbSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbSavePath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxbSavePath.Location = new System.Drawing.Point(16, 54);
            this.TxbSavePath.Margin = new System.Windows.Forms.Padding(4);
            this.TxbSavePath.Name = "TxbSavePath";
            this.TxbSavePath.ReadOnly = true;
            this.TxbSavePath.Size = new System.Drawing.Size(492, 27);
            this.TxbSavePath.TabIndex = 6;
            this.TxbSavePath.TextChanged += new System.EventHandler(this.TxbSavePath_TextChanged);
            // 
            // TxbNewPath
            // 
            this.TxbNewPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbNewPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxbNewPath.Location = new System.Drawing.Point(16, 91);
            this.TxbNewPath.Margin = new System.Windows.Forms.Padding(4);
            this.TxbNewPath.Name = "TxbNewPath";
            this.TxbNewPath.ReadOnly = true;
            this.TxbNewPath.Size = new System.Drawing.Size(492, 27);
            this.TxbNewPath.TabIndex = 7;
            // 
            // BtnLoadNew
            // 
            this.BtnLoadNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLoadNew.Location = new System.Drawing.Point(519, 90);
            this.BtnLoadNew.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLoadNew.Name = "BtnLoadNew";
            this.BtnLoadNew.Size = new System.Drawing.Size(156, 31);
            this.BtnLoadNew.TabIndex = 8;
            this.BtnLoadNew.Text = "选择新文件并比较";
            this.BtnLoadNew.UseVisualStyleBackColor = true;
            this.BtnLoadNew.Click += new System.EventHandler(this.BtnLoadNew_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnResult.Location = new System.Drawing.Point(519, 126);
            this.BtnResult.Margin = new System.Windows.Forms.Padding(4);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(156, 31);
            this.BtnResult.TabIndex = 9;
            this.BtnResult.Text = "重置并清空";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // BtnOpenExport
            // 
            this.BtnOpenExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenExport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOpenExport.Location = new System.Drawing.Point(387, 126);
            this.BtnOpenExport.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOpenExport.Name = "BtnOpenExport";
            this.BtnOpenExport.Size = new System.Drawing.Size(123, 31);
            this.BtnOpenExport.TabIndex = 10;
            this.BtnOpenExport.Text = "打开导出位置";
            this.BtnOpenExport.UseVisualStyleBackColor = true;
            this.BtnOpenExport.Click += new System.EventHandler(this.BtnOpenExport_Click);
            // 
            // lbCount
            // 
            this.lbCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCount.Location = new System.Drawing.Point(653, 622);
            this.lbCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(24, 20);
            this.lbCount.TabIndex = 11;
            this.lbCount.Text = "条";
            // 
            // lbCountValue
            // 
            this.lbCountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCountValue.BackColor = System.Drawing.SystemColors.Control;
            this.lbCountValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCountValue.Location = new System.Drawing.Point(529, 621);
            this.lbCountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountValue.Name = "lbCountValue";
            this.lbCountValue.Size = new System.Drawing.Size(129, 24);
            this.lbCountValue.TabIndex = 12;
            this.lbCountValue.Text = "999999999";
            this.lbCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnWriteOldData
            // 
            this.BtnWriteOldData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWriteOldData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWriteOldData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnWriteOldData.Location = new System.Drawing.Point(275, 126);
            this.BtnWriteOldData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnWriteOldData.Name = "BtnWriteOldData";
            this.BtnWriteOldData.Size = new System.Drawing.Size(105, 31);
            this.BtnWriteOldData.TabIndex = 13;
            this.BtnWriteOldData.Text = "导出库数据";
            this.BtnWriteOldData.UseVisualStyleBackColor = true;
            this.BtnWriteOldData.Click += new System.EventHandler(this.BtnWriteOldData_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 622);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "TXT去重 limit7@vip.qq.com";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlParent
            // 
            this.PnlParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlParent.Controls.Add(this.PnlLoad);
            this.PnlParent.Controls.Add(this.PnlCompare);
            this.PnlParent.Location = new System.Drawing.Point(16, 162);
            this.PnlParent.Margin = new System.Windows.Forms.Padding(4);
            this.PnlParent.Name = "PnlParent";
            this.PnlParent.Size = new System.Drawing.Size(659, 456);
            this.PnlParent.TabIndex = 15;
            // 
            // PnlLoad
            // 
            this.PnlLoad.AllowDrop = true;
            this.PnlLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLoad.Controls.Add(this.label3);
            this.PnlLoad.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlLoad.Location = new System.Drawing.Point(340, 0);
            this.PnlLoad.Margin = new System.Windows.Forms.Padding(4);
            this.PnlLoad.Name = "PnlLoad";
            this.PnlLoad.Size = new System.Drawing.Size(319, 456);
            this.PnlLoad.TabIndex = 1;
            this.PnlLoad.DragDrop += new System.Windows.Forms.DragEventHandler(this.PnlLoad_DragDrop);
            this.PnlLoad.DragEnter += new System.Windows.Forms.DragEventHandler(this.PnlLoad_DragEnter);
            this.PnlLoad.DragLeave += new System.EventHandler(this.PnlLoad_DragLeave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 90);
            this.label3.TabIndex = 14;
            this.label3.Text = "拖拽此处添加到老数据";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlCompare
            // 
            this.PnlCompare.AllowDrop = true;
            this.PnlCompare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCompare.Controls.Add(this.label2);
            this.PnlCompare.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlCompare.Location = new System.Drawing.Point(0, 0);
            this.PnlCompare.Margin = new System.Windows.Forms.Padding(4);
            this.PnlCompare.Name = "PnlCompare";
            this.PnlCompare.Size = new System.Drawing.Size(319, 456);
            this.PnlCompare.TabIndex = 0;
            this.PnlCompare.DragDrop += new System.Windows.Forms.DragEventHandler(this.PnlCompare_DragDrop);
            this.PnlCompare.DragEnter += new System.Windows.Forms.DragEventHandler(this.PnlCompare_DragEnter);
            this.PnlCompare.DragLeave += new System.EventHandler(this.PnlCompare_DragLeave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 90);
            this.label2.TabIndex = 13;
            this.label2.Text = "拖拽到此处进行去重";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 648);
            this.Controls.Add(this.PnlParent);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.BtnWriteOldData);
            this.Controls.Add(this.lbCountValue);
            this.Controls.Add(this.BtnOpenExport);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.BtnLoadNew);
            this.Controls.Add(this.TxbNewPath);
            this.Controls.Add(this.TxbSavePath);
            this.Controls.Add(this.BtnSetPath);
            this.Controls.Add(this.TxbOldPath);
            this.Controls.Add(this.ChbIsSave);
            this.Controls.Add(this.TxbMsg);
            this.Controls.Add(this.BtnLoadOldData);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(606, 549);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TXT去重";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PnlParent.ResumeLayout(false);
            this.PnlLoad.ResumeLayout(false);
            this.PnlCompare.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadOldData;
        private System.Windows.Forms.TextBox TxbMsg;
        private System.Windows.Forms.CheckBox ChbIsSave;
        private System.Windows.Forms.TextBox TxbOldPath;
        private System.Windows.Forms.Button BtnSetPath;
        private System.Windows.Forms.TextBox TxbSavePath;
        private System.Windows.Forms.TextBox TxbNewPath;
        private System.Windows.Forms.Button BtnLoadNew;
        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.Button BtnOpenExport;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbCountValue;
        private System.Windows.Forms.Button BtnWriteOldData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlParent;
        private System.Windows.Forms.Panel PnlLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PnlCompare;
        private System.Windows.Forms.Label label2;
    }
}


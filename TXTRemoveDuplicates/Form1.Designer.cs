namespace TXTRemoveDuplicates
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
            this.SuspendLayout();
            // 
            // BtnLoadOldData
            // 
            this.BtnLoadOldData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadOldData.Location = new System.Drawing.Point(483, 15);
            this.BtnLoadOldData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLoadOldData.Name = "BtnLoadOldData";
            this.BtnLoadOldData.Size = new System.Drawing.Size(156, 29);
            this.BtnLoadOldData.TabIndex = 0;
            this.BtnLoadOldData.Text = "加载老数据";
            this.BtnLoadOldData.UseVisualStyleBackColor = true;
            this.BtnLoadOldData.Click += new System.EventHandler(this.BtnLoadOldData_Click);
            // 
            // TxbMsg
            // 
            this.TxbMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbMsg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxbMsg.Location = new System.Drawing.Point(16, 162);
            this.TxbMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxbMsg.Multiline = true;
            this.TxbMsg.Name = "TxbMsg";
            this.TxbMsg.ReadOnly = true;
            this.TxbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxbMsg.Size = new System.Drawing.Size(621, 338);
            this.TxbMsg.TabIndex = 1;
            // 
            // ChbIsSave
            // 
            this.ChbIsSave.AutoSize = true;
            this.ChbIsSave.Location = new System.Drawing.Point(16, 124);
            this.ChbIsSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChbIsSave.Name = "ChbIsSave";
            this.ChbIsSave.Size = new System.Drawing.Size(149, 19);
            this.ChbIsSave.TabIndex = 2;
            this.ChbIsSave.Text = "是否另存重复数据";
            this.ChbIsSave.UseVisualStyleBackColor = true;
            this.ChbIsSave.CheckedChanged += new System.EventHandler(this.ChbIsSave_CheckedChanged);
            // 
            // TxbOldPath
            // 
            this.TxbOldPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbOldPath.Location = new System.Drawing.Point(16, 16);
            this.TxbOldPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxbOldPath.Name = "TxbOldPath";
            this.TxbOldPath.ReadOnly = true;
            this.TxbOldPath.Size = new System.Drawing.Size(456, 25);
            this.TxbOldPath.TabIndex = 3;
            // 
            // BtnSetPath
            // 
            this.BtnSetPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSetPath.Location = new System.Drawing.Point(483, 52);
            this.BtnSetPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSetPath.Name = "BtnSetPath";
            this.BtnSetPath.Size = new System.Drawing.Size(156, 29);
            this.BtnSetPath.TabIndex = 4;
            this.BtnSetPath.Text = "设置保存位置";
            this.BtnSetPath.UseVisualStyleBackColor = true;
            this.BtnSetPath.Click += new System.EventHandler(this.BtnSetPath_Click);
            // 
            // TxbSavePath
            // 
            this.TxbSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbSavePath.Location = new System.Drawing.Point(16, 54);
            this.TxbSavePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxbSavePath.Name = "TxbSavePath";
            this.TxbSavePath.ReadOnly = true;
            this.TxbSavePath.Size = new System.Drawing.Size(456, 25);
            this.TxbSavePath.TabIndex = 6;
            this.TxbSavePath.TextChanged += new System.EventHandler(this.TxbSavePath_TextChanged);
            // 
            // TxbNewPath
            // 
            this.TxbNewPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbNewPath.Location = new System.Drawing.Point(16, 91);
            this.TxbNewPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxbNewPath.Name = "TxbNewPath";
            this.TxbNewPath.ReadOnly = true;
            this.TxbNewPath.Size = new System.Drawing.Size(456, 25);
            this.TxbNewPath.TabIndex = 7;
            // 
            // BtnLoadNew
            // 
            this.BtnLoadNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadNew.Location = new System.Drawing.Point(483, 90);
            this.BtnLoadNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLoadNew.Name = "BtnLoadNew";
            this.BtnLoadNew.Size = new System.Drawing.Size(156, 29);
            this.BtnLoadNew.TabIndex = 8;
            this.BtnLoadNew.Text = "选择新文件并比较";
            this.BtnLoadNew.UseVisualStyleBackColor = true;
            this.BtnLoadNew.Click += new System.EventHandler(this.BtnLoadNew_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResult.Location = new System.Drawing.Point(483, 126);
            this.BtnResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(156, 29);
            this.BtnResult.TabIndex = 9;
            this.BtnResult.Text = "重置并清空";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // BtnOpenExport
            // 
            this.BtnOpenExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenExport.Location = new System.Drawing.Point(350, 126);
            this.BtnOpenExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnOpenExport.Name = "BtnOpenExport";
            this.BtnOpenExport.Size = new System.Drawing.Size(122, 29);
            this.BtnOpenExport.TabIndex = 10;
            this.BtnOpenExport.Text = "打开导出位置";
            this.BtnOpenExport.UseVisualStyleBackColor = true;
            this.BtnOpenExport.Click += new System.EventHandler(this.BtnOpenExport_Click);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(13, 144);
            this.lbCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(60, 15);
            this.lbCount.TabIndex = 11;
            this.lbCount.Text = "库总量:";
            // 
            // lbCountValue
            // 
            this.lbCountValue.AutoSize = true;
            this.lbCountValue.Location = new System.Drawing.Point(84, 144);
            this.lbCountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountValue.Name = "lbCountValue";
            this.lbCountValue.Size = new System.Drawing.Size(15, 15);
            this.lbCountValue.TabIndex = 12;
            this.lbCountValue.Text = "0";
            // 
            // BtnWriteOldData
            // 
            this.BtnWriteOldData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWriteOldData.Location = new System.Drawing.Point(245, 126);
            this.BtnWriteOldData.Name = "BtnWriteOldData";
            this.BtnWriteOldData.Size = new System.Drawing.Size(98, 29);
            this.BtnWriteOldData.TabIndex = 13;
            this.BtnWriteOldData.Text = "导出库数据";
            this.BtnWriteOldData.UseVisualStyleBackColor = true;
            this.BtnWriteOldData.Click += new System.EventHandler(this.BtnWriteOldData_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 514);
            this.Controls.Add(this.BtnWriteOldData);
            this.Controls.Add(this.lbCountValue);
            this.Controls.Add(this.lbCount);
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(607, 551);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TXT去重---极限";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
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
    }
}


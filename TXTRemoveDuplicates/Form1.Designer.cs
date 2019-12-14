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
            this.SuspendLayout();
            // 
            // BtnLoadOldData
            // 
            this.BtnLoadOldData.Location = new System.Drawing.Point(309, 12);
            this.BtnLoadOldData.Name = "BtnLoadOldData";
            this.BtnLoadOldData.Size = new System.Drawing.Size(117, 23);
            this.BtnLoadOldData.TabIndex = 0;
            this.BtnLoadOldData.Text = "加载老数据";
            this.BtnLoadOldData.UseVisualStyleBackColor = true;
            this.BtnLoadOldData.Click += new System.EventHandler(this.BtnLoadOldData_Click);
            // 
            // TxbMsg
            // 
            this.TxbMsg.Location = new System.Drawing.Point(12, 130);
            this.TxbMsg.Multiline = true;
            this.TxbMsg.Name = "TxbMsg";
            this.TxbMsg.ReadOnly = true;
            this.TxbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxbMsg.Size = new System.Drawing.Size(414, 265);
            this.TxbMsg.TabIndex = 1;
            // 
            // ChbIsSave
            // 
            this.ChbIsSave.AutoSize = true;
            this.ChbIsSave.Location = new System.Drawing.Point(12, 105);
            this.ChbIsSave.Name = "ChbIsSave";
            this.ChbIsSave.Size = new System.Drawing.Size(120, 16);
            this.ChbIsSave.TabIndex = 2;
            this.ChbIsSave.Text = "是否另存重复数据";
            this.ChbIsSave.UseVisualStyleBackColor = true;
            this.ChbIsSave.CheckedChanged += new System.EventHandler(this.ChbIsSave_CheckedChanged);
            // 
            // TxbOldPath
            // 
            this.TxbOldPath.Location = new System.Drawing.Point(12, 13);
            this.TxbOldPath.Name = "TxbOldPath";
            this.TxbOldPath.ReadOnly = true;
            this.TxbOldPath.Size = new System.Drawing.Size(290, 21);
            this.TxbOldPath.TabIndex = 3;
            // 
            // BtnSetPath
            // 
            this.BtnSetPath.Location = new System.Drawing.Point(309, 42);
            this.BtnSetPath.Name = "BtnSetPath";
            this.BtnSetPath.Size = new System.Drawing.Size(117, 23);
            this.BtnSetPath.TabIndex = 4;
            this.BtnSetPath.Text = "设置保存位置";
            this.BtnSetPath.UseVisualStyleBackColor = true;
            this.BtnSetPath.Click += new System.EventHandler(this.BtnSetPath_Click);
            // 
            // TxbSavePath
            // 
            this.TxbSavePath.Location = new System.Drawing.Point(12, 43);
            this.TxbSavePath.Name = "TxbSavePath";
            this.TxbSavePath.ReadOnly = true;
            this.TxbSavePath.Size = new System.Drawing.Size(290, 21);
            this.TxbSavePath.TabIndex = 6;
            this.TxbSavePath.TextChanged += new System.EventHandler(this.TxbSavePath_TextChanged);
            // 
            // TxbNewPath
            // 
            this.TxbNewPath.Location = new System.Drawing.Point(12, 73);
            this.TxbNewPath.Name = "TxbNewPath";
            this.TxbNewPath.ReadOnly = true;
            this.TxbNewPath.Size = new System.Drawing.Size(290, 21);
            this.TxbNewPath.TabIndex = 7;
            // 
            // BtnLoadNew
            // 
            this.BtnLoadNew.Location = new System.Drawing.Point(309, 72);
            this.BtnLoadNew.Name = "BtnLoadNew";
            this.BtnLoadNew.Size = new System.Drawing.Size(117, 23);
            this.BtnLoadNew.TabIndex = 8;
            this.BtnLoadNew.Text = "选择新文件并比较";
            this.BtnLoadNew.UseVisualStyleBackColor = true;
            this.BtnLoadNew.Click += new System.EventHandler(this.BtnLoadNew_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(309, 101);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(117, 23);
            this.BtnResult.TabIndex = 9;
            this.BtnResult.Text = "重置并清空";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // BtnOpenExport
            // 
            this.BtnOpenExport.Location = new System.Drawing.Point(186, 101);
            this.BtnOpenExport.Name = "BtnOpenExport";
            this.BtnOpenExport.Size = new System.Drawing.Size(116, 23);
            this.BtnOpenExport.TabIndex = 10;
            this.BtnOpenExport.Text = "打开导出位置";
            this.BtnOpenExport.UseVisualStyleBackColor = true;
            this.BtnOpenExport.Click += new System.EventHandler(this.BtnOpenExport_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 405);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
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
    }
}


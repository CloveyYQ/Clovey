﻿namespace ClyUpdateClient
{
    partial class ClyUpdateClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClyUpdateClient));
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SynProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SynSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.DocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Other = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.cb_Start = new System.Windows.Forms.CheckBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pb_All = new System.Windows.Forms.ProgressBar();
            this.lbl_SUM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDownLoad = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_show = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(449, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 61;
            this.label4.Text = "更新文件：";
            // 
            // lbl_Size
            // 
            this.lbl_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Size.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Size.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Size.ForeColor = System.Drawing.Color.Black;
            this.lbl_Size.Location = new System.Drawing.Point(362, 337);
            this.lbl_Size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(280, 30);
            this.lbl_Size.TabIndex = 55;
            this.lbl_Size.Text = "大小:0MB/0MB";
            this.lbl_Size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 62;
            this.label3.Text = "更新进度：";
            // 
            // SynProgress
            // 
            this.SynProgress.DataPropertyName = "SynProgress";
            this.SynProgress.HeaderText = "进度";
            this.SynProgress.Name = "SynProgress";
            this.SynProgress.ReadOnly = true;
            this.SynProgress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SynProgress.Visible = false;
            // 
            // SynSpeed
            // 
            this.SynSpeed.DataPropertyName = "SynSpeed";
            this.SynSpeed.HeaderText = "已下载";
            this.SynSpeed.Name = "SynSpeed";
            this.SynSpeed.ReadOnly = true;
            this.SynSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SynSpeed.Width = 50;
            // 
            // FileSize
            // 
            this.FileSize.DataPropertyName = "FileSize";
            this.FileSize.HeaderText = "大小";
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            this.FileSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FileSize.Width = 50;
            // 
            // DocName
            // 
            this.DocName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DocName.DataPropertyName = "DocName";
            this.DocName.HeaderText = "更新文件";
            this.DocName.Name = "DocName";
            this.DocName.ReadOnly = true;
            this.DocName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "更新说明";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DocID
            // 
            this.DocID.DataPropertyName = "DocID";
            this.DocID.HeaderText = "DocID";
            this.DocID.Name = "DocID";
            this.DocID.ReadOnly = true;
            this.DocID.Visible = false;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoEllipsis = true;
            this.lbl_Info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Info.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Info.ForeColor = System.Drawing.Color.Black;
            this.lbl_Info.Location = new System.Drawing.Point(58, 34);
            this.lbl_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(291, 227);
            this.lbl_Info.TabIndex = 0;
            this.lbl_Info.Text = "正在更新最新版本....";
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.Width = 30;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Black;
            this.lbl_Title.Location = new System.Drawing.Point(198, 152);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(138, 28);
            this.lbl_Title.TabIndex = 50;
            this.lbl_Title.Text = "在线自动更新";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Title.Visible = false;
            // 
            // lbl_Other
            // 
            this.lbl_Other.AutoEllipsis = true;
            this.lbl_Other.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Other.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Other.ForeColor = System.Drawing.Color.Black;
            this.lbl_Other.Location = new System.Drawing.Point(4, 461);
            this.lbl_Other.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Other.Name = "lbl_Other";
            this.lbl_Other.Size = new System.Drawing.Size(240, 46);
            this.lbl_Other.TabIndex = 63;
            this.lbl_Other.Text = "在线更新程序";
            this.lbl_Other.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Other.Visible = false;
            // 
            // btn_OK
            // 
            this.btn_OK.Enabled = false;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(520, 454);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(112, 42);
            this.btn_OK.TabIndex = 59;
            this.btn_OK.Text = "启动";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // cb_Start
            // 
            this.cb_Start.AutoSize = true;
            this.cb_Start.BackColor = System.Drawing.Color.Transparent;
            this.cb_Start.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_Start.ForeColor = System.Drawing.Color.Black;
            this.cb_Start.Location = new System.Drawing.Point(25, 427);
            this.cb_Start.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Start.Name = "cb_Start";
            this.cb_Start.Size = new System.Drawing.Size(185, 32);
            this.cb_Start.TabIndex = 58;
            this.cb_Start.Text = "更新后自动启动";
            this.cb_Start.UseVisualStyleBackColor = false;
            this.cb_Start.CheckedChanged += new System.EventHandler(this.cb_Start_CheckedChanged);
            // 
            // lbl_Error
            // 
            this.lbl_Error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Error.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(136, 378);
            this.lbl_Error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(439, 30);
            this.lbl_Error.TabIndex = 60;
            this.lbl_Error.Text = "错误";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Error.Visible = false;
            // 
            // pb_All
            // 
            this.pb_All.Location = new System.Drawing.Point(141, 379);
            this.pb_All.Margin = new System.Windows.Forms.Padding(4);
            this.pb_All.Name = "pb_All";
            this.pb_All.Size = new System.Drawing.Size(431, 23);
            this.pb_All.TabIndex = 57;
            // 
            // lbl_SUM
            // 
            this.lbl_SUM.AutoSize = true;
            this.lbl_SUM.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SUM.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SUM.ForeColor = System.Drawing.Color.Black;
            this.lbl_SUM.Location = new System.Drawing.Point(17, 338);
            this.lbl_SUM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SUM.Name = "lbl_SUM";
            this.lbl_SUM.Size = new System.Drawing.Size(108, 28);
            this.lbl_SUM.TabIndex = 56;
            this.lbl_SUM.Text = "文件：0/0";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_Info);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Controls.Add(this.dgvDownLoad);
            this.panel1.Location = new System.Drawing.Point(22, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 271);
            this.panel1.TabIndex = 54;
            // 
            // dgvDownLoad
            // 
            this.dgvDownLoad.AllowUserToAddRows = false;
            this.dgvDownLoad.AllowUserToDeleteRows = false;
            this.dgvDownLoad.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDownLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDownLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.DocID,
            this.DocName,
            this.FileSize,
            this.SynSpeed,
            this.SynProgress});
            this.dgvDownLoad.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvDownLoad.Location = new System.Drawing.Point(185, 75);
            this.dgvDownLoad.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDownLoad.Name = "dgvDownLoad";
            this.dgvDownLoad.ReadOnly = true;
            this.dgvDownLoad.RowHeadersVisible = false;
            this.dgvDownLoad.RowTemplate.Height = 23;
            this.dgvDownLoad.Size = new System.Drawing.Size(72, 73);
            this.dgvDownLoad.TabIndex = 52;
            this.dgvDownLoad.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_show
            // 
            this.lbl_show.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbl_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_show.Enabled = false;
            this.lbl_show.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_show.Location = new System.Drawing.Point(456, 87);
            this.lbl_show.Multiline = true;
            this.lbl_show.Name = "lbl_show";
            this.lbl_show.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lbl_show.Size = new System.Drawing.Size(200, 237);
            this.lbl_show.TabIndex = 64;
            // 
            // ClyUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.CanResize = false;
            this.CaptionHeight = 35;
            this.ClientSize = new System.Drawing.Size(681, 519);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.ControlBoxOffset = new System.Drawing.Point(1, 0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Other);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.cb_Start);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.pb_All);
            this.Controls.Add(this.lbl_SUM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_show);
            this.EffectCaption = CCWin.TitleType.Title;
            this.EffectWidth = 1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.Name = "ClyUpdateClient";
            this.Radius = 1;
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.Shadow = false;
            this.ShadowWidth = 1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件更新";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClyUpdateClient_FormClosed);
            this.Load += new System.EventHandler(this.UpdatePrecent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SynProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SynSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocID;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Other;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.CheckBox cb_Start;
        private System.Windows.Forms.Label lbl_Error;
        public System.Windows.Forms.ProgressBar pb_All;
        private System.Windows.Forms.Label lbl_SUM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDownLoad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox lbl_show;
    }
}


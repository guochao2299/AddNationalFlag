namespace AddRedFlag
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBefore = new System.Windows.Forms.TabPage();
            this.tpAfter = new System.Windows.Forms.TabPage();
            this.pBefore = new System.Windows.Forms.PictureBox();
            this.pAfter = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tpBefore.SuspendLayout();
            this.tpAfter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "图片路径：";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(97, 12);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(730, 25);
            this.txtImagePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(833, 11);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(87, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "浏  览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(834, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加国旗";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(833, 102);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBefore);
            this.tabControl1.Controls.Add(this.tpAfter);
            this.tabControl1.Location = new System.Drawing.Point(24, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 492);
            this.tabControl1.TabIndex = 6;
            // 
            // tpBefore
            // 
            this.tpBefore.Controls.Add(this.pBefore);
            this.tpBefore.Location = new System.Drawing.Point(4, 25);
            this.tpBefore.Name = "tpBefore";
            this.tpBefore.Padding = new System.Windows.Forms.Padding(3);
            this.tpBefore.Size = new System.Drawing.Size(795, 463);
            this.tpBefore.TabIndex = 0;
            this.tpBefore.Text = "原始图片";
            this.tpBefore.UseVisualStyleBackColor = true;
            // 
            // tpAfter
            // 
            this.tpAfter.Controls.Add(this.pAfter);
            this.tpAfter.Location = new System.Drawing.Point(4, 25);
            this.tpAfter.Name = "tpAfter";
            this.tpAfter.Padding = new System.Windows.Forms.Padding(3);
            this.tpAfter.Size = new System.Drawing.Size(795, 463);
            this.tpAfter.TabIndex = 1;
            this.tpAfter.Text = "添加国旗后的图片";
            this.tpAfter.UseVisualStyleBackColor = true;
            // 
            // pBefore
            // 
            this.pBefore.BackColor = System.Drawing.Color.Gray;
            this.pBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBefore.Location = new System.Drawing.Point(3, 3);
            this.pBefore.Name = "pBefore";
            this.pBefore.Size = new System.Drawing.Size(789, 457);
            this.pBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBefore.TabIndex = 0;
            this.pBefore.TabStop = false;
            // 
            // pAfter
            // 
            this.pAfter.BackColor = System.Drawing.Color.Gray;
            this.pAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAfter.Location = new System.Drawing.Point(3, 3);
            this.pAfter.Name = "pAfter";
            this.pAfter.Size = new System.Drawing.Size(789, 457);
            this.pAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pAfter.TabIndex = 1;
            this.pAfter.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 556);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "给图片添加国旗";
            this.tabControl1.ResumeLayout(false);
            this.tpBefore.ResumeLayout(false);
            this.tpAfter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBefore;
        private System.Windows.Forms.PictureBox pBefore;
        private System.Windows.Forms.TabPage tpAfter;
        private System.Windows.Forms.PictureBox pAfter;
    }
}


namespace XinFeng
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.ImportBnt = new System.Windows.Forms.Button();
            this.BatchPrintBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PrintDSBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.TextBox3);
            this.groupBox1.Controls.Add(this.TextBox2);
            this.groupBox1.Controls.Add(this.TextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(632, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单条记录打印：";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(124, 71);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(491, 25);
            this.TextBox3.TabIndex = 3;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(463, 28);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(152, 25);
            this.TextBox2.TabIndex = 2;
            this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(124, 28);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.MaxLength = 6;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(89, 25);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox1.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "收件人：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "邮寄地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "邮编：";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintBtn.Image")));
            this.PrintBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintBtn.Location = new System.Drawing.Point(653, 40);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(120, 70);
            this.PrintBtn.TabIndex = 1;
            this.PrintBtn.Text = "打  印";
            this.PrintBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // ImportBnt
            // 
            this.ImportBnt.Image = ((System.Drawing.Image)(resources.GetObject("ImportBnt.Image")));
            this.ImportBnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImportBnt.Location = new System.Drawing.Point(43, 44);
            this.ImportBnt.Margin = new System.Windows.Forms.Padding(4);
            this.ImportBnt.Name = "ImportBnt";
            this.ImportBnt.Size = new System.Drawing.Size(120, 34);
            this.ImportBnt.TabIndex = 1;
            this.ImportBnt.Text = "  导入数据";
            this.ImportBnt.UseVisualStyleBackColor = true;
            this.ImportBnt.Click += new System.EventHandler(this.ImportBnt_Click);
            // 
            // BatchPrintBtn
            // 
            this.BatchPrintBtn.Enabled = false;
            this.BatchPrintBtn.Image = ((System.Drawing.Image)(resources.GetObject("BatchPrintBtn.Image")));
            this.BatchPrintBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BatchPrintBtn.Location = new System.Drawing.Point(227, 44);
            this.BatchPrintBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BatchPrintBtn.Name = "BatchPrintBtn";
            this.BatchPrintBtn.Size = new System.Drawing.Size(120, 34);
            this.BatchPrintBtn.TabIndex = 1;
            this.BatchPrintBtn.Text = "  批量打印";
            this.BatchPrintBtn.UseVisualStyleBackColor = true;
            this.BatchPrintBtn.Click += new System.EventHandler(this.BatchPrintBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "统一称呼：";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(740, 51);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.MaxLength = 10;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 25);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "招生办";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.WordWrap = false;
            // 
            // PrintDSBtn
            // 
            this.PrintDSBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintDSBtn.Image")));
            this.PrintDSBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintDSBtn.Location = new System.Drawing.Point(781, 40);
            this.PrintDSBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PrintDSBtn.Name = "PrintDSBtn";
            this.PrintDSBtn.Size = new System.Drawing.Size(120, 70);
            this.PrintDSBtn.TabIndex = 1;
            this.PrintDSBtn.Text = "打印设计";
            this.PrintDSBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintDSBtn.UseVisualStyleBackColor = true;
            this.PrintDSBtn.Click += new System.EventHandler(this.PrintDSBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 29;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(13, 254);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(895, 268);
            this.dgv.TabIndex = 5;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResetBtn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.BatchPrintBtn);
            this.groupBox2.Controls.Add(this.ImportBnt);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 148);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(895, 99);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "批量打印信息导入：";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Enabled = false;
            this.ResetBtn.Location = new System.Drawing.Point(580, 52);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(52, 26);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "重置";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "条";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "到";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "范围：从";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(504, 51);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(35, 25);
            this.textBox6.TabIndex = 3;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(443, 51);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(35, 25);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.PrintDSBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信封打印工具  v1.7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button ImportBnt;
        private System.Windows.Forms.Button BatchPrintBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button PrintDSBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ResetBtn;
    }
}


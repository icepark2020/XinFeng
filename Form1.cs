using FastReport;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace XinFeng
{
    public partial class Form1 : Form
    {
        string reportFile;
        private bool IsDesign = false;


        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Left = 500;
            //this.Top = 300;

            InitInfo();
            SetColumns();
        }
        private void InitInfo()
        {

            //printPreviewDialog1.Document = pdControl;
            //string baseDir = Application.StartupPath;
            // reportFile = Path.Combine(baseDir, "Report/PostTemplate.frx");
            reportFile = @"Report/PostTemplate.frx";

            //FastReport.NET汉化
            FastReport.Utils.Res.LoadLocale(@"Report\Chinese (Simplified).frl");

        }
        private void SetColumns()
        {
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgv.Columns[0].HeaderText = "行号";
            dgv.Columns[1].HeaderText = "邮编";
            dgv.Columns[2].HeaderText = "地址";
            dgv.Columns[3].HeaderText = "单位名称";
            dgv.Columns[4].HeaderText = "姓名";

            dgv.Columns[0].FillWeight = 8; //第一列的相对宽度为8%
            dgv.Columns[1].FillWeight = 10; //第一列的相对宽度为10%
            dgv.Columns[2].FillWeight = 45; //第一列的相对宽度为45%
            dgv.Columns[3].FillWeight = 20; //第一列的相对宽度为20%
            dgv.Columns[4].FillWeight = 10; //第一列的相对宽度为10%
            for (int i = 0; i < this.dgv.Columns.Count; i++)
            {
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private Dictionary<string, object> GetDict()
        {
            var dict = new Dictionary<string, object>();

            var zipCode = TextBox1.Text.Trim().PadRight(6, ' ').ToCharArray();
            dict.Add("C1", zipCode[0]);
            dict.Add("C2", zipCode[1]);
            dict.Add("C3", zipCode[2]);
            dict.Add("C4", zipCode[3]);
            dict.Add("C5", zipCode[4]);
            dict.Add("C6", zipCode[5]);

            dict.Add("dizhi", this.TextBox3.Text.Trim());

            var name = this.TextBox2.Text.Trim();
            if (!name.EndsWith("收"))
            {
                name += " 收";
            }
            dict.Add("name", name);
            return dict;

        }
        private void ImportXLS()
        {
            DataSet ds = new DataSet();
            this.openFileDialog1.Filter = "*.xls;*.xlsx|*.xls;*.xlsx";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileNames.Length == 0)
            {
                MessageBox.Show("请选择文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable table = ExcelHelper.ImportFromExcel(openFileDialog1.FileName, "Sheet1", 0);
            ds.Tables.Add(table);
            dgv.Columns.Clear();
            dgv.DataSource = ds.Tables[0];
            SetColumns();
            textBox6.Text = dgv.Rows.Count.ToString();
            textBox5.Text = 1.ToString();
            ResetBtn.Enabled = true;
            BatchPrintBtn.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;

            //DataGridViewColumn c = new DataGridViewColumn();
            //dgv.AutoSizeColumnMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            // MessageBox.Show("文件导入完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
        private void BatchPrint()
        {
            //批量打印
            Report report = new Report();

            //加载报表
            report.Load(reportFile);
          
            string tyname, dwname, dizhi, name, yb;
            int endrow = int.Parse(textBox6.Text);
            int starrow = int.Parse(textBox5.Text);

            Form2 ff = new Form2();
            //ff.StartPosition = FormStartPosition.Manual;
            ff.StartPosition = FormStartPosition.CenterScreen;
            //ff.Location = new Point(this.Width - 80, this.Top + 120);


            ff.Show();

            int total = endrow - starrow + 1;
            int k = 1;

            EnvironmentSettings eSet = new EnvironmentSettings();
            eSet.ReportSettings.ShowProgress = false; //取消进度显示

            report.PrintSettings.ShowDialog = false;
            for (int i = starrow - 1; i < endrow; i++)
            {
                
               
                //report.Prepare(true);
                ff.TopMost = true;
                ff.SetCaption("正在打印...", string.Format("正在打印...任务 {0} / {1}", k++, total));
                //0   ,  1,     2,     3,       4
                //行号，邮编，地址，单位名称，姓名
                yb = dgv.Rows[i].Cells[1].Value.ToString();
                dwname = dgv.Rows[i].Cells[3].Value.ToString();
                dizhi = dgv.Rows[i].Cells[2].Value.ToString();

                if (textBox4.Text != "")
                {
                    tyname = "(" + textBox4.Text.Trim() + ")";
                    dizhi = dizhi + "—" + dwname + tyname;
                }
                else
                {
                    dizhi = dizhi + "—" + dwname;
                }

                name = dgv.Rows[i].Cells[4].Value.ToString();
                name = name + " 收";

                var dict = new Dictionary<string, object>();
                var zipCode = yb.ToString().PadRight(6, ' ').ToCharArray();
                dict.Add("C1", zipCode[0]);
                dict.Add("C2", zipCode[1]);
                dict.Add("C3", zipCode[2]);
                dict.Add("C4", zipCode[3]);
                dict.Add("C5", zipCode[4]);
                dict.Add("C6", zipCode[5]);
                dict.Add("dizhi", dizhi);
                dict.Add("name", name);

                foreach (string key in dict.Keys)
                {
                    report.SetParameterValue(key, dict[key]);
                }
                Application.DoEvents();


                //  report.Prepare(false);

                report.Print();
                Thread.Sleep(3000);
                // report.Show();


            }
            //report.ShowPrepared();
           // report.Show();
            //report.Print();

            ff.SetCaption("打印完成！", string.Format("完成全部打印，共打印【{0}】份！", total));
            //Thread.Sleep(1000);
            //ff.close();
            //report.Dispose();

        }
        private void SinglePrint()
        {

            Report report = new Report();
            //加载报表

            //string reportFile = @"E:\c#\信封.frx";

            report.Load(reportFile);

            Dictionary<string, object> dict = GetDict();

            foreach (string key in dict.Keys)
            {
                report.SetParameterValue(key, dict[key]);
            }


            if (!IsDesign)
            {
                report.Print();
            }
            else
            {
                report.Design();
            }


            //report.Print(); //准备
            // report.Dispose();

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            //测试打印




            if (TextBox2.Text == "" || TextBox3.Text == "")
            {

                MessageBox.Show("请输入收件人及地址！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IsDesign = false;
            SinglePrint();

        }
        private void PrintDSBtn_Click(object sender, EventArgs e)
        {

            IsDesign = true;
            SinglePrint();

        }
        private void ImportBnt_Click(object sender, EventArgs e)
        {
            ImportXLS();

        }
        private void BatchPrintBtn_Click(object sender, EventArgs e)
        {
            //连续打印

            if (dgv.Rows.Count < 1)
            {
                MessageBox.Show("文件没有成功导入，请检查 ！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BatchPrint();
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            //重置
            textBox6.Text = dgv.Rows.Count.ToString();
            textBox5.Text = 1.ToString();

        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string dwname = dgv.CurrentRow.Cells[3].Value.ToString();//学校名称
            string dizhi = dgv.CurrentRow.Cells[2].Value.ToString();//地址
            TextBox1.Text = dgv.CurrentRow.Cells[1].Value.ToString();//邮编
            TextBox2.Text = dgv.CurrentRow.Cells[4].Value.ToString();//收件人

            if (textBox4.Text != "")
            {
                string tyname = "(" + textBox4.Text.Trim() + ")";
                TextBox3.Text = dizhi + "—" + dwname + tyname;
            }
            else
            {
                TextBox3.Text = dizhi + "—" + dwname;
            }

        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //    if (dgv.Rows.Count < 1)
        //    {
        //        MessageBox.Show("文件没有成功导入，请检查 ！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    //批量打印
        //    Report report = new Report();
        //    //加载报表


        //    report.Load(reportFile);

        //    DataTable dt = (dgv.DataSource as DataTable);



        //    string tyname, dwname, dizhi, name;
        //    int endrow = int.Parse(textBox6.Text);
        //    int starrow = int.Parse(textBox5.Text);


        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        if (starrow < endrow + 1)
        //        {
        //            var dict = new Dictionary<string, object>();

        //            tyname = textBox4.Text.Trim();
        //            dwname = dr["单位名称"].ToString().Trim();
        //            dizhi = dr["地址"].ToString().Trim();
        //            dizhi = dizhi + "-" + dwname + "(" + tyname + ")";

        //            name = dr["姓名"].ToString().Trim();
        //            name = name + " 收";

        //            var zipCode = dr["邮编"].ToString().PadRight(6, ' ').ToCharArray();
        //            dict.Add("C1", zipCode[0]);
        //            dict.Add("C2", zipCode[1]);
        //            dict.Add("C3", zipCode[2]);
        //            dict.Add("C4", zipCode[3]);
        //            dict.Add("C5", zipCode[4]);
        //            dict.Add("C6", zipCode[5]);

        //            dict.Add("dizhi", dizhi);

        //            dict.Add("name", name);

        //            foreach (string key in dict.Keys)
        //            {
        //                report.SetParameterValue(key, dict[key]);
        //            }


        //            report.PrintSettings.ShowDialog = false;
        //            report.Print();

        //            Thread.Sleep(100);
        //            starrow++;
        //        }
        //    }



        //    //report.PrintSettings.ShowDialog = false;

        //    //report.Print(); //准备
        //    report.Dispose();


        //}
    }

}
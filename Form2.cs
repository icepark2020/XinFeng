using System.Windows.Forms;

namespace XinFeng
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public void SetCaption(string title, string content)
        {
            this.Text = title;
            label1.Text = content;
        }
        public void close() => this.Dispose();

    }
}

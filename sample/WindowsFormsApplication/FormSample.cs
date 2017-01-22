using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using WpfApplication;
using XY.UI;

namespace WindowsFormsApplication
{
    public partial class FormSample : Form
    {
        public FormSample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElementHost host = WindowGrid.GetHost<MainWindow>();

            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(host);
            this.Text = this.Tag.ToString() + "-[" + host.Name + "]";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElementHost host = WindowGrid.GetHost<Window1>();

            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(host);
            this.Text = this.Tag.ToString() + "-[" + host.Name + "]";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ElementHost host = WindowGrid.GetHost<Window2>();

            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(host);
            this.Text = this.Tag.ToString() + "-[" + host.Name + "]";
        }

        private void FormSample_Load(object sender, EventArgs e)
        {
            this.Tag = this.Text;
            ElementHost host = WindowGrid.GetHost<MainWindow>();

            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(host);
            this.Text = this.Tag.ToString() + "-[" + host.Name + "]";
        }

    }
}

using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void edge_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void go_Click(object sender, EventArgs e)
        {
            double valueedge;
            double valuediagonal;
            double valuearea;
            if (!(double.TryParse(edge.Text, out valueedge) == true))
            {
                MessageBox.Show("数値を入力してください");
            }
            else
            {
                valueedge = double.Parse(edge.Text);
                valuediagonal = valueedge * Math.Sqrt(2);
                diagonal.Text = valuediagonal.ToString();
                valuearea = valueedge * valueedge;
                area.Text = valuearea.ToString();
            }
        }
        private void exit_Click(object sender, EventArgs e) => Close();

        private void clear_Click(object sender, EventArgs e)
        {
            edge.Text = "0";
            diagonal.Text = "0";
            area.Text = "0";
        }
    }
}

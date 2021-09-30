using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Task
{
    public partial class TaskForm : Form
    {
        public TaskForm() 
        {
            InitializeComponent();
            nInput.Text = Properties.Settings.Default.n.ToString();
            if (nInput.Text.Length != 0)
            {
                solveLable.Text = "Искомое число: " + Logic.Solve(int.Parse(nInput.Text));
            }
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nInput.Text, out int n))
            {
                solveLable.Text = "Искомое число: " + Logic.Solve(n);
                Properties.Settings.Default.n = nInput.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("В строке должны быть только цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nInput_TextChanged(object sender, EventArgs e)
        {
            if (nInput.Text.Length > 0)
            {
                solveButton.Enabled = true;
            }
            else
            {
                solveButton.Enabled = false;
            }
        }
    }
}

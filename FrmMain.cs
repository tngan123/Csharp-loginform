using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_loginform
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(btnTinh.Text);
            for (int i = 1; i <= 0; i++)
            {
                if (a%1 == 0)
                    btnTinh.Text = i.ToString();
            }

        }
    }
}

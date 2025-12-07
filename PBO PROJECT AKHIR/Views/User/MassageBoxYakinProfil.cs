using PBO_PROJECT_AKHIR.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_PROJECT_AKHIR.Views.User
{
    public partial class MassageBoxYakinProfil : Form
    {
        public MassageBoxYakinProfil()
        {
            InitializeComponent();
        }

        private void lbbatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lbyakin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

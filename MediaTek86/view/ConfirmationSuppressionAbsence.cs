using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.view
{
    public partial class ConfirmSupprAbsence : Form
    {
        public ConfirmSupprAbsence()
        {
            InitializeComponent();
            btnAnnulSupprAbsence.Click += btnAnnulSupprAbsence_Click;
        }

        private void btnAnnulSupprAbsence_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmSupprAbsence_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

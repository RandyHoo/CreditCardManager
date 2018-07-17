using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRecording_Click(object sender, EventArgs e)
        {
            RecordingForm form = new RecordingForm();
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void cmbMonth_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbYear2_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}

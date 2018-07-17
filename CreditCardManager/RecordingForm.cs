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
    public partial class RecordingForm : Form
    {
        CommonFunc cf = new CommonFunc();

        public RecordingForm()
        {
            InitializeComponent();

        }

        private void btnRecording_Click(object sender, EventArgs e)
        {
            DataTable dt = cf.getDataTable("SELECT ID FROM LOG");
            int id = (dt.Rows.Count != 0) ? Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["ID"].ToString()) + 1 : 0;

            if (checkInput())
            {
                string SQL = "INSERT INTO LOG VALUES("
                           + id + ","
                           + cmbYear.Text + ","
                           + cmbMonth.Text + ","
                           + cf.surroundApos(txtPlace.Text) + ","
                           + cf.surroundApos(txtName.Text) + ","
                           + txtValue.Text + ")";

                if (cf.executeSQL(SQL) != 0)
                {
                    MessageBox.Show("記録されました。");
                }
                else
                {
                    MessageBox.Show("記録に失敗しました。");
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkInput()
        {
            if (String.IsNullOrEmpty(cmbYear.Text))
            {
                MessageBox.Show("年が入力されていません。");
                return false;
            }

            if (String.IsNullOrEmpty(cmbMonth.Text))
            {
                MessageBox.Show("月が入力されていません。");
                return false;
            }

            if (String.IsNullOrEmpty(txtPlace.Text))
            {
                MessageBox.Show("購入場所が入力されていません。");
                return false;
            }

            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("品名が入力されていません。");
                return false;
            }

            if (String.IsNullOrEmpty(txtValue.Text))
            {
                MessageBox.Show("金額が入力されていません。");
                return false;
            }

            return true;
        }
    }
}

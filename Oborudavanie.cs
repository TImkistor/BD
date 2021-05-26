using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Oborudavanie : Form
    {
        public Oborudavanie()
        {
            InitializeComponent();
        }

        private void oborudovaniyeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oborudovaniyeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Индивидуальное_задание_25_04DataSet1);

        }

        private void Oborudavanie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Индивидуальное_задание_25_04DataSet1.Oborudovaniye". При необходимости она может быть перемещена или удалена.
            this.oborudovaniyeTableAdapter.Fill(this._Индивидуальное_задание_25_04DataSet1.Oborudovaniye);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
            this.Hide();
        }
        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}

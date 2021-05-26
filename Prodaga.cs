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
    public partial class Prodaga : Form
    {
        public Prodaga()
        {
            InitializeComponent();
        }

        private void prodazhaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prodazhaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Индивидуальное_задание_25_04DataSet1);

        }

        private void Prodaga_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Индивидуальное_задание_25_04DataSet1.Prodazha". При необходимости она может быть перемещена или удалена.
            this.prodazhaTableAdapter.Fill(this._Индивидуальное_задание_25_04DataSet1.Prodazha);

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

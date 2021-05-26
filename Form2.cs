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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

    private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Индивидуальное_задание_25_04DataSet1.Kategoriya_sotrudnikov". При необходимости она может быть перемещена или удалена.
            this.kategoriya_sotrudnikovTableAdapter.Fill(this._Индивидуальное_задание_25_04DataSet1.Kategoriya_sotrudnikov);
            InitializeComponent();
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

        internal void Showdialog()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
            this.Hide();
        }

        private void kategoriya_sotrudnikovBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kategoriya_sotrudnikovBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Индивидуальное_задание_25_04DataSet1);

        }
    }
}

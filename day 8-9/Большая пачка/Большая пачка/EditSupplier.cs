using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Большая_пачка
{
    public partial class EditSupplier : Form
    {
        public EditSupplier()
        {
            InitializeComponent();
        }

        private void EditSupplier_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "task_2DataSet1.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.task_2DataSet1.Supplier);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int delet = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delet);
        }
    }
}

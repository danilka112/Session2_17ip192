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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "task_2DataSet1.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.task_2DataSet1.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "task_2DataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.task_2DataSet.Material);

        }
        //Кнопка добавление данных в таблицу
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                supplierTableAdapter.Update(task_2DataSet1.Supplier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

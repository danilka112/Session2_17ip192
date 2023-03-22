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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "task_2DataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.task_2DataSet.Material);
            ToolTip t = new ToolTip();
            t.SetToolTip(button2, "Добавить материал в таблицу");
            t.SetToolTip(button1, "Редактирование материала");
            t.SetToolTip(button3, "Добавить поставщика");
            t.SetToolTip(button4, "Редактирование поставщика");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit Edit = new Edit();
            Edit.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add Add = new Add();
            Add.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColumn = comboBox1.SelectedItem.ToString();
            DataGridViewColumn sortColumn;
            switch (selectedColumn)
            {
                case "Наименование":
                    sortColumn = dataGridView1.Columns[0];
                    break;
                case "Остаток на складе":
                    sortColumn = dataGridView1.Columns[4];
                    break;
                case "Стоимость":
                    sortColumn = dataGridView1.Columns[3];
                    break;
                default:
                    sortColumn = dataGridView1.Columns[0];
                    break;
            }
            dataGridView1.Sort(sortColumn, ListSortDirection.Ascending);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[comboBox1.Text], ListSortDirection.Ascending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddSupplier s = new AddSupplier();
            s.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditSupplier a = new EditSupplier();
            a.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void materialBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

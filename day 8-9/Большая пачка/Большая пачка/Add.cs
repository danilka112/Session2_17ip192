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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "task_2DataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.task_2DataSet.Material);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
        public int Del(int a, int b)
        {
            return a / b ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Кнопка добавление данных в таблицу
            var row = task_2DataSet.Material.NewRow();
            row[0] = textBox1.Text;
            row[1] = textBox2.Text;
            row[3] = textBox3.Text;
            row[4] = textBox4.Text;
            row[5] = textBox5.Text;
            row[6] = textBox6.Text;
            row[7] = textBox7.Text;
            task_2DataSet.Material.Rows.Add(row);
            task_2DataSet.Material.AcceptChanges();

            //Сумма за единицу товара 
            int a, b;
            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);
            a = Del(a, b);
            textBox8.Text = Convert.ToString(a);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

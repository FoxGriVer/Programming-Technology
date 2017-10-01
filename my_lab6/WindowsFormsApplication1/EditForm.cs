using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EditForm : Form
    {
        public delegate void MethodContainer();
        public event MethodContainer onEdit;

        private AbstractCivilPlane _plane_from_f3;
        public AbstractCivilPlane Plane_from_f3
        {
            get { return _plane_from_f3; }
            set { _plane_from_f3 = value; }
        }

        public EditForm()
        {
            InitializeComponent();
            
            //if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            //{
            //    button1.Enabled = false;
            //}
            
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back))
            {
                return;
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back))
            {
                return;
            }
            e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool fl = false;
            if (textBox1.Text.Length < 1) fl = true;
            //Проверка 2
            if (textBox2.Text.Length < 1) fl = true;
            //Проверка 3
            if (textBox3.Text.Length < 1) fl = true;
            if (fl)
            {
                MessageBox.Show("Не заполнено, или заполнено неправильно одно или несколько полей!");
                return;
            }
            else
            {

                int i = int.Parse(textBox2.Text);
                int j = int.Parse(textBox3.Text);
                Plane_from_f3 = new PassangerPlane(textBox1.Text, j, i, 2000, "Passenger", 1000, j);

                this.Hide();

                Form1 main = this.Owner as Form1;
                this.onEdit += main.ChangeStat;
                onEdit();
                this.onEdit -= main.ChangeStat;
                if (main != null)
                {
                    main.Show();
                }
            }
        }

        public void ClearText()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
        }
    }
}

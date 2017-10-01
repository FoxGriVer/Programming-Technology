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

    public partial class AddForm : Form
    {
        public delegate void MethodContainer();
        public event MethodContainer onCount;

        private AbstractCivilPlane _plane_from_f2;
        public AbstractCivilPlane Plane_from_f2
        {
            get { return _plane_from_f2; }
            set { _plane_from_f2 = value; }
        }
        private DialogResult _result;

        public DialogResult Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public AddForm()
        {
            InitializeComponent();


           
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool fl = false;
            if (comboBox1.SelectedIndex < 0)
            {
                fl = true;
            }
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

                if (comboBox1.SelectedIndex == 0)
                {
                    int i = int.Parse(textBox2.Text);
                    int j = int.Parse(textBox3.Text);
                    Plane_from_f2 = new PassangerPlane(textBox1.Text, 300, i, 2000, "Passenger", 1000, j);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    int i = int.Parse(textBox2.Text);
                    int j = int.Parse(textBox3.Text);
                    Plane_from_f2 = new TransportationPlane(textBox1.Text, 300, i, 2000, "Passenger", 1000, j);

                }

                this.Result = DialogResult.OK;
                this.Hide();

                Form1 main = this.Owner as Form1;
                this.onCount += main.ClearPanel;
                onCount();
                this.onCount -= main.ClearPanel;
                if (main != null)
                {
                    main.Show();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            this.Hide();
            Form1 main = this.Owner as Form1;           
            if (main != null)
            {
                main.Show();

            }

        }
        public void ClearText()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back ) )
                {
                return;
                }
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back))
            {
                return;
            }
            e.Handled = true;
        }
    }
}

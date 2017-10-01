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
    public partial class Form1 : Form
    {
        Airport our_airport = new Airport();
        AddForm button_add_form = new AddForm();
        EditForm edit_form = new EditForm();    

        public Form1()
        {
            our_airport = AirportFactory.CreateAirport();

            InitializeComponent();          
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < our_airport.Number_of_planes; i++)
            {
                listBox1.Items.Add(our_airport.ShowPlane(i));
            }
           
            label2.Text = Convert.ToString(our_airport.CountPassangers());

        }

        private void add_Click(object sender, EventArgs e)
        {
            button_add_form.Show();
            button_add_form.ClearText();
            this.Hide();
            button_add_form.Owner = this;
           

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                our_airport.DeletePlane((listBox1.SelectedIndex));

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                label2.Text = Convert.ToString(our_airport.CountPassangers());
            }
            else
            {
                MessageBox.Show("Выберете элемент");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                edit_form.Show();
                edit_form.ClearText();
                this.Hide();
                edit_form.Owner = this;
            }
            else
            {
                MessageBox.Show("Выберете элемент");
            }
        }

 
        
        public void ClearPanel()
        {
            listBox1.Items.Clear();

            for (int i = 0; i < our_airport.Number_of_planes; i++)
            {
                listBox1.Items.Add(our_airport.ShowPlane(i));
            }
            if (button_add_form.Result == DialogResult.OK)
            {
                AbstractCivilPlane plane_from_form2 = button_add_form.Plane_from_f2;

                our_airport.AddPlane(plane_from_form2);
                listBox1.Items.Add(plane_from_form2.Name);
                our_airport.ShowPlanes();
                label2.Text = Convert.ToString(our_airport.CountPassangers());

            }
        }
        public void ChangeStat()
        {
            our_airport.ChangePassengers(edit_form.Plane_from_f3.Name, edit_form.Plane_from_f3.Number_of_pilots, edit_form.Plane_from_f3.Speed, listBox1.SelectedIndex);

            listBox1.Items.Clear();

            for (int i = 0; i < our_airport.Number_of_planes; i++)
            {
                listBox1.Items.Add(our_airport.ShowPlane(i));
            }
            label2.Text = Convert.ToString(our_airport.CountPassangers());

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

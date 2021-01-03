
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteTest
{
    public partial class Form1 : Form
    {
        List<PersonModel> people = new List<PersonModel>();

        public Form1()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            people = SQLiteDataAccess.LoadPeople();
            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            listPeopleListBox.DataSource = null;
            listPeopleListBox.DataSource = people;
            listPeopleListBox.DisplayMember = "FullName";
        }

                

        private void button3_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();

            p.FirstName = textBox1.Text;
            p.LastName = textBox2.Text;

            SQLiteDataAccess.SavePerson(p);
                       

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}

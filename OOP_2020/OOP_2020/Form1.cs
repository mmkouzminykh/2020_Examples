using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateHuman_Click(object sender, EventArgs e)
        {
            /*
            Human h = new Human("Петр", "Петрович", "Петров");
            //txtTestValue.Text = h.testVar;
            //txtTestValue.Text = "Создано" + Human.Count.ToString();
            MessageBox.Show("Результат: " + h[txtTestValue.Text]);

            Human h2 = new Human("Иван", "Иванович", "Иванов");
            Human h3 = new Human("Петр", "Петрович", "Петров");

            if (h == h2)
                MessageBox.Show("h == h2");
            else
                MessageBox.Show("h != h2");

            if (h == h3)
                MessageBox.Show("h == h3");
            else
                MessageBox.Show("h != h3");
                */
            Student s = new Student("Иван", "Иванович", "Иванов", new DateTime(2000, 5, 10), "Киров");            
            Human h = s;            

            Human h1 = new Human("Петр", "Петрович", "Петров");
            Student s2;

            /*
            s2 = h1 as Student;
            if (s2 != null)
                txtTestValue.Text = s2.Course.ToString();
            else
                txtTestValue.Text = "это не Student";
              

            Magister m = new Magister("Иван", "Иванович", "Иванов", new DateTime(2000, 5, 10), "Киров");

            if (!(h1 is Student))
                txtTestValue.Text = "это не Student";            
            else
                txtTestValue.Text = ((Student)h1).Course.ToString();
            */

            ChangeName(s);
            txtTestValue.Text = s.Name;
            
        }       

        private void ChangeName(Human h)
        {
            //
            h = new Human();
            h.Name = "New name";
        }
    }
}

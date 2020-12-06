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

            //Human h1 = new Human("Петр", "Петрович", "Петров");
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
            //h = new Human();
            //h.Name = "New name";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "";

            //Human h = new Human();
            //txtInfo.Text = h.GetInfo2();

            //txtInfo.Text += Environment.NewLine;

            Human s = new Student("Василий", "Петрович", "Сергеев", new DateTime(2000, 1, 25), "Слободской");
            txtInfo.Text += s.GetInfo2();

            txtInfo.Text += Environment.NewLine;

            Human m = new Magister("Андрей", "Иванович", "Коршунов", new DateTime(2002, 5, 18), "Киров");
            txtInfo.Text += m.GetInfo2();

            Employee emp = new Employee("Роман", "Алексеевич", "Павлов", new DateTime(1980, 11, 2), "Киров", "Преподаватель");

            Human[] arr = new Human[] {s, m, emp };
            for (int i = 0; i < 3; i++)
            {
                txtInfo.Text += Environment.NewLine;
                txtInfo.Text += arr[i].GetInfo();
            }

            for (int i = 0; i < 3; i++)
            {
                txtInfo.Text += Environment.NewLine;
                switch (arr[i])
                {
                    case Magister m2:
                        txtInfo.Text += m2.GetInfo2();
                        break;
                    case Student s2:
                        txtInfo.Text += s2.GetInfo2();
                        break;
                    case Human h2:
                        txtInfo.Text += h2.GetInfo2();
                        break;
                }
            }

            txtInfo.Text += Environment.NewLine;
            txtInfo.Text += "--- interface ---";

            TestClass t = new TestClass();

            IGetInfo[] igf = new IGetInfo[] { s, m, emp, t };
            for (int i = 0; i < 4; i++)
            {
                txtInfo.Text += Environment.NewLine;
                txtInfo.Text += igf[i].GetInfoInt();
            }
        }
    }
}

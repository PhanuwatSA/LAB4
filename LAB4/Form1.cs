using System;

namespace LAB4
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textName.Text;
            string BirthYear = this.textBirthYear.Text;
            string gpa = this.textGPA.Text;
            int iYear = Int32.Parse(BirthYear);
            double g = Double.Parse(gpa);
            //
            Class1 class1 = new Class1(name, iYear, g);
            this.classroom.addClass12Class(class1);



            this.textListofPerson.Text = this.classroom.showallclass12inclass();
            this.textTotal.Text = this.classroom.totalAge().ToString();
            this.textGPAAvg.Text = this.classroom.GPAAverage().ToString();
            this.textGPAMin.Text = this.classroom.MinGPA().ToString();
            this.textGPAMax.Text = this.classroom.MaxGPA().ToString();
            this.textName2.Text = this.classroom.NMaxGPA().ToString();
            this.textName3.Text = this.classroom.NMinGPA().ToString();








            this.textName.Text = "";
            this.textBirthYear.Text = "";
            this.textGPA.Text = "";


        }
    }
}
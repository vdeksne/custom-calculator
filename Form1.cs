using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace custom_calculator
{
    public partial class Form1 : Form
    {
        private int gradeCount = 0;
        private Label label3;
        private TextBox textBox1;
        // Removed duplicate definition of textBox2
        private TextBox textBox4; // Removed duplicate definition of textBox3
        private TextBox[] gradeTextBoxes;
        private Button calculateButton;
        private Label averageLabel;
        private Label label4;

        public Form1()
        {
            InitializeComponent();
            // Ensure label4 is initialized
            if (label4 == null)
            {
                label4 = new System.Windows.Forms.Label();
                this.Controls.Add(label4);
            }
        }

        private void InitializeCustomComponents()
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            // This method can be used to handle any specific actions when label3 is clicked
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // grade count number ( 1, 2, 3 .. -10)
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // average grade
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // entered grades
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double sum = 0;
                int count = 0;
                TextBox[] gradeTextBoxes = { textBox8, textBox9, textBox10, textBox5, textBox6, textBox2, textBox11 };

                foreach (var textBox in gradeTextBoxes)
                {
                    if (double.TryParse(textBox.Text, out double grade) && grade >= 0 && grade <= 100)
                    {
                        sum += grade;
                        count++;
                    }
                }

                if (count > 0)
                {
                    double average = sum / count;
                    label1.Text = $"Average grade: {average:F2}";
                }
                else
                {
                    label1.Text = "No valid grades entered.";
                }
            }
            catch (Exception ex)
            {
                label1.Text = $"Error: {ex.Message}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes if necessary
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> grades = new List<double>();
                string[] inputs = textBox13.Text.Split(new[] { ' ', ',', ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var input in inputs)
                {
                    if (double.TryParse(input, out double grade))
                    {
                        if (grade == -1)
                        {
                            break;
                        }
                        if (grade >= 0 && grade <= 100)
                        {
                            grades.Add(grade);
                        }
                    }
                }

                if (grades.Count > 0)
                {
                    double average = grades.Average();
                    label7.Text = $"Average grade: {average:F2}";
                }
                else
                {
                    label7.Text = "No valid grades entered.";
                }
            }
            catch (Exception ex)
            {
                label7.Text = $"Error: {ex.Message}";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBox13.Text, out int number))
                {
                    if (number <= 0)
                    {
                        label8.Text = "Skaitlis nav pareizs.";
                    }
                    else
                    {
                        long factorial = 1;
                        for (int i = 1; i <= number; i++)
                        {
                            factorial *= i;
                        }
                        label8.Text = $"Faktoriāls: {factorial}";
                    }
                }
                else
                {
                    label8.Text = "Lūdzu ievadiet derīgu skaitli.";
                }
            }
            catch (Exception ex)
            {
                label8.Text = $"Kļūda: {ex.Message}";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

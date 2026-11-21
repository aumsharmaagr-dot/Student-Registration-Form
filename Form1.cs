
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Student_Registration_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Student Name
            string name = textBox1.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Please enter student name.");
                textBox1.Focus();
                return;
            }

            // 2. Email Validation
            string email = textBox2.Text.Trim();

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.");
                textBox2.Focus();
                return;
            }

            // 3. Gender Selection
            string gender = "";

            if (radioButton1.Checked)
                gender = "Male";
            else if (radioButton2.Checked)
                gender = "Female";
            else if (radioButton3.Checked)
                gender = "Other";
            else
            {
                MessageBox.Show("Please select your gender.");
                return;
            }

            // 4. Course Selection
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course.");
                comboBox1.Focus();
                return;
            }

            string course = comboBox1.Text.Trim();

            // 5. Hobbies Selection
            List<string> hobbies = new List<string>();

            if (checkBox1.Checked)
                hobbies.Add(checkBox1.Text);

            if (checkBox2.Checked)
                hobbies.Add(checkBox2.Text);

            if (checkBox3.Checked)
                hobbies.Add(checkBox3.Text);

            if (checkBox4.Checked)
                hobbies.Add(checkBox4.Text);

            string hobbyText = hobbies.Count > 0
                ? string.Join(", ", hobbies)
                : "None";

            // 6. Date of Birth
            string dob = dateTimePicker1.Value.ToShortDateString();

            // 7. Registration Summary
            lstSummary.Items.Clear();

            lstSummary.Items.Add("===== STUDENT DETAILS =====");
            lstSummary.Items.Add("Name: " + name);
            lstSummary.Items.Add("Email: " + email);
            lstSummary.Items.Add("Gender: " + gender);
            lstSummary.Items.Add("Course: " + course);
            lstSummary.Items.Add("Hobbies: " + hobbyText);
            lstSummary.Items.Add("Date of Birth: " + dob);

            // 8. Success Message
            MessageBox.Show(
                "Student Registration Successful!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

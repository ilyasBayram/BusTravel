using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        #region methods
        public void addToTextboxes()
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
        }

        public void clearTextboxes()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        public void addToComboBoxes()
        {
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
        }

        public void getNullComboboxes()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        public void radioButtonCheck()
        {
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox4.Items.Add(radioButton2.Text);
            }
        }
        #endregion

        #region 1. Botton
        private void button1_Click(object sender, EventArgs e)
        {
            //when the button is clicked first it checks if the textboxes are empty
            //then if user enters the informations it adds them to listboxes
            //as final step enable property of the button becomes false to prevent
            //a second entry
          
            if (textBox1.Text== "" || textBox2.Text==""||comboBox1.Text==""||comboBox2.Text=="")
            {
                MessageBox.Show("Please fill in the required fields");
            }
            else
            {
                radioButtonCheck();
                addToTextboxes();
                clearTextboxes();
                addToComboBoxes();
                getNullComboboxes();
                listBox6.Items.Add("1");              
                radioButton1.Checked = true;
                button1.Enabled = false;
            }
        }
        #endregion

        #region 2. Button
        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in the required fields");
            }
            else
            {
                radioButtonCheck();
                addToTextboxes();
                clearTextboxes();
                addToComboBoxes();
                getNullComboboxes();
                listBox6.Items.Add("2");
                radioButton1.Checked = true;
                button2.Enabled = false;
            }
        }
        #endregion

        #region 3. Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in the required fields");
            }
            else
            {
                radioButtonCheck();
                addToTextboxes();
                clearTextboxes();
                addToComboBoxes();
                getNullComboboxes();
                listBox6.Items.Add("3");
                radioButton1.Checked = true;
                button3.Enabled = false;
            }
        }
        #endregion

        #region 4.Button
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in the required fields");
            }
            else
            {
                radioButtonCheck();
                addToTextboxes();
                clearTextboxes();
                addToComboBoxes();
                getNullComboboxes();
                listBox6.Items.Add("4");
                radioButton1.Checked = true;
                button4.Enabled = false;
            }
        }
        #endregion

        #region 5.Button
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in the required fields");
            }
            else
            {
                radioButtonCheck();
                addToTextboxes();
                clearTextboxes();
                addToComboBoxes();
                getNullComboboxes();
                listBox6.Items.Add("5");         
                radioButton1.Checked = true;
                button5.Enabled = false;
            }
        }
    }
    #endregion
}

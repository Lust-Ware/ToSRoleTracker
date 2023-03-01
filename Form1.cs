using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToSTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            willButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            Role1.Visible = false;
            Role2.Visible = false;
            Role3.Visible = false;
            Role4.Visible = false;
            Role5.Visible = false;
            Role6.Visible = false;
            Role7.Visible = false;
            Role8.Visible = false;
            Role9.Visible = false;
            Role10.Visible = false;
            Role11.Visible = false;
            Role12.Visible = false;
            Role13.Visible = false;
            Role14.Visible = false;
            Role15.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainTitle.Visible = false;
            willButton.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            Role1.Visible = true;
            Role2.Visible = true;
            Role3.Visible = true;
            Role4.Visible = true;
            Role5.Visible = true;
            Role6.Visible = true;
            Role7.Visible = true;
            Role8.Visible = true;
            Role9.Visible = true;
            Role10.Visible = true;
            Role11.Visible = true;
            Role12.Visible = true;
            Role13.Visible = true;
            Role14.Visible = true;
            Role15.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            Role1.Text = "";
            Role2.Text = "";
            Role3.Text = "";
            Role4.Text = "";
            Role5.Text = "";
            Role6.Text = "";
            Role7.Text = "";
            Role8.Text = "";
            Role9.Text = "";
            Role10.Text = "";
            Role11.Text = "";
            Role12.Text = "";
            Role13.Text = "";
            Role14.Text = "";
            Role15.Text = "";
        }

        private void willButton_Click(object sender, EventArgs e)
        {
            string outputtext = $@"SHER: {textBox1.Text}
LO: {textBox2.Text}
INVEST: {textBox3.Text}
JAILOR: {textBox4.Text}
DOC: {textBox5.Text}
ESC: {textBox6.Text}
MED: {textBox7.Text}
TK: {textBox8.Text}
RT: {textBox9.Text}
EXE: {textBox10.Text}
JEST: {textBox11.Text}
";
            Clipboard.SetText(outputtext);
            string msg = "Will Copied to your clipboard, paste in game with CTRL + V";
            MessageBox.Show(msg);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(textBox1.Text + e.KeyChar) >= 16 ||
                textBox1.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(textBox2.Text + e.KeyChar) >= 16 ||
                textBox2.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(textBox3.Text + e.KeyChar) >= 16 ||
                textBox3.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(textBox4.Text + e.KeyChar) >= 16 ||
                textBox4.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(textBox5.Text + e.KeyChar) >= 16 ||
                textBox5.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(textBox6.Text + e.KeyChar) >= 16 ||
                textBox6.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(textBox7.Text + e.KeyChar) >= 16 ||
                textBox7.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(textBox8.Text + e.KeyChar) >= 16 ||
                textBox8.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(textBox9.Text + e.KeyChar) >= 16 ||
                textBox9.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(textBox10.Text + e.KeyChar) >= 16 ||
                textBox10.Text == "0") && c != '\b')
                e.Handled = true;
        }
        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) || Convert.ToInt32(textBox11.Text + e.KeyChar) >= 16 || textBox11.Text == "0") && c != '\b') 
                e.Handled = true;
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                int roleid = Convert.ToInt32(textBox11.Text);
                switch (roleid)
                {
                    case 1:
                        Role1.Text = "Jester";
                        break;
                    case 2:
                        Role2.Text = "Jester";
                        break;
                    case 3:
                        Role3.Text = "Jester";
                        break;
                    case 4:
                        Role4.Text = "Jester";
                        break;
                    case 5:
                        Role5.Text = "Jester";
                        break;
                    case 6:
                        Role6.Text = "Jester";
                        break;
                    case 7:
                        Role7.Text = "Jester";
                        break;
                    case 8:
                        Role8.Text = "Jester";
                        break;
                    case 9:
                        Role9.Text = "Jester";
                        break;
                    case 10:
                        Role10.Text = "Jester";
                        break;
                    case 11:
                        Role11.Text = "Jester";
                        break;
                    case 12:
                        Role12.Text = "Jester";
                        break;
                    case 13:
                        Role13.Text = "Jester";
                        break;
                    case 14:
                        Role14.Text = "Jester";
                        break;
                    case 15:
                        Role15.Text = "Jester";
                        break;
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int roleid = Convert.ToInt32(textBox1.Text);
                switch (roleid)
                {
                    case 1:
                        Role1.Text = "Sheriff";
                        break;
                    case 2:
                        Role2.Text = "Sheriff";
                        break;
                    case 3:
                        Role3.Text = "Sheriff";
                        break;
                    case 4:
                        Role4.Text = "Sheriff";
                        break;
                    case 5:
                        Role5.Text = "Sheriff";
                        break;
                    case 6:
                        Role6.Text = "Sheriff";
                        break;
                    case 7:
                        Role7.Text = "Sheriff";
                        break;
                    case 8:
                        Role8.Text = "Sheriff";
                        break;
                    case 9:
                        Role9.Text = "Sheriff";
                        break;
                    case 10:
                        Role10.Text = "Sheriff";
                        break;
                    case 11:
                        Role11.Text = "Sheriff";
                        break;
                    case 12:
                        Role12.Text = "Sheriff";
                        break;
                    case 13:
                        Role13.Text = "Sheriff";
                        break;
                    case 14:
                        Role14.Text = "Sheriff";
                        break;
                    case 15:
                        Role15.Text = "Sheriff";
                        break;
                }
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int roleid = Convert.ToInt32(textBox2.Text);
                switch (roleid)
                {
                    case 1:
                        Role1.Text = "LookOut";
                        break;
                    case 2:
                        Role2.Text = "LookOut";
                        break;
                    case 3:
                        Role3.Text = "LookOut";
                        break;
                    case 4:
                        Role4.Text = "LookOut";
                        break;
                    case 5:
                        Role5.Text = "LookOut";
                        break;
                    case 6:
                        Role6.Text = "LookOut";
                        break;
                    case 7:
                        Role7.Text = "LookOut";
                        break;
                    case 8:
                        Role8.Text = "LookOut";
                        break;
                    case 9:
                        Role9.Text = "LookOut";
                        break;
                    case 10:
                        Role10.Text = "LookOut";
                        break;
                    case 11:
                        Role11.Text = "LookOut";
                        break;
                    case 12:
                        Role12.Text = "LookOut";
                        break;
                    case 13:
                        Role13.Text = "LookOut";
                        break;
                    case 14:
                        Role14.Text = "LookOut";
                        break;
                    case 15:
                        Role15.Text = "LookOut";
                        break;
                }
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int roleid = Convert.ToInt32(textBox3.Text);
                switch (roleid)
                {
                    case 1:
                        Role1.Text = "Investigator";
                        break;
                    case 2:
                        Role2.Text = "Investigator";
                        break;
                    case 3:
                        Role3.Text = "Investigator";
                        break;
                    case 4:
                        Role4.Text = "Investigator";
                        break;
                    case 5:
                        Role5.Text = "Investigator";
                        break;
                    case 6:
                        Role6.Text = "Investigator";
                        break;
                    case 7:
                        Role7.Text = "Investigator";
                        break;
                    case 8:
                        Role8.Text = "Investigator";
                        break;
                    case 9:
                        Role9.Text = "Investigator";
                        break;
                    case 10:
                        Role10.Text = "Investigator";
                        break;
                    case 11:
                        Role11.Text = "Investigator";
                        break;
                    case 12:
                        Role12.Text = "Investigator";
                        break;
                    case 13:
                        Role13.Text = "Investigator";
                        break;
                    case 14:
                        Role14.Text = "Investigator";
                        break;
                    case 15:
                        Role15.Text = "Investigator";
                        break;
                }
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label28;

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                int roleid = Convert.ToInt32(textBox4.Text);
                switch (roleid)
                {
                    case 1:
                        Role1.Text = "Jailor";
                        break;
                    case 2:
                        Role2.Text = "Jailor";
                        break;
                    case 3:
                        Role3.Text = "Jailor";
                        break;
                    case 4:
                        Role4.Text = "Jailor";
                        break;
                    case 5:
                        Role5.Text = "Jailor";
                        break;
                    case 6:
                        Role6.Text = "Jailor";
                        break;
                    case 7:
                        Role7.Text = "Jailor";
                        break;
                    case 8:
                        Role8.Text = "Jailor";
                        break;
                    case 9:
                        Role9.Text = "Jailor";
                        break;
                    case 10:
                        Role10.Text = "Jailor";
                        break;
                    case 11:
                        Role11.Text = "Jailor";
                        break;
                    case 12:
                        Role12.Text = "Jailor";
                        break;
                    case 13:
                        Role13.Text = "Jailor";
                        break;
                    case 14:
                        Role14.Text = "Jailor";
                        break;
                    case 15:
                        Role15.Text = "Jailor";
                        break;
                }
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                int roleid = Convert.ToInt32(textBox5.Text);
                switch (roleid)
                {
                    case 1:
                        Role1.Text = "Doctor";
                        break;
                    case 2:
                        Role2.Text = "Doctor";
                        break;
                    case 3:
                        Role3.Text = "Doctor";
                        break;
                    case 4:
                        Role4.Text = "Doctor";
                        break;
                    case 5:
                        Role5.Text = "Doctor";
                        break;
                    case 6:
                        Role6.Text = "Doctor";
                        break;
                    case 7:
                        Role7.Text = "Doctor";
                        break;
                    case 8:
                        Role8.Text = "Doctor";
                        break;
                    case 9:
                        Role9.Text = "Doctor";
                        break;
                    case 10:
                        Role10.Text = "Doctor";
                        break;
                    case 11:
                        Role11.Text = "Doctor";
                        break;
                    case 12:
                        Role12.Text = "Doctor";
                        break;
                    case 13:
                        Role13.Text = "Doctor";
                        break;
                    case 14:
                        Role14.Text = "Doctor";
                        break;
                    case 15:
                        Role15.Text = "Doctor";
                        break;
                }
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                int roleid = Convert.ToInt32(textBox6.Text);
                switch (roleid)
                {
                    case 1:
                        Role1.Text = "Escort";
                        break;
                    case 2:
                        Role2.Text = "Escort";
                        break;
                    case 3:
                        Role3.Text = "Escort";
                        break;
                    case 4:
                        Role4.Text = "Escort";
                        break;
                    case 5:
                        Role5.Text = "Escort";
                        break;
                    case 6:
                        Role6.Text = "Escort";
                        break;
                    case 7:
                        Role7.Text = "Escort";
                        break;
                    case 8:
                        Role8.Text = "Escort";
                        break;
                    case 9:
                        Role9.Text = "Escort";
                        break;
                    case 10:
                        Role10.Text = "Escort";
                        break;
                    case 11:
                        Role11.Text = "Escort";
                        break;
                    case 12:
                        Role12.Text = "Escort";
                        break;
                    case 13:
                        Role13.Text = "Escort";
                        break;
                    case 14:
                        Role14.Text = "Escort";
                        break;
                    case 15:
                        Role15.Text = "Escort";
                        break;
                }
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                int roleid = Convert.ToInt32(textBox7.Text);
                switch (roleid)
                {
                    case 1:
                        Role1.Text = "Medium";
                        break;
                    case 2:
                        Role2.Text = "Medium";
                        break;
                    case 3:
                        Role3.Text = "Medium";
                        break;
                    case 4:
                        Role4.Text = "Medium";
                        break;
                    case 5:
                        Role5.Text = "Medium";
                        break;
                    case 6:
                        Role6.Text = "Medium";
                        break;
                    case 7:
                        Role7.Text = "Medium";
                        break;
                    case 8:
                        Role8.Text = "Medium";
                        break;
                    case 9:
                        Role9.Text = "Medium";
                        break;
                    case 10:
                        Role10.Text = "Medium";
                        break;
                    case 11:
                        Role11.Text = "Medium";
                        break;
                    case 12:
                        Role12.Text = "Medium";
                        break;
                    case 13:
                        Role13.Text = "Medium";
                        break;
                    case 14:
                        Role14.Text = "Medium";
                        break;
                    case 15:
                        Role15.Text = "Medium";
                        break;
                }
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                int roleid = Convert.ToInt32(textBox8.Text);
                switch (roleid)
                {
                    case 1:
                        Role1.Text = "Town Killing";
                        break;
                    case 2:
                        Role2.Text = "Town Killing";
                        break;
                    case 3:
                        Role3.Text = "Town Killing";
                        break;
                    case 4:
                        Role4.Text = "Town Killing";
                        break;
                    case 5:
                        Role5.Text = "Town Killing";
                        break;
                    case 6:
                        Role6.Text = "Town Killing";
                        break;
                    case 7:
                        Role7.Text = "Town Killing";
                        break;
                    case 8:
                        Role8.Text = "Town Killing";
                        break;
                    case 9:
                        Role9.Text = "Town Killing";
                        break;
                    case 10:
                        Role10.Text = "Town Killing";
                        break;
                    case 11:
                        Role11.Text = "Town Killing";
                        break;
                    case 12:
                        Role12.Text = "Town Killing";
                        break;
                    case 13:
                        Role13.Text = "Town Killing";
                        break;
                    case 14:
                        Role14.Text = "Town Killing";
                        break;
                    case 15:
                        Role15.Text = "Town Killing";
                        break;
                }
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                int roleid = Convert.ToInt32(textBox9.Text);
                switch (roleid)
                {
                    case 1:
                        Role1.Text = "Random Town";
                        break;
                    case 2:
                        Role2.Text = "Random Town";
                        break;
                    case 3:
                        Role3.Text = "Random Town";
                        break;
                    case 4:
                        Role4.Text = "Random Town";
                        break;
                    case 5:
                        Role5.Text = "Random Town";
                        break;
                    case 6:
                        Role6.Text = "Random Town";
                        break;
                    case 7:
                        Role7.Text = "Random Town";
                        break;
                    case 8:
                        Role8.Text = "Random Town";
                        break;
                    case 9:
                        Role9.Text = "Random Town";
                        break;
                    case 10:
                        Role10.Text = "Random Town";
                        break;
                    case 11:
                        Role11.Text = "Random Town";
                        break;
                    case 12:
                        Role12.Text = "Random Town";
                        break;
                    case 13:
                        Role13.Text = "Random Town";
                        break;
                    case 14:
                        Role14.Text = "Random Town";
                        break;
                    case 15:
                        Role15.Text = "Random Town";
                        break;
                }
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                int roleid = Convert.ToInt32(textBox10.Text);
                switch (roleid)
                {
                    case 1:
                        Role1.Text = "Executioner";
                        break;
                    case 2:
                        Role2.Text = "Executioner";
                        break;
                    case 3:
                        Role3.Text = "Executioner";
                        break;
                    case 4:
                        Role4.Text = "Executioner";
                        break;
                    case 5:
                        Role5.Text = "Executioner";
                        break;
                    case 6:
                        Role6.Text = "Executioner";
                        break;
                    case 7:
                        Role7.Text = "Executioner";
                        break;
                    case 8:
                        Role8.Text = "Executioner";
                        break;
                    case 9:
                        Role9.Text = "Executioner";
                        break;
                    case 10:
                        Role10.Text = "Executioner";
                        break;
                    case 11:
                        Role11.Text = "Executioner";
                        break;
                    case 12:
                        Role12.Text = "Executioner";
                        break;
                    case 13:
                        Role13.Text = "Executioner";
                        break;
                    case 14:
                        Role14.Text = "Executioner";
                        break;
                    case 15:
                        Role15.Text = "Executioner";
                        break;
                }
            }
        }

        private void Role1_TextChanged(object sender, EventArgs e)
        {
            if (Role1.Text != "")
            {
                if (Role1.Text == Role2.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role1.Text == Role3.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role1.Text == Role4.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role1.Text == Role5.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role1.Text == Role6.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role1.Text == Role7.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role1.Text == Role8.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role1.Text == Role9.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role1.Text == Role10.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role1.Text == Role11.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role1.Text == Role12.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role1.Text == Role13.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role1.Text == Role14.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role1.Text == Role15.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role1.BackColor = Color.White;
            }

        }

        private void Role2_TextChanged(object sender, EventArgs e)
        {
            if (Role2.Text != "")
            {
                if (Role2.Text == Role1.Text)
                {
                    Role1.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role2.Text == Role3.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role2.Text == Role4.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role2.Text == Role5.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role2.Text == Role6.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role2.Text == Role7.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role2.Text == Role8.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role2.Text == Role9.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role2.Text == Role10.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role2.Text == Role11.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role2.Text == Role12.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role2.Text == Role13.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role2.Text == Role14.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role2.Text == Role15.Text)
                {
                    Role2.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role2.BackColor = Color.White;
            }
        }

        private void Role3_TextChanged(object sender, EventArgs e)
        {
            if (Role3.Text != "")
            {
                if (Role3.Text == Role1.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role3.Text == Role2.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role3.Text == Role4.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role3.Text == Role5.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role3.Text == Role6.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role3.Text == Role7.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role3.Text == Role8.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role3.Text == Role9.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role3.Text == Role10.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role3.Text == Role11.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role3.Text == Role12.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role3.Text == Role13.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role3.Text == Role14.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role3.Text == Role15.Text)
                {
                    Role3.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role3.BackColor = Color.White;
            }
        }

        private void Role4_TextChanged(object sender, EventArgs e)
        {
            if (Role4.Text != "")
            {
                if (Role4.Text == Role1.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role4.Text == Role2.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role4.Text == Role3.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role4.Text == Role5.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role4.Text == Role6.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role4.Text == Role7.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role4.Text == Role8.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role4.Text == Role9.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role4.Text == Role10.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role4.Text == Role11.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role4.Text == Role12.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role4.Text == Role13.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role4.Text == Role14.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role4.Text == Role15.Text)
                {
                    Role4.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role4.BackColor = Color.White;
            }
        }

        private void Role5_TextChanged(object sender, EventArgs e)
        {
            if (Role5.Text != "")
            {
                if (Role5.Text == Role1.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role5.Text == Role2.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role5.Text == Role3.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role5.Text == Role4.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role5.Text == Role6.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role5.Text == Role7.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role5.Text == Role8.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role5.Text == Role9.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role5.Text == Role10.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role5.Text == Role11.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role5.Text == Role12.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role5.Text == Role13.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role5.Text == Role14.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role5.Text == Role15.Text)
                {
                    Role5.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role5.BackColor = Color.White;
            }
        }

        private void Role6_TextChanged(object sender, EventArgs e)
        {
            if (Role6.Text != "")
            {
                if (Role6.Text == Role1.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role6.Text == Role2.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role6.Text == Role3.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role6.Text == Role4.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role6.Text == Role5.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role6.Text == Role7.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role6.Text == Role8.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role6.Text == Role9.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role6.Text == Role10.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role6.Text == Role11.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role6.Text == Role12.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role6.Text == Role13.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role6.Text == Role14.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role6.Text == Role15.Text)
                {
                    Role6.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role6.BackColor = Color.White;
            }
        }

        private void Role7_TextChanged(object sender, EventArgs e)
        {
            if (Role7.Text != "")
            {
                if (Role7.Text == Role1.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role7.Text == Role2.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role7.Text == Role3.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role7.Text == Role4.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role7.Text == Role5.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role7.Text == Role6.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role7.Text == Role8.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role7.Text == Role9.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role7.Text == Role10.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role7.Text == Role11.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role7.Text == Role12.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role7.Text == Role13.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role7.Text == Role14.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role7.Text == Role15.Text)
                {
                    Role7.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role7.BackColor = Color.White;
            }
        }

        private void Role8_TextChanged(object sender, EventArgs e)
        {
            if (Role8.Text != "")
            {
                if (Role8.Text == Role1.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role8.Text == Role2.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role8.Text == Role3.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role8.Text == Role4.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role8.Text == Role5.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role8.Text == Role6.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role8.Text == Role7.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role8.Text == Role9.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role8.Text == Role10.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role8.Text == Role11.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role8.Text == Role12.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role8.Text == Role13.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role8.Text == Role14.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role8.Text == Role15.Text)
                {
                    Role8.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role8.BackColor = Color.White;
            }
        }

        private void Role9_TextChanged(object sender, EventArgs e)
        {
            if (Role9.Text != "")
            {
                if (Role9.Text == Role1.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role9.Text == Role2.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role9.Text == Role3.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role9.Text == Role4.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role9.Text == Role5.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role9.Text == Role6.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role9.Text == Role7.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role9.Text == Role8.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role9.Text == Role10.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role9.Text == Role11.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role9.Text == Role12.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role9.Text == Role13.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role9.Text == Role14.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role9.Text == Role15.Text)
                {
                    Role9.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role9.BackColor = Color.White;
            }
        }

        private void Role10_TextChanged(object sender, EventArgs e)
        {
            if (Role10.Text != "")
            {
                if (Role10.Text == Role1.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role10.Text == Role2.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role10.Text == Role3.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role10.Text == Role4.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role10.Text == Role5.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role10.Text == Role6.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role10.Text == Role7.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role10.Text == Role8.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role10.Text == Role9.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role10.Text == Role11.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role10.Text == Role12.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role10.Text == Role13.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role10.Text == Role14.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role10.Text == Role15.Text)
                {
                    Role10.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role10.BackColor = Color.White;
            }
        }

        private void Role11_TextChanged(object sender, EventArgs e)
        {
            if (Role11.Text != "")
            {
                if (Role11.Text == Role1.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role11.Text == Role2.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role11.Text == Role3.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role11.Text == Role4.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role11.Text == Role5.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role11.Text == Role6.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role11.Text == Role7.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role11.Text == Role8.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role11.Text == Role9.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role11.Text == Role10.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role11.Text == Role12.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role11.Text == Role13.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role11.Text == Role14.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role11.Text == Role15.Text)
                {
                    Role11.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role11.BackColor = Color.White;
            }
        }

        private void Role12_TextChanged(object sender, EventArgs e)
        {
            if (Role12.Text != "")
            {
                if (Role12.Text == Role1.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role12.Text == Role2.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role12.Text == Role3.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role12.Text == Role4.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role12.Text == Role5.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role12.Text == Role6.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role12.Text == Role7.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role12.Text == Role8.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role12.Text == Role9.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role12.Text == Role10.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role12.Text == Role11.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role12.Text == Role13.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role12.Text == Role14.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role12.Text == Role15.Text)
                {
                    Role12.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role12.BackColor = Color.White;
            }
        }

        private void Role13_TextChanged(object sender, EventArgs e)
        {
            if (Role13.Text != "")
            {
                if (Role13.Text == Role1.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role13.Text == Role2.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role13.Text == Role3.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role13.Text == Role4.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role13.Text == Role5.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role13.Text == Role6.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role13.Text == Role7.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role13.Text == Role8.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role13.Text == Role9.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role13.Text == Role10.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role13.Text == Role11.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role13.Text == Role12.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role13.Text == Role14.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
                else if (Role13.Text == Role15.Text)
                {
                    Role13.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role13.BackColor = Color.White;
            }
        }

        private void Role14_TextChanged(object sender, EventArgs e)
        {
            if (Role14.Text != "")
            {
                if (Role14.Text == Role1.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role14.Text == Role2.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role14.Text == Role3.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role14.Text == Role4.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role14.Text == Role5.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role14.Text == Role6.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role14.Text == Role7.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role14.Text == Role8.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role14.Text == Role9.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role14.Text == Role10.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role14.Text == Role11.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role14.Text == Role12.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role14.Text == Role13.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role14.Text == Role15.Text)
                {
                    Role14.BackColor = Color.Red;
                    Role15.BackColor = Color.Red;
                }
            }
            else
            {
                Role14.BackColor = Color.White;
            }
        }

        private void Role15_TextChanged(object sender, EventArgs e)
        {
            if (Role15.Text != "")
            {
                if (Role15.Text == Role1.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role1.BackColor = Color.Red;
                }
                else if (Role15.Text == Role2.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role2.BackColor = Color.Red;
                }
                else if (Role15.Text == Role3.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role3.BackColor = Color.Red;
                }
                else if (Role15.Text == Role4.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role4.BackColor = Color.Red;
                }
                else if (Role15.Text == Role5.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role5.BackColor = Color.Red;
                }
                else if (Role15.Text == Role6.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role6.BackColor = Color.Red;
                }
                else if (Role15.Text == Role7.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role7.BackColor = Color.Red;
                }
                else if (Role15.Text == Role8.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role8.BackColor = Color.Red;
                }
                else if (Role15.Text == Role9.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role9.BackColor = Color.Red;
                }
                else if (Role15.Text == Role10.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role10.BackColor = Color.Red;
                }
                else if (Role15.Text == Role11.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role11.BackColor = Color.Red;
                }
                else if (Role15.Text == Role12.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role12.BackColor = Color.Red;
                }
                else if (Role15.Text == Role13.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role13.BackColor = Color.Red;
                }
                else if (Role15.Text == Role14.Text)
                {
                    Role15.BackColor = Color.Red;
                    Role14.BackColor = Color.Red;
                }
            } else
            {
                Role15.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg2 = @"Thank You for using my ToS Tracking Tool.
Currently this tool is only meant for classic, i may add different modes later.

How to use:
When a player claims a role, or when a player dies, you can put their number in the respective role's textbox.
Doing this will automatically fill the textboxes on the right with their roles.
if 2 people claim the same role, the boxes on the right will turn red, indicating something is off. Either RT or they lying.

Pressing the Last Will button will automatically copy the roles (on the left) and the numbers you have assigned to your clipboard, ready for you to paste it in your will in game.

(This does not account for any night actions you may do, so that you have to fill out yourself in game.)


Will you get banned for using this?
I highly doubt you will be banned for using this program, its the equivalent of using a pen and paper, just less work.
it does not interact with the game in any way.


Questions or ideas?
my discord is: LustWare#7302
";
            MessageBox.Show(msg2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Task1
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");
        int index;


        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        //Create ClearInputFields() Method for Clear Button
        private void ClearInputFields()
        {
            contact_id.Clear();
            first_name.Clear();
            last_name.Clear();
            contactNo.Clear();
            theEmail.Clear();
            address_text.Clear();
            theGender.SelectedIndex = -1;   // Clear the ComboBox selected value

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void addButt_Click(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearButt_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //initialize the combo box value
            theGender.Items.Add("Male");
            theGender.Items.Add("Female");


            table.Columns.Add("contactID", Type.GetType("System.String"));
            table.Columns.Add("firstName", Type.GetType("System.String"));
            table.Columns.Add("lastName", Type.GetType("System.String"));
            table.Columns.Add("contactNo", Type.GetType("System.String"));
            table.Columns.Add("email", Type.GetType("System.String"));
            table.Columns.Add("address", Type.GetType("System.String"));
            table.Columns.Add("gender", Type.GetType("System.String"));
            dataView.DataSource = table;
            dataView.Columns[0].HeaderText = "Contact ID";
            dataView.Columns[1].HeaderText = "First Name";
            dataView.Columns[2].HeaderText = "Last Name";
            dataView.Columns[3].HeaderText = "Contact No.";
            dataView.Columns[4].HeaderText = "Email";
            dataView.Columns[5].HeaderText = "Address";
            dataView.Columns[6].HeaderText = "Gender";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contact_id.Text) || string.IsNullOrWhiteSpace(first_name.Text) ||
                string.IsNullOrWhiteSpace(last_name.Text) || string.IsNullOrWhiteSpace(contactNo.Text) ||
                string.IsNullOrWhiteSpace(theEmail.Text) || string.IsNullOrWhiteSpace(address_text.Text) ||
                theGender.SelectedIndex == -1)

            {
                MessageBox.Show("Please fill in all the required fields!!", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Validate Contact No.
                string contactNoInput = contactNo.Text;
                string contactNoPattern = @"^\+?[0-9]{12,15}$"; // + followed by 12 to 15 digits

                if (!Regex.IsMatch(contactNoInput, contactNoPattern))
                {
                    MessageBox.Show("Contact No. should be numeric and between 12 to 15 digits with an optional '+' at the start!!", "Invalid Contact No.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate theEmail
                string emailInput = theEmail.Text;
                string emailPattern = @"^[a-zA-Z0-9._%+-]+@(gmail\.com|mail\.com|yahoo\.com|jababeka\.co)$";

                if (!Regex.IsMatch(emailInput, emailPattern))
                {
                    MessageBox.Show("Invalid email format. Valid formats are @gmail.com, @mail.com, @yahoo.com, or @jababeka.co!!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Do you want to add this contact?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    table.Rows.Add(contact_id.Text, first_name.Text, last_name.Text, contactNo.Text, theEmail.Text, address_text.Text, theGender.Text);
                    MessageBox.Show("Contact Added Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to clear the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ClearInputFields();
            }
        }

        private void new_butt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to add new contact?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                contact_id.Text = String.Empty;
                first_name.Text = String.Empty;
                last_name.Text = String.Empty;
                contactNo.Text = String.Empty;
                theEmail.Text = String.Empty;
                address_text.Text = String.Empty;
                theGender.SelectedIndex = -1;

               

            }
            
        }

        private void dataView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataView.Rows.Count)
            {
                index = e.RowIndex;
                DataGridViewRow row = dataView.Rows[index];

                contact_id.Text = row.Cells[0].Value.ToString();
                first_name.Text = row.Cells[1].Value.ToString();
                last_name.Text = row.Cells[2].Value.ToString();
                contactNo.Text = row.Cells[3].Value.ToString();
                theEmail.Text = row.Cells[4].Value.ToString();
                address_text.Text = row.Cells[5].Value.ToString();

                string genderValue = row.Cells[6].Value.ToString();

                int genderIndex = theGender.FindStringExact(genderValue);

                if (genderIndex != -1)
                {
                    theGender.SelectedIndex = genderIndex;
                }
            }

        }

        private void dataView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void update_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to update this contact?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow newdata = dataView.Rows[index];
                newdata.Cells[0].Value = contact_id.Text;
                newdata.Cells[1].Value = first_name.Text;
                newdata.Cells[2].Value = last_name.Text;
                newdata.Cells[3].Value = contactNo.Text;
                newdata.Cells[4].Value = theEmail.Text;
                newdata.Cells[5].Value = address_text.Text;
                newdata.Cells[6].Value = theGender.Text;

                MessageBox.Show("Contact Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to remove this contact?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                index = dataView.CurrentCell.RowIndex;
                dataView.Rows.RemoveAt(index);

                MessageBox.Show("Contact Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string filter = "";

            if (!string.IsNullOrEmpty(contact_id.Text))
            {
                filter += "[contactID] LIKE '%" + search_bar.Text + "%' AND ";
            }

            // Repeat the above pattern for other search criteria

            if (!string.IsNullOrEmpty(filter))
            {
                // Remove the trailing " AND "
                filter = filter.Substring(0, filter.Length - 5);
            }

            (dataView.DataSource as DataTable).DefaultView.RowFilter = filter;


        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

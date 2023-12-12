
namespace Task1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contact_id = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.contactNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.theEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.theGender = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.new_butt = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(468, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 173);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(77, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "Contact ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // contact_id
            // 
            this.contact_id.Location = new System.Drawing.Point(250, 236);
            this.contact_id.Name = "contact_id";
            this.contact_id.Size = new System.Drawing.Size(286, 34);
            this.contact_id.TabIndex = 2;
            this.contact_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(250, 294);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(286, 34);
            this.first_name.TabIndex = 4;
            this.first_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(77, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "First Name";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(250, 355);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(286, 34);
            this.last_name.TabIndex = 6;
            this.last_name.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(77, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 27);
            this.label10.TabIndex = 5;
            this.label10.Text = "Last Name";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // contactNo
            // 
            this.contactNo.Location = new System.Drawing.Point(250, 418);
            this.contactNo.Name = "contactNo";
            this.contactNo.Size = new System.Drawing.Size(286, 34);
            this.contactNo.TabIndex = 8;
            this.contactNo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(77, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 27);
            this.label11.TabIndex = 7;
            this.label11.Text = "Contact No.";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // theEmail
            // 
            this.theEmail.Location = new System.Drawing.Point(250, 481);
            this.theEmail.Name = "theEmail";
            this.theEmail.Size = new System.Drawing.Size(286, 34);
            this.theEmail.TabIndex = 10;
            this.theEmail.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(77, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 27);
            this.label12.TabIndex = 9;
            this.label12.Text = "Email";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // address_text
            // 
            this.address_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address_text.Location = new System.Drawing.Point(250, 544);
            this.address_text.Multiline = true;
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(286, 78);
            this.address_text.TabIndex = 12;
            this.address_text.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(77, 547);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 27);
            this.label13.TabIndex = 11;
            this.label13.Text = "Address";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(77, 654);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 27);
            this.label14.TabIndex = 13;
            this.label14.Text = "Gender";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // theGender
            // 
            this.theGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.theGender.FormattingEnabled = true;
            this.theGender.Location = new System.Drawing.Point(250, 651);
            this.theGender.Name = "theGender";
            this.theGender.Size = new System.Drawing.Size(286, 34);
            this.theGender.TabIndex = 14;
            this.theGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(93, 713);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(105, 45);
            this.add.TabIndex = 15;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(250, 713);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(105, 45);
            this.clear.TabIndex = 16;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // new_butt
            // 
            this.new_butt.Location = new System.Drawing.Point(393, 713);
            this.new_butt.Name = "new_butt";
            this.new_butt.Size = new System.Drawing.Size(105, 45);
            this.new_butt.TabIndex = 17;
            this.new_butt.Text = "New";
            this.new_butt.UseVisualStyleBackColor = true;
            this.new_butt.Click += new System.EventHandler(this.new_butt_Click);
            // 
            // dataView
            // 
            this.dataView.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataView.ColumnHeadersHeight = 29;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataView.Location = new System.Drawing.Point(648, 297);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(568, 388);
            this.dataView.TabIndex = 18;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellClick_1);
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick_1);
            // 
            // search_bar
            // 
            this.search_bar.Location = new System.Drawing.Point(648, 236);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(400, 34);
            this.search_bar.TabIndex = 19;
            this.search_bar.TextChanged += new System.EventHandler(this.search_bar_TextChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(1086, 230);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(130, 45);
            this.search.TabIndex = 20;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(758, 713);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(130, 45);
            this.update.TabIndex = 21;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(961, 713);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(130, 45);
            this.remove.TabIndex = 22;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1284, 817);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.update);
            this.Controls.Add(this.search);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.new_butt);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.theGender);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.theEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.contactNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.contact_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Contact Management";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox myContactLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox contactID;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox ContactNum;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Button clearButt;
        private System.Windows.Forms.Button newButt;
        private System.Windows.Forms.Button updateButt;
        private System.Windows.Forms.Button removeButt;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButt;
        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox contact_id;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox contactNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox theEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox theGender;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button new_butt;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox search_bar;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button remove;
    }
}



namespace Real_Estate_Agent
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eSubComboBox = new System.Windows.Forms.ComboBox();
            this.CommonVar1 = new System.Windows.Forms.Label();
            this.txtCV1 = new System.Windows.Forms.TextBox();
            this.CommonVar2 = new System.Windows.Forms.Label();
            this.CommonVar3 = new System.Windows.Forms.Label();
            this.txtCV2 = new System.Windows.Forms.TextBox();
            this.txtCV3 = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register the land";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(564, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // eTypeComboBox
            // 
            this.eTypeComboBox.AccessibleName = "";
            this.eTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.eTypeComboBox.FormattingEnabled = true;
            this.eTypeComboBox.Location = new System.Drawing.Point(205, 52);
            this.eTypeComboBox.Name = "eTypeComboBox";
            this.eTypeComboBox.Size = new System.Drawing.Size(145, 27);
            this.eTypeComboBox.TabIndex = 2;
            this.eTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.eTypeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estate Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subtype";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // eSubComboBox
            // 
            this.eSubComboBox.FormattingEnabled = true;
            this.eSubComboBox.Location = new System.Drawing.Point(204, 87);
            this.eSubComboBox.Name = "eSubComboBox";
            this.eSubComboBox.Size = new System.Drawing.Size(145, 27);
            this.eSubComboBox.TabIndex = 5;
            // 
            // CommonVar1
            // 
            this.CommonVar1.AutoSize = true;
            this.CommonVar1.Location = new System.Drawing.Point(40, 127);
            this.CommonVar1.Name = "CommonVar1";
            this.CommonVar1.Size = new System.Drawing.Size(112, 19);
            this.CommonVar1.TabIndex = 6;
            this.CommonVar1.Text = "CommonVar1";
            this.CommonVar1.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCV1
            // 
            this.txtCV1.Location = new System.Drawing.Point(205, 119);
            this.txtCV1.Name = "txtCV1";
            this.txtCV1.Size = new System.Drawing.Size(145, 26);
            this.txtCV1.TabIndex = 7;
            this.txtCV1.TextChanged += new System.EventHandler(this.txtCV1_TextChanged);
            // 
            // CommonVar2
            // 
            this.CommonVar2.AutoSize = true;
            this.CommonVar2.Location = new System.Drawing.Point(40, 161);
            this.CommonVar2.Name = "CommonVar2";
            this.CommonVar2.Size = new System.Drawing.Size(112, 19);
            this.CommonVar2.TabIndex = 8;
            this.CommonVar2.Text = "CommonVar2";
            this.CommonVar2.Click += new System.EventHandler(this.CommonVar2_Click);
            // 
            // CommonVar3
            // 
            this.CommonVar3.AutoSize = true;
            this.CommonVar3.Location = new System.Drawing.Point(40, 197);
            this.CommonVar3.Name = "CommonVar3";
            this.CommonVar3.Size = new System.Drawing.Size(112, 19);
            this.CommonVar3.TabIndex = 9;
            this.CommonVar3.Text = "CommonVar3";
            // 
            // txtCV2
            // 
            this.txtCV2.Location = new System.Drawing.Point(204, 153);
            this.txtCV2.Name = "txtCV2";
            this.txtCV2.Size = new System.Drawing.Size(146, 26);
            this.txtCV2.TabIndex = 10;
            // 
            // txtCV3
            // 
            this.txtCV3.Location = new System.Drawing.Point(203, 189);
            this.txtCV3.Name = "txtCV3";
            this.txtCV3.Size = new System.Drawing.Size(146, 26);
            this.txtCV3.TabIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightGray;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Location = new System.Drawing.Point(279, 233);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(107, 38);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightGray;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(519, 319);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 193);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(40, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 38);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.LightGray;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change.Location = new System.Drawing.Point(163, 233);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(98, 38);
            this.Change.TabIndex = 15;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(31, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 190);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(564, 59);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(53, 19);
            this.lblStreet.TabIndex = 17;
            this.lblStreet.Text = "Street";
            this.lblStreet.Click += new System.EventHandler(this.lblStreet_Click);
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(564, 97);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(76, 19);
            this.lblZipCode.TabIndex = 18;
            this.lblZipCode.Text = "ZIP Code";
            this.lblZipCode.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(564, 135);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 19);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City";
            this.lblCity.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(564, 174);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(69, 19);
            this.lblCountry.TabIndex = 20;
            this.lblCountry.Text = "Country";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(678, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 26);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(678, 89);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 26);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(678, 127);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 26);
            this.textBox3.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(678, 166);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 27);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AccessibleDescription = "";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1035, 519);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCV3);
            this.Controls.Add(this.txtCV2);
            this.Controls.Add(this.CommonVar3);
            this.Controls.Add(this.CommonVar2);
            this.Controls.Add(this.txtCV1);
            this.Controls.Add(this.CommonVar1);
            this.Controls.Add(this.eSubComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "mainForm";
            this.Text = "Real Estate Agent";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox eTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox eSubComboBox;
        private System.Windows.Forms.Label CommonVar1;
        private System.Windows.Forms.TextBox txtCV1;
        private System.Windows.Forms.Label CommonVar2;
        private System.Windows.Forms.Label CommonVar3;
        private System.Windows.Forms.TextBox txtCV2;
        private System.Windows.Forms.TextBox txtCV3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


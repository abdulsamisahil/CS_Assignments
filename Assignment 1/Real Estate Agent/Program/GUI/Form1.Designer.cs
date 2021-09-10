
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register the land";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(577, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // eTypeComboBox
            // 
            this.eTypeComboBox.FormattingEnabled = true;
            this.eTypeComboBox.Location = new System.Drawing.Point(267, 71);
            this.eTypeComboBox.Name = "eTypeComboBox";
            this.eTypeComboBox.Size = new System.Drawing.Size(161, 33);
            this.eTypeComboBox.TabIndex = 2;
            this.eTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.eTypeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estate Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subtype";
            // 
            // eSubComboBox
            // 
            this.eSubComboBox.FormattingEnabled = true;
            this.eSubComboBox.Location = new System.Drawing.Point(267, 110);
            this.eSubComboBox.Name = "eSubComboBox";
            this.eSubComboBox.Size = new System.Drawing.Size(161, 33);
            this.eSubComboBox.TabIndex = 5;
            // 
            // CommonVar1
            // 
            this.CommonVar1.AutoSize = true;
            this.CommonVar1.Location = new System.Drawing.Point(44, 170);
            this.CommonVar1.Name = "CommonVar1";
            this.CommonVar1.Size = new System.Drawing.Size(122, 25);
            this.CommonVar1.TabIndex = 6;
            this.CommonVar1.Text = "CommonVar1";
            this.CommonVar1.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCV1
            // 
            this.txtCV1.Location = new System.Drawing.Point(278, 164);
            this.txtCV1.Name = "txtCV1";
            this.txtCV1.Size = new System.Drawing.Size(150, 31);
            this.txtCV1.TabIndex = 7;
            // 
            // CommonVar2
            // 
            this.CommonVar2.AutoSize = true;
            this.CommonVar2.Location = new System.Drawing.Point(44, 207);
            this.CommonVar2.Name = "CommonVar2";
            this.CommonVar2.Size = new System.Drawing.Size(122, 25);
            this.CommonVar2.TabIndex = 8;
            this.CommonVar2.Text = "CommonVar2";
            this.CommonVar2.Click += new System.EventHandler(this.CommonVar2_Click);
            // 
            // CommonVar3
            // 
            this.CommonVar3.AutoSize = true;
            this.CommonVar3.Location = new System.Drawing.Point(44, 238);
            this.CommonVar3.Name = "CommonVar3";
            this.CommonVar3.Size = new System.Drawing.Size(122, 25);
            this.CommonVar3.TabIndex = 9;
            this.CommonVar3.Text = "CommonVar3";
            // 
            // txtCV2
            // 
            this.txtCV2.Location = new System.Drawing.Point(278, 201);
            this.txtCV2.Name = "txtCV2";
            this.txtCV2.Size = new System.Drawing.Size(150, 31);
            this.txtCV2.TabIndex = 10;
            // 
            // txtCV3
            // 
            this.txtCV3.Location = new System.Drawing.Point(278, 238);
            this.txtCV3.Name = "txtCV3";
            this.txtCV3.Size = new System.Drawing.Size(150, 31);
            this.txtCV3.TabIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(310, 323);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(118, 34);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(577, 444);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(533, 265);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(44, 323);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 34);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(182, 323);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(109, 34);
            this.Change.TabIndex = 15;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 444);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 265);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 721);
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
            this.Name = "mainForm";
            this.Text = "Real Estate Agent";
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
    }
}


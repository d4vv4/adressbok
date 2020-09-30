namespace Inlämningsuppgift1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblErrorSearch = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchResult = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPostalSearch = new System.Windows.Forms.TextBox();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(79, 48);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(170, 20);
            this.txtAdress.TabIndex = 1;
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(79, 75);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(170, 20);
            this.txtPostal.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(79, 101);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(170, 20);
            this.txtCity.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(79, 127);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(170, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(79, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Namn";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(18, 51);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(55, 13);
            this.lblAdress.TabIndex = 7;
            this.lblAdress.Text = "Gatudress";
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Location = new System.Drawing.Point(8, 78);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(65, 13);
            this.lblPostal.TabIndex = 8;
            this.lblPostal.Text = "Postnummer";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(33, 104);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(40, 13);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "Postort";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 130);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 156);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-post";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(93, 204);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Registrera";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(79, 180);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.txtPostal);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblPostal);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblAdress);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 240);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrera / Ändra";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(21, 172);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(47, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Rensa";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(174, 204);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "Spara";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblErrorSearch
            // 
            this.lblErrorSearch.AutoSize = true;
            this.lblErrorSearch.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSearch.Location = new System.Drawing.Point(85, 48);
            this.lblErrorSearch.Name = "lblErrorSearch";
            this.lblErrorSearch.Size = new System.Drawing.Size(14, 13);
            this.lblErrorSearch.TabIndex = 15;
            this.lblErrorSearch.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchResult);
            this.groupBox2.Controls.Add(this.lblErrorSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPostalSearch);
            this.groupBox2.Controls.Add(this.txtNameSearch);
            this.groupBox2.Location = new System.Drawing.Point(283, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 240);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sök / Ändra";
            // 
            // SearchResult
            // 
            this.SearchResult.FormattingEnabled = true;
            this.SearchResult.Location = new System.Drawing.Point(6, 113);
            this.SearchResult.Name = "SearchResult";
            this.SearchResult.Size = new System.Drawing.Size(649, 121);
            this.SearchResult.TabIndex = 16;
            this.SearchResult.SelectedIndexChanged += new System.EventHandler(this.SearchResult_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(88, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Postort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Namn";
            // 
            // txtPostalSearch
            // 
            this.txtPostalSearch.Location = new System.Drawing.Point(266, 22);
            this.txtPostalSearch.Name = "txtPostalSearch";
            this.txtPostalSearch.Size = new System.Drawing.Size(115, 20);
            this.txtPostalSearch.TabIndex = 1;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(88, 22);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(115, 20);
            this.txtNameSearch.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(956, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Adressbok";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPostalSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label lblErrorSearch;
        private System.Windows.Forms.ListBox SearchResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
    }
}


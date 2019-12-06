namespace BTH5
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxClass = new System.Windows.Forms.TextBox();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.timepick = new System.Windows.Forms.DateTimePicker();
            this.cbxPhone = new System.Windows.Forms.ComboBox();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlInfo2 = new System.Windows.Forms.Panel();
            this.pnlInfo1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areacode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlInfo2.SuspendLayout();
            this.pnlInfo1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnChange);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Name = "panel2";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDel
            // 
            resources.ApplyResources(this.btnDel, "btnDel");
            this.btnDel.Name = "btnDel";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnChange
            // 
            resources.ApplyResources(this.btnChange, "btnChange");
            this.btnChange.Name = "btnChange";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // lblClass
            // 
            resources.ApplyResources(this.lblClass, "lblClass");
            this.lblClass.Name = "lblClass";
            // 
            // lblDOB
            // 
            resources.ApplyResources(this.lblDOB, "lblDOB");
            this.lblDOB.Name = "lblDOB";
            // 
            // lblGender
            // 
            resources.ApplyResources(this.lblGender, "lblGender");
            this.lblGender.Name = "lblGender";
            // 
            // lblPhone
            // 
            resources.ApplyResources(this.lblPhone, "lblPhone");
            this.lblPhone.Name = "lblPhone";
            // 
            // lblMail
            // 
            resources.ApplyResources(this.lblMail, "lblMail");
            this.lblMail.Name = "lblMail";
            // 
            // tbxName
            // 
            resources.ApplyResources(this.tbxName, "tbxName");
            this.tbxName.Name = "tbxName";
            // 
            // tbxPhone
            // 
            resources.ApplyResources(this.tbxPhone, "tbxPhone");
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberFilter);
            // 
            // tbxClass
            // 
            resources.ApplyResources(this.tbxClass, "tbxClass");
            this.tbxClass.Name = "tbxClass";
            // 
            // tbxID
            // 
            resources.ApplyResources(this.tbxID, "tbxID");
            this.tbxID.Name = "tbxID";
            // 
            // timepick
            // 
            resources.ApplyResources(this.timepick, "timepick");
            this.timepick.Name = "timepick";
            // 
            // cbxPhone
            // 
            this.cbxPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPhone.Items.AddRange(new object[] {
            resources.GetString("cbxPhone.Items"),
            resources.GetString("cbxPhone.Items1"),
            resources.GetString("cbxPhone.Items2"),
            resources.GetString("cbxPhone.Items3"),
            resources.GetString("cbxPhone.Items4"),
            resources.GetString("cbxPhone.Items5")});
            resources.ApplyResources(this.cbxPhone, "cbxPhone");
            this.cbxPhone.Name = "cbxPhone";
            // 
            // tbxMail
            // 
            resources.ApplyResources(this.tbxMail, "tbxMail");
            this.tbxMail.Name = "tbxMail";
            // 
            // rad1
            // 
            resources.ApplyResources(this.rad1, "rad1");
            this.rad1.Name = "rad1";
            this.rad1.TabStop = true;
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            resources.ApplyResources(this.rad2, "rad2");
            this.rad2.Name = "rad2";
            this.rad2.TabStop = true;
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            resources.ApplyResources(this.rad3, "rad3");
            this.rad3.Name = "rad3";
            this.rad3.TabStop = true;
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlInfo2);
            this.groupBox1.Controls.Add(this.pnlInfo1);
            this.groupBox1.Controls.Add(this.panel2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pnlInfo2
            // 
            resources.ApplyResources(this.pnlInfo2, "pnlInfo2");
            this.pnlInfo2.Controls.Add(this.rad1);
            this.pnlInfo2.Controls.Add(this.rad3);
            this.pnlInfo2.Controls.Add(this.tbxPhone);
            this.pnlInfo2.Controls.Add(this.lblMail);
            this.pnlInfo2.Controls.Add(this.rad2);
            this.pnlInfo2.Controls.Add(this.lblPhone);
            this.pnlInfo2.Controls.Add(this.lblGender);
            this.pnlInfo2.Controls.Add(this.tbxMail);
            this.pnlInfo2.Controls.Add(this.cbxPhone);
            this.pnlInfo2.Name = "pnlInfo2";
            // 
            // pnlInfo1
            // 
            resources.ApplyResources(this.pnlInfo1, "pnlInfo1");
            this.pnlInfo1.Controls.Add(this.tbxName);
            this.pnlInfo1.Controls.Add(this.lblName);
            this.pnlInfo1.Controls.Add(this.tbxClass);
            this.pnlInfo1.Controls.Add(this.tbxID);
            this.pnlInfo1.Controls.Add(this.timepick);
            this.pnlInfo1.Controls.Add(this.lblID);
            this.pnlInfo1.Controls.Add(this.lblDOB);
            this.pnlInfo1.Controls.Add(this.lblClass);
            this.pnlInfo1.Name = "pnlInfo1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sv_id,
            this.sv_name,
            this.sv_class,
            this.sv_dob,
            this.sv_gender,
            this.areacode,
            this.sv_phone,
            this.sv_mail});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellSelectionOverride);
            // 
            // sv_id
            // 
            this.sv_id.DataPropertyName = "Id";
            resources.ApplyResources(this.sv_id, "sv_id");
            this.sv_id.Name = "sv_id";
            this.sv_id.ReadOnly = true;
            // 
            // sv_name
            // 
            this.sv_name.DataPropertyName = "Sv_name";
            resources.ApplyResources(this.sv_name, "sv_name");
            this.sv_name.Name = "sv_name";
            this.sv_name.ReadOnly = true;
            // 
            // sv_class
            // 
            this.sv_class.DataPropertyName = "Sv_class";
            resources.ApplyResources(this.sv_class, "sv_class");
            this.sv_class.Name = "sv_class";
            this.sv_class.ReadOnly = true;
            // 
            // sv_dob
            // 
            this.sv_dob.DataPropertyName = "Dob";
            resources.ApplyResources(this.sv_dob, "sv_dob");
            this.sv_dob.Name = "sv_dob";
            this.sv_dob.ReadOnly = true;
            // 
            // sv_gender
            // 
            this.sv_gender.DataPropertyName = "Gender";
            resources.ApplyResources(this.sv_gender, "sv_gender");
            this.sv_gender.Name = "sv_gender";
            this.sv_gender.ReadOnly = true;
            // 
            // areacode
            // 
            this.areacode.DataPropertyName = "Areacode";
            resources.ApplyResources(this.areacode, "areacode");
            this.areacode.Name = "areacode";
            this.areacode.ReadOnly = true;
            // 
            // sv_phone
            // 
            this.sv_phone.DataPropertyName = "Phone";
            resources.ApplyResources(this.sv_phone, "sv_phone");
            this.sv_phone.Name = "sv_phone";
            this.sv_phone.ReadOnly = true;
            // 
            // sv_mail
            // 
            this.sv_mail.DataPropertyName = "Mail";
            resources.ApplyResources(this.sv_mail, "sv_mail");
            this.sv_mail.Name = "sv_mail";
            this.sv_mail.ReadOnly = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.TopMost = true;
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlInfo2.ResumeLayout(false);
            this.pnlInfo2.PerformLayout();
            this.pnlInfo1.ResumeLayout(false);
            this.pnlInfo1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker timepick;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxClass;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlInfo2;
        private System.Windows.Forms.Panel pnlInfo1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn areacode;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_mail;
        private System.Windows.Forms.ComboBox cbxPhone;
    }
}


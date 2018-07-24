namespace ADOE
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
            this.components = new System.ComponentModel.Container();
            this.lblname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblmembership = new System.Windows.Forms.Label();
            this.lblpref = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.rbfree = new System.Windows.Forms.RadioButton();
            this.rbpaid = new System.Windows.Forms.RadioButton();
            this.clbshop = new System.Windows.Forms.CheckedListBox();
            this.cbcod = new System.Windows.Forms.CheckBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.registerShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingDBDataSet = new ADOE.TrainingDBDataSet();
            this.btndelete = new System.Windows.Forms.Button();
            this.registerShoppingTableAdapter = new ADOE.TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(46, 66);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(115, 25);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter Name:";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(46, 123);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(129, 25);
            this.lblgender.TabIndex = 1;
            this.lblgender.Text = "Select Gender";
            // 
            // lblmembership
            // 
            this.lblmembership.AutoSize = true;
            this.lblmembership.Location = new System.Drawing.Point(46, 212);
            this.lblmembership.Name = "lblmembership";
            this.lblmembership.Size = new System.Drawing.Size(173, 25);
            this.lblmembership.TabIndex = 2;
            this.lblmembership.Text = "Select Membership";
            // 
            // lblpref
            // 
            this.lblpref.AutoSize = true;
            this.lblpref.Location = new System.Drawing.Point(42, 297);
            this.lblpref.Name = "lblpref";
            this.lblpref.Size = new System.Drawing.Size(189, 25);
            this.lblpref.TabIndex = 3;
            this.lblpref.Text = "Shopping preference";
            this.lblpref.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(46, 523);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(115, 25);
            this.lblcod.TabIndex = 4;
            this.lblcod.Text = "Prefer COD?";
            this.lblcod.Click += new System.EventHandler(this.lblcod_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(46, 597);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(91, 25);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "Password";
            this.lblpassword.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(248, 58);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(238, 33);
            this.txtname.TabIndex = 6;
            // 
            // cbgender
            // 
            this.cbgender.AllowDrop = true;
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHERS"});
            this.cbgender.Location = new System.Drawing.Point(248, 123);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(238, 33);
            this.cbgender.TabIndex = 7;
            // 
            // rbfree
            // 
            this.rbfree.AutoSize = true;
            this.rbfree.Location = new System.Drawing.Point(248, 218);
            this.rbfree.Name = "rbfree";
            this.rbfree.Size = new System.Drawing.Size(66, 29);
            this.rbfree.TabIndex = 8;
            this.rbfree.TabStop = true;
            this.rbfree.Text = "Free";
            this.rbfree.UseVisualStyleBackColor = true;
            // 
            // rbpaid
            // 
            this.rbpaid.AutoSize = true;
            this.rbpaid.Location = new System.Drawing.Point(420, 218);
            this.rbpaid.Name = "rbpaid";
            this.rbpaid.Size = new System.Drawing.Size(66, 29);
            this.rbpaid.TabIndex = 9;
            this.rbpaid.TabStop = true;
            this.rbpaid.Text = "Paid";
            this.rbpaid.UseVisualStyleBackColor = true;
            // 
            // clbshop
            // 
            this.clbshop.FormattingEnabled = true;
            this.clbshop.Items.AddRange(new object[] {
            "APPARELS",
            "COSMETICS",
            "SHOES",
            "MOBILE",
            "LAPTOPS",
            "GADGETS",
            "KITCHEN ITEM"});
            this.clbshop.Location = new System.Drawing.Point(248, 297);
            this.clbshop.Name = "clbshop";
            this.clbshop.Size = new System.Drawing.Size(238, 172);
            this.clbshop.TabIndex = 10;
            // 
            // cbcod
            // 
            this.cbcod.AutoSize = true;
            this.cbcod.Location = new System.Drawing.Point(266, 523);
            this.cbcod.Name = "cbcod";
            this.cbcod.Size = new System.Drawing.Size(62, 29);
            this.cbcod.TabIndex = 11;
            this.cbcod.Text = "YES";
            this.cbcod.UseVisualStyleBackColor = true;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(248, 598);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(238, 33);
            this.txtpass.TabIndex = 12;
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.AliceBlue;
            this.btnregister.Font = new System.Drawing.Font("Haettenschweiler", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnregister.Location = new System.Drawing.Point(712, 598);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(113, 33);
            this.btnregister.TabIndex = 13;
            this.btnregister.Text = "REGISTER";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.GhostWhite;
            this.btnselect.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnselect.Location = new System.Drawing.Point(900, 597);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(113, 37);
            this.btnselect.TabIndex = 14;
            this.btnselect.Text = "SELECT";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // lbselect
            // 
            this.lbselect.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbselect.FormattingEnabled = true;
            this.lbselect.ItemHeight = 15;
            this.lbselect.Location = new System.Drawing.Point(592, 42);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(326, 424);
            this.lbselect.TabIndex = 15;
            this.lbselect.SelectedIndexChanged += new System.EventHandler(this.lbselect_SelectedIndexChanged);
            // 
            // cbid
            // 
            this.cbid.DataSource = this.registerShoppingBindingSource;
            this.cbid.DisplayMember = "Name";
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(248, 12);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(238, 33);
            this.cbid.TabIndex = 16;
            this.cbid.ValueMember = "id";
            // 
            // registerShoppingBindingSource
            // 
            this.registerShoppingBindingSource.DataMember = "RegisterShopping";
            this.registerShoppingBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.AliceBlue;
            this.btndelete.Font = new System.Drawing.Font("Haettenschweiler", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btndelete.Location = new System.Drawing.Point(712, 515);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(113, 33);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // registerShoppingTableAdapter
            // 
            this.registerShoppingTableAdapter.ClearBeforeFill = true;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.AliceBlue;
            this.btnupdate.Font = new System.Drawing.Font("Haettenschweiler", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnupdate.Location = new System.Drawing.Point(900, 515);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(113, 33);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1097, 703);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.cbcod);
            this.Controls.Add(this.clbshop);
            this.Controls.Add(this.rbpaid);
            this.Controls.Add(this.rbfree);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.lblpref);
            this.Controls.Add(this.lblmembership);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblmembership;
        private System.Windows.Forms.Label lblpref;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.RadioButton rbfree;
        private System.Windows.Forms.RadioButton rbpaid;
        private System.Windows.Forms.CheckedListBox clbshop;
        private System.Windows.Forms.CheckBox cbcod;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.Button btndelete;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource;
        private TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter registerShoppingTableAdapter;
        private System.Windows.Forms.Button btnupdate;
    }
}


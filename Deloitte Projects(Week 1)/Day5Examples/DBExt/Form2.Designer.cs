namespace DBExt
{
    partial class Form2
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
            this.btndelete = new System.Windows.Forms.Button();
            this.registerShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbid = new System.Windows.Forms.ComboBox();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.cbcod = new System.Windows.Forms.CheckBox();
            this.clbshop = new System.Windows.Forms.CheckedListBox();
            this.rbpaid = new System.Windows.Forms.RadioButton();
            this.rbfree = new System.Windows.Forms.RadioButton();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblpref = new System.Windows.Forms.Label();
            this.lblmembership = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.trainingDBDataSet = new DBExt.TrainingDBDataSet();
            this.registerShoppingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registerShoppingTableAdapter = new DBExt.TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter();
            this.btnsp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.AliceBlue;
            this.btndelete.Font = new System.Drawing.Font("Haettenschweiler", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btndelete.Location = new System.Drawing.Point(568, 354);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(113, 33);
            this.btndelete.TabIndex = 36;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // registerShoppingBindingSource
            // 
            this.registerShoppingBindingSource.DataMember = "RegisterShopping";
            // 
            // cbid
            // 
            this.cbid.DataSource = this.registerShoppingBindingSource1;
            this.cbid.DisplayMember = "Name";
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(224, 12);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(238, 21);
            this.cbid.TabIndex = 35;
            this.cbid.ValueMember = "Id";
            // 
            // lbselect
            // 
            this.lbselect.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbselect.FormattingEnabled = true;
            this.lbselect.ItemHeight = 15;
            this.lbselect.Location = new System.Drawing.Point(568, 45);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(326, 274);
            this.lbselect.TabIndex = 34;
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.GhostWhite;
            this.btnselect.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnselect.Location = new System.Drawing.Point(781, 441);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(113, 37);
            this.btnselect.TabIndex = 33;
            this.btnselect.Text = "SELECT";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.AliceBlue;
            this.btnregister.Font = new System.Drawing.Font("Haettenschweiler", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnregister.Location = new System.Drawing.Point(568, 444);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(113, 33);
            this.btnregister.TabIndex = 32;
            this.btnregister.Text = "REGISTER";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(224, 453);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(238, 20);
            this.txtpass.TabIndex = 31;
            // 
            // cbcod
            // 
            this.cbcod.AutoSize = true;
            this.cbcod.Location = new System.Drawing.Point(224, 374);
            this.cbcod.Name = "cbcod";
            this.cbcod.Size = new System.Drawing.Size(47, 17);
            this.cbcod.TabIndex = 30;
            this.cbcod.Text = "YES";
            this.cbcod.UseVisualStyleBackColor = true;
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
            this.clbshop.Location = new System.Drawing.Point(224, 195);
            this.clbshop.Name = "clbshop";
            this.clbshop.Size = new System.Drawing.Size(238, 169);
            this.clbshop.TabIndex = 29;
            // 
            // rbpaid
            // 
            this.rbpaid.AutoSize = true;
            this.rbpaid.Location = new System.Drawing.Point(388, 139);
            this.rbpaid.Name = "rbpaid";
            this.rbpaid.Size = new System.Drawing.Size(46, 17);
            this.rbpaid.TabIndex = 28;
            this.rbpaid.TabStop = true;
            this.rbpaid.Text = "Paid";
            this.rbpaid.UseVisualStyleBackColor = true;
            // 
            // rbfree
            // 
            this.rbfree.AutoSize = true;
            this.rbfree.Location = new System.Drawing.Point(224, 137);
            this.rbfree.Name = "rbfree";
            this.rbfree.Size = new System.Drawing.Size(46, 17);
            this.rbfree.TabIndex = 27;
            this.rbfree.TabStop = true;
            this.rbfree.Text = "Free";
            this.rbfree.UseVisualStyleBackColor = true;
            // 
            // cbgender
            // 
            this.cbgender.AllowDrop = true;
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHERS"});
            this.cbgender.Location = new System.Drawing.Point(224, 83);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(238, 21);
            this.cbgender.TabIndex = 26;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(224, 38);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(238, 20);
            this.txtname.TabIndex = 25;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(35, 456);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 24;
            this.lblpassword.Text = "Password";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(30, 374);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(67, 13);
            this.lblcod.TabIndex = 23;
            this.lblcod.Text = "Prefer COD?";
            // 
            // lblpref
            // 
            this.lblpref.AutoSize = true;
            this.lblpref.Location = new System.Drawing.Point(22, 195);
            this.lblpref.Name = "lblpref";
            this.lblpref.Size = new System.Drawing.Size(106, 13);
            this.lblpref.TabIndex = 22;
            this.lblpref.Text = "Shopping preference";
            // 
            // lblmembership
            // 
            this.lblmembership.AutoSize = true;
            this.lblmembership.Location = new System.Drawing.Point(18, 139);
            this.lblmembership.Name = "lblmembership";
            this.lblmembership.Size = new System.Drawing.Size(97, 13);
            this.lblmembership.TabIndex = 21;
            this.lblmembership.Text = "Select Membership";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(22, 86);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(75, 13);
            this.lblgender.TabIndex = 20;
            this.lblgender.Text = "Select Gender";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(22, 45);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(66, 13);
            this.lblname.TabIndex = 19;
            this.lblname.Text = "Enter Name:";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.AliceBlue;
            this.btnupdate.Font = new System.Drawing.Font("Haettenschweiler", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnupdate.Location = new System.Drawing.Point(781, 354);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(113, 33);
            this.btnupdate.TabIndex = 37;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerShoppingBindingSource1
            // 
            this.registerShoppingBindingSource1.DataMember = "RegisterShopping";
            this.registerShoppingBindingSource1.DataSource = this.trainingDBDataSet;
            // 
            // registerShoppingTableAdapter
            // 
            this.registerShoppingTableAdapter.ClearBeforeFill = true;
            // 
            // btnsp
            // 
            this.btnsp.BackColor = System.Drawing.Color.GhostWhite;
            this.btnsp.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsp.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnsp.Location = new System.Drawing.Point(677, 505);
            this.btnsp.Name = "btnsp";
            this.btnsp.Size = new System.Drawing.Size(113, 37);
            this.btnsp.TabIndex = 38;
            this.btnsp.Text = "Call SP";
            this.btnsp.UseVisualStyleBackColor = false;
            this.btnsp.Click += new System.EventHandler(this.btnsp_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1113, 652);
            this.Controls.Add(this.btnsp);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.CheckBox cbcod;
        private System.Windows.Forms.CheckedListBox clbshop;
        private System.Windows.Forms.RadioButton rbpaid;
        private System.Windows.Forms.RadioButton rbfree;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblpref;
        private System.Windows.Forms.Label lblmembership;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnupdate;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource1;
        private TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter registerShoppingTableAdapter;
        private System.Windows.Forms.Button btnsp;
    }
}
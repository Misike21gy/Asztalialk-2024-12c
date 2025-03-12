namespace halmazok
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
            this.A_halmaz = new System.Windows.Forms.ListBox();
            this.B_halmaz = new System.Windows.Forms.ListBox();
            this.AB_unio = new System.Windows.Forms.ListBox();
            this.ABmetszet = new System.Windows.Forms.ListBox();
            this.AbolB = new System.Windows.Forms.ListBox();
            this.BbolA = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.btn_general = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Ahalmaz = new System.Windows.Forms.TextBox();
            this.Bhalmaz = new System.Windows.Forms.TextBox();
            this.AbolBeredm = new System.Windows.Forms.TextBox();
            this.BbolAeredm = new System.Windows.Forms.TextBox();
            this.ABunio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // A_halmaz
            // 
            this.A_halmaz.FormattingEnabled = true;
            this.A_halmaz.Location = new System.Drawing.Point(12, 39);
            this.A_halmaz.Name = "A_halmaz";
            this.A_halmaz.Size = new System.Drawing.Size(125, 303);
            this.A_halmaz.TabIndex = 0;
            this.A_halmaz.SelectedIndexChanged += new System.EventHandler(this.Ahalmaz_SelectedIndexChanged);
            // 
            // B_halmaz
            // 
            this.B_halmaz.FormattingEnabled = true;
            this.B_halmaz.Location = new System.Drawing.Point(143, 39);
            this.B_halmaz.Name = "B_halmaz";
            this.B_halmaz.Size = new System.Drawing.Size(126, 303);
            this.B_halmaz.TabIndex = 1;
            // 
            // AB_unio
            // 
            this.AB_unio.FormattingEnabled = true;
            this.AB_unio.Location = new System.Drawing.Point(275, 39);
            this.AB_unio.Name = "AB_unio";
            this.AB_unio.Size = new System.Drawing.Size(126, 303);
            this.AB_unio.TabIndex = 2;
            // 
            // ABmetszet
            // 
            this.ABmetszet.FormattingEnabled = true;
            this.ABmetszet.Location = new System.Drawing.Point(407, 39);
            this.ABmetszet.Name = "ABmetszet";
            this.ABmetszet.Size = new System.Drawing.Size(126, 303);
            this.ABmetszet.TabIndex = 3;
            // 
            // AbolB
            // 
            this.AbolB.FormattingEnabled = true;
            this.AbolB.Location = new System.Drawing.Point(539, 39);
            this.AbolB.Name = "AbolB";
            this.AbolB.Size = new System.Drawing.Size(126, 303);
            this.AbolB.TabIndex = 4;
            this.AbolB.SelectedIndexChanged += new System.EventHandler(this.AbolB_SelectedIndexChanged);
            // 
            // BbolA
            // 
            this.BbolA.FormattingEnabled = true;
            this.BbolA.Location = new System.Drawing.Point(671, 39);
            this.BbolA.Name = "BbolA";
            this.BbolA.Size = new System.Drawing.Size(117, 303);
            this.BbolA.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "\"A\" halmaz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "\"B\" halmaz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "A unió B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "A metszet B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "A-B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(671, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "B-A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "A halmazok elemszáma:";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Location = new System.Drawing.Point(15, 403);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(56, 20);
            this.domainUpDown1.TabIndex = 13;
            this.domainUpDown1.Text = "0";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Items.Add("1");
            this.domainUpDown2.Items.Add("2");
            this.domainUpDown2.Items.Add("3");
            this.domainUpDown2.Items.Add("4");
            this.domainUpDown2.Items.Add("5");
            this.domainUpDown2.Items.Add("6");
            this.domainUpDown2.Items.Add("7");
            this.domainUpDown2.Items.Add("8");
            this.domainUpDown2.Items.Add("9");
            this.domainUpDown2.Items.Add("10");
            this.domainUpDown2.Location = new System.Drawing.Point(81, 403);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(56, 20);
            this.domainUpDown2.TabIndex = 14;
            this.domainUpDown2.Text = "0";
            this.domainUpDown2.SelectedItemChanged += new System.EventHandler(this.domainUpDown2_SelectedItemChanged);
            // 
            // btn_general
            // 
            this.btn_general.Location = new System.Drawing.Point(153, 400);
            this.btn_general.Name = "btn_general";
            this.btn_general.Size = new System.Drawing.Size(75, 23);
            this.btn_general.TabIndex = 15;
            this.btn_general.Text = "Generálj!";
            this.btn_general.UseVisualStyleBackColor = true;
            this.btn_general.Click += new System.EventHandler(this.btn_general_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "A halmaz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "B halmaz";
            // 
            // Ahalmaz
            // 
            this.Ahalmaz.Location = new System.Drawing.Point(15, 65);
            this.Ahalmaz.Name = "Ahalmaz";
            this.Ahalmaz.Size = new System.Drawing.Size(113, 20);
            this.Ahalmaz.TabIndex = 18;
            // 
            // Bhalmaz
            // 
            this.Bhalmaz.Location = new System.Drawing.Point(153, 64);
            this.Bhalmaz.Name = "Bhalmaz";
            this.Bhalmaz.Size = new System.Drawing.Size(100, 20);
            this.Bhalmaz.TabIndex = 19;
            // 
            // AbolBeredm
            // 
            this.AbolBeredm.Location = new System.Drawing.Point(548, 64);
            this.AbolBeredm.Name = "AbolBeredm";
            this.AbolBeredm.Size = new System.Drawing.Size(100, 20);
            this.AbolBeredm.TabIndex = 20;
            // 
            // BbolAeredm
            // 
            this.BbolAeredm.Location = new System.Drawing.Point(674, 64);
            this.BbolAeredm.Name = "BbolAeredm";
            this.BbolAeredm.Size = new System.Drawing.Size(100, 20);
            this.BbolAeredm.TabIndex = 21;
            // 
            // ABunio
            // 
            this.ABunio.Location = new System.Drawing.Point(278, 64);
            this.ABunio.Name = "ABunio";
            this.ABunio.Size = new System.Drawing.Size(100, 20);
            this.ABunio.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ABunio);
            this.Controls.Add(this.BbolAeredm);
            this.Controls.Add(this.AbolBeredm);
            this.Controls.Add(this.Bhalmaz);
            this.Controls.Add(this.Ahalmaz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_general);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BbolA);
            this.Controls.Add(this.AbolB);
            this.Controls.Add(this.ABmetszet);
            this.Controls.Add(this.AB_unio);
            this.Controls.Add(this.B_halmaz);
            this.Controls.Add(this.A_halmaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox B_halmaz;
        private System.Windows.Forms.ListBox AB_unio;
        private System.Windows.Forms.ListBox ABmetszet;
        private System.Windows.Forms.ListBox AbolB;
        private System.Windows.Forms.ListBox BbolA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.Button btn_general;
        private System.Windows.Forms.ListBox A_halmaz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Ahalmaz;
        private System.Windows.Forms.TextBox Bhalmaz;
        private System.Windows.Forms.TextBox AbolBeredm;
        private System.Windows.Forms.TextBox BbolAeredm;
        private System.Windows.Forms.TextBox ABunio;
    }
}


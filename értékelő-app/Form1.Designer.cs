﻿namespace értékelő_app
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
            this.label_cim = new System.Windows.Forms.Label();
            this.btn_töri = new System.Windows.Forms.Button();
            this.btn_matek = new System.Windows.Forms.Button();
            this.label_alcim = new System.Windows.Forms.Label();
            this.label_alcim2 = new System.Windows.Forms.Label();
            this.btn_angol = new System.Windows.Forms.Button();
            this.btn_irodalom = new System.Windows.Forms.Button();
            this.btn_nyelvtan = new System.Windows.Forms.Button();
            this.btn_digikult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_cim
            // 
            this.label_cim.AutoSize = true;
            this.label_cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cim.Location = new System.Drawing.Point(296, 25);
            this.label_cim.Name = "label_cim";
            this.label_cim.Size = new System.Drawing.Size(581, 33);
            this.label_cim.TabIndex = 0;
            this.label_cim.Text = "Felkészülnél az érettségire? Itt megteheted!";
            // 
            // btn_töri
            // 
            this.btn_töri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_töri.Location = new System.Drawing.Point(778, 300);
            this.btn_töri.Name = "btn_töri";
            this.btn_töri.Size = new System.Drawing.Size(117, 54);
            this.btn_töri.TabIndex = 2;
            this.btn_töri.Text = "Történelem";
            this.btn_töri.UseVisualStyleBackColor = true;
            this.btn_töri.Click += new System.EventHandler(this.btn_töri_Click);
            // 
            // btn_matek
            // 
            this.btn_matek.BackColor = System.Drawing.SystemColors.Control;
            this.btn_matek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matek.Location = new System.Drawing.Point(778, 370);
            this.btn_matek.Name = "btn_matek";
            this.btn_matek.Size = new System.Drawing.Size(117, 54);
            this.btn_matek.TabIndex = 3;
            this.btn_matek.Text = "Matematika";
            this.btn_matek.UseVisualStyleBackColor = true;
            this.btn_matek.Click += new System.EventHandler(this.btn_matek_Click);
            // 
            // label_alcim
            // 
            this.label_alcim.AutoSize = true;
            this.label_alcim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alcim.Location = new System.Drawing.Point(217, 67);
            this.label_alcim.Name = "label_alcim";
            this.label_alcim.Size = new System.Drawing.Size(759, 24);
            this.label_alcim.TabIndex = 4;
            this.label_alcim.Text = "Könnyen tanulhatod meg a fontosabb témaköröket változatos kérdésekkel, és feladat" +
    "okkal!\r\n";
            // 
            // label_alcim2
            // 
            this.label_alcim2.AutoSize = true;
            this.label_alcim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alcim2.Location = new System.Drawing.Point(217, 180);
            this.label_alcim2.Name = "label_alcim2";
            this.label_alcim2.Size = new System.Drawing.Size(310, 48);
            this.label_alcim2.TabIndex = 5;
            this.label_alcim2.Text = "Válaszd ki a tanulni kívánt tantárgyat:\r\n\r\n";
            // 
            // btn_angol
            // 
            this.btn_angol.BackColor = System.Drawing.SystemColors.Control;
            this.btn_angol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_angol.Location = new System.Drawing.Point(655, 370);
            this.btn_angol.Name = "btn_angol";
            this.btn_angol.Size = new System.Drawing.Size(117, 54);
            this.btn_angol.TabIndex = 7;
            this.btn_angol.Text = "Angol nyelv";
            this.btn_angol.UseVisualStyleBackColor = true;
            this.btn_angol.Click += new System.EventHandler(this.btn_angol_Click);
            // 
            // btn_irodalom
            // 
            this.btn_irodalom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_irodalom.Location = new System.Drawing.Point(655, 300);
            this.btn_irodalom.Name = "btn_irodalom";
            this.btn_irodalom.Size = new System.Drawing.Size(117, 54);
            this.btn_irodalom.TabIndex = 1;
            this.btn_irodalom.Text = "Irodalom";
            this.btn_irodalom.UseVisualStyleBackColor = true;
            this.btn_irodalom.Click += new System.EventHandler(this.btn_irodalom_Click);
            // 
            // btn_nyelvtan
            // 
            this.btn_nyelvtan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nyelvtan.Location = new System.Drawing.Point(655, 229);
            this.btn_nyelvtan.Name = "btn_nyelvtan";
            this.btn_nyelvtan.Size = new System.Drawing.Size(240, 54);
            this.btn_nyelvtan.TabIndex = 8;
            this.btn_nyelvtan.Text = "Magyar nyelvtan";
            this.btn_nyelvtan.UseVisualStyleBackColor = true;
            this.btn_nyelvtan.Click += new System.EventHandler(this.btn_nyelvtan_Click);
            // 
            // btn_digikult
            // 
            this.btn_digikult.BackColor = System.Drawing.SystemColors.Control;
            this.btn_digikult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_digikult.Location = new System.Drawing.Point(655, 440);
            this.btn_digikult.Name = "btn_digikult";
            this.btn_digikult.Size = new System.Drawing.Size(240, 54);
            this.btn_digikult.TabIndex = 9;
            this.btn_digikult.Text = "Digitális kultúra";
            this.btn_digikult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 610);
            this.Controls.Add(this.btn_digikult);
            this.Controls.Add(this.btn_nyelvtan);
            this.Controls.Add(this.btn_angol);
            this.Controls.Add(this.label_alcim2);
            this.Controls.Add(this.label_alcim);
            this.Controls.Add(this.btn_matek);
            this.Controls.Add(this.btn_töri);
            this.Controls.Add(this.btn_irodalom);
            this.Controls.Add(this.label_cim);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cim;
        private System.Windows.Forms.Button btn_töri;
        private System.Windows.Forms.Button btn_matek;
        private System.Windows.Forms.Label label_alcim;
        private System.Windows.Forms.Label label_alcim2;
        private System.Windows.Forms.Button btn_angol;
        private System.Windows.Forms.Button btn_irodalom;
        private System.Windows.Forms.Button btn_nyelvtan;
        private System.Windows.Forms.Button btn_digikult;
    }
}


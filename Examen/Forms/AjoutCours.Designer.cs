
namespace Examen.Forms
{
    partial class AjoutCours
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Id_cours = new System.Windows.Forms.TextBox();
            this.NomCours = new System.Windows.Forms.TextBox();
            this.Id_Module = new System.Windows.Forms.TextBox();
            this.Id_Salle = new System.Windows.Forms.TextBox();
            this.CIN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(593, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "AJOUTER COURS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(117, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID COURS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(976, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID SALLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(117, 541);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOM COURS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(976, 541);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "CIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(117, 869);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 50);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID MODULE";
            // 
            // Id_cours
            // 
            this.Id_cours.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Id_cours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id_cours.Location = new System.Drawing.Point(117, 358);
            this.Id_cours.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Id_cours.Multiline = true;
            this.Id_cours.Name = "Id_cours";
            this.Id_cours.Size = new System.Drawing.Size(563, 90);
            this.Id_cours.TabIndex = 6;
            // 
            // NomCours
            // 
            this.NomCours.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NomCours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NomCours.Location = new System.Drawing.Point(117, 656);
            this.NomCours.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.NomCours.Multiline = true;
            this.NomCours.Name = "NomCours";
            this.NomCours.Size = new System.Drawing.Size(563, 63);
            this.NomCours.TabIndex = 7;
            // 
            // Id_Module
            // 
            this.Id_Module.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Id_Module.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id_Module.Location = new System.Drawing.Point(117, 989);
            this.Id_Module.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Id_Module.Multiline = true;
            this.Id_Module.Name = "Id_Module";
            this.Id_Module.Size = new System.Drawing.Size(563, 63);
            this.Id_Module.TabIndex = 8;
            // 
            // Id_Salle
            // 
            this.Id_Salle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Id_Salle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id_Salle.Location = new System.Drawing.Point(976, 358);
            this.Id_Salle.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Id_Salle.Multiline = true;
            this.Id_Salle.Name = "Id_Salle";
            this.Id_Salle.Size = new System.Drawing.Size(534, 90);
            this.Id_Salle.TabIndex = 9;
            // 
            // CIN
            // 
            this.CIN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CIN.Location = new System.Drawing.Point(976, 656);
            this.CIN.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CIN.Multiline = true;
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(534, 82);
            this.CIN.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Location = new System.Drawing.Point(816, 358);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 694);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(663, 1156);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(393, 180);
            this.button1.TabIndex = 12;
            this.button1.Text = "AJOUTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Examen.Properties.Resources.round_close_black_24pt_1x;
            this.button2.Location = new System.Drawing.Point(1491, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 139);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AjoutCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1649, 1490);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CIN);
            this.Controls.Add(this.Id_Salle);
            this.Controls.Add(this.Id_Module);
            this.Controls.Add(this.NomCours);
            this.Controls.Add(this.Id_cours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "AjoutCours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AjoutCours";
            this.Load += new System.EventHandler(this.AjoutCours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Id_cours;
        private System.Windows.Forms.TextBox NomCours;
        private System.Windows.Forms.TextBox Id_Module;
        private System.Windows.Forms.TextBox Id_Salle;
        private System.Windows.Forms.TextBox CIN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
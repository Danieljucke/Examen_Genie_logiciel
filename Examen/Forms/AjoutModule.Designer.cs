
namespace Examen.Forms
{
    partial class AjoutModule
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Id_module = new System.Windows.Forms.TextBox();
            this.Moyenne = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Charge = new System.Windows.Forms.TextBox();
            this.Id_salle = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(537, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "AJOUT MODULE";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Examen.Properties.Resources.round_close_black_24pt_1x;
            this.button1.Location = new System.Drawing.Point(1496, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 145);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(588, 1063);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(372, 197);
            this.button2.TabIndex = 2;
            this.button2.Text = "AJOUTER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(109, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID MODULE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(109, 530);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOM MODULE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(109, 774);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "CHARGE HORAIRE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(933, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 46);
            this.label5.TabIndex = 6;
            this.label5.Text = "MOYENNE GENERALE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(933, 528);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 46);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID SALLE";
            // 
            // Id_module
            // 
            this.Id_module.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Id_module.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id_module.Location = new System.Drawing.Point(109, 358);
            this.Id_module.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Id_module.Name = "Id_module";
            this.Id_module.Size = new System.Drawing.Size(427, 40);
            this.Id_module.TabIndex = 8;
            // 
            // Moyenne
            // 
            this.Moyenne.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Moyenne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Moyenne.Location = new System.Drawing.Point(933, 358);
            this.Moyenne.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Moyenne.Name = "Moyenne";
            this.Moyenne.Size = new System.Drawing.Size(447, 40);
            this.Moyenne.TabIndex = 9;
            // 
            // Nom
            // 
            this.Nom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nom.Location = new System.Drawing.Point(109, 582);
            this.Nom.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(427, 40);
            this.Nom.TabIndex = 10;
            // 
            // Charge
            // 
            this.Charge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Charge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Charge.Location = new System.Drawing.Point(109, 823);
            this.Charge.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Charge.Name = "Charge";
            this.Charge.Size = new System.Drawing.Size(427, 40);
            this.Charge.TabIndex = 11;
            // 
            // Id_salle
            // 
            this.Id_salle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Id_salle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id_salle.Location = new System.Drawing.Point(933, 582);
            this.Id_salle.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Id_salle.Name = "Id_salle";
            this.Id_salle.Size = new System.Drawing.Size(447, 40);
            this.Id_salle.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Location = new System.Drawing.Point(726, 358);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 519);
            this.panel1.TabIndex = 13;
            // 
            // AjoutModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1632, 1339);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Id_salle);
            this.Controls.Add(this.Charge);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Moyenne);
            this.Controls.Add(this.Id_module);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "AjoutModule";
            this.Text = "AjoutModule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Id_module;
        private System.Windows.Forms.TextBox Moyenne;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Charge;
        private System.Windows.Forms.TextBox Id_salle;
        private System.Windows.Forms.Panel panel1;
    }
}
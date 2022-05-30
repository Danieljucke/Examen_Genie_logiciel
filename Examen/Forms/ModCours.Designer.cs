
namespace Examen.Forms
{
    partial class ModCours
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.id_module = new System.Windows.Forms.TextBox();
            this.Nom_Cours = new System.Windows.Forms.TextBox();
            this.labelmod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_salle = new System.Windows.Forms.TextBox();
            this.CIN = new System.Windows.Forms.TextBox();
            this.id_cours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 273);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(879, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 145);
            this.button3.TabIndex = 1;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODIFIER Cours";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1159);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 257);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(699, 104);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(316, 101);
            this.button2.TabIndex = 1;
            this.button2.Text = "MODIFIER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(29, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "CHERCHER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 273);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 886);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.id_module);
            this.panel3.Controls.Add(this.Nom_Cours);
            this.panel3.Controls.Add(this.labelmod);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.id_salle);
            this.panel3.Controls.Add(this.CIN);
            this.panel3.Controls.Add(this.id_cours);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 273);
            this.panel3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 543);
            this.panel3.TabIndex = 3;
            // 
            // id_module
            // 
            this.id_module.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.id_module.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_module.Location = new System.Drawing.Point(254, 449);
            this.id_module.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.id_module.Name = "id_module";
            this.id_module.Size = new System.Drawing.Size(583, 40);
            this.id_module.TabIndex = 8;
            // 
            // Nom_Cours
            // 
            this.Nom_Cours.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Nom_Cours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nom_Cours.Location = new System.Drawing.Point(254, 144);
            this.Nom_Cours.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Nom_Cours.Name = "Nom_Cours";
            this.Nom_Cours.Size = new System.Drawing.Size(583, 40);
            this.Nom_Cours.TabIndex = 4;
            // 
            // labelmod
            // 
            this.labelmod.AutoSize = true;
            this.labelmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelmod.Location = new System.Drawing.Point(24, 449);
            this.labelmod.Name = "labelmod";
            this.labelmod.Size = new System.Drawing.Size(176, 39);
            this.labelmod.TabIndex = 7;
            this.labelmod.Text = "Id Module";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "CIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id Salle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom Cours";
            // 
            // id_salle
            // 
            this.id_salle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.id_salle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_salle.Location = new System.Drawing.Point(254, 232);
            this.id_salle.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.id_salle.Name = "id_salle";
            this.id_salle.Size = new System.Drawing.Size(583, 40);
            this.id_salle.TabIndex = 3;
            // 
            // CIN
            // 
            this.CIN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CIN.Location = new System.Drawing.Point(254, 333);
            this.CIN.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(583, 40);
            this.CIN.TabIndex = 2;
            // 
            // id_cours
            // 
            this.id_cours.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.id_cours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_cours.Location = new System.Drawing.Point(254, 29);
            this.id_cours.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.id_cours.Name = "id_cours";
            this.id_cours.Size = new System.Drawing.Size(583, 40);
            this.id_cours.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Cours";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.DarkGray;
            this.button4.Location = new System.Drawing.Point(364, 104);
            this.button4.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(301, 101);
            this.button4.TabIndex = 2;
            this.button4.Text = "SELECTIONNER";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ModCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1044, 1416);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "ModCours";
            this.Text = "ModCours";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox id_cours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelmod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_salle;
        private System.Windows.Forms.TextBox CIN;
        private System.Windows.Forms.TextBox Nom_Cours;
        private System.Windows.Forms.TextBox id_module;
        private System.Windows.Forms.Button button4;
    }
}

namespace Examen
{
    partial class DatabaseConnexion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Server = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.Userid = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1617, 115);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1474, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 115);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Server
            // 
            this.Server.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Server.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Server.Location = new System.Drawing.Point(634, 429);
            this.Server.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(549, 40);
            this.Server.TabIndex = 1;
            // 
            // pwd
            // 
            this.pwd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwd.Location = new System.Drawing.Point(634, 735);
            this.pwd.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(549, 40);
            this.pwd.TabIndex = 2;
            this.pwd.UseSystemPasswordChar = true;
            // 
            // Userid
            // 
            this.Userid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Userid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Userid.Location = new System.Drawing.Point(634, 585);
            this.Userid.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Userid.Name = "Userid";
            this.Userid.Size = new System.Drawing.Size(549, 40);
            this.Userid.TabIndex = 3;
            // 
            // Nom
            // 
            this.Nom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nom.Location = new System.Drawing.Point(634, 951);
            this.Nom.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(549, 40);
            this.Nom.TabIndex = 4;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ConnectBtn.FlatAppearance.BorderSize = 0;
            this.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.ConnectBtn.Location = new System.Drawing.Point(634, 1164);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(364, 191);
            this.ConnectBtn.TabIndex = 5;
            this.ConnectBtn.Text = "Se connecter";
            this.ConnectBtn.UseVisualStyleBackColor = false;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 429);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom du serveur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(151, 588);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "Identifiant de l\'utilisateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(151, 738);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mot de passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(151, 951);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nom de la base de données";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(352, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(980, 72);
            this.label5.TabIndex = 10;
            this.label5.Text = "CONNEXION A UNE BASE DE DONNEES";
            // 
            // DatabaseConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1617, 1427);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Userid);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "DatabaseConnexion";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox Userid;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}



namespace Examen.Forms
{
    partial class DashboardEtudiant
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSalle = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.btnCours = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 39);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.pnlNav);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnSalle);
            this.panel2.Controls.Add(this.btnProf);
            this.panel2.Controls.Add(this.btnCours);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 604);
            this.panel2.TabIndex = 1;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(4, 165);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 115);
            this.pnlNav.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.Location = new System.Drawing.Point(0, 529);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(217, 75);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Déconnexion";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnSalle
            // 
            this.btnSalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalle.FlatAppearance.BorderSize = 0;
            this.btnSalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalle.Location = new System.Drawing.Point(0, 254);
            this.btnSalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalle.Name = "btnSalle";
            this.btnSalle.Size = new System.Drawing.Size(217, 75);
            this.btnSalle.TabIndex = 3;
            this.btnSalle.Text = "Salles";
            this.btnSalle.UseVisualStyleBackColor = true;
            this.btnSalle.Click += new System.EventHandler(this.btnSalle_Click);
            this.btnSalle.Leave += new System.EventHandler(this.btnSalle_Leave);
            // 
            // btnProf
            // 
            this.btnProf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProf.FlatAppearance.BorderSize = 0;
            this.btnProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProf.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProf.Location = new System.Drawing.Point(0, 179);
            this.btnProf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(217, 75);
            this.btnProf.TabIndex = 2;
            this.btnProf.Text = "Professeurs";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            this.btnProf.Leave += new System.EventHandler(this.btnProf_Leave);
            // 
            // btnCours
            // 
            this.btnCours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCours.FlatAppearance.BorderSize = 0;
            this.btnCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCours.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCours.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCours.Location = new System.Drawing.Point(0, 104);
            this.btnCours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCours.Name = "btnCours";
            this.btnCours.Size = new System.Drawing.Size(217, 75);
            this.btnCours.TabIndex = 1;
            this.btnCours.Text = "Cours";
            this.btnCours.UseVisualStyleBackColor = true;
            this.btnCours.Click += new System.EventHandler(this.btnCours_Click);
            this.btnCours.Leave += new System.EventHandler(this.btnCours_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 104);
            this.panel3.TabIndex = 0;
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.BackColor = System.Drawing.Color.White;
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(217, 39);
            this.ContainerPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(694, 604);
            this.ContainerPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Examen.Properties.Resources.round_account_circle_black_24pt_3x;
            this.pictureBox1.Location = new System.Drawing.Point(71, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DashboardEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(911, 643);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DashboardEtudiant";
            this.Text = "DashboardEtudiant";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSalle;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.Button btnCours;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

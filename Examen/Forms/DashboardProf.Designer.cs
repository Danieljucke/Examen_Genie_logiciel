
namespace Examen.Forms
{
    partial class DashboardProf
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCours = new System.Windows.Forms.Button();
            this.btnEtud = new System.Windows.Forms.Button();
            this.btnSalle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minBtn);
            this.panel1.Controls.Add(this.maxBtn);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 39);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.pnlNav);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnSalle);
            this.panel2.Controls.Add(this.btnEtud);
            this.panel2.Controls.Add(this.btnCours);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 604);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(217, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 604);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 104);
            this.panel4.TabIndex = 0;
            // 
            // btnCours
            // 
            this.btnCours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCours.FlatAppearance.BorderSize = 0;
            this.btnCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCours.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCours.Location = new System.Drawing.Point(0, 104);
            this.btnCours.Name = "btnCours";
            this.btnCours.Size = new System.Drawing.Size(217, 75);
            this.btnCours.TabIndex = 1;
            this.btnCours.Text = "Cours";
            this.btnCours.UseVisualStyleBackColor = true;
            this.btnCours.Click += new System.EventHandler(this.btnCours_Click);
            this.btnCours.Leave += new System.EventHandler(this.btnCours_Leave);
            // 
            // btnEtud
            // 
            this.btnEtud.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEtud.FlatAppearance.BorderSize = 0;
            this.btnEtud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtud.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEtud.Location = new System.Drawing.Point(0, 179);
            this.btnEtud.Name = "btnEtud";
            this.btnEtud.Size = new System.Drawing.Size(217, 75);
            this.btnEtud.TabIndex = 2;
            this.btnEtud.Text = "Etudiants";
            this.btnEtud.UseVisualStyleBackColor = true;
            this.btnEtud.Click += new System.EventHandler(this.btnEtud_Click);
            this.btnEtud.Leave += new System.EventHandler(this.btnEtud_Leave);
            // 
            // btnSalle
            // 
            this.btnSalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalle.FlatAppearance.BorderSize = 0;
            this.btnSalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalle.Location = new System.Drawing.Point(0, 254);
            this.btnSalle.Name = "btnSalle";
            this.btnSalle.Size = new System.Drawing.Size(217, 75);
            this.btnSalle.TabIndex = 3;
            this.btnSalle.Text = "Salles";
            this.btnSalle.UseVisualStyleBackColor = true;
            this.btnSalle.Click += new System.EventHandler(this.btnSalle_Click);
            this.btnSalle.Leave += new System.EventHandler(this.btnSalle_Leave);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(0, 529);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "Déconnexion";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Examen.Properties.Resources.round_account_circle_black_24pt_3x;
            this.pictureBox1.Location = new System.Drawing.Point(66, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Examen.Properties.Resources.round_close_black_24pt_1x;
            this.button5.Location = new System.Drawing.Point(864, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 39);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // maxBtn
            // 
            this.maxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxBtn.FlatAppearance.BorderSize = 0;
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Image = global::Examen.Properties.Resources.round_maximize_black_24pt_1x;
            this.maxBtn.Location = new System.Drawing.Point(817, 0);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(47, 39);
            this.maxBtn.TabIndex = 1;
            this.maxBtn.UseVisualStyleBackColor = true;
            this.maxBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // minBtn
            // 
            this.minBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Image = global::Examen.Properties.Resources.round_minimize_black_24pt_1x;
            this.minBtn.Location = new System.Drawing.Point(770, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(47, 39);
            this.minBtn.TabIndex = 2;
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(4, 165);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 115);
            this.pnlNav.TabIndex = 5;
            // 
            // DashboardProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(911, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardProf";
            this.Text = "DashboardProf";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCours;
        private System.Windows.Forms.Button btnEtud;
        private System.Windows.Forms.Button btnSalle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnlNav;
    }
}
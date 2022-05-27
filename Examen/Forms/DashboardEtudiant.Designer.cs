
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
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.SalleBtn = new System.Windows.Forms.Button();
            this.ProfBtn = new System.Windows.Forms.Button();
            this.CourseBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserBtn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.MaxBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 39);
            this.panel1.TabIndex = 0;
            // 
            // MinBtn
            // 
            this.MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Image = global::Examen.Properties.Resources.round_minimize_black_24pt_1x;
            this.MinBtn.Location = new System.Drawing.Point(685, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(42, 39);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Image = global::Examen.Properties.Resources.round_maximize_black_24pt_1x;
            this.MaxBtn.Location = new System.Drawing.Point(727, 0);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(42, 39);
            this.MaxBtn.TabIndex = 1;
            this.MaxBtn.UseVisualStyleBackColor = true;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = global::Examen.Properties.Resources.round_close_black_24pt_1x;
            this.CloseBtn.Location = new System.Drawing.Point(769, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(42, 39);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.CloseBtn.MouseHover += new System.EventHandler(this.CloseBtn_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.pnlNav);
            this.panel2.Controls.Add(this.LogOutBtn);
            this.panel2.Controls.Add(this.SalleBtn);
            this.panel2.Controls.Add(this.ProfBtn);
            this.panel2.Controls.Add(this.CourseBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 749);
            this.panel2.TabIndex = 1;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 145);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(7, 149);
            this.pnlNav.TabIndex = 5;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.ForeColor = System.Drawing.Color.LightGray;
            this.LogOutBtn.Location = new System.Drawing.Point(0, 677);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(200, 72);
            this.LogOutBtn.TabIndex = 4;
            this.LogOutBtn.Text = "Déconnexion";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            // 
            // SalleBtn
            // 
            this.SalleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalleBtn.FlatAppearance.BorderSize = 0;
            this.SalleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalleBtn.ForeColor = System.Drawing.Color.LightGray;
            this.SalleBtn.Location = new System.Drawing.Point(0, 248);
            this.SalleBtn.Name = "SalleBtn";
            this.SalleBtn.Size = new System.Drawing.Size(200, 74);
            this.SalleBtn.TabIndex = 3;
            this.SalleBtn.Text = "Salles";
            this.SalleBtn.UseVisualStyleBackColor = true;
            this.SalleBtn.Click += new System.EventHandler(this.SalleBtn_Click);
            this.SalleBtn.Leave += new System.EventHandler(this.SalleBtn_Leave);
            // 
            // ProfBtn
            // 
            this.ProfBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfBtn.FlatAppearance.BorderSize = 0;
            this.ProfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfBtn.ForeColor = System.Drawing.Color.LightGray;
            this.ProfBtn.Location = new System.Drawing.Point(0, 174);
            this.ProfBtn.Name = "ProfBtn";
            this.ProfBtn.Size = new System.Drawing.Size(200, 74);
            this.ProfBtn.TabIndex = 2;
            this.ProfBtn.Text = "Professeurs";
            this.ProfBtn.UseVisualStyleBackColor = true;
            this.ProfBtn.Click += new System.EventHandler(this.ProfBtn_Click);
            this.ProfBtn.Leave += new System.EventHandler(this.ProfBtn_Leave);
            // 
            // CourseBtn
            // 
            this.CourseBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CourseBtn.FlatAppearance.BorderSize = 0;
            this.CourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseBtn.ForeColor = System.Drawing.Color.LightGray;
            this.CourseBtn.Location = new System.Drawing.Point(0, 100);
            this.CourseBtn.Name = "CourseBtn";
            this.CourseBtn.Size = new System.Drawing.Size(200, 74);
            this.CourseBtn.TabIndex = 1;
            this.CourseBtn.Text = "Cours";
            this.CourseBtn.UseVisualStyleBackColor = true;
            this.CourseBtn.Click += new System.EventHandler(this.CourseBtn_Click);
            this.CourseBtn.Leave += new System.EventHandler(this.CourseBtn_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UserBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // UserBtn
            // 
            this.UserBtn.FlatAppearance.BorderSize = 0;
            this.UserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBtn.Image = global::Examen.Properties.Resources.round_account_circle_black_24pt_3x;
            this.UserBtn.Location = new System.Drawing.Point(48, 6);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(93, 88);
            this.UserBtn.TabIndex = 0;
            this.UserBtn.UseVisualStyleBackColor = true;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(200, 39);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(611, 749);
            this.MainPanel.TabIndex = 2;
            // 
            // DashboardEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(811, 788);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardEtudiant";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button SalleBtn;
        private System.Windows.Forms.Button ProfBtn;
        private System.Windows.Forms.Button CourseBtn;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button UserBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}
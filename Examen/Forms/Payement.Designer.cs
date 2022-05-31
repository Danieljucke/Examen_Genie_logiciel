
namespace Examen.Forms
{
    partial class Payement
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CNE = new System.Windows.Forms.TextBox();
            this.Montant = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 158);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(62, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 50);
            this.label4.TabIndex = 1;
            this.label4.Text = "PAYEMENT FRAIS";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Examen.Properties.Resources.round_close_black_24pt_1x;
            this.button1.Location = new System.Drawing.Point(999, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 115);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 726);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1198, 215);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(410, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 143);
            this.button2.TabIndex = 0;
            this.button2.Text = "PAYER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "CNE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "MONTANT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "TYPE";
            // 
            // CNE
            // 
            this.CNE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CNE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CNE.Location = new System.Drawing.Point(410, 333);
            this.CNE.Name = "CNE";
            this.CNE.Size = new System.Drawing.Size(398, 40);
            this.CNE.TabIndex = 5;
            // 
            // Montant
            // 
            this.Montant.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Montant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Montant.Location = new System.Drawing.Point(410, 497);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(398, 40);
            this.Montant.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chèque",
            "Cash"});
            this.comboBox1.Location = new System.Drawing.Point(410, 616);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(398, 49);
            this.comboBox1.TabIndex = 7;
            // 
            // Payement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1198, 941);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.CNE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CNE;
        private System.Windows.Forms.TextBox Montant;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}
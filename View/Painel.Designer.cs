namespace Cadastrosdeclientes.View
{
    partial class Painel
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
            this.painelLateral = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.painelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelLateral
            // 
            this.painelLateral.BackColor = System.Drawing.Color.NavajoWhite;
            this.painelLateral.Controls.Add(this.button2);
            this.painelLateral.Controls.Add(this.button1);
            this.painelLateral.Controls.Add(this.Logo);
            this.painelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelLateral.Location = new System.Drawing.Point(0, 0);
            this.painelLateral.Name = "painelLateral";
            this.painelLateral.Size = new System.Drawing.Size(210, 575);
            this.painelLateral.TabIndex = 0;
            this.painelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(210, 79);
            this.Logo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Residentes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cuidador";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 575);
            this.Controls.Add(this.painelLateral);
            this.Name = "Painel";
            this.Text = "Painel";
            this.painelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelLateral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Button button2;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCuidador = new System.Windows.Forms.Button();
            this.btnIdoso = new System.Windows.Forms.Button();
            this.pbImagem2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(217, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "© 2024, Casa do Idoso Viva Bem";
            // 
            // btnCuidador
            // 
            this.btnCuidador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCuidador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuidador.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuidador.ForeColor = System.Drawing.Color.White;
            this.btnCuidador.Image = ((System.Drawing.Image)(resources.GetObject("btnCuidador.Image")));
            this.btnCuidador.Location = new System.Drawing.Point(249, 199);
            this.btnCuidador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCuidador.Name = "btnCuidador";
            this.btnCuidador.Size = new System.Drawing.Size(169, 155);
            this.btnCuidador.TabIndex = 10;
            this.btnCuidador.Text = "CUIDADOR";
            this.btnCuidador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCuidador.UseVisualStyleBackColor = false;
            this.btnCuidador.Click += new System.EventHandler(this.btnCuidador_Click);
            // 
            // btnIdoso
            // 
            this.btnIdoso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIdoso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdoso.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdoso.ForeColor = System.Drawing.Color.White;
            this.btnIdoso.Image = ((System.Drawing.Image)(resources.GetObject("btnIdoso.Image")));
            this.btnIdoso.Location = new System.Drawing.Point(53, 199);
            this.btnIdoso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIdoso.Name = "btnIdoso";
            this.btnIdoso.Size = new System.Drawing.Size(169, 155);
            this.btnIdoso.TabIndex = 10;
            this.btnIdoso.Text = "IDOSO";
            this.btnIdoso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIdoso.UseVisualStyleBackColor = false;
            this.btnIdoso.Click += new System.EventHandler(this.btnIdoso_Click);
            // 
            // pbImagem2
            // 
            this.pbImagem2.Image = ((System.Drawing.Image)(resources.GetObject("pbImagem2.Image")));
            this.pbImagem2.Location = new System.Drawing.Point(103, -23);
            this.pbImagem2.Name = "pbImagem2";
            this.pbImagem2.Size = new System.Drawing.Size(267, 251);
            this.pbImagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagem2.TabIndex = 13;
            this.pbImagem2.TabStop = false;
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCuidador);
            this.Controls.Add(this.btnIdoso);
            this.Controls.Add(this.pbImagem2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Painel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIdoso;
        private System.Windows.Forms.Button btnCuidador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImagem2;
    }
}
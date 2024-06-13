namespace Cadastrosdeclientes.View
{
    partial class CadCuidador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCuidador));
            this.txbBuscarCpf = new System.Windows.Forms.MaskedTextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblBuscaCpf = new System.Windows.Forms.Label();
            this.txbBuscarNome = new System.Windows.Forms.TextBox();
            this.lblBuscaNome = new System.Windows.Forms.Label();
            this.lblBuscaId = new System.Windows.Forms.Label();
            this.gvCuidador = new System.Windows.Forms.DataGridView();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txbData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCuidador = new System.Windows.Forms.CheckBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuidador)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbBuscarCpf
            // 
            this.txbBuscarCpf.BackColor = System.Drawing.Color.Gainsboro;
            this.txbBuscarCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarCpf.Location = new System.Drawing.Point(466, 338);
            this.txbBuscarCpf.Mask = "000,000,000-00";
            this.txbBuscarCpf.Name = "txbBuscarCpf";
            this.txbBuscarCpf.Size = new System.Drawing.Size(155, 30);
            this.txbBuscarCpf.TabIndex = 7;
            // 
            // txbId
            // 
            this.txbId.BackColor = System.Drawing.Color.Gainsboro;
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(18, 338);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(70, 30);
            this.txbId.TabIndex = 5;
            // 
            // lblBuscaCpf
            // 
            this.lblBuscaCpf.AutoSize = true;
            this.lblBuscaCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscaCpf.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBuscaCpf.Location = new System.Drawing.Point(462, 313);
            this.lblBuscaCpf.Name = "lblBuscaCpf";
            this.lblBuscaCpf.Size = new System.Drawing.Size(43, 22);
            this.lblBuscaCpf.TabIndex = 57;
            this.lblBuscaCpf.Text = "CPF";
            // 
            // txbBuscarNome
            // 
            this.txbBuscarNome.BackColor = System.Drawing.Color.Gainsboro;
            this.txbBuscarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarNome.Location = new System.Drawing.Point(94, 338);
            this.txbBuscarNome.Name = "txbBuscarNome";
            this.txbBuscarNome.Size = new System.Drawing.Size(370, 30);
            this.txbBuscarNome.TabIndex = 6;
            // 
            // lblBuscaNome
            // 
            this.lblBuscaNome.AutoSize = true;
            this.lblBuscaNome.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscaNome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBuscaNome.Location = new System.Drawing.Point(90, 313);
            this.lblBuscaNome.Name = "lblBuscaNome";
            this.lblBuscaNome.Size = new System.Drawing.Size(64, 22);
            this.lblBuscaNome.TabIndex = 58;
            this.lblBuscaNome.Text = "Nome";
            // 
            // lblBuscaId
            // 
            this.lblBuscaId.AutoSize = true;
            this.lblBuscaId.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscaId.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBuscaId.Location = new System.Drawing.Point(44, 313);
            this.lblBuscaId.Name = "lblBuscaId";
            this.lblBuscaId.Size = new System.Drawing.Size(27, 22);
            this.lblBuscaId.TabIndex = 59;
            this.lblBuscaId.Text = "Id";
            // 
            // gvCuidador
            // 
            this.gvCuidador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCuidador.Location = new System.Drawing.Point(14, 430);
            this.gvCuidador.Name = "gvCuidador";
            this.gvCuidador.RowHeadersWidth = 51;
            this.gvCuidador.RowTemplate.Height = 24;
            this.gvCuidador.Size = new System.Drawing.Size(752, 261);
            this.gvCuidador.TabIndex = 56;
            // 
            // txbTelefone
            // 
            this.txbTelefone.BackColor = System.Drawing.Color.Gainsboro;
            this.txbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone.Location = new System.Drawing.Point(22, 256);
            this.txbTelefone.Mask = "(00) 00000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(365, 30);
            this.txbTelefone.TabIndex = 4;
            // 
            // txbCpf
            // 
            this.txbCpf.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpf.Location = new System.Drawing.Point(18, 175);
            this.txbCpf.Mask = "000,000,000-00";
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(369, 30);
            this.txbCpf.TabIndex = 1;
            // 
            // txbData
            // 
            this.txbData.BackColor = System.Drawing.Color.Gainsboro;
            this.txbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbData.Location = new System.Drawing.Point(418, 175);
            this.txbData.Mask = "00/00/0000";
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(334, 30);
            this.txbData.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblData.Location = new System.Drawing.Point(414, 150);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(192, 22);
            this.lblData.TabIndex = 44;
            this.lblData.Text = "Data de Nascimento";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.Gainsboro;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(18, 102);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(734, 30);
            this.txbNome.TabIndex = 0;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTelefone.Location = new System.Drawing.Point(18, 231);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(86, 22);
            this.lblTelefone.TabIndex = 41;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCpf.Location = new System.Drawing.Point(14, 150);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(43, 22);
            this.lblCpf.TabIndex = 45;
            this.lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(14, 77);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 22);
            this.lblNome.TabIndex = 40;
            this.lblNome.Text = "Nome";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(189, 376);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(123, 46);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(14, 376);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(173, 46);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Location = new System.Drawing.Point(318, 376);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(131, 46);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(455, 77);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 45);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMatricula.Location = new System.Drawing.Point(417, 231);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(92, 22);
            this.lblMatricula.TabIndex = 59;
            this.lblMatricula.Text = "Matricula";
            // 
            // txbMatricula
            // 
            this.txbMatricula.BackColor = System.Drawing.Color.Gainsboro;
            this.txbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatricula.Location = new System.Drawing.Point(418, 256);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(334, 30);
            this.txbMatricula.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(0, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 427);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // chkCuidador
            // 
            this.chkCuidador.AutoSize = true;
            this.chkCuidador.Checked = true;
            this.chkCuidador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCuidador.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.chkCuidador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkCuidador.Location = new System.Drawing.Point(15, 38);
            this.chkCuidador.Name = "chkCuidador";
            this.chkCuidador.Size = new System.Drawing.Size(115, 26);
            this.chkCuidador.TabIndex = 62;
            this.chkCuidador.Text = "Cuidador";
            this.chkCuidador.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTipo.Location = new System.Drawing.Point(10, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(46, 22);
            this.lblTipo.TabIndex = 61;
            this.lblTipo.Text = "Tipo";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(14, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 65);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            // 
            // CadCuidador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 703);
            this.Controls.Add(this.chkCuidador);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txbBuscarCpf);
            this.Controls.Add(this.txbMatricula);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblBuscaCpf);
            this.Controls.Add(this.txbBuscarNome);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblBuscaNome);
            this.Controls.Add(this.lblBuscaId);
            this.Controls.Add(this.gvCuidador);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "CadCuidador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cuidador";
            ((System.ComponentModel.ISupportInitialize)(this.gvCuidador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txbBuscarCpf;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblBuscaCpf;
        private System.Windows.Forms.TextBox txbBuscarNome;
        private System.Windows.Forms.Label lblBuscaNome;
        private System.Windows.Forms.Label lblBuscaId;
        private System.Windows.Forms.DataGridView gvCuidador;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.MaskedTextBox txbCpf;
        private System.Windows.Forms.MaskedTextBox txbData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCuidador;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
namespace Cadastrosdeclientes.View
{
    partial class CadIdoso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadIdoso));
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.gvIdoso = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txbBuscarCpf = new System.Windows.Forms.MaskedTextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblBuscarCpf = new System.Windows.Forms.Label();
            this.txbBuscarNome = new System.Windows.Forms.TextBox();
            this.lblBuscarNome = new System.Windows.Forms.Label();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gr = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.MaskedTextBox();
            this.chkIdoso = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvIdoso)).BeginInit();
            this.gr.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(11, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 22);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.Gainsboro;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(15, 101);
            this.txbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(752, 30);
            this.txbNome.TabIndex = 0;
            // 
            // txbDataEntrada
            // 
            this.txbDataEntrada.BackColor = System.Drawing.Color.Gainsboro;
            this.txbDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDataEntrada.Location = new System.Drawing.Point(399, 263);
            this.txbDataEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDataEntrada.Mask = "00/00/0000";
            this.txbDataEntrada.Name = "txbDataEntrada";
            this.txbDataEntrada.Size = new System.Drawing.Size(281, 30);
            this.txbDataEntrada.TabIndex = 5;
            // 
            // txbCpf
            // 
            this.txbCpf.BackColor = System.Drawing.Color.Gainsboro;
            this.txbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpf.Location = new System.Drawing.Point(13, 174);
            this.txbCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCpf.Mask = "000,000,000-00";
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(369, 30);
            this.txbCpf.TabIndex = 1;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblDataEntrada.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblDataEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDataEntrada.Location = new System.Drawing.Point(395, 239);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(153, 22);
            this.lblDataEntrada.TabIndex = 6;
            this.lblDataEntrada.Text = "Data de Entrada";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCpf.Location = new System.Drawing.Point(11, 149);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(43, 22);
            this.lblCpf.TabIndex = 6;
            this.lblCpf.Text = "CPF";
            // 
            // txbTelefone
            // 
            this.txbTelefone.BackColor = System.Drawing.Color.Gainsboro;
            this.txbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone.Location = new System.Drawing.Point(399, 174);
            this.txbTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTelefone.Mask = "(00) 00000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(364, 30);
            this.txbTelefone.TabIndex = 2;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTelefone.Location = new System.Drawing.Point(405, 149);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(86, 22);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblData.Location = new System.Drawing.Point(13, 239);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(192, 22);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data de Nascimento";
            // 
            // gvIdoso
            // 
            this.gvIdoso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIdoso.Location = new System.Drawing.Point(13, 140);
            this.gvIdoso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvIdoso.Name = "gvIdoso";
            this.gvIdoso.RowHeadersWidth = 51;
            this.gvIdoso.RowTemplate.Height = 24;
            this.gvIdoso.Size = new System.Drawing.Size(752, 261);
            this.gvIdoso.TabIndex = 11;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Location = new System.Drawing.Point(352, 390);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(141, 46);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txbBuscarCpf
            // 
            this.txbBuscarCpf.BackColor = System.Drawing.Color.Gainsboro;
            this.txbBuscarCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarCpf.Location = new System.Drawing.Point(496, 34);
            this.txbBuscarCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbBuscarCpf.Mask = "000,000,000-00";
            this.txbBuscarCpf.Name = "txbBuscarCpf";
            this.txbBuscarCpf.Size = new System.Drawing.Size(155, 30);
            this.txbBuscarCpf.TabIndex = 8;
            // 
            // txbId
            // 
            this.txbId.BackColor = System.Drawing.Color.Gainsboro;
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(15, 348);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(71, 30);
            this.txbId.TabIndex = 6;
            // 
            // lblBuscarCpf
            // 
            this.lblBuscarCpf.AutoSize = true;
            this.lblBuscarCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarCpf.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBuscarCpf.Location = new System.Drawing.Point(489, 10);
            this.lblBuscarCpf.Name = "lblBuscarCpf";
            this.lblBuscarCpf.Size = new System.Drawing.Size(43, 22);
            this.lblBuscarCpf.TabIndex = 34;
            this.lblBuscarCpf.Text = "CPF";
            // 
            // txbBuscarNome
            // 
            this.txbBuscarNome.BackColor = System.Drawing.Color.Gainsboro;
            this.txbBuscarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarNome.Location = new System.Drawing.Point(109, 34);
            this.txbBuscarNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbBuscarNome.Name = "txbBuscarNome";
            this.txbBuscarNome.Size = new System.Drawing.Size(367, 30);
            this.txbBuscarNome.TabIndex = 7;
            // 
            // lblBuscarNome
            // 
            this.lblBuscarNome.AutoSize = true;
            this.lblBuscarNome.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarNome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBuscarNome.Location = new System.Drawing.Point(105, 10);
            this.lblBuscarNome.Name = "lblBuscarNome";
            this.lblBuscarNome.Size = new System.Drawing.Size(64, 22);
            this.lblBuscarNome.TabIndex = 35;
            this.lblBuscarNome.Text = "Nome";
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarId.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBuscarId.Location = new System.Drawing.Point(37, 322);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(27, 22);
            this.lblBuscarId.TabIndex = 36;
            this.lblBuscarId.Text = "Id";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(501, 78);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 46);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(13, 390);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(169, 46);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(189, 390);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 46);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gr
            // 
            this.gr.Controls.Add(this.lblBuscarCpf);
            this.gr.Controls.Add(this.gvIdoso);
            this.gr.Controls.Add(this.txbBuscarNome);
            this.gr.Controls.Add(this.txbBuscarCpf);
            this.gr.Controls.Add(this.lblBuscarNome);
            this.gr.Controls.Add(this.btnBuscar);
            this.gr.Location = new System.Drawing.Point(-1, 313);
            this.gr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr.Name = "gr";
            this.gr.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr.Size = new System.Drawing.Size(784, 434);
            this.gr.TabIndex = 37;
            this.gr.TabStop = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTipo.Location = new System.Drawing.Point(12, 6);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(46, 22);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            // 
            // txbData
            // 
            this.txbData.BackColor = System.Drawing.Color.Gainsboro;
            this.txbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbData.Location = new System.Drawing.Point(13, 263);
            this.txbData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbData.Mask = "00/00/0000";
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(245, 30);
            this.txbData.TabIndex = 3;
            // 
            // chkIdoso
            // 
            this.chkIdoso.AutoSize = true;
            this.chkIdoso.Checked = true;
            this.chkIdoso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIdoso.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.chkIdoso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkIdoso.Location = new System.Drawing.Point(17, 35);
            this.chkIdoso.Name = "chkIdoso";
            this.chkIdoso.Size = new System.Drawing.Size(81, 26);
            this.chkIdoso.TabIndex = 38;
            this.chkIdoso.Text = "Idoso";
            this.chkIdoso.UseVisualStyleBackColor = true;
            // 
            // CadIdoso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 726);
            this.Controls.Add(this.chkIdoso);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblBuscarId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.txbDataEntrada);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.gr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CadIdoso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Idoso";
            ((System.ComponentModel.ISupportInitialize)(this.gvIdoso)).EndInit();
            this.gr.ResumeLayout(false);
            this.gr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.MaskedTextBox txbDataEntrada;
        private System.Windows.Forms.MaskedTextBox txbCpf;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridView gvIdoso;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox txbBuscarCpf;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblBuscarCpf;
        private System.Windows.Forms.TextBox txbBuscarNome;
        private System.Windows.Forms.Label lblBuscarNome;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gr;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.MaskedTextBox txbData;
        private System.Windows.Forms.CheckBox chkIdoso;
    }
}
namespace ProjetoORM
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tableClientes = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.TxtHorario = new System.Windows.Forms.TextBox();
            this.clienteModelo = new System.Windows.Forms.TextBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableClientes
            // 
            this.tableClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Horário,
            this.modelo,
            this.Placa});
            this.tableClientes.Location = new System.Drawing.Point(175, 155);
            this.tableClientes.Name = "tableClientes";
            this.tableClientes.Size = new System.Drawing.Size(442, 189);
            this.tableClientes.TabIndex = 1;
            this.tableClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableClientes_CellContentClick);
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Horário
            // 
            this.Horário.HeaderText = "Horário";
            this.Horário.Name = "Horário";
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "Modelo";
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa do veiculo";
            this.Placa.Name = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Placa do \r\nveiculo";
            // 
            // TxtData
            // 
            this.TxtData.Location = new System.Drawing.Point(69, 74);
            this.TxtData.Multiline = true;
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(100, 20);
            this.TxtData.TabIndex = 5;
            this.TxtData.TextChanged += new System.EventHandler(this.clienteId_TextChanged);
            // 
            // TxtHorario
            // 
            this.TxtHorario.Location = new System.Drawing.Point(69, 137);
            this.TxtHorario.Name = "TxtHorario";
            this.TxtHorario.Size = new System.Drawing.Size(100, 20);
            this.TxtHorario.TabIndex = 6;
            this.TxtHorario.TextChanged += new System.EventHandler(this.nomeCliente_TextChanged);
            // 
            // clienteModelo
            // 
            this.clienteModelo.Location = new System.Drawing.Point(298, 26);
            this.clienteModelo.Name = "clienteModelo";
            this.clienteModelo.Size = new System.Drawing.Size(100, 20);
            this.clienteModelo.TabIndex = 7;
            this.clienteModelo.TextChanged += new System.EventHandler(this.clienteCPF_TextChanged);
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(320, 77);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(100, 20);
            this.TxtPlaca.TabIndex = 8;
            this.TxtPlaca.TextChanged += new System.EventHandler(this.clienteTelefone_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(196, 362);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 56);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(345, 362);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 56);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(497, 362);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 56);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.clienteModelo);
            this.Controls.Add(this.TxtHorario);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableClientes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.TextBox TxtHorario;
        private System.Windows.Forms.TextBox clienteModelo;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horário;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
    }
}


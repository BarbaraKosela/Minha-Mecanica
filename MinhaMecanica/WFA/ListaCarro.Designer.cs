namespace WFA
{
    partial class ListaCarro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLista = new System.Windows.Forms.TabPage();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageLista.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnMarca,
            this.ColumnAno,
            this.ColumnValor});
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(585, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnMarca.HeaderText = "Marca";
            this.ColumnMarca.Name = "ColumnMarca";
            this.ColumnMarca.ReadOnly = true;
            // 
            // ColumnAno
            // 
            this.ColumnAno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAno.HeaderText = "Ano de fabricação";
            this.ColumnAno.Name = "ColumnAno";
            this.ColumnAno.ReadOnly = true;
            // 
            // ColumnValor
            // 
            this.ColumnValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnValor.HeaderText = "Valor";
            this.ColumnValor.Name = "ColumnValor";
            this.ColumnValor.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Square721 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(398, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADICIONAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLista);
            this.tabControl1.Controls.Add(this.tabPageCadastro);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 345);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageLista
            // 
            this.tabPageLista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPageLista.Controls.Add(this.btnApagar);
            this.tabPageLista.Controls.Add(this.btnEditar);
            this.tabPageLista.Controls.Add(this.dataGridView1);
            this.tabPageLista.Controls.Add(this.button1);
            this.tabPageLista.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageLista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageLista.Location = new System.Drawing.Point(4, 22);
            this.tabPageLista.Name = "tabPageLista";
            this.tabPageLista.Size = new System.Drawing.Size(577, 319);
            this.tabPageLista.TabIndex = 0;
            this.tabPageLista.Text = "LISTA";
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPageCadastro.Controls.Add(this.btnCancelar);
            this.tabPageCadastro.Controls.Add(this.txtValor);
            this.tabPageCadastro.Controls.Add(this.txtAno);
            this.tabPageCadastro.Controls.Add(this.txtMarca);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Controls.Add(this.btnSalvar);
            this.tabPageCadastro.Controls.Add(this.label4);
            this.tabPageCadastro.Controls.Add(this.label3);
            this.tabPageCadastro.Controls.Add(this.label2);
            this.tabPageCadastro.Controls.Add(this.label1);
            this.tabPageCadastro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Size = new System.Drawing.Size(577, 319);
            this.tabPageCadastro.TabIndex = 1;
            this.tabPageCadastro.Text = "CADASTRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MARCA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ANO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "VALOR:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalvar.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Honeydew;
            this.btnSalvar.Location = new System.Drawing.Point(350, 232);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(211, 74);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Gray;
            this.txtNome.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNome.Location = new System.Drawing.Point(15, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(536, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.Gray;
            this.txtMarca.ForeColor = System.Drawing.SystemColors.Info;
            this.txtMarca.Location = new System.Drawing.Point(15, 82);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(536, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.Gray;
            this.txtAno.ForeColor = System.Drawing.SystemColors.Info;
            this.txtAno.Location = new System.Drawing.Point(15, 134);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(536, 20);
            this.txtAno.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Gray;
            this.txtValor.ForeColor = System.Drawing.SystemColors.Info;
            this.txtValor.Location = new System.Drawing.Point(15, 191);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(536, 20);
            this.txtValor.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancelar.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Honeydew;
            this.btnCancelar.Location = new System.Drawing.Point(133, 232);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(211, 74);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditar.Font = new System.Drawing.Font("Square721 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(199, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(166, 71);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnApagar.Font = new System.Drawing.Font("Square721 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApagar.Location = new System.Drawing.Point(10, 3);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(166, 71);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // ListaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(608, 375);
            this.Controls.Add(this.tabControl1);
            this.Name = "ListaCarro";
            this.Text = "Lista de carros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLista.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLista;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
    }
}


namespace TrabalhoKatia
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
            this.lbUnidade = new System.Windows.Forms.Label();
            this.lbQuarto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxUnidade = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiarias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFrigo = new System.Windows.Forms.TextBox();
            this.txtAtv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRestaurante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumQuarto = new System.Windows.Forms.TextBox();
            this.cbxQuadra = new System.Windows.Forms.ComboBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Costa";
            // 
            // lbUnidade
            // 
            this.lbUnidade.AutoSize = true;
            this.lbUnidade.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnidade.Location = new System.Drawing.Point(49, 156);
            this.lbUnidade.Name = "lbUnidade";
            this.lbUnidade.Size = new System.Drawing.Size(116, 33);
            this.lbUnidade.TabIndex = 1;
            this.lbUnidade.Text = "Unidade:";
            this.lbUnidade.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbQuarto
            // 
            this.lbQuarto.AutoSize = true;
            this.lbQuarto.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuarto.Location = new System.Drawing.Point(492, 157);
            this.lbQuarto.Name = "lbQuarto";
            this.lbQuarto.Size = new System.Drawing.Size(100, 33);
            this.lbQuarto.TabIndex = 2;
            this.lbQuarto.Text = "Quarto:";
            this.lbQuarto.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(911, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quadra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1310, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbxUnidade
            // 
            this.cbxUnidade.FormattingEnabled = true;
            this.cbxUnidade.Location = new System.Drawing.Point(171, 164);
            this.cbxUnidade.Name = "cbxUnidade";
            this.cbxUnidade.Size = new System.Drawing.Size(268, 24);
            this.cbxUnidade.TabIndex = 5;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(1390, 167);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(268, 24);
            this.cbxTipo.TabIndex = 8;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Diárias:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtDiarias
            // 
            this.txtDiarias.Location = new System.Drawing.Point(158, 282);
            this.txtDiarias.Multiline = true;
            this.txtDiarias.Name = "txtDiarias";
            this.txtDiarias.Size = new System.Drawing.Size(119, 44);
            this.txtDiarias.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor Diária:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(477, 282);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(92, 44);
            this.txtValor.TabIndex = 12;
            this.txtValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gasto Frigobar:";
            // 
            // txtFrigo
            // 
            this.txtFrigo.Location = new System.Drawing.Point(787, 282);
            this.txtFrigo.Multiline = true;
            this.txtFrigo.Name = "txtFrigo";
            this.txtFrigo.Size = new System.Drawing.Size(106, 56);
            this.txtFrigo.TabIndex = 14;
            // 
            // txtAtv
            // 
            this.txtAtv.Location = new System.Drawing.Point(1081, 282);
            this.txtAtv.Multiline = true;
            this.txtAtv.Name = "txtAtv";
            this.txtAtv.Size = new System.Drawing.Size(106, 56);
            this.txtAtv.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(934, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Atividades:";
            // 
            // txtRestaurante
            // 
            this.txtRestaurante.Location = new System.Drawing.Point(1406, 282);
            this.txtRestaurante.Multiline = true;
            this.txtRestaurante.Name = "txtRestaurante";
            this.txtRestaurante.Size = new System.Drawing.Size(106, 56);
            this.txtRestaurante.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1230, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 33);
            this.label8.TabIndex = 17;
            this.label8.Text = "Restaurante:";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(318, 509);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(186, 77);
            this.btnSalva.TabIndex = 19;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(589, 509);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(186, 77);
            this.btnPesquisa.TabIndex = 20;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 33);
            this.label9.TabIndex = 21;
            this.label9.Text = "Código da reserva:";
            // 
            // txtNumQuarto
            // 
            this.txtNumQuarto.Location = new System.Drawing.Point(598, 164);
            this.txtNumQuarto.Name = "txtNumQuarto";
            this.txtNumQuarto.Size = new System.Drawing.Size(234, 22);
            this.txtNumQuarto.TabIndex = 23;
            // 
            // cbxQuadra
            // 
            this.cbxQuadra.FormattingEnabled = true;
            this.cbxQuadra.Location = new System.Drawing.Point(1021, 164);
            this.cbxQuadra.Name = "cbxQuadra";
            this.cbxQuadra.Size = new System.Drawing.Size(268, 24);
            this.cbxQuadra.TabIndex = 7;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(277, 398);
            this.txtCPF.Multiline = true;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(119, 44);
            this.txtCPF.TabIndex = 24;
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(871, 509);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(186, 77);
            this.btnLimpa.TabIndex = 25;
            this.btnLimpa.Text = "Limpar Campos";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1142, 509);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(186, 77);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 717);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNumQuarto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtRestaurante);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAtv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFrigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiarias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxQuadra);
            this.Controls.Add(this.cbxUnidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbQuarto);
            this.Controls.Add(this.lbUnidade);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUnidade;
        private System.Windows.Forms.Label lbQuarto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxUnidade;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiarias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFrigo;
        private System.Windows.Forms.TextBox txtAtv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRestaurante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumQuarto;
        private System.Windows.Forms.ComboBox cbxQuadra;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnSair;
    }
}


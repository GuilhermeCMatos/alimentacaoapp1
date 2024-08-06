namespace alimentacaoapp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.b_calcular = new System.Windows.Forms.Button();
            this.b_novo = new System.Windows.Forms.Button();
            this.b_fechar = new System.Windows.Forms.Button();
            this.g_energia = new System.Windows.Forms.TextBox();
            this.g_agua = new System.Windows.Forms.TextBox();
            this.g_internet = new System.Windows.Forms.TextBox();
            this.g_outros = new System.Windows.Forms.TextBox();
            this.total_renda = new System.Windows.Forms.TextBox();
            this.g_total = new System.Windows.Forms.Label();
            this.saldo_f = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.g_alimentacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renda Familiar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gastos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Energia Elétrica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Água:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TV / Fone / Internet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Outros gastos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Totral dos Gastos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Saldo:";
            // 
            // b_calcular
            // 
            this.b_calcular.Location = new System.Drawing.Point(62, 335);
            this.b_calcular.Name = "b_calcular";
            this.b_calcular.Size = new System.Drawing.Size(88, 23);
            this.b_calcular.TabIndex = 9;
            this.b_calcular.Text = "Calcular";
            this.b_calcular.UseVisualStyleBackColor = true;
            this.b_calcular.Click += new System.EventHandler(this.b_calcular_Click);
            // 
            // b_novo
            // 
            this.b_novo.Location = new System.Drawing.Point(193, 335);
            this.b_novo.Name = "b_novo";
            this.b_novo.Size = new System.Drawing.Size(88, 23);
            this.b_novo.TabIndex = 10;
            this.b_novo.Text = "Novo Calculo";
            this.b_novo.UseVisualStyleBackColor = true;
            this.b_novo.Click += new System.EventHandler(this.b_novo_Click);
            // 
            // b_fechar
            // 
            this.b_fechar.Location = new System.Drawing.Point(320, 335);
            this.b_fechar.Name = "b_fechar";
            this.b_fechar.Size = new System.Drawing.Size(89, 23);
            this.b_fechar.TabIndex = 11;
            this.b_fechar.Text = "Fechar";
            this.b_fechar.UseVisualStyleBackColor = true;
            this.b_fechar.Click += new System.EventHandler(this.b_fechar_Click);
            // 
            // g_energia
            // 
            this.g_energia.Location = new System.Drawing.Point(183, 140);
            this.g_energia.Name = "g_energia";
            this.g_energia.Size = new System.Drawing.Size(226, 20);
            this.g_energia.TabIndex = 13;
            // 
            // g_agua
            // 
            this.g_agua.Location = new System.Drawing.Point(183, 171);
            this.g_agua.Name = "g_agua";
            this.g_agua.Size = new System.Drawing.Size(226, 20);
            this.g_agua.TabIndex = 14;
            // 
            // g_internet
            // 
            this.g_internet.Location = new System.Drawing.Point(183, 202);
            this.g_internet.Name = "g_internet";
            this.g_internet.Size = new System.Drawing.Size(226, 20);
            this.g_internet.TabIndex = 15;
            // 
            // g_outros
            // 
            this.g_outros.Location = new System.Drawing.Point(183, 260);
            this.g_outros.Name = "g_outros";
            this.g_outros.Size = new System.Drawing.Size(226, 20);
            this.g_outros.TabIndex = 16;
            // 
            // total_renda
            // 
            this.total_renda.Location = new System.Drawing.Point(183, 32);
            this.total_renda.Name = "total_renda";
            this.total_renda.Size = new System.Drawing.Size(226, 20);
            this.total_renda.TabIndex = 17;
            // 
            // g_total
            // 
            this.g_total.AutoSize = true;
            this.g_total.Location = new System.Drawing.Point(159, 436);
            this.g_total.Name = "g_total";
            this.g_total.Size = new System.Drawing.Size(0, 13);
            this.g_total.TabIndex = 18;
            // 
            // saldo_f
            // 
            this.saldo_f.AutoSize = true;
            this.saldo_f.Location = new System.Drawing.Point(159, 465);
            this.saldo_f.Name = "saldo_f";
            this.saldo_f.Size = new System.Drawing.Size(0, 13);
            this.saldo_f.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Alimentação";
            // 
            // g_alimentacao
            // 
            this.g_alimentacao.Location = new System.Drawing.Point(183, 231);
            this.g_alimentacao.Name = "g_alimentacao";
            this.g_alimentacao.Size = new System.Drawing.Size(226, 20);
            this.g_alimentacao.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 638);
            this.Controls.Add(this.g_alimentacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.saldo_f);
            this.Controls.Add(this.g_total);
            this.Controls.Add(this.total_renda);
            this.Controls.Add(this.g_outros);
            this.Controls.Add(this.g_internet);
            this.Controls.Add(this.g_agua);
            this.Controls.Add(this.g_energia);
            this.Controls.Add(this.b_fechar);
            this.Controls.Add(this.b_novo);
            this.Controls.Add(this.b_calcular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button b_calcular;
        private System.Windows.Forms.Button b_novo;
        private System.Windows.Forms.Button b_fechar;
        private System.Windows.Forms.TextBox g_agua;
        private System.Windows.Forms.TextBox g_internet;
        private System.Windows.Forms.TextBox g_outros;
        private System.Windows.Forms.TextBox total_renda;
        internal System.Windows.Forms.TextBox g_energia;
        private System.Windows.Forms.Label g_total;
        private System.Windows.Forms.Label saldo_f;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox g_alimentacao;
    }
}


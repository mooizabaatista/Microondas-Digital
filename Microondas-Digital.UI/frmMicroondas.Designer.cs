namespace Microondas_Digital.UI
{
    partial class fmMicroondas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer = new System.Windows.Forms.Timer(components);
            lblMensagemTempo = new Label();
            cboProgramasCustomizados = new ComboBox();
            cboProgramasPadrao = new ComboBox();
            lblProcessamento = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            lblIdentificador = new Label();
            txtIdentificador = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtInstrucoesPrograma = new TextBox();
            txtPotenciaPrograma = new TextBox();
            txtTempoPrograma = new TextBox();
            txtAlimentoPrograma = new TextBox();
            txtNomePrograma = new TextBox();
            panel2 = new Panel();
            btnGerenciarProgramas = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTempo = new Label();
            txtPotencia = new TextBox();
            txtTempo = new TextBox();
            btnLigarAcrescentarTempo = new Button();
            btnPausarCancelar = new Button();
            panel3 = new Panel();
            lblPot = new Label();
            lblPotencia = new Label();
            lblVisor = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            // 
            // timer
            // 
            timer.Interval = 1000;
            // 
            // lblMensagemTempo
            // 
            lblMensagemTempo.AutoSize = true;
            lblMensagemTempo.Location = new Point(111, 128);
            lblMensagemTempo.Name = "lblMensagemTempo";
            lblMensagemTempo.Size = new Size(0, 15);
            lblMensagemTempo.TabIndex = 0;
            // 
            // cboProgramasCustomizados
            // 
            cboProgramasCustomizados.FormattingEnabled = true;
            cboProgramasCustomizados.Location = new Point(3, 42);
            cboProgramasCustomizados.Name = "cboProgramasCustomizados";
            cboProgramasCustomizados.Size = new Size(228, 23);
            cboProgramasCustomizados.TabIndex = 1;
            cboProgramasCustomizados.SelectedIndexChanged += cboProgramasCustomizados_SelectedIndexChanged;
            // 
            // cboProgramasPadrao
            // 
            cboProgramasPadrao.FormattingEnabled = true;
            cboProgramasPadrao.Location = new Point(246, 42);
            cboProgramasPadrao.Name = "cboProgramasPadrao";
            cboProgramasPadrao.Size = new Size(227, 23);
            cboProgramasPadrao.TabIndex = 2;
            cboProgramasPadrao.SelectedIndexChanged += cboProgramasPadrao_SelectedIndexChanged;
            // 
            // lblProcessamento
            // 
            lblProcessamento.AutoSize = true;
            lblProcessamento.FlatStyle = FlatStyle.Flat;
            lblProcessamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProcessamento.Location = new Point(6, 85);
            lblProcessamento.MaximumSize = new Size(460, 0);
            lblProcessamento.Name = "lblProcessamento";
            lblProcessamento.Size = new Size(0, 25);
            lblProcessamento.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(69, 49, 225);
            label4.Location = new Point(21, 24);
            label4.Name = "label4";
            label4.Size = new Size(189, 15);
            label4.TabIndex = 4;
            label4.Text = "PROGRAMAS PERSONALIZADOS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(69, 49, 225);
            label5.Location = new Point(272, 24);
            label5.Name = "label5";
            label5.Size = new Size(174, 15);
            label5.TabIndex = 5;
            label5.Text = "PROGRAMAS PRÉ-DEFINIDOS";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblIdentificador);
            panel1.Controls.Add(txtIdentificador);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtInstrucoesPrograma);
            panel1.Controls.Add(txtPotenciaPrograma);
            panel1.Controls.Add(txtTempoPrograma);
            panel1.Controls.Add(txtAlimentoPrograma);
            panel1.Controls.Add(txtNomePrograma);
            panel1.Location = new Point(3, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 316);
            panel1.TabIndex = 6;
            // 
            // lblIdentificador
            // 
            lblIdentificador.AutoSize = true;
            lblIdentificador.ForeColor = Color.FromArgb(69, 49, 225);
            lblIdentificador.Location = new Point(53, 15);
            lblIdentificador.Name = "lblIdentificador";
            lblIdentificador.Size = new Size(74, 15);
            lblIdentificador.TabIndex = 11;
            lblIdentificador.Text = "Identificador";
            // 
            // txtIdentificador
            // 
            txtIdentificador.BackColor = Color.FromArgb(69, 49, 225);
            txtIdentificador.BorderStyle = BorderStyle.None;
            txtIdentificador.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdentificador.ForeColor = Color.White;
            txtIdentificador.Location = new Point(5, 10);
            txtIdentificador.Multiline = true;
            txtIdentificador.Name = "txtIdentificador";
            txtIdentificador.ReadOnly = true;
            txtIdentificador.Size = new Size(42, 35);
            txtIdentificador.TabIndex = 10;
            txtIdentificador.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(69, 49, 225);
            label10.Location = new Point(4, 156);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 9;
            label10.Text = "Instruções";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(69, 49, 225);
            label9.Location = new Point(263, 103);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 8;
            label9.Text = "Potência";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(69, 49, 225);
            label8.Location = new Point(4, 102);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 7;
            label8.Text = "Tempo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(69, 49, 225);
            label7.Location = new Point(263, 53);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 6;
            label7.Text = "Alimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(69, 49, 225);
            label6.Location = new Point(4, 53);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 5;
            label6.Text = "Nome do Programa";
            // 
            // txtInstrucoesPrograma
            // 
            txtInstrucoesPrograma.Enabled = false;
            txtInstrucoesPrograma.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtInstrucoesPrograma.Location = new Point(3, 174);
            txtInstrucoesPrograma.Multiline = true;
            txtInstrucoesPrograma.Name = "txtInstrucoesPrograma";
            txtInstrucoesPrograma.Size = new Size(462, 133);
            txtInstrucoesPrograma.TabIndex = 4;
            txtInstrucoesPrograma.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPotenciaPrograma
            // 
            txtPotenciaPrograma.Enabled = false;
            txtPotenciaPrograma.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtPotenciaPrograma.Location = new Point(263, 121);
            txtPotenciaPrograma.Name = "txtPotenciaPrograma";
            txtPotenciaPrograma.Size = new Size(202, 27);
            txtPotenciaPrograma.TabIndex = 3;
            txtPotenciaPrograma.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTempoPrograma
            // 
            txtTempoPrograma.Enabled = false;
            txtTempoPrograma.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtTempoPrograma.Location = new Point(3, 120);
            txtTempoPrograma.Name = "txtTempoPrograma";
            txtTempoPrograma.Size = new Size(222, 27);
            txtTempoPrograma.TabIndex = 2;
            txtTempoPrograma.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAlimentoPrograma
            // 
            txtAlimentoPrograma.Enabled = false;
            txtAlimentoPrograma.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtAlimentoPrograma.Location = new Point(263, 73);
            txtAlimentoPrograma.Name = "txtAlimentoPrograma";
            txtAlimentoPrograma.Size = new Size(202, 27);
            txtAlimentoPrograma.TabIndex = 1;
            txtAlimentoPrograma.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomePrograma
            // 
            txtNomePrograma.Enabled = false;
            txtNomePrograma.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtNomePrograma.Location = new Point(3, 71);
            txtNomePrograma.Name = "txtNomePrograma";
            txtNomePrograma.Size = new Size(222, 27);
            txtNomePrograma.TabIndex = 0;
            txtNomePrograma.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnGerenciarProgramas);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTempo);
            panel2.Controls.Add(txtPotencia);
            panel2.Controls.Add(txtTempo);
            panel2.Controls.Add(btnLigarAcrescentarTempo);
            panel2.Controls.Add(btnPausarCancelar);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(479, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 387);
            panel2.TabIndex = 0;
            // 
            // btnGerenciarProgramas
            // 
            btnGerenciarProgramas.BackColor = Color.FromArgb(69, 49, 225);
            btnGerenciarProgramas.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnGerenciarProgramas.FlatStyle = FlatStyle.Flat;
            btnGerenciarProgramas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerenciarProgramas.ForeColor = SystemColors.Control;
            btnGerenciarProgramas.Location = new Point(4, 329);
            btnGerenciarProgramas.Name = "btnGerenciarProgramas";
            btnGerenciarProgramas.Size = new Size(343, 53);
            btnGerenciarProgramas.TabIndex = 9;
            btnGerenciarProgramas.Text = "GERENCIAR PROGRAMAS";
            btnGerenciarProgramas.UseVisualStyleBackColor = false;
            btnGerenciarProgramas.Click += btnGerenciarProgramas_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(223, 23, 69);
            label3.Location = new Point(246, 180);
            label3.Name = "label3";
            label3.Size = new Size(37, 13);
            label3.TabIndex = 8;
            label3.Text = "1 à 10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(223, 23, 69);
            label2.Location = new Point(28, 180);
            label2.Name = "label2";
            label2.Size = new Size(100, 13);
            label2.TabIndex = 7;
            label2.Text = "Min (1) Max (120)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(69, 49, 225);
            label1.Location = new Point(236, 160);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 6;
            label1.Text = "Potência";
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTempo.ForeColor = Color.FromArgb(69, 49, 225);
            lblTempo.Location = new Point(8, 160);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(146, 17);
            lblTempo.TabIndex = 1;
            lblTempo.Text = "Tempo (Em segundos)";
            // 
            // txtPotencia
            // 
            txtPotencia.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPotencia.Location = new Point(183, 197);
            txtPotencia.Multiline = true;
            txtPotencia.Name = "txtPotencia";
            txtPotencia.Size = new Size(162, 39);
            txtPotencia.TabIndex = 5;
            txtPotencia.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTempo
            // 
            txtTempo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTempo.Location = new Point(4, 197);
            txtTempo.Multiline = true;
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(162, 39);
            txtTempo.TabIndex = 4;
            txtTempo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLigarAcrescentarTempo
            // 
            btnLigarAcrescentarTempo.BackColor = Color.SeaGreen;
            btnLigarAcrescentarTempo.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnLigarAcrescentarTempo.FlatStyle = FlatStyle.Flat;
            btnLigarAcrescentarTempo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLigarAcrescentarTempo.ForeColor = SystemColors.Control;
            btnLigarAcrescentarTempo.Location = new Point(182, 258);
            btnLigarAcrescentarTempo.Name = "btnLigarAcrescentarTempo";
            btnLigarAcrescentarTempo.Size = new Size(162, 53);
            btnLigarAcrescentarTempo.TabIndex = 3;
            btnLigarAcrescentarTempo.Text = "Ligar/+30S";
            btnLigarAcrescentarTempo.UseVisualStyleBackColor = false;
            btnLigarAcrescentarTempo.Click += btnLigarAcrescentarTempo_Click;
            // 
            // btnPausarCancelar
            // 
            btnPausarCancelar.BackColor = Color.FromArgb(223, 23, 69);
            btnPausarCancelar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnPausarCancelar.FlatStyle = FlatStyle.Flat;
            btnPausarCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPausarCancelar.ForeColor = SystemColors.Control;
            btnPausarCancelar.Location = new Point(3, 258);
            btnPausarCancelar.Name = "btnPausarCancelar";
            btnPausarCancelar.Size = new Size(162, 53);
            btnPausarCancelar.TabIndex = 2;
            btnPausarCancelar.Text = "Pausar/Cancelar";
            btnPausarCancelar.UseVisualStyleBackColor = false;
            btnPausarCancelar.Click += btnPausarCancelar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 30);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblPot);
            panel3.Controls.Add(lblPotencia);
            panel3.Controls.Add(lblVisor);
            panel3.Location = new Point(3, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(341, 129);
            panel3.TabIndex = 0;
            // 
            // lblPot
            // 
            lblPot.AutoSize = true;
            lblPot.Font = new Font("Calibri", 10.25F, FontStyle.Bold);
            lblPot.ForeColor = Color.Yellow;
            lblPot.Location = new Point(241, 7);
            lblPot.Name = "lblPot";
            lblPot.Size = new Size(0, 17);
            lblPot.TabIndex = 2;
            // 
            // lblPotencia
            // 
            lblPotencia.AllowDrop = true;
            lblPotencia.AutoSize = true;
            lblPotencia.Location = new Point(161, 15);
            lblPotencia.Name = "lblPotencia";
            lblPotencia.Size = new Size(0, 15);
            lblPotencia.TabIndex = 1;
            // 
            // lblVisor
            // 
            lblVisor.AutoSize = true;
            lblVisor.Font = new Font("Fira Code Retina", 30.75F, FontStyle.Bold);
            lblVisor.ForeColor = Color.SeaGreen;
            lblVisor.Location = new Point(104, 37);
            lblVisor.Name = "lblVisor";
            lblVisor.Size = new Size(152, 51);
            lblVisor.TabIndex = 0;
            lblVisor.Text = "00:00";
            lblVisor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InactiveCaption;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblProcessamento);
            panel4.Controls.Add(cboProgramasPadrao);
            panel4.Controls.Add(cboProgramasCustomizados);
            panel4.Controls.Add(lblMensagemTempo);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(835, 395);
            panel4.TabIndex = 1;
            // 
            // fmMicroondas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(835, 395);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "fmMicroondas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MICROONDAS DIGITAL";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblMensagem;
        private System.Windows.Forms.Timer timer;
        private Label lblMensagemTempo;
        private ComboBox cboProgramasCustomizados;
        private ComboBox cboProgramasPadrao;
        private Label lblProcessamento;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label lblIdentificador;
        private TextBox txtIdentificador;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtInstrucoesPrograma;
        private TextBox txtPotenciaPrograma;
        private TextBox txtTempoPrograma;
        private TextBox txtAlimentoPrograma;
        private TextBox txtNomePrograma;
        private Panel panel2;
        private Button btnGerenciarProgramas;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblTempo;
        private TextBox txtPotencia;
        private TextBox txtTempo;
        private Button btnLigarAcrescentarTempo;
        private Button btnPausarCancelar;
        private Panel panel3;
        private Label lblPot;
        private Label lblPotencia;
        private Label lblVisor;
        private Panel panel4;
    }
}

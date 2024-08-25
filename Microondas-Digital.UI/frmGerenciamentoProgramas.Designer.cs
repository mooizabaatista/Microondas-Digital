namespace Microondas_Digital.UI;

partial class frmGerenciamentoProgramas
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
        label1 = new Label();
        lstProgramas = new ListBox();
        label2 = new Label();
        label3 = new Label();
        txtAlimentoPrograma = new TextBox();
        label4 = new Label();
        txtTempoPrograma = new TextBox();
        txtNomePrograma = new TextBox();
        label6 = new Label();
        txtPotenciaPrograma = new TextBox();
        label5 = new Label();
        txtInstrucoesPrograma = new TextBox();
        btnSalvar = new Button();
        btnResetarCampos = new Button();
        btnExcluir = new Button();
        label7 = new Label();
        txtSimboloAquecimento = new TextBox();
        label8 = new Label();
        txtIdPrograma = new TextBox();
        label9 = new Label();
        label10 = new Label();
        label11 = new Label();
        label12 = new Label();
        label13 = new Label();
        label14 = new Label();
        label15 = new Label();
        panel1 = new Panel();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        label1.ForeColor = Color.FromArgb(69, 49, 225);
        label1.Location = new Point(74, 8);
        label1.Name = "label1";
        label1.Size = new Size(268, 17);
        label1.TabIndex = 0;
        label1.Text = "GERENCIAR PROGRAMAS CUSTOMIZADOS";
        // 
        // lstProgramas
        // 
        lstProgramas.FormattingEnabled = true;
        lstProgramas.ItemHeight = 15;
        lstProgramas.Location = new Point(12, 95);
        lstProgramas.Name = "lstProgramas";
        lstProgramas.Size = new Size(394, 79);
        lstProgramas.TabIndex = 1;
        lstProgramas.SelectedIndexChanged += lstProgramas_SelectedIndexChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
        label2.ForeColor = Color.FromArgb(69, 49, 225);
        label2.Location = new Point(222, 191);
        label2.Name = "label2";
        label2.Size = new Size(33, 12);
        label2.TabIndex = 3;
        label2.Text = "Nome";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
        label3.ForeColor = Color.FromArgb(69, 49, 225);
        label3.Location = new Point(15, 191);
        label3.Name = "label3";
        label3.Size = new Size(48, 12);
        label3.TabIndex = 5;
        label3.Text = "Alimento";
        // 
        // txtAlimentoPrograma
        // 
        txtAlimentoPrograma.Location = new Point(222, 206);
        txtAlimentoPrograma.Name = "txtAlimentoPrograma";
        txtAlimentoPrograma.Size = new Size(178, 23);
        txtAlimentoPrograma.TabIndex = 3;
        txtAlimentoPrograma.TextAlign = HorizontalAlignment.Center;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
        label4.ForeColor = Color.FromArgb(69, 49, 225);
        label4.Location = new Point(15, 239);
        label4.Name = "label4";
        label4.Size = new Size(36, 12);
        label4.TabIndex = 7;
        label4.Text = "Tempo";
        // 
        // txtTempoPrograma
        // 
        txtTempoPrograma.Location = new Point(15, 256);
        txtTempoPrograma.Name = "txtTempoPrograma";
        txtTempoPrograma.Size = new Size(52, 23);
        txtTempoPrograma.TabIndex = 4;
        txtTempoPrograma.TextAlign = HorizontalAlignment.Center;
        txtTempoPrograma.KeyPress += txtTempoPrograma_KeyPress;
        // 
        // txtNomePrograma
        // 
        txtNomePrograma.Location = new Point(15, 206);
        txtNomePrograma.Name = "txtNomePrograma";
        txtNomePrograma.Size = new Size(179, 23);
        txtNomePrograma.TabIndex = 2;
        txtNomePrograma.TextAlign = HorizontalAlignment.Center;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
        label6.ForeColor = Color.FromArgb(69, 49, 225);
        label6.Location = new Point(15, 292);
        label6.Name = "label6";
        label6.Size = new Size(45, 12);
        label6.TabIndex = 11;
        label6.Text = "Potência";
        // 
        // txtPotenciaPrograma
        // 
        txtPotenciaPrograma.Location = new Point(15, 308);
        txtPotenciaPrograma.Name = "txtPotenciaPrograma";
        txtPotenciaPrograma.Size = new Size(52, 23);
        txtPotenciaPrograma.TabIndex = 5;
        txtPotenciaPrograma.TextAlign = HorizontalAlignment.Center;
        txtPotenciaPrograma.KeyPress += txtPotenciaPrograma_KeyPress;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
        label5.ForeColor = Color.FromArgb(69, 49, 225);
        label5.Location = new Point(89, 242);
        label5.Name = "label5";
        label5.Size = new Size(52, 12);
        label5.TabIndex = 13;
        label5.Text = "Instruções";
        // 
        // txtInstrucoesPrograma
        // 
        txtInstrucoesPrograma.Location = new Point(86, 256);
        txtInstrucoesPrograma.Multiline = true;
        txtInstrucoesPrograma.Name = "txtInstrucoesPrograma";
        txtInstrucoesPrograma.Size = new Size(314, 127);
        txtInstrucoesPrograma.TabIndex = 7;
        txtInstrucoesPrograma.TextAlign = HorizontalAlignment.Center;
        // 
        // btnSalvar
        // 
        btnSalvar.BackColor = Color.SeaGreen;
        btnSalvar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
        btnSalvar.FlatStyle = FlatStyle.Flat;
        btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnSalvar.ForeColor = SystemColors.ControlLightLight;
        btnSalvar.Location = new Point(62, 405);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(83, 32);
        btnSalvar.TabIndex = 8;
        btnSalvar.Text = "Salvar";
        btnSalvar.UseVisualStyleBackColor = false;
        btnSalvar.Click += btnSalvar_Click;
        // 
        // btnResetarCampos
        // 
        btnResetarCampos.BackColor = Color.SteelBlue;
        btnResetarCampos.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
        btnResetarCampos.FlatStyle = FlatStyle.Flat;
        btnResetarCampos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnResetarCampos.ForeColor = SystemColors.ControlLightLight;
        btnResetarCampos.Location = new Point(151, 405);
        btnResetarCampos.Name = "btnResetarCampos";
        btnResetarCampos.Size = new Size(123, 32);
        btnResetarCampos.TabIndex = 9;
        btnResetarCampos.Text = "Resetar Campos";
        btnResetarCampos.UseVisualStyleBackColor = false;
        btnResetarCampos.Click += btnResetarCampos_Click;
        // 
        // btnExcluir
        // 
        btnExcluir.BackColor = Color.Brown;
        btnExcluir.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
        btnExcluir.FlatStyle = FlatStyle.Flat;
        btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnExcluir.ForeColor = SystemColors.ControlLightLight;
        btnExcluir.Location = new Point(280, 405);
        btnExcluir.Name = "btnExcluir";
        btnExcluir.Size = new Size(83, 32);
        btnExcluir.TabIndex = 10;
        btnExcluir.Text = "Excluir";
        btnExcluir.UseVisualStyleBackColor = false;
        btnExcluir.Click += btnExcluir_Click;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
        label7.ForeColor = Color.FromArgb(69, 49, 225);
        label7.Location = new Point(15, 345);
        label7.Name = "label7";
        label7.Size = new Size(44, 12);
        label7.TabIndex = 18;
        label7.Text = "Simbolo";
        // 
        // txtSimboloAquecimento
        // 
        txtSimboloAquecimento.Location = new Point(15, 360);
        txtSimboloAquecimento.MaxLength = 1;
        txtSimboloAquecimento.Name = "txtSimboloAquecimento";
        txtSimboloAquecimento.Size = new Size(52, 23);
        txtSimboloAquecimento.TabIndex = 6;
        txtSimboloAquecimento.TextAlign = HorizontalAlignment.Center;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label8.ForeColor = SystemColors.ControlLightLight;
        label8.Location = new Point(8, 5);
        label8.Name = "label8";
        label8.Size = new Size(310, 13);
        label8.TabIndex = 19;
        label8.Text = "Selecione um programa abaixo para edita-lo ou remove-lo";
        // 
        // txtIdPrograma
        // 
        txtIdPrograma.Location = new Point(-1, 2);
        txtIdPrograma.Name = "txtIdPrograma";
        txtIdPrograma.Size = new Size(24, 23);
        txtIdPrograma.TabIndex = 20;
        txtIdPrograma.Visible = false;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label9.ForeColor = Color.FromArgb(233, 23, 69);
        label9.Location = new Point(253, 188);
        label9.Name = "label9";
        label9.Size = new Size(13, 15);
        label9.TabIndex = 21;
        label9.Text = "*";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label10.ForeColor = Color.FromArgb(233, 23, 69);
        label10.Location = new Point(62, 188);
        label10.Name = "label10";
        label10.Size = new Size(13, 15);
        label10.TabIndex = 22;
        label10.Text = "*";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label11.ForeColor = Color.FromArgb(233, 23, 69);
        label11.Location = new Point(59, 240);
        label11.Name = "label11";
        label11.Size = new Size(13, 15);
        label11.TabIndex = 23;
        label11.Text = "*";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label12.ForeColor = Color.FromArgb(233, 23, 69);
        label12.Location = new Point(59, 289);
        label12.Name = "label12";
        label12.Size = new Size(13, 15);
        label12.TabIndex = 24;
        label12.Text = "*";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label13.ForeColor = Color.FromArgb(233, 23, 69);
        label13.Location = new Point(59, 343);
        label13.Name = "label13";
        label13.Size = new Size(13, 15);
        label13.TabIndex = 25;
        label13.Text = "*";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label14.ForeColor = SystemColors.ControlLightLight;
        label14.Location = new Point(23, 23);
        label14.Name = "label14";
        label14.Size = new Size(245, 13);
        label14.TabIndex = 26;
        label14.Text = "Os campos que possuem         são obrigatórios";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label15.ForeColor = Color.FromArgb(233, 23, 69);
        label15.Location = new Point(160, 23);
        label15.Name = "label15";
        label15.Size = new Size(13, 15);
        label15.TabIndex = 27;
        label15.Text = "*";
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(69, 49, 225);
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(label8);
        panel1.Controls.Add(label15);
        panel1.Controls.Add(label14);
        panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        panel1.Location = new Point(44, 36);
        panel1.Name = "panel1";
        panel1.Size = new Size(328, 46);
        panel1.TabIndex = 28;
        // 
        // frmGerenciamentoProgramas
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.InactiveCaption;
        ClientSize = new Size(419, 447);
        Controls.Add(panel1);
        Controls.Add(label13);
        Controls.Add(label12);
        Controls.Add(label11);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(txtIdPrograma);
        Controls.Add(label7);
        Controls.Add(txtSimboloAquecimento);
        Controls.Add(btnExcluir);
        Controls.Add(btnResetarCampos);
        Controls.Add(btnSalvar);
        Controls.Add(label5);
        Controls.Add(txtInstrucoesPrograma);
        Controls.Add(label6);
        Controls.Add(txtPotenciaPrograma);
        Controls.Add(txtNomePrograma);
        Controls.Add(label4);
        Controls.Add(txtTempoPrograma);
        Controls.Add(label3);
        Controls.Add(txtAlimentoPrograma);
        Controls.Add(label2);
        Controls.Add(lstProgramas);
        Controls.Add(label1);
        ForeColor = SystemColors.ControlText;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "frmGerenciamentoProgramas";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "GERENCIAR PROGRAMAS";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private ListBox lstProgramas;
    private Label label2;
    private Label label3;
    private TextBox txtAlimentoPrograma;
    private Label label4;
    private TextBox txtTempoPrograma;
    private TextBox txtNomePrograma;
    private Label label6;
    private TextBox txtPotenciaPrograma;
    private Label label5;
    private TextBox txtInstrucoesPrograma;
    private Button btnSalvar;
    private Button btnResetarCampos;
    private Button btnExcluir;
    private Label label7;
    private TextBox txtSimboloAquecimento;
    private Label label8;
    private TextBox txtIdPrograma;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label13;
    private Label label14;
    private Label label15;
    private Panel panel1;
}
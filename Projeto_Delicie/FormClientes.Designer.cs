
namespace Projeto_Delicie
{
    partial class FormClientes
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
            this.labelPedido = new System.Windows.Forms.Label();
            this.groupBoxBolos = new System.Windows.Forms.GroupBox();
            this.cb_BoloCenoura = new System.Windows.Forms.CheckBox();
            this.cb_BoloBanana = new System.Windows.Forms.CheckBox();
            this.cb_BoloFuba = new System.Windows.Forms.CheckBox();
            this.cb_BoloChocolate = new System.Windows.Forms.CheckBox();
            this.tb_QtdCenoura = new System.Windows.Forms.TextBox();
            this.tb_QtdBanana = new System.Windows.Forms.TextBox();
            this.tb_QtdFuba = new System.Windows.Forms.TextBox();
            this.tb_QtdChoco = new System.Windows.Forms.TextBox();
            this.labelQtd = new System.Windows.Forms.Label();
            this.btnVoltarLogin = new System.Windows.Forms.Button();
            this.groupBoxLanches = new System.Windows.Forms.GroupBox();
            this.cb_TortaFrango = new System.Windows.Forms.CheckBox();
            this.tb_QtdTorta = new System.Windows.Forms.TextBox();
            this.cb_PaodeQueijo = new System.Windows.Forms.CheckBox();
            this.cb_XDuplo = new System.Windows.Forms.CheckBox();
            this.cb_Atum = new System.Windows.Forms.CheckBox();
            this.cb_Frango = new System.Windows.Forms.CheckBox();
            this.tb_QtdPaodeQueijo = new System.Windows.Forms.TextBox();
            this.tb_QtdDuplo = new System.Windows.Forms.TextBox();
            this.tb_QtdLAtum = new System.Windows.Forms.TextBox();
            this.tb_QtdLFrango = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.groupBoxBebida = new System.Windows.Forms.GroupBox();
            this.cb_Cafe = new System.Windows.Forms.CheckBox();
            this.cb_Suco = new System.Windows.Forms.CheckBox();
            this.tb_ValorTotal = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb_credito = new System.Windows.Forms.RadioButton();
            this.Rb_debito = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.groupBoxBolos.SuspendLayout();
            this.groupBoxLanches.SuspendLayout();
            this.groupBoxBebida.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPedido
            // 
            this.labelPedido.AutoSize = true;
            this.labelPedido.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedido.Location = new System.Drawing.Point(334, 15);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(185, 29);
            this.labelPedido.TabIndex = 0;
            this.labelPedido.Text = "Faça seu Pedido";
            // 
            // groupBoxBolos
            // 
            this.groupBoxBolos.Controls.Add(this.cb_BoloCenoura);
            this.groupBoxBolos.Controls.Add(this.cb_BoloBanana);
            this.groupBoxBolos.Controls.Add(this.cb_BoloFuba);
            this.groupBoxBolos.Controls.Add(this.cb_BoloChocolate);
            this.groupBoxBolos.Controls.Add(this.tb_QtdCenoura);
            this.groupBoxBolos.Controls.Add(this.tb_QtdBanana);
            this.groupBoxBolos.Controls.Add(this.tb_QtdFuba);
            this.groupBoxBolos.Controls.Add(this.tb_QtdChoco);
            this.groupBoxBolos.Controls.Add(this.labelQtd);
            this.groupBoxBolos.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxBolos.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBolos.Location = new System.Drawing.Point(403, 116);
            this.groupBoxBolos.Name = "groupBoxBolos";
            this.groupBoxBolos.Size = new System.Drawing.Size(369, 188);
            this.groupBoxBolos.TabIndex = 1;
            this.groupBoxBolos.TabStop = false;
            this.groupBoxBolos.Text = "Bolos (pedaços)";
            // 
            // cb_BoloCenoura
            // 
            this.cb_BoloCenoura.AutoSize = true;
            this.cb_BoloCenoura.Location = new System.Drawing.Point(6, 153);
            this.cb_BoloCenoura.Name = "cb_BoloCenoura";
            this.cb_BoloCenoura.Size = new System.Drawing.Size(167, 27);
            this.cb_BoloCenoura.TabIndex = 17;
            this.cb_BoloCenoura.Text = "Bolo de Cenoura";
            this.cb_BoloCenoura.UseVisualStyleBackColor = true;
            this.cb_BoloCenoura.CheckedChanged += new System.EventHandler(this.cb_BoloCenoura_CheckedChanged);
            // 
            // cb_BoloBanana
            // 
            this.cb_BoloBanana.AutoSize = true;
            this.cb_BoloBanana.Location = new System.Drawing.Point(6, 117);
            this.cb_BoloBanana.Name = "cb_BoloBanana";
            this.cb_BoloBanana.Size = new System.Drawing.Size(160, 27);
            this.cb_BoloBanana.TabIndex = 16;
            this.cb_BoloBanana.Text = "Bolo de Banana";
            this.cb_BoloBanana.UseVisualStyleBackColor = true;
            this.cb_BoloBanana.CheckedChanged += new System.EventHandler(this.cb_BoloBanana_CheckedChanged);
            // 
            // cb_BoloFuba
            // 
            this.cb_BoloFuba.AutoSize = true;
            this.cb_BoloFuba.Location = new System.Drawing.Point(6, 81);
            this.cb_BoloFuba.Name = "cb_BoloFuba";
            this.cb_BoloFuba.Size = new System.Drawing.Size(139, 27);
            this.cb_BoloFuba.TabIndex = 15;
            this.cb_BoloFuba.Text = "Bolo de Fubá";
            this.cb_BoloFuba.UseVisualStyleBackColor = true;
            this.cb_BoloFuba.CheckedChanged += new System.EventHandler(this.cb_BoloFuba_CheckedChanged);
            // 
            // cb_BoloChocolate
            // 
            this.cb_BoloChocolate.AutoSize = true;
            this.cb_BoloChocolate.Location = new System.Drawing.Point(6, 45);
            this.cb_BoloChocolate.Name = "cb_BoloChocolate";
            this.cb_BoloChocolate.Size = new System.Drawing.Size(179, 27);
            this.cb_BoloChocolate.TabIndex = 14;
            this.cb_BoloChocolate.Text = "Bolo de Chocolate";
            this.cb_BoloChocolate.UseVisualStyleBackColor = true;
            this.cb_BoloChocolate.CheckedChanged += new System.EventHandler(this.cb_BoloChocolate_CheckedChanged);
            // 
            // tb_QtdCenoura
            // 
            this.tb_QtdCenoura.Location = new System.Drawing.Point(245, 153);
            this.tb_QtdCenoura.Name = "tb_QtdCenoura";
            this.tb_QtdCenoura.ReadOnly = true;
            this.tb_QtdCenoura.Size = new System.Drawing.Size(94, 29);
            this.tb_QtdCenoura.TabIndex = 11;
            // 
            // tb_QtdBanana
            // 
            this.tb_QtdBanana.Location = new System.Drawing.Point(245, 117);
            this.tb_QtdBanana.Name = "tb_QtdBanana";
            this.tb_QtdBanana.ReadOnly = true;
            this.tb_QtdBanana.Size = new System.Drawing.Size(94, 29);
            this.tb_QtdBanana.TabIndex = 10;
            // 
            // tb_QtdFuba
            // 
            this.tb_QtdFuba.Location = new System.Drawing.Point(245, 81);
            this.tb_QtdFuba.Name = "tb_QtdFuba";
            this.tb_QtdFuba.ReadOnly = true;
            this.tb_QtdFuba.Size = new System.Drawing.Size(94, 29);
            this.tb_QtdFuba.TabIndex = 9;
            // 
            // tb_QtdChoco
            // 
            this.tb_QtdChoco.Location = new System.Drawing.Point(245, 44);
            this.tb_QtdChoco.Name = "tb_QtdChoco";
            this.tb_QtdChoco.ReadOnly = true;
            this.tb_QtdChoco.Size = new System.Drawing.Size(94, 29);
            this.tb_QtdChoco.TabIndex = 8;
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtd.Location = new System.Drawing.Point(212, 25);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(151, 16);
            this.labelQtd.TabIndex = 2;
            this.labelQtd.Text = "Selecione a Quantidade";
            // 
            // btnVoltarLogin
            // 
            this.btnVoltarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.btnVoltarLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltarLogin.Location = new System.Drawing.Point(11, 12);
            this.btnVoltarLogin.Name = "btnVoltarLogin";
            this.btnVoltarLogin.Size = new System.Drawing.Size(100, 40);
            this.btnVoltarLogin.TabIndex = 8;
            this.btnVoltarLogin.Text = "Voltar";
            this.btnVoltarLogin.UseVisualStyleBackColor = false;
            this.btnVoltarLogin.Click += new System.EventHandler(this.btnVoltarLogin_Click);
            // 
            // groupBoxLanches
            // 
            this.groupBoxLanches.Controls.Add(this.cb_TortaFrango);
            this.groupBoxLanches.Controls.Add(this.tb_QtdTorta);
            this.groupBoxLanches.Controls.Add(this.cb_PaodeQueijo);
            this.groupBoxLanches.Controls.Add(this.cb_XDuplo);
            this.groupBoxLanches.Controls.Add(this.cb_Atum);
            this.groupBoxLanches.Controls.Add(this.cb_Frango);
            this.groupBoxLanches.Controls.Add(this.tb_QtdPaodeQueijo);
            this.groupBoxLanches.Controls.Add(this.tb_QtdDuplo);
            this.groupBoxLanches.Controls.Add(this.tb_QtdLAtum);
            this.groupBoxLanches.Controls.Add(this.tb_QtdLFrango);
            this.groupBoxLanches.Controls.Add(this.label1);
            this.groupBoxLanches.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxLanches.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLanches.Location = new System.Drawing.Point(12, 116);
            this.groupBoxLanches.Name = "groupBoxLanches";
            this.groupBoxLanches.Size = new System.Drawing.Size(369, 243);
            this.groupBoxLanches.TabIndex = 9;
            this.groupBoxLanches.TabStop = false;
            this.groupBoxLanches.Text = "Lanches";
            // 
            // cb_TortaFrango
            // 
            this.cb_TortaFrango.AutoSize = true;
            this.cb_TortaFrango.Location = new System.Drawing.Point(6, 191);
            this.cb_TortaFrango.Name = "cb_TortaFrango";
            this.cb_TortaFrango.Size = new System.Drawing.Size(166, 27);
            this.cb_TortaFrango.TabIndex = 23;
            this.cb_TortaFrango.Text = "Torta de Frango";
            this.cb_TortaFrango.UseVisualStyleBackColor = true;
            this.cb_TortaFrango.CheckedChanged += new System.EventHandler(this.cb_TortaFrango_CheckedChanged);
            // 
            // tb_QtdTorta
            // 
            this.tb_QtdTorta.Location = new System.Drawing.Point(245, 190);
            this.tb_QtdTorta.Name = "tb_QtdTorta";
            this.tb_QtdTorta.ReadOnly = true;
            this.tb_QtdTorta.Size = new System.Drawing.Size(94, 29);
            this.tb_QtdTorta.TabIndex = 22;
            // 
            // cb_PaodeQueijo
            // 
            this.cb_PaodeQueijo.AutoSize = true;
            this.cb_PaodeQueijo.Location = new System.Drawing.Point(6, 155);
            this.cb_PaodeQueijo.Name = "cb_PaodeQueijo";
            this.cb_PaodeQueijo.Size = new System.Drawing.Size(147, 27);
            this.cb_PaodeQueijo.TabIndex = 21;
            this.cb_PaodeQueijo.Text = "Pão de Queijo";
            this.cb_PaodeQueijo.UseVisualStyleBackColor = true;
            this.cb_PaodeQueijo.CheckedChanged += new System.EventHandler(this.cb_PaodeQueijo_CheckedChanged);
            // 
            // cb_XDuplo
            // 
            this.cb_XDuplo.AutoSize = true;
            this.cb_XDuplo.Location = new System.Drawing.Point(6, 119);
            this.cb_XDuplo.Name = "cb_XDuplo";
            this.cb_XDuplo.Size = new System.Drawing.Size(101, 27);
            this.cb_XDuplo.TabIndex = 20;
            this.cb_XDuplo.Text = "X-Duplo";
            this.cb_XDuplo.UseVisualStyleBackColor = true;
            this.cb_XDuplo.CheckedChanged += new System.EventHandler(this.cb_XDuplo_CheckedChanged);
            // 
            // cb_Atum
            // 
            this.cb_Atum.AutoSize = true;
            this.cb_Atum.Location = new System.Drawing.Point(6, 83);
            this.cb_Atum.Name = "cb_Atum";
            this.cb_Atum.Size = new System.Drawing.Size(173, 27);
            this.cb_Atum.TabIndex = 19;
            this.cb_Atum.Text = "Natural de Atum";
            this.cb_Atum.UseVisualStyleBackColor = true;
            this.cb_Atum.CheckedChanged += new System.EventHandler(this.cb_Atum_CheckedChanged);
            // 
            // cb_Frango
            // 
            this.cb_Frango.AutoSize = true;
            this.cb_Frango.Location = new System.Drawing.Point(6, 46);
            this.cb_Frango.Name = "cb_Frango";
            this.cb_Frango.Size = new System.Drawing.Size(185, 27);
            this.cb_Frango.TabIndex = 18;
            this.cb_Frango.Text = "Natural de Frango";
            this.cb_Frango.UseVisualStyleBackColor = true;
            this.cb_Frango.CheckedChanged += new System.EventHandler(this.cb_Frango_CheckedChanged);
            // 
            // tb_QtdPaodeQueijo
            // 
            this.tb_QtdPaodeQueijo.Location = new System.Drawing.Point(245, 153);
            this.tb_QtdPaodeQueijo.Name = "tb_QtdPaodeQueijo";
            this.tb_QtdPaodeQueijo.ReadOnly = true;
            this.tb_QtdPaodeQueijo.Size = new System.Drawing.Size(94, 29);
            this.tb_QtdPaodeQueijo.TabIndex = 11;
            // 
            // tb_QtdDuplo
            // 
            this.tb_QtdDuplo.Location = new System.Drawing.Point(245, 117);
            this.tb_QtdDuplo.Name = "tb_QtdDuplo";
            this.tb_QtdDuplo.ReadOnly = true;
            this.tb_QtdDuplo.Size = new System.Drawing.Size(94, 29);
            this.tb_QtdDuplo.TabIndex = 10;
            // 
            // tb_QtdLAtum
            // 
            this.tb_QtdLAtum.Location = new System.Drawing.Point(245, 81);
            this.tb_QtdLAtum.Name = "tb_QtdLAtum";
            this.tb_QtdLAtum.ReadOnly = true;
            this.tb_QtdLAtum.Size = new System.Drawing.Size(94, 29);
            this.tb_QtdLAtum.TabIndex = 9;
            // 
            // tb_QtdLFrango
            // 
            this.tb_QtdLFrango.Location = new System.Drawing.Point(245, 44);
            this.tb_QtdLFrango.Name = "tb_QtdLFrango";
            this.tb_QtdLFrango.ReadOnly = true;
            this.tb_QtdLFrango.Size = new System.Drawing.Size(94, 29);
            this.tb_QtdLFrango.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione a Quantidade";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.btnSelecionar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionar.Location = new System.Drawing.Point(120, 471);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(141, 40);
            this.btnSelecionar.TabIndex = 10;
            this.btnSelecionar.Text = "Selecionar Itens";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(453, 421);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(116, 23);
            this.labelValor.TabIndex = 11;
            this.labelValor.Text = "Valor Total: ";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(525, 342);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 23);
            this.labelResultado.TabIndex = 12;
            // 
            // groupBoxBebida
            // 
            this.groupBoxBebida.Controls.Add(this.cb_Cafe);
            this.groupBoxBebida.Controls.Add(this.cb_Suco);
            this.groupBoxBebida.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxBebida.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBebida.Location = new System.Drawing.Point(90, 373);
            this.groupBoxBebida.Name = "groupBoxBebida";
            this.groupBoxBebida.Size = new System.Drawing.Size(213, 72);
            this.groupBoxBebida.TabIndex = 12;
            this.groupBoxBebida.TabStop = false;
            this.groupBoxBebida.Text = "Bebidas (opcional)";
            // 
            // cb_Cafe
            // 
            this.cb_Cafe.AutoSize = true;
            this.cb_Cafe.Location = new System.Drawing.Point(82, 28);
            this.cb_Cafe.Name = "cb_Cafe";
            this.cb_Cafe.Size = new System.Drawing.Size(66, 27);
            this.cb_Cafe.TabIndex = 23;
            this.cb_Cafe.Text = "Café";
            this.cb_Cafe.UseVisualStyleBackColor = true;
            // 
            // cb_Suco
            // 
            this.cb_Suco.AutoSize = true;
            this.cb_Suco.Location = new System.Drawing.Point(6, 28);
            this.cb_Suco.Name = "cb_Suco";
            this.cb_Suco.Size = new System.Drawing.Size(70, 27);
            this.cb_Suco.TabIndex = 22;
            this.cb_Suco.Text = "Suco";
            this.cb_Suco.UseVisualStyleBackColor = true;
            // 
            // tb_ValorTotal
            // 
            this.tb_ValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.tb_ValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ValorTotal.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ValorTotal.Location = new System.Drawing.Point(575, 422);
            this.tb_ValorTotal.Multiline = true;
            this.tb_ValorTotal.Name = "tb_ValorTotal";
            this.tb_ValorTotal.Size = new System.Drawing.Size(119, 23);
            this.tb_ValorTotal.TabIndex = 14;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(37, 68);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(156, 23);
            this.labelNome.TabIndex = 16;
            this.labelNome.Text = "Insira seu nome: ";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nome.Location = new System.Drawing.Point(189, 68);
            this.tb_Nome.Multiline = true;
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(214, 29);
            this.tb_Nome.TabIndex = 1;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.btn_Confirmar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Confirmar.Location = new System.Drawing.Point(524, 467);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(141, 40);
            this.btn_Confirmar.TabIndex = 18;
            this.btn_Confirmar.Text = "Confirmar pedido";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.Rb_credito);
            this.groupBox1.Controls.Add(this.Rb_debito);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(490, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 72);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de Pagamento";
            // 
            // Rb_credito
            // 
            this.Rb_credito.AutoSize = true;
            this.Rb_credito.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_credito.Location = new System.Drawing.Point(130, 40);
            this.Rb_credito.Name = "Rb_credito";
            this.Rb_credito.Size = new System.Drawing.Size(78, 22);
            this.Rb_credito.TabIndex = 1;
            this.Rb_credito.TabStop = true;
            this.Rb_credito.Text = "Crédito";
            this.Rb_credito.UseVisualStyleBackColor = true;
            // 
            // Rb_debito
            // 
            this.Rb_debito.AutoSize = true;
            this.Rb_debito.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_debito.Location = new System.Drawing.Point(33, 40);
            this.Rb_debito.Name = "Rb_debito";
            this.Rb_debito.Size = new System.Drawing.Size(72, 22);
            this.Rb_debito.TabIndex = 0;
            this.Rb_debito.TabStop = true;
            this.Rb_debito.Text = "Débito";
            this.Rb_debito.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(822, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(310, 371);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.btn_visualizar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_visualizar.Location = new System.Drawing.Point(894, 467);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(141, 40);
            this.btn_visualizar.TabIndex = 21;
            this.btn_visualizar.Text = "Visualizar pedido";
            this.btn_visualizar.UseVisualStyleBackColor = false;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(846, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Clique aqui para visualizar o pedido \r\napós a confirmação";
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.btn_Sair.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sair.Location = new System.Drawing.Point(1135, 467);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(53, 40);
            this.btn_Sair.TabIndex = 23;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1200, 523);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.tb_ValorTotal);
            this.Controls.Add(this.groupBoxBebida);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.groupBoxLanches);
            this.Controls.Add(this.btnVoltarLogin);
            this.Controls.Add(this.groupBoxBolos);
            this.Controls.Add(this.labelPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClientes";
            this.groupBoxBolos.ResumeLayout(false);
            this.groupBoxBolos.PerformLayout();
            this.groupBoxLanches.ResumeLayout(false);
            this.groupBoxLanches.PerformLayout();
            this.groupBoxBebida.ResumeLayout(false);
            this.groupBoxBebida.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.GroupBox groupBoxBolos;
        private System.Windows.Forms.Label labelQtd;
        private System.Windows.Forms.Button btnVoltarLogin;
        private System.Windows.Forms.TextBox tb_QtdCenoura;
        private System.Windows.Forms.TextBox tb_QtdBanana;
        private System.Windows.Forms.TextBox tb_QtdFuba;
        private System.Windows.Forms.TextBox tb_QtdChoco;
        private System.Windows.Forms.GroupBox groupBoxLanches;
        private System.Windows.Forms.TextBox tb_QtdPaodeQueijo;
        private System.Windows.Forms.TextBox tb_QtdDuplo;
        private System.Windows.Forms.TextBox tb_QtdLAtum;
        private System.Windows.Forms.TextBox tb_QtdLFrango;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.GroupBox groupBoxBebida;
        private System.Windows.Forms.CheckBox cb_BoloFuba;
        private System.Windows.Forms.CheckBox cb_BoloChocolate;
        private System.Windows.Forms.CheckBox cb_BoloBanana;
        private System.Windows.Forms.CheckBox cb_BoloCenoura;
        private System.Windows.Forms.CheckBox cb_Frango;
        private System.Windows.Forms.CheckBox cb_Atum;
        private System.Windows.Forms.CheckBox cb_PaodeQueijo;
        private System.Windows.Forms.CheckBox cb_XDuplo;
        private System.Windows.Forms.CheckBox cb_Suco;
        private System.Windows.Forms.CheckBox cb_Cafe;
        private System.Windows.Forms.TextBox tb_ValorTotal;
        private System.Windows.Forms.CheckBox cb_TortaFrango;
        private System.Windows.Forms.TextBox tb_QtdTorta;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_credito;
        private System.Windows.Forms.RadioButton Rb_debito;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Sair;
    }
}
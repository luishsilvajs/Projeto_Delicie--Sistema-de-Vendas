
namespace Projeto_Delicie
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnCardapio = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.gbAcesso = new System.Windows.Forms.GroupBox();
            this.brnEntrar = new System.Windows.Forms.Button();
            this.rbFuncionario = new System.Windows.Forms.RadioButton();
            this.rbClientes = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.gbAcesso.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCardapio
            // 
            this.btnCardapio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.btnCardapio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardapio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCardapio.Location = new System.Drawing.Point(12, 389);
            this.btnCardapio.Name = "btnCardapio";
            this.btnCardapio.Size = new System.Drawing.Size(100, 40);
            this.btnCardapio.TabIndex = 0;
            this.btnCardapio.Text = "Cardápio";
            this.btnCardapio.UseVisualStyleBackColor = false;
            this.btnCardapio.Click += new System.EventHandler(this.btnCardapio_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.btnSair.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(12, 454);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 40);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 351);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(161, 160);
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;           
            // 
            // gbAcesso
            // 
            this.gbAcesso.Controls.Add(this.brnEntrar);
            this.gbAcesso.Controls.Add(this.rbFuncionario);
            this.gbAcesso.Controls.Add(this.rbClientes);
            this.gbAcesso.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcesso.Location = new System.Drawing.Point(80, 138);
            this.gbAcesso.Name = "gbAcesso";
            this.gbAcesso.Size = new System.Drawing.Size(261, 173);
            this.gbAcesso.TabIndex = 5;
            this.gbAcesso.TabStop = false;
            this.gbAcesso.Text = "Acesso";
            // 
            // brnEntrar
            // 
            this.brnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.brnEntrar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.brnEntrar.Location = new System.Drawing.Point(81, 116);
            this.brnEntrar.Name = "brnEntrar";
            this.brnEntrar.Size = new System.Drawing.Size(100, 40);
            this.brnEntrar.TabIndex = 6;
            this.brnEntrar.Text = "Entrar";
            this.brnEntrar.UseVisualStyleBackColor = false;
            this.brnEntrar.Click += new System.EventHandler(this.brnEntrar_Click);
            // 
            // rbFuncionario
            // 
            this.rbFuncionario.AutoSize = true;
            this.rbFuncionario.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFuncionario.Location = new System.Drawing.Point(73, 74);
            this.rbFuncionario.Name = "rbFuncionario";
            this.rbFuncionario.Size = new System.Drawing.Size(131, 27);
            this.rbFuncionario.TabIndex = 1;
            this.rbFuncionario.TabStop = true;
            this.rbFuncionario.Text = "Funcionário";
            this.rbFuncionario.UseVisualStyleBackColor = true;
            // 
            // rbClientes
            // 
            this.rbClientes.AutoSize = true;
            this.rbClientes.Location = new System.Drawing.Point(73, 41);
            this.rbClientes.Name = "rbClientes";
            this.rbClientes.Size = new System.Drawing.Size(95, 27);
            this.rbClientes.TabIndex = 0;
            this.rbClientes.TabStop = true;
            this.rbClientes.Text = "Clientes";
            this.rbClientes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(433, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 523);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(74, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Deliciê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(22, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cozinha e amor";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(719, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbAcesso);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCardapio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.gbAcesso.ResumeLayout(false);
            this.gbAcesso.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCardapio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox gbAcesso;
        private System.Windows.Forms.Button brnEntrar;
        private System.Windows.Forms.RadioButton rbFuncionario;
        private System.Windows.Forms.RadioButton rbClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


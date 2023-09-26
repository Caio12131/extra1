namespace extra1
{
    partial class txtName
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
            NomeIn = new Label();
            PrimeiroNome = new TextBox();
            Enviar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            RuaInfo = new TextBox();
            CepInfo = new TextBox();
            CidadeInfo = new TextBox();
            CadPes = new Button();
            label1 = new Label();
            CadNome = new TextBox();
            Sobrenome = new Label();
            UltimoNome = new TextBox();
            SuspendLayout();
            // 
            // NomeIn
            // 
            NomeIn.AutoSize = true;
            NomeIn.Location = new Point(183, 105);
            NomeIn.Name = "NomeIn";
            NomeIn.Size = new Size(50, 20);
            NomeIn.TabIndex = 0;
            NomeIn.Text = "Nome";
            // 
            // PrimeiroNome
            // 
            PrimeiroNome.Location = new Point(269, 105);
            PrimeiroNome.Name = "PrimeiroNome";
            PrimeiroNome.Size = new Size(433, 27);
            PrimeiroNome.TabIndex = 1;
            // 
            // Enviar
            // 
            Enviar.Location = new Point(269, 280);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(94, 29);
            Enviar.TabIndex = 2;
            Enviar.Text = "enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += enviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 171);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 3;
            label2.Text = "Rua";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 204);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 4;
            label3.Text = "Cidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 240);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 5;
            label4.Text = "Cep";
            // 
            // RuaInfo
            // 
            RuaInfo.Location = new Point(269, 171);
            RuaInfo.Name = "RuaInfo";
            RuaInfo.Size = new Size(433, 27);
            RuaInfo.TabIndex = 6;
            // 
            // CepInfo
            // 
            CepInfo.Location = new Point(269, 237);
            CepInfo.Name = "CepInfo";
            CepInfo.Size = new Size(433, 27);
            CepInfo.TabIndex = 7;
            // 
            // CidadeInfo
            // 
            CidadeInfo.Location = new Point(269, 204);
            CidadeInfo.Name = "CidadeInfo";
            CidadeInfo.Size = new Size(433, 27);
            CidadeInfo.TabIndex = 8;
            // 
            // CadPes
            // 
            CadPes.Location = new Point(329, 377);
            CadPes.Name = "CadPes";
            CadPes.Size = new Size(238, 29);
            CadPes.TabIndex = 9;
            CadPes.Text = "Pesquisar Cadastro";
            CadPes.UseVisualStyleBackColor = true;
            CadPes.Click += CadPes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowText;
            label1.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(349, 45);
            label1.Name = "label1";
            label1.Size = new Size(253, 21);
            label1.TabIndex = 10;
            label1.Text = "Cadastrar Informações";
            label1.Click += label1_Click_1;
            // 
            // CadNome
            // 
            CadNome.Location = new Point(387, 412);
            CadNome.Name = "CadNome";
            CadNome.Size = new Size(125, 27);
            CadNome.TabIndex = 11;
            // 
            // Sobrenome
            // 
            Sobrenome.AutoSize = true;
            Sobrenome.Location = new Point(183, 138);
            Sobrenome.Name = "Sobrenome";
            Sobrenome.Size = new Size(86, 20);
            Sobrenome.TabIndex = 12;
            Sobrenome.Text = "Sobrenome";
            // 
            // UltimoNome
            // 
            UltimoNome.Location = new Point(269, 138);
            UltimoNome.Name = "UltimoNome";
            UltimoNome.Size = new Size(433, 27);
            UltimoNome.TabIndex = 13;
            // 
            // txtName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 477);
            Controls.Add(UltimoNome);
            Controls.Add(Sobrenome);
            Controls.Add(CadNome);
            Controls.Add(label1);
            Controls.Add(CadPes);
            Controls.Add(CidadeInfo);
            Controls.Add(CepInfo);
            Controls.Add(RuaInfo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Enviar);
            Controls.Add(PrimeiroNome);
            Controls.Add(NomeIn);
            Name = "txtName";
            Text = "Atividade Extra";
            Load += começo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nome;
        private TextBox Nome1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox RuaInfo;
        private TextBox CepInfo;
        private TextBox CidadeInfo;
        private Button CadPes;
        private Label label1;
        private TextBox CadNome;
        private Label label5;
        private TextBox textBox1;
        private TextBox PrimeiroNome1;
        private TextBox UltimoNome1;
        private Label NomeIn;
        private Label Sobrenome;
        private TextBox PrimeiroNome;
        private TextBox UltimoNome;
        private Button Enviar;
    }
}
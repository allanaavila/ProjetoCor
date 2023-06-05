namespace ProjetoCor
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
            System.Windows.Forms.Label txtTitulo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.boxNome = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.boxEmail = new System.Windows.Forms.ComboBox();
            this.txtIdade = new System.Windows.Forms.Label();
            this.boxIdade = new System.Windows.Forms.ComboBox();
            this.txtEscola = new System.Windows.Forms.Label();
            this.boxEscola = new System.Windows.Forms.ComboBox();
            this.txtSerie = new System.Windows.Forms.Label();
            this.boxSerie = new System.Windows.Forms.ComboBox();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            txtTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
            txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTitulo.ForeColor = System.Drawing.SystemColors.Info;
            txtTitulo.Location = new System.Drawing.Point(28, 38);
            txtTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new System.Drawing.Size(214, 22);
            txtTitulo.TabIndex = 1;
            txtTitulo.Text = "Formulário para Cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNome.Location = new System.Drawing.Point(24, 68);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(45, 17);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "Nome";
            // 
            // boxNome
            // 
            this.boxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
            this.boxNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.boxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNome.ForeColor = System.Drawing.SystemColors.Info;
            this.boxNome.FormattingEnabled = true;
            this.boxNome.Location = new System.Drawing.Point(27, 87);
            this.boxNome.Margin = new System.Windows.Forms.Padding(2);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(210, 21);
            this.boxNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Location = new System.Drawing.Point(24, 135);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(47, 17);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "E-mail";
            // 
            // boxEmail
            // 
            this.boxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
            this.boxEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.boxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxEmail.ForeColor = System.Drawing.SystemColors.Info;
            this.boxEmail.FormattingEnabled = true;
            this.boxEmail.Location = new System.Drawing.Point(27, 154);
            this.boxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(210, 21);
            this.boxEmail.TabIndex = 5;
            // 
            // txtIdade
            // 
            this.txtIdade.AutoSize = true;
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.ForeColor = System.Drawing.SystemColors.Info;
            this.txtIdade.Location = new System.Drawing.Point(24, 202);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(43, 17);
            this.txtIdade.TabIndex = 6;
            this.txtIdade.Text = "Idade";
            // 
            // boxIdade
            // 
            this.boxIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
            this.boxIdade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.boxIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIdade.ForeColor = System.Drawing.SystemColors.Info;
            this.boxIdade.FormattingEnabled = true;
            this.boxIdade.Location = new System.Drawing.Point(26, 220);
            this.boxIdade.Margin = new System.Windows.Forms.Padding(2);
            this.boxIdade.Name = "boxIdade";
            this.boxIdade.Size = new System.Drawing.Size(211, 21);
            this.boxIdade.TabIndex = 7;
            // 
            // txtEscola
            // 
            this.txtEscola.AutoSize = true;
            this.txtEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscola.ForeColor = System.Drawing.SystemColors.Info;
            this.txtEscola.Location = new System.Drawing.Point(24, 266);
            this.txtEscola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(50, 17);
            this.txtEscola.TabIndex = 8;
            this.txtEscola.Text = "Escola";
            // 
            // boxEscola
            // 
            this.boxEscola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
            this.boxEscola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.boxEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxEscola.ForeColor = System.Drawing.SystemColors.Info;
            this.boxEscola.FormattingEnabled = true;
            this.boxEscola.Location = new System.Drawing.Point(26, 284);
            this.boxEscola.Margin = new System.Windows.Forms.Padding(2);
            this.boxEscola.Name = "boxEscola";
            this.boxEscola.Size = new System.Drawing.Size(211, 22);
            this.boxEscola.TabIndex = 9;
            // 
            // txtSerie
            // 
            this.txtSerie.AutoSize = true;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSerie.Location = new System.Drawing.Point(25, 323);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(41, 17);
            this.txtSerie.TabIndex = 10;
            this.txtSerie.Text = "Serie";
            // 
            // boxSerie
            // 
            this.boxSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
            this.boxSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.boxSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSerie.ForeColor = System.Drawing.SystemColors.Info;
            this.boxSerie.FormattingEnabled = true;
            this.boxSerie.Location = new System.Drawing.Point(26, 342);
            this.boxSerie.Margin = new System.Windows.Forms.Padding(2);
            this.boxSerie.Name = "boxSerie";
            this.boxSerie.Size = new System.Drawing.Size(211, 21);
            this.boxSerie.TabIndex = 11;
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.buttonContinuar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinuar.Location = new System.Drawing.Point(26, 380);
            this.buttonContinuar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(127, 30);
            this.buttonContinuar.TabIndex = 12;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = false;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuuar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(329, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(630, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.boxSerie);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.boxEscola);
            this.Controls.Add(this.txtEscola);
            this.Controls.Add(this.boxIdade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(txtTitulo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.ComboBox boxNome;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.ComboBox boxEmail;
        private System.Windows.Forms.Label txtIdade;
        private System.Windows.Forms.ComboBox boxIdade;
        private System.Windows.Forms.Label txtEscola;
        private System.Windows.Forms.ComboBox boxEscola;
        private System.Windows.Forms.Label txtSerie;
        private System.Windows.Forms.ComboBox boxSerie;
        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


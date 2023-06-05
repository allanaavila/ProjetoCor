namespace ProjetoCor
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.listaUsuario = new System.Windows.Forms.ListBox();
            this.listaJogos = new System.Windows.Forms.ListBox();
            this.listaRedes = new System.Windows.Forms.ListBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(375, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.Info;
            this.txtTitulo.Location = new System.Drawing.Point(389, 32);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(285, 22);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.Text = "Cadrastro Realizado com Sucesso";
            // 
            // listaUsuario
            // 
            this.listaUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.listaUsuario.FormattingEnabled = true;
            this.listaUsuario.ItemHeight = 16;
            this.listaUsuario.Location = new System.Drawing.Point(171, 146);
            this.listaUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaUsuario.Name = "listaUsuario";
            this.listaUsuario.Size = new System.Drawing.Size(717, 132);
            this.listaUsuario.TabIndex = 2;
            // 
            // listaJogos
            // 
            this.listaJogos.BackColor = System.Drawing.SystemColors.Control;
            this.listaJogos.FormattingEnabled = true;
            this.listaJogos.ItemHeight = 16;
            this.listaJogos.Location = new System.Drawing.Point(597, 348);
            this.listaJogos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaJogos.Name = "listaJogos";
            this.listaJogos.Size = new System.Drawing.Size(291, 116);
            this.listaJogos.TabIndex = 3;
            // 
            // listaRedes
            // 
            this.listaRedes.BackColor = System.Drawing.SystemColors.Control;
            this.listaRedes.FormattingEnabled = true;
            this.listaRedes.ItemHeight = 16;
            this.listaRedes.Location = new System.Drawing.Point(171, 348);
            this.listaRedes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaRedes.Name = "listaRedes";
            this.listaRedes.Size = new System.Drawing.Size(304, 116);
            this.listaRedes.TabIndex = 4;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(404, 68);
            this.btnGerarRelatorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(261, 28);
            this.btnGerarRelatorio.TabIndex = 5;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.listaRedes);
            this.Controls.Add(this.listaJogos);
            this.Controls.Add(this.listaUsuario);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.ListBox listaUsuario;
        private System.Windows.Forms.ListBox listaJogos;
        private System.Windows.Forms.ListBox listaRedes;
        private System.Windows.Forms.Button btnGerarRelatorio;
    }
}
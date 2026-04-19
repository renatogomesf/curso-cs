namespace aula60
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
            this.btn_canal = new System.Windows.Forms.Button();
            this.lb_linkCanal = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_canal
            // 
            this.btn_canal.BackColor = System.Drawing.Color.Black;
            this.btn_canal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_canal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canal.ForeColor = System.Drawing.Color.Red;
            this.btn_canal.Location = new System.Drawing.Point(328, 208);
            this.btn_canal.Name = "btn_canal";
            this.btn_canal.Size = new System.Drawing.Size(172, 55);
            this.btn_canal.TabIndex = 0;
            this.btn_canal.Text = "CFB Cursos";
            this.btn_canal.UseVisualStyleBackColor = false;
            this.btn_canal.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_linkCanal
            // 
            this.lb_linkCanal.AutoSize = true;
            this.lb_linkCanal.Location = new System.Drawing.Point(375, 176);
            this.lb_linkCanal.Name = "lb_linkCanal";
            this.lb_linkCanal.Size = new System.Drawing.Size(68, 13);
            this.lb_linkCanal.TabIndex = 1;
            this.lb_linkCanal.Text = "youtube.com";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(328, 295);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(172, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_linkCanal);
            this.Controls.Add(this.btn_canal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Curso de C# - CFB Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_canal;
        private System.Windows.Forms.Label lb_linkCanal;
        private System.Windows.Forms.TextBox tb_nome;
    }
}


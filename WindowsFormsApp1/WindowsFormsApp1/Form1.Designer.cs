namespace WindowsFormsApp1
{
    partial class botao2
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
            this.ClicaAqui = new System.Windows.Forms.Button();
            this.primeiraMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClicaAqui
            // 
            this.ClicaAqui.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClicaAqui.Font = new System.Drawing.Font("Goudy Stout", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClicaAqui.Location = new System.Drawing.Point(12, 12);
            this.ClicaAqui.Name = "ClicaAqui";
            this.ClicaAqui.Size = new System.Drawing.Size(194, 88);
            this.ClicaAqui.TabIndex = 0;
            this.ClicaAqui.Text = "Visite Aqui";
            this.ClicaAqui.UseVisualStyleBackColor = false;
            this.ClicaAqui.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // primeiraMensagem
            // 
            this.primeiraMensagem.AutoSize = true;
            this.primeiraMensagem.Font = new System.Drawing.Font("Snap ITC", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeiraMensagem.Location = new System.Drawing.Point(33, 103);
            this.primeiraMensagem.Name = "primeiraMensagem";
            this.primeiraMensagem.Size = new System.Drawing.Size(153, 61);
            this.primeiraMensagem.TabIndex = 1;
            this.primeiraMensagem.Text = "Base";
            this.primeiraMensagem.Click += new System.EventHandler(this.label1_Click);
            // 
            // botao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1015, 563);
            this.Controls.Add(this.primeiraMensagem);
            this.Controls.Add(this.ClicaAqui);
            this.Name = "botao2";
            this.Text = "Eae Blz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClicaAqui;
        private System.Windows.Forms.Label primeiraMensagem;
    }
}


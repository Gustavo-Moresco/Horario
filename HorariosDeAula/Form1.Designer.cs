
namespace HorariosDeAula
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
            this.button3Intervalo = new System.Windows.Forms.Button();
            this.button2Sala = new System.Windows.Forms.Button();
            this.button1Aluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3Intervalo
            // 
            this.button3Intervalo.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Intervalo.Location = new System.Drawing.Point(305, 343);
            this.button3Intervalo.Name = "button3Intervalo";
            this.button3Intervalo.Size = new System.Drawing.Size(175, 51);
            this.button3Intervalo.TabIndex = 9;
            this.button3Intervalo.Text = "Intervalo";
            this.button3Intervalo.UseVisualStyleBackColor = true;
            this.button3Intervalo.Click += new System.EventHandler(this.button3Intervalo_Click);
            // 
            // button2Sala
            // 
            this.button2Sala.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Italic);
            this.button2Sala.Location = new System.Drawing.Point(305, 267);
            this.button2Sala.Name = "button2Sala";
            this.button2Sala.Size = new System.Drawing.Size(175, 51);
            this.button2Sala.TabIndex = 8;
            this.button2Sala.Text = "Sala";
            this.button2Sala.UseVisualStyleBackColor = true;
            this.button2Sala.Click += new System.EventHandler(this.button2Sala_Click);
            // 
            // button1Aluno
            // 
            this.button1Aluno.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Italic);
            this.button1Aluno.Location = new System.Drawing.Point(305, 196);
            this.button1Aluno.Name = "button1Aluno";
            this.button1Aluno.Size = new System.Drawing.Size(175, 51);
            this.button1Aluno.TabIndex = 7;
            this.button1Aluno.Text = "Aluno";
            this.button1Aluno.UseVisualStyleBackColor = true;
            this.button1Aluno.Click += new System.EventHandler(this.button1Aluno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Insira ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gerador de turmas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3Intervalo);
            this.Controls.Add(this.button2Sala);
            this.Controls.Add(this.button1Aluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3Intervalo;
        private System.Windows.Forms.Button button2Sala;
        private System.Windows.Forms.Button button1Aluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


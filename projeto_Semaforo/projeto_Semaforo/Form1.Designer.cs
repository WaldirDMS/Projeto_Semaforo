
namespace projeto_Semaforo
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
            this.components = new System.ComponentModel.Container();
            this.pictureSemaforo2 = new System.Windows.Forms.PictureBox();
            this.pictureSemaforo1 = new System.Windows.Forms.PictureBox();
            this.btnVml2 = new System.Windows.Forms.Button();
            this.btnAm2 = new System.Windows.Forms.Button();
            this.btnVd2 = new System.Windows.Forms.Button();
            this.btnVd1 = new System.Windows.Forms.Button();
            this.btnAm1 = new System.Windows.Forms.Button();
            this.btnVrm1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radLiga = new System.Windows.Forms.RadioButton();
            this.radDesliga = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSemaforo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSemaforo1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSemaforo2
            // 
            this.pictureSemaforo2.Image = global::projeto_Semaforo.Properties.Resources.amr;
            this.pictureSemaforo2.Location = new System.Drawing.Point(63, 184);
            this.pictureSemaforo2.Name = "pictureSemaforo2";
            this.pictureSemaforo2.Size = new System.Drawing.Size(46, 112);
            this.pictureSemaforo2.TabIndex = 0;
            this.pictureSemaforo2.TabStop = false;
            // 
            // pictureSemaforo1
            // 
            this.pictureSemaforo1.Image = global::projeto_Semaforo.Properties.Resources.amr;
            this.pictureSemaforo1.Location = new System.Drawing.Point(177, 184);
            this.pictureSemaforo1.Name = "pictureSemaforo1";
            this.pictureSemaforo1.Size = new System.Drawing.Size(46, 112);
            this.pictureSemaforo1.TabIndex = 1;
            this.pictureSemaforo1.TabStop = false;
            // 
            // btnVml2
            // 
            this.btnVml2.Location = new System.Drawing.Point(49, 78);
            this.btnVml2.Name = "btnVml2";
            this.btnVml2.Size = new System.Drawing.Size(75, 23);
            this.btnVml2.TabIndex = 3;
            this.btnVml2.Text = "Vermelho";
            this.btnVml2.UseVisualStyleBackColor = true;
            this.btnVml2.Click += new System.EventHandler(this.btnVml2_Click);
            // 
            // btnAm2
            // 
            this.btnAm2.Location = new System.Drawing.Point(49, 107);
            this.btnAm2.Name = "btnAm2";
            this.btnAm2.Size = new System.Drawing.Size(75, 23);
            this.btnAm2.TabIndex = 4;
            this.btnAm2.Text = "Amarelo";
            this.btnAm2.UseVisualStyleBackColor = true;
            this.btnAm2.Click += new System.EventHandler(this.btnAm2_Click);
            // 
            // btnVd2
            // 
            this.btnVd2.Location = new System.Drawing.Point(49, 136);
            this.btnVd2.Name = "btnVd2";
            this.btnVd2.Size = new System.Drawing.Size(75, 23);
            this.btnVd2.TabIndex = 5;
            this.btnVd2.Text = "Verde";
            this.btnVd2.UseVisualStyleBackColor = true;
            this.btnVd2.Click += new System.EventHandler(this.btnVd2_Click);
            // 
            // btnVd1
            // 
            this.btnVd1.Location = new System.Drawing.Point(163, 136);
            this.btnVd1.Name = "btnVd1";
            this.btnVd1.Size = new System.Drawing.Size(75, 23);
            this.btnVd1.TabIndex = 8;
            this.btnVd1.Text = "Verde";
            this.btnVd1.UseVisualStyleBackColor = true;
            this.btnVd1.Click += new System.EventHandler(this.btnVd1_Click);
            // 
            // btnAm1
            // 
            this.btnAm1.Location = new System.Drawing.Point(163, 107);
            this.btnAm1.Name = "btnAm1";
            this.btnAm1.Size = new System.Drawing.Size(75, 23);
            this.btnAm1.TabIndex = 7;
            this.btnAm1.Text = "Amarelo";
            this.btnAm1.UseVisualStyleBackColor = true;
            this.btnAm1.Click += new System.EventHandler(this.btnAm1_Click);
            // 
            // btnVrm1
            // 
            this.btnVrm1.Location = new System.Drawing.Point(163, 78);
            this.btnVrm1.Name = "btnVrm1";
            this.btnVrm1.Size = new System.Drawing.Size(75, 23);
            this.btnVrm1.TabIndex = 6;
            this.btnVrm1.Text = "Vermelho";
            this.btnVrm1.UseVisualStyleBackColor = true;
            this.btnVrm1.Click += new System.EventHandler(this.btnVrm1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rua 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rua 1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radLiga
            // 
            this.radLiga.AutoSize = true;
            this.radLiga.Location = new System.Drawing.Point(116, 315);
            this.radLiga.Name = "radLiga";
            this.radLiga.Size = new System.Drawing.Size(48, 17);
            this.radLiga.TabIndex = 11;
            this.radLiga.TabStop = true;
            this.radLiga.Text = "Ligar";
            this.radLiga.UseVisualStyleBackColor = true;
            this.radLiga.Click += new System.EventHandler(this.radLiga_Click);
            // 
            // radDesliga
            // 
            this.radDesliga.AutoSize = true;
            this.radDesliga.Location = new System.Drawing.Point(116, 338);
            this.radDesliga.Name = "radDesliga";
            this.radDesliga.Size = new System.Drawing.Size(63, 17);
            this.radDesliga.TabIndex = 12;
            this.radDesliga.TabStop = true;
            this.radDesliga.Text = "Desligar";
            this.radDesliga.UseVisualStyleBackColor = true;
            this.radDesliga.Click += new System.EventHandler(this.radDesliga_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(112, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(81, 20);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "00000000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 367);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.radDesliga);
            this.Controls.Add(this.radLiga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVd1);
            this.Controls.Add(this.btnAm1);
            this.Controls.Add(this.btnVrm1);
            this.Controls.Add(this.btnVd2);
            this.Controls.Add(this.btnAm2);
            this.Controls.Add(this.btnVml2);
            this.Controls.Add(this.pictureSemaforo1);
            this.Controls.Add(this.pictureSemaforo2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Semaforo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSemaforo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSemaforo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSemaforo2;
        private System.Windows.Forms.PictureBox pictureSemaforo1;
        private System.Windows.Forms.Button btnVml2;
        private System.Windows.Forms.Button btnAm2;
        private System.Windows.Forms.Button btnVd2;
        private System.Windows.Forms.Button btnVd1;
        private System.Windows.Forms.Button btnAm1;
        private System.Windows.Forms.Button btnVrm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radLiga;
        private System.Windows.Forms.RadioButton radDesliga;
        private System.Windows.Forms.Label lblEstado;
    }
}


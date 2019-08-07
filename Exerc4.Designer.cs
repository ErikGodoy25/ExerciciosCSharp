namespace WindowsFormsApp1
{
    partial class Exerc4
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
            this.BtnCalcViagem = new System.Windows.Forms.Button();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblQuilometros = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtVelocidadeM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCalcViagem
            // 
            this.BtnCalcViagem.Location = new System.Drawing.Point(196, 152);
            this.BtnCalcViagem.Name = "BtnCalcViagem";
            this.BtnCalcViagem.Size = new System.Drawing.Size(112, 37);
            this.BtnCalcViagem.TabIndex = 0;
            this.BtnCalcViagem.Text = "Calcular Viagem";
            this.BtnCalcViagem.UseVisualStyleBackColor = true;
            this.BtnCalcViagem.Click += new System.EventHandler(this.BtnCalcViagem_Click);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(43, 43);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(144, 13);
            this.lblTempo.TabIndex = 1;
            this.lblTempo.Text = "Tempo de Viagem em Horas:";
            this.lblTempo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblQuilometros
            // 
            this.lblQuilometros.AutoSize = true;
            this.lblQuilometros.Location = new System.Drawing.Point(43, 96);
            this.lblQuilometros.Name = "lblQuilometros";
            this.lblQuilometros.Size = new System.Drawing.Size(127, 13);
            this.lblQuilometros.TabIndex = 2;
            this.lblQuilometros.Text = "Velocidade Média Km/h: ";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(193, 36);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(38, 20);
            this.txtTempo.TabIndex = 3;
            this.txtTempo.TextChanged += new System.EventHandler(this.TxtTempo_TextChanged);
            // 
            // txtVelocidadeM
            // 
            this.txtVelocidadeM.Location = new System.Drawing.Point(193, 89);
            this.txtVelocidadeM.Name = "txtVelocidadeM";
            this.txtVelocidadeM.Size = new System.Drawing.Size(38, 20);
            this.txtVelocidadeM.TabIndex = 4;
            // 
            // Exerc4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVelocidadeM);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblQuilometros);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.BtnCalcViagem);
            this.Name = "Exerc4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcViagem;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblQuilometros;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtVelocidadeM;
    }
}
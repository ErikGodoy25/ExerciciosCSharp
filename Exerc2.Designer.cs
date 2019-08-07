namespace WindowsFormsApp1
{
    partial class Exerc2
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
            this.BtnResultAB = new System.Windows.Forms.Button();
            this.lblva = new System.Windows.Forms.Label();
            this.lblvb = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnResultAB
            // 
            this.BtnResultAB.Location = new System.Drawing.Point(134, 151);
            this.BtnResultAB.Name = "BtnResultAB";
            this.BtnResultAB.Size = new System.Drawing.Size(75, 23);
            this.BtnResultAB.TabIndex = 0;
            this.BtnResultAB.Text = "Result";
            this.BtnResultAB.UseVisualStyleBackColor = true;
            this.BtnResultAB.Click += new System.EventHandler(this.BtnResultAB_Click);
            // 
            // lblva
            // 
            this.lblva.AutoSize = true;
            this.lblva.Location = new System.Drawing.Point(80, 45);
            this.lblva.Name = "lblva";
            this.lblva.Size = new System.Drawing.Size(41, 13);
            this.lblva.TabIndex = 1;
            this.lblva.Text = "Valor A";
            // 
            // lblvb
            // 
            this.lblvb.AutoSize = true;
            this.lblvb.Location = new System.Drawing.Point(80, 93);
            this.lblvb.Name = "lblvb";
            this.lblvb.Size = new System.Drawing.Size(41, 13);
            this.lblvb.TabIndex = 2;
            this.lblvb.Text = "Valor B";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(134, 38);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 20);
            this.txtValorA.TabIndex = 3;
            this.txtValorA.TextChanged += new System.EventHandler(this.TxtValorA_TextChanged);
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(134, 86);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(100, 20);
            this.txtValorB.TabIndex = 4;
            this.txtValorB.TextChanged += new System.EventHandler(this.TxtValorB_TextChanged);
            // 
            // Exerc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lblvb);
            this.Controls.Add(this.lblva);
            this.Controls.Add(this.BtnResultAB);
            this.Name = "Exerc2";
            this.Text = "Exerc2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnResultAB;
        private System.Windows.Forms.Label lblva;
        private System.Windows.Forms.Label lblvb;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
    }
}
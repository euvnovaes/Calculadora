namespace PrjCalculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVa1 = new System.Windows.Forms.TextBox();
            this.txtVa2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.lblSinal = new System.Windows.Forms.Label();
            this.rdSoma = new System.Windows.Forms.RadioButton();
            this.rdSubt = new System.Windows.Forms.RadioButton();
            this.rdDiv = new System.Windows.Forms.RadioButton();
            this.rdMult = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o primeiro valor";
            // 
            // txtVa1
            // 
            this.txtVa1.Location = new System.Drawing.Point(107, 59);
            this.txtVa1.Name = "txtVa1";
            this.txtVa1.Size = new System.Drawing.Size(100, 20);
            this.txtVa1.TabIndex = 1;
            this.txtVa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVa2
            // 
            this.txtVa2.Location = new System.Drawing.Point(327, 59);
            this.txtVa2.Name = "txtVa2";
            this.txtVa2.Size = new System.Drawing.Size(100, 20);
            this.txtVa2.TabIndex = 3;
            this.txtVa2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o segundo valor";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(221, 273);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(236, 211);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 6;
            this.btnSoma.Text = "Calcular";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Location = new System.Drawing.Point(223, 97);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(98, 13);
            this.lblSinal.TabIndex = 13;
            this.lblSinal.Text = "Defina a operacão:";
            // 
            // rdSoma
            // 
            this.rdSoma.AutoSize = true;
            this.rdSoma.Location = new System.Drawing.Point(198, 131);
            this.rdSoma.Name = "rdSoma";
            this.rdSoma.Size = new System.Drawing.Size(55, 17);
            this.rdSoma.TabIndex = 14;
            this.rdSoma.TabStop = true;
            this.rdSoma.Text = "Somar";
            this.rdSoma.UseVisualStyleBackColor = true;
            // 
            // rdSubt
            // 
            this.rdSubt.AutoSize = true;
            this.rdSubt.Location = new System.Drawing.Point(306, 131);
            this.rdSubt.Name = "rdSubt";
            this.rdSubt.Size = new System.Drawing.Size(61, 17);
            this.rdSubt.TabIndex = 15;
            this.rdSubt.TabStop = true;
            this.rdSubt.Text = "Subtrair";
            this.rdSubt.UseVisualStyleBackColor = true;
            // 
            // rdDiv
            // 
            this.rdDiv.AutoSize = true;
            this.rdDiv.Location = new System.Drawing.Point(306, 177);
            this.rdDiv.Name = "rdDiv";
            this.rdDiv.Size = new System.Drawing.Size(54, 17);
            this.rdDiv.TabIndex = 16;
            this.rdDiv.TabStop = true;
            this.rdDiv.Text = "Dividir";
            this.rdDiv.UseVisualStyleBackColor = true;
            // 
            // rdMult
            // 
            this.rdMult.AutoSize = true;
            this.rdMult.Location = new System.Drawing.Point(198, 177);
            this.rdMult.Name = "rdMult";
            this.rdMult.Size = new System.Drawing.Size(72, 17);
            this.rdMult.TabIndex = 17;
            this.rdMult.TabStop = true;
            this.rdMult.Text = "Multiplicar";
            this.rdMult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(582, 311);
            this.Controls.Add(this.rdMult);
            this.Controls.Add(this.rdDiv);
            this.Controls.Add(this.rdSubt);
            this.Controls.Add(this.rdSoma);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVa2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVa1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVa1;
        private System.Windows.Forms.TextBox txtVa2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.RadioButton rdSoma;
        private System.Windows.Forms.RadioButton rdSubt;
        private System.Windows.Forms.RadioButton rdDiv;
        private System.Windows.Forms.RadioButton rdMult;
    }
}


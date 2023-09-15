namespace Folha_Salarial_Simples_Final
{
    partial class FormFinal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mostrarDescontoTotalLable = new System.Windows.Forms.Label();
            this.mostrarDescontoIrLable = new System.Windows.Forms.Label();
            this.mostrarDescontoInssLable = new System.Windows.Forms.Label();
            this.mostrarSalarioLiquidoLable = new System.Windows.Forms.Label();
            this.mostrarSalarioBrutoLabel = new System.Windows.Forms.Label();
            this.descontoTotalLable = new System.Windows.Forms.Label();
            this.descontoIrLable = new System.Windows.Forms.Label();
            this.descontoInssLable = new System.Windows.Forms.Label();
            this.salarioFinalLable = new System.Windows.Forms.Label();
            this.salarioBrutoLable = new System.Windows.Forms.Label();
            this.calculoDescontoButton = new System.Windows.Forms.Button();
            this.insiraSalarioLable = new System.Windows.Forms.Label();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.calculoDescontoButton);
            this.panel1.Controls.Add(this.insiraSalarioLable);
            this.panel1.Controls.Add(this.salarioTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 287);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.mostrarDescontoTotalLable);
            this.panel2.Controls.Add(this.mostrarDescontoIrLable);
            this.panel2.Controls.Add(this.mostrarDescontoInssLable);
            this.panel2.Controls.Add(this.mostrarSalarioLiquidoLable);
            this.panel2.Controls.Add(this.mostrarSalarioBrutoLabel);
            this.panel2.Controls.Add(this.descontoTotalLable);
            this.panel2.Controls.Add(this.descontoIrLable);
            this.panel2.Controls.Add(this.descontoInssLable);
            this.panel2.Controls.Add(this.salarioFinalLable);
            this.panel2.Controls.Add(this.salarioBrutoLable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(348, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 287);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // mostrarDescontoTotalLable
            // 
            this.mostrarDescontoTotalLable.AutoSize = true;
            this.mostrarDescontoTotalLable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarDescontoTotalLable.ForeColor = System.Drawing.Color.Black;
            this.mostrarDescontoTotalLable.Location = new System.Drawing.Point(131, 157);
            this.mostrarDescontoTotalLable.Name = "mostrarDescontoTotalLable";
            this.mostrarDescontoTotalLable.Size = new System.Drawing.Size(0, 16);
            this.mostrarDescontoTotalLable.TabIndex = 11;
            // 
            // mostrarDescontoIrLable
            // 
            this.mostrarDescontoIrLable.AutoSize = true;
            this.mostrarDescontoIrLable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarDescontoIrLable.ForeColor = System.Drawing.Color.Black;
            this.mostrarDescontoIrLable.Location = new System.Drawing.Point(127, 117);
            this.mostrarDescontoIrLable.Name = "mostrarDescontoIrLable";
            this.mostrarDescontoIrLable.Size = new System.Drawing.Size(0, 16);
            this.mostrarDescontoIrLable.TabIndex = 10;
            // 
            // mostrarDescontoInssLable
            // 
            this.mostrarDescontoInssLable.AutoSize = true;
            this.mostrarDescontoInssLable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarDescontoInssLable.ForeColor = System.Drawing.Color.Black;
            this.mostrarDescontoInssLable.Location = new System.Drawing.Point(131, 77);
            this.mostrarDescontoInssLable.Name = "mostrarDescontoInssLable";
            this.mostrarDescontoInssLable.Size = new System.Drawing.Size(0, 16);
            this.mostrarDescontoInssLable.TabIndex = 9;
            // 
            // mostrarSalarioLiquidoLable
            // 
            this.mostrarSalarioLiquidoLable.AutoSize = true;
            this.mostrarSalarioLiquidoLable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarSalarioLiquidoLable.ForeColor = System.Drawing.Color.Black;
            this.mostrarSalarioLiquidoLable.Location = new System.Drawing.Point(131, 197);
            this.mostrarSalarioLiquidoLable.Name = "mostrarSalarioLiquidoLable";
            this.mostrarSalarioLiquidoLable.Size = new System.Drawing.Size(0, 16);
            this.mostrarSalarioLiquidoLable.TabIndex = 8;
            this.mostrarSalarioLiquidoLable.Click += new System.EventHandler(this.label8_Click);
            // 
            // mostrarSalarioBrutoLabel
            // 
            this.mostrarSalarioBrutoLabel.AutoSize = true;
            this.mostrarSalarioBrutoLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarSalarioBrutoLabel.ForeColor = System.Drawing.Color.Black;
            this.mostrarSalarioBrutoLabel.Location = new System.Drawing.Point(121, 38);
            this.mostrarSalarioBrutoLabel.Name = "mostrarSalarioBrutoLabel";
            this.mostrarSalarioBrutoLabel.Size = new System.Drawing.Size(0, 16);
            this.mostrarSalarioBrutoLabel.TabIndex = 7;
            // 
            // descontoTotalLable
            // 
            this.descontoTotalLable.AutoSize = true;
            this.descontoTotalLable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descontoTotalLable.ForeColor = System.Drawing.Color.Black;
            this.descontoTotalLable.Location = new System.Drawing.Point(34, 158);
            this.descontoTotalLable.Name = "descontoTotalLable";
            this.descontoTotalLable.Size = new System.Drawing.Size(91, 15);
            this.descontoTotalLable.TabIndex = 6;
            this.descontoTotalLable.Text = "Desconto Total";
            // 
            // descontoIrLable
            // 
            this.descontoIrLable.AutoSize = true;
            this.descontoIrLable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descontoIrLable.ForeColor = System.Drawing.Color.Black;
            this.descontoIrLable.Location = new System.Drawing.Point(34, 118);
            this.descontoIrLable.Name = "descontoIrLable";
            this.descontoIrLable.Size = new System.Drawing.Size(87, 15);
            this.descontoIrLable.TabIndex = 5;
            this.descontoIrLable.Text = "Desconto IRFF";
            // 
            // descontoInssLable
            // 
            this.descontoInssLable.AutoSize = true;
            this.descontoInssLable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descontoInssLable.ForeColor = System.Drawing.Color.Black;
            this.descontoInssLable.Location = new System.Drawing.Point(34, 78);
            this.descontoInssLable.Name = "descontoInssLable";
            this.descontoInssLable.Size = new System.Drawing.Size(91, 15);
            this.descontoInssLable.TabIndex = 4;
            this.descontoInssLable.Text = "Desconto INSS";
            // 
            // salarioFinalLable
            // 
            this.salarioFinalLable.AutoSize = true;
            this.salarioFinalLable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioFinalLable.ForeColor = System.Drawing.Color.Black;
            this.salarioFinalLable.Location = new System.Drawing.Point(34, 198);
            this.salarioFinalLable.Name = "salarioFinalLable";
            this.salarioFinalLable.Size = new System.Drawing.Size(91, 15);
            this.salarioFinalLable.TabIndex = 3;
            this.salarioFinalLable.Text = "Salário Líquido";
            // 
            // salarioBrutoLable
            // 
            this.salarioBrutoLable.AutoSize = true;
            this.salarioBrutoLable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioBrutoLable.ForeColor = System.Drawing.Color.Black;
            this.salarioBrutoLable.Location = new System.Drawing.Point(34, 38);
            this.salarioBrutoLable.Name = "salarioBrutoLable";
            this.salarioBrutoLable.Size = new System.Drawing.Size(81, 15);
            this.salarioBrutoLable.TabIndex = 2;
            this.salarioBrutoLable.Text = "Salário Bruto";
            // 
            // calculoDescontoButton
            // 
            this.calculoDescontoButton.AutoSize = true;
            this.calculoDescontoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.calculoDescontoButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.calculoDescontoButton.FlatAppearance.BorderSize = 2;
            this.calculoDescontoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.calculoDescontoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculoDescontoButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculoDescontoButton.ForeColor = System.Drawing.Color.White;
            this.calculoDescontoButton.Location = new System.Drawing.Point(171, 78);
            this.calculoDescontoButton.Name = "calculoDescontoButton";
            this.calculoDescontoButton.Size = new System.Drawing.Size(120, 37);
            this.calculoDescontoButton.TabIndex = 0;
            this.calculoDescontoButton.Text = "Calcular Desconto";
            this.calculoDescontoButton.UseVisualStyleBackColor = false;
            this.calculoDescontoButton.Click += new System.EventHandler(this.calculoDescontoButton_Click);
            // 
            // insiraSalarioLable
            // 
            this.insiraSalarioLable.AutoSize = true;
            this.insiraSalarioLable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insiraSalarioLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.insiraSalarioLable.Location = new System.Drawing.Point(47, 38);
            this.insiraSalarioLable.Name = "insiraSalarioLable";
            this.insiraSalarioLable.Size = new System.Drawing.Size(118, 16);
            this.insiraSalarioLable.TabIndex = 1;
            this.insiraSalarioLable.Text = "Insira seu Salário";
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.Location = new System.Drawing.Point(171, 37);
            this.salarioTextBox.MaxLength = 8;
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(120, 20);
            this.salarioTextBox.TabIndex = 2;
            this.salarioTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 287);
            this.Controls.Add(this.panel1);
            this.Name = "FormFinal";
            this.Text = "Calculo de Folha Salarial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calculoDescontoButton;
        private System.Windows.Forms.Label insiraSalarioLable;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label salarioBrutoLable;
        private System.Windows.Forms.Label descontoInssLable;
        private System.Windows.Forms.Label salarioFinalLable;
        private System.Windows.Forms.Label descontoTotalLable;
        private System.Windows.Forms.Label descontoIrLable;
        private System.Windows.Forms.Label mostrarSalarioLiquidoLable;
        private System.Windows.Forms.Label mostrarSalarioBrutoLabel;
        private System.Windows.Forms.Label mostrarDescontoTotalLable;
        private System.Windows.Forms.Label mostrarDescontoIrLable;
        private System.Windows.Forms.Label mostrarDescontoInssLable;
    }
}


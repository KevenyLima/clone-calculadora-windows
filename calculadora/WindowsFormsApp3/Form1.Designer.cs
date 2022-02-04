namespace WindowsFormsApp3
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
            this.cmd_1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmd_igual = new System.Windows.Forms.Button();
            this.cmd_0 = new System.Windows.Forms.Button();
            this.cmd_4 = new System.Windows.Forms.Button();
            this.cmd_7 = new System.Windows.Forms.Button();
            this.cmd_5 = new System.Windows.Forms.Button();
            this.cmd_8 = new System.Windows.Forms.Button();
            this.cmd_9 = new System.Windows.Forms.Button();
            this.cmd_6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.cmd_multiplicar = new System.Windows.Forms.Button();
            this.cmd_soma = new System.Windows.Forms.Button();
            this.cmd_subtrair = new System.Windows.Forms.Button();
            this.mcd_decimal = new System.Windows.Forms.Button();
            this.cmd_divisao = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_1
            // 
            this.cmd_1.Location = new System.Drawing.Point(12, 270);
            this.cmd_1.Name = "cmd_1";
            this.cmd_1.Size = new System.Drawing.Size(37, 33);
            this.cmd_1.TabIndex = 0;
            this.cmd_1.Text = "1";
            this.cmd_1.UseVisualStyleBackColor = true;
            this.cmd_1.Click += new System.EventHandler(this.cmd_1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 33);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmd_igual
            // 
            this.cmd_igual.Location = new System.Drawing.Point(184, 270);
            this.cmd_igual.Name = "cmd_igual";
            this.cmd_igual.Size = new System.Drawing.Size(39, 72);
            this.cmd_igual.TabIndex = 2;
            this.cmd_igual.Text = "=";
            this.cmd_igual.UseVisualStyleBackColor = true;
            this.cmd_igual.Click += new System.EventHandler(this.cmd_igual_Click);
            // 
            // cmd_0
            // 
            this.cmd_0.Location = new System.Drawing.Point(12, 309);
            this.cmd_0.Name = "cmd_0";
            this.cmd_0.Size = new System.Drawing.Size(80, 31);
            this.cmd_0.TabIndex = 3;
            this.cmd_0.Text = "0";
            this.cmd_0.UseVisualStyleBackColor = true;
            this.cmd_0.Click += new System.EventHandler(this.cmd_0_Click);
            this.cmd_0.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.cmd_0_ControlAdded);
            // 
            // cmd_4
            // 
            this.cmd_4.Location = new System.Drawing.Point(12, 231);
            this.cmd_4.Name = "cmd_4";
            this.cmd_4.Size = new System.Drawing.Size(37, 33);
            this.cmd_4.TabIndex = 4;
            this.cmd_4.Text = "4";
            this.cmd_4.UseVisualStyleBackColor = true;
            this.cmd_4.Click += new System.EventHandler(this.cmd_4_Click);
            // 
            // cmd_7
            // 
            this.cmd_7.Location = new System.Drawing.Point(12, 192);
            this.cmd_7.Name = "cmd_7";
            this.cmd_7.Size = new System.Drawing.Size(37, 33);
            this.cmd_7.TabIndex = 5;
            this.cmd_7.Text = "7";
            this.cmd_7.UseVisualStyleBackColor = true;
            this.cmd_7.Click += new System.EventHandler(this.cmd_7_Click);
            // 
            // cmd_5
            // 
            this.cmd_5.Location = new System.Drawing.Point(55, 231);
            this.cmd_5.Name = "cmd_5";
            this.cmd_5.Size = new System.Drawing.Size(37, 33);
            this.cmd_5.TabIndex = 6;
            this.cmd_5.Text = "5";
            this.cmd_5.UseVisualStyleBackColor = true;
            this.cmd_5.Click += new System.EventHandler(this.cmd_5_Click);
            // 
            // cmd_8
            // 
            this.cmd_8.Location = new System.Drawing.Point(55, 192);
            this.cmd_8.Name = "cmd_8";
            this.cmd_8.Size = new System.Drawing.Size(37, 33);
            this.cmd_8.TabIndex = 7;
            this.cmd_8.Text = "8";
            this.cmd_8.UseVisualStyleBackColor = true;
            this.cmd_8.Click += new System.EventHandler(this.cmd_8_Click);
            // 
            // cmd_9
            // 
            this.cmd_9.Location = new System.Drawing.Point(98, 192);
            this.cmd_9.Name = "cmd_9";
            this.cmd_9.Size = new System.Drawing.Size(37, 33);
            this.cmd_9.TabIndex = 8;
            this.cmd_9.Text = "9";
            this.cmd_9.UseVisualStyleBackColor = true;
            this.cmd_9.Click += new System.EventHandler(this.cmd_9_Click);
            // 
            // cmd_6
            // 
            this.cmd_6.Location = new System.Drawing.Point(98, 231);
            this.cmd_6.Name = "cmd_6";
            this.cmd_6.Size = new System.Drawing.Size(37, 33);
            this.cmd_6.TabIndex = 9;
            this.cmd_6.Text = "6";
            this.cmd_6.UseVisualStyleBackColor = true;
            this.cmd_6.Click += new System.EventHandler(this.cmd_6_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(98, 270);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(37, 33);
            this.button11.TabIndex = 10;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // cmd_multiplicar
            // 
            this.cmd_multiplicar.Location = new System.Drawing.Point(141, 270);
            this.cmd_multiplicar.Name = "cmd_multiplicar";
            this.cmd_multiplicar.Size = new System.Drawing.Size(37, 33);
            this.cmd_multiplicar.TabIndex = 11;
            this.cmd_multiplicar.Text = "x";
            this.cmd_multiplicar.UseVisualStyleBackColor = true;
            this.cmd_multiplicar.Click += new System.EventHandler(this.cmd_multiplicar_Click);
            // 
            // cmd_soma
            // 
            this.cmd_soma.Location = new System.Drawing.Point(141, 231);
            this.cmd_soma.Name = "cmd_soma";
            this.cmd_soma.Size = new System.Drawing.Size(37, 33);
            this.cmd_soma.TabIndex = 12;
            this.cmd_soma.Text = "+";
            this.cmd_soma.UseVisualStyleBackColor = true;
            this.cmd_soma.Click += new System.EventHandler(this.cmd_soma_Click);
            // 
            // cmd_subtrair
            // 
            this.cmd_subtrair.Location = new System.Drawing.Point(141, 192);
            this.cmd_subtrair.Name = "cmd_subtrair";
            this.cmd_subtrair.Size = new System.Drawing.Size(37, 33);
            this.cmd_subtrair.TabIndex = 13;
            this.cmd_subtrair.Text = "-";
            this.cmd_subtrair.UseVisualStyleBackColor = true;
            this.cmd_subtrair.Click += new System.EventHandler(this.cmd_subtrair_Click);
            // 
            // mcd_decimal
            // 
            this.mcd_decimal.Location = new System.Drawing.Point(98, 309);
            this.mcd_decimal.Name = "mcd_decimal";
            this.mcd_decimal.Size = new System.Drawing.Size(37, 33);
            this.mcd_decimal.TabIndex = 14;
            this.mcd_decimal.Text = ",";
            this.mcd_decimal.UseVisualStyleBackColor = true;
            // 
            // cmd_divisao
            // 
            this.cmd_divisao.Location = new System.Drawing.Point(141, 309);
            this.cmd_divisao.Name = "cmd_divisao";
            this.cmd_divisao.Size = new System.Drawing.Size(37, 33);
            this.cmd_divisao.TabIndex = 15;
            this.cmd_divisao.Text = "/";
            this.cmd_divisao.UseVisualStyleBackColor = true;
            this.cmd_divisao.Click += new System.EventHandler(this.cmd_divisao_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 124);
            this.listBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 17;
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmd_divisao);
            this.Controls.Add(this.mcd_decimal);
            this.Controls.Add(this.cmd_subtrair);
            this.Controls.Add(this.cmd_soma);
            this.Controls.Add(this.cmd_multiplicar);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.cmd_6);
            this.Controls.Add(this.cmd_9);
            this.Controls.Add(this.cmd_8);
            this.Controls.Add(this.cmd_5);
            this.Controls.Add(this.cmd_7);
            this.Controls.Add(this.cmd_4);
            this.Controls.Add(this.cmd_0);
            this.Controls.Add(this.cmd_igual);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmd_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmd_igual;
        private System.Windows.Forms.Button cmd_0;
        private System.Windows.Forms.Button cmd_4;
        private System.Windows.Forms.Button cmd_7;
        private System.Windows.Forms.Button cmd_5;
        private System.Windows.Forms.Button cmd_8;
        private System.Windows.Forms.Button cmd_9;
        private System.Windows.Forms.Button cmd_6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button cmd_multiplicar;
        private System.Windows.Forms.Button cmd_soma;
        private System.Windows.Forms.Button cmd_subtrair;
        private System.Windows.Forms.Button mcd_decimal;
        private System.Windows.Forms.Button cmd_divisao;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}


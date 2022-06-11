namespace Form_Calculadora
{
    partial class F_Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Calculadora));
            this.Lbl_Display = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Igual = new System.Windows.Forms.Button();
            this.Btn_OpAdi = new System.Windows.Forms.Button();
            this.Btn_CasaDec = new System.Windows.Forms.Button();
            this.Btn_Num0 = new System.Windows.Forms.Button();
            this.Btn_OpSub = new System.Windows.Forms.Button();
            this.Btn_Num3 = new System.Windows.Forms.Button();
            this.Btn_Num2 = new System.Windows.Forms.Button();
            this.Btn_Num1 = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_OpMut = new System.Windows.Forms.Button();
            this.Btn_Num6 = new System.Windows.Forms.Button();
            this.Btn_Num5 = new System.Windows.Forms.Button();
            this.Btn_Num4 = new System.Windows.Forms.Button();
            this.Btn_AllClear = new System.Windows.Forms.Button();
            this.Btn_OpDiv = new System.Windows.Forms.Button();
            this.Btn_Num9 = new System.Windows.Forms.Button();
            this.Btn_Num8 = new System.Windows.Forms.Button();
            this.Btn_Num7 = new System.Windows.Forms.Button();
            this.Lbl_Conta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Display
            // 
            this.Lbl_Display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Display.AutoEllipsis = true;
            this.Lbl_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Lbl_Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Display.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Display.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Lbl_Display.Location = new System.Drawing.Point(7, 41);
            this.Lbl_Display.Name = "Lbl_Display";
            this.Lbl_Display.Size = new System.Drawing.Size(354, 48);
            this.Lbl_Display.TabIndex = 0;
            this.Lbl_Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Btn_Igual);
            this.panel1.Controls.Add(this.Btn_OpAdi);
            this.panel1.Controls.Add(this.Btn_CasaDec);
            this.panel1.Controls.Add(this.Btn_Num0);
            this.panel1.Controls.Add(this.Btn_OpSub);
            this.panel1.Controls.Add(this.Btn_Num3);
            this.panel1.Controls.Add(this.Btn_Num2);
            this.panel1.Controls.Add(this.Btn_Num1);
            this.panel1.Controls.Add(this.Btn_Clear);
            this.panel1.Controls.Add(this.Btn_OpMut);
            this.panel1.Controls.Add(this.Btn_Num6);
            this.panel1.Controls.Add(this.Btn_Num5);
            this.panel1.Controls.Add(this.Btn_Num4);
            this.panel1.Controls.Add(this.Btn_AllClear);
            this.panel1.Controls.Add(this.Btn_OpDiv);
            this.panel1.Controls.Add(this.Btn_Num9);
            this.panel1.Controls.Add(this.Btn_Num8);
            this.panel1.Controls.Add(this.Btn_Num7);
            this.panel1.Controls.Add(this.Lbl_Display);
            this.panel1.Controls.Add(this.Lbl_Conta);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 347);
            this.panel1.TabIndex = 1;
            // 
            // Btn_Igual
            // 
            this.Btn_Igual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_Igual.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Igual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_Igual.Location = new System.Drawing.Point(295, 230);
            this.Btn_Igual.Name = "Btn_Igual";
            this.Btn_Igual.Size = new System.Drawing.Size(66, 114);
            this.Btn_Igual.TabIndex = 20;
            this.Btn_Igual.Text = "=";
            this.Btn_Igual.UseVisualStyleBackColor = false;
            this.Btn_Igual.Click += new System.EventHandler(this.Btn_Igual_Click);
            // 
            // Btn_OpAdi
            // 
            this.Btn_OpAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_OpAdi.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OpAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_OpAdi.Location = new System.Drawing.Point(223, 290);
            this.Btn_OpAdi.Name = "Btn_OpAdi";
            this.Btn_OpAdi.Size = new System.Drawing.Size(66, 54);
            this.Btn_OpAdi.TabIndex = 19;
            this.Btn_OpAdi.Text = "+";
            this.Btn_OpAdi.UseVisualStyleBackColor = false;
            this.Btn_OpAdi.Click += new System.EventHandler(this.ObtemOpDigitada);
            // 
            // Btn_CasaDec
            // 
            this.Btn_CasaDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_CasaDec.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CasaDec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_CasaDec.Location = new System.Drawing.Point(151, 290);
            this.Btn_CasaDec.Name = "Btn_CasaDec";
            this.Btn_CasaDec.Size = new System.Drawing.Size(66, 54);
            this.Btn_CasaDec.TabIndex = 18;
            this.Btn_CasaDec.Text = ",";
            this.Btn_CasaDec.UseVisualStyleBackColor = false;
            this.Btn_CasaDec.Click += new System.EventHandler(this.AdicionaNumAoDisplay);
            // 
            // Btn_Num0
            // 
            this.Btn_Num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_Num0.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Num0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_Num0.Location = new System.Drawing.Point(7, 290);
            this.Btn_Num0.Name = "Btn_Num0";
            this.Btn_Num0.Size = new System.Drawing.Size(138, 54);
            this.Btn_Num0.TabIndex = 16;
            this.Btn_Num0.Text = "0";
            this.Btn_Num0.UseVisualStyleBackColor = false;
            this.Btn_Num0.Click += new System.EventHandler(this.AdicionaNumAoDisplay);
            // 
            // Btn_OpSub
            // 
            this.Btn_OpSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_OpSub.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OpSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_OpSub.Location = new System.Drawing.Point(223, 230);
            this.Btn_OpSub.Name = "Btn_OpSub";
            this.Btn_OpSub.Size = new System.Drawing.Size(66, 54);
            this.Btn_OpSub.TabIndex = 14;
            this.Btn_OpSub.Text = "-";
            this.Btn_OpSub.UseVisualStyleBackColor = false;
            this.Btn_OpSub.Click += new System.EventHandler(this.ObtemOpDigitada);
            // 
            // Btn_Num3
            // 
            this.Btn_Num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_Num3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Num3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_Num3.Location = new System.Drawing.Point(151, 230);
            this.Btn_Num3.Name = "Btn_Num3";
            this.Btn_Num3.Size = new System.Drawing.Size(66, 54);
            this.Btn_Num3.TabIndex = 13;
            this.Btn_Num3.Text = "3";
            this.Btn_Num3.UseVisualStyleBackColor = false;
            this.Btn_Num3.Click += new System.EventHandler(this.AdicionaNumAoDisplay);
            // 
            // Btn_Num2
            // 
            this.Btn_Num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_Num2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Num2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_Num2.Location = new System.Drawing.Point(79, 230);
            this.Btn_Num2.Name = "Btn_Num2";
            this.Btn_Num2.Size = new System.Drawing.Size(66, 54);
            this.Btn_Num2.TabIndex = 12;
            this.Btn_Num2.Text = "2";
            this.Btn_Num2.UseVisualStyleBackColor = false;
            this.Btn_Num2.Click += new System.EventHandler(this.AdicionaNumAoDisplay);
            // 
            // Btn_Num1
            // 
            this.Btn_Num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_Num1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Num1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_Num1.Location = new System.Drawing.Point(7, 230);
            this.Btn_Num1.Name = "Btn_Num1";
            this.Btn_Num1.Size = new System.Drawing.Size(66, 54);
            this.Btn_Num1.TabIndex = 11;
            this.Btn_Num1.Text = "1";
            this.Btn_Num1.UseVisualStyleBackColor = false;
            this.Btn_Num1.Click += new System.EventHandler(this.AdicionaNumAoDisplay);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_Clear.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_Clear.Location = new System.Drawing.Point(295, 170);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(66, 54);
            this.Btn_Clear.TabIndex = 10;
            this.Btn_Clear.Text = "C";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_OpMut
            // 
            this.Btn_OpMut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_OpMut.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OpMut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_OpMut.Location = new System.Drawing.Point(223, 170);
            this.Btn_OpMut.Name = "Btn_OpMut";
            this.Btn_OpMut.Size = new System.Drawing.Size(66, 54);
            this.Btn_OpMut.TabIndex = 9;
            this.Btn_OpMut.Text = "*";
            this.Btn_OpMut.UseVisualStyleBackColor = false;
            this.Btn_OpMut.Click += new System.EventHandler(this.ObtemOpDigitada);
            // 
            // Btn_Num6
            // 
            this.Btn_Num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_Num6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Num6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_Num6.Location = new System.Drawing.Point(151, 170);
            this.Btn_Num6.Name = "Btn_Num6";
            this.Btn_Num6.Size = new System.Drawing.Size(66, 54);
            this.Btn_Num6.TabIndex = 8;
            this.Btn_Num6.Text = "6";
            this.Btn_Num6.UseVisualStyleBackColor = false;
            this.Btn_Num6.Click += new System.EventHandler(this.AdicionaNumAoDisplay);
            // 
            // Btn_Num5
            // 
            this.Btn_Num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_Num5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Num5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_Num5.Location = new System.Drawing.Point(79, 170);
            this.Btn_Num5.Name = "Btn_Num5";
            this.Btn_Num5.Size = new System.Drawing.Size(66, 54);
            this.Btn_Num5.TabIndex = 7;
            this.Btn_Num5.Text = "5";
            this.Btn_Num5.UseVisualStyleBackColor = false;
            this.Btn_Num5.Click += new System.EventHandler(this.AdicionaNumAoDisplay);
            // 
            // Btn_Num4
            // 
            this.Btn_Num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_Num4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Num4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_Num4.Location = new System.Drawing.Point(7, 170);
            this.Btn_Num4.Name = "Btn_Num4";
            this.Btn_Num4.Size = new System.Drawing.Size(66, 54);
            this.Btn_Num4.TabIndex = 6;
            this.Btn_Num4.Text = "4";
            this.Btn_Num4.UseVisualStyleBackColor = false;
            this.Btn_Num4.Click += new System.EventHandler(this.AdicionaNumAoDisplay);
            // 
            // Btn_AllClear
            // 
            this.Btn_AllClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_AllClear.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AllClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_AllClear.Location = new System.Drawing.Point(295, 110);
            this.Btn_AllClear.Name = "Btn_AllClear";
            this.Btn_AllClear.Size = new System.Drawing.Size(66, 54);
            this.Btn_AllClear.TabIndex = 5;
            this.Btn_AllClear.Text = "AC";
            this.Btn_AllClear.UseVisualStyleBackColor = false;
            this.Btn_AllClear.Click += new System.EventHandler(this.Btn_AllClear_Click);
            // 
            // Btn_OpDiv
            // 
            this.Btn_OpDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_OpDiv.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OpDiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_OpDiv.Location = new System.Drawing.Point(223, 110);
            this.Btn_OpDiv.Name = "Btn_OpDiv";
            this.Btn_OpDiv.Size = new System.Drawing.Size(66, 54);
            this.Btn_OpDiv.TabIndex = 4;
            this.Btn_OpDiv.Text = "/";
            this.Btn_OpDiv.UseVisualStyleBackColor = false;
            this.Btn_OpDiv.Click += new System.EventHandler(this.ObtemOpDigitada);
            // 
            // Btn_Num9
            // 
            this.Btn_Num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_Num9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Num9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_Num9.Location = new System.Drawing.Point(151, 110);
            this.Btn_Num9.Name = "Btn_Num9";
            this.Btn_Num9.Size = new System.Drawing.Size(66, 54);
            this.Btn_Num9.TabIndex = 3;
            this.Btn_Num9.Text = "9";
            this.Btn_Num9.UseVisualStyleBackColor = false;
            this.Btn_Num9.Click += new System.EventHandler(this.AdicionaNumAoDisplay);
            // 
            // Btn_Num8
            // 
            this.Btn_Num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_Num8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Num8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_Num8.Location = new System.Drawing.Point(79, 110);
            this.Btn_Num8.Name = "Btn_Num8";
            this.Btn_Num8.Size = new System.Drawing.Size(66, 54);
            this.Btn_Num8.TabIndex = 2;
            this.Btn_Num8.Text = "8";
            this.Btn_Num8.UseVisualStyleBackColor = false;
            this.Btn_Num8.Click += new System.EventHandler(this.AdicionaNumAoDisplay);
            // 
            // Btn_Num7
            // 
            this.Btn_Num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Btn_Num7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Num7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Btn_Num7.Location = new System.Drawing.Point(7, 110);
            this.Btn_Num7.Name = "Btn_Num7";
            this.Btn_Num7.Size = new System.Drawing.Size(66, 54);
            this.Btn_Num7.TabIndex = 1;
            this.Btn_Num7.Text = "7";
            this.Btn_Num7.UseVisualStyleBackColor = false;
            this.Btn_Num7.Click += new System.EventHandler(this.AdicionaNumAoDisplay);
            // 
            // Lbl_Conta
            // 
            this.Lbl_Conta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Conta.AutoEllipsis = true;
            this.Lbl_Conta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Lbl_Conta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Conta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Lbl_Conta.Location = new System.Drawing.Point(7, 0);
            this.Lbl_Conta.Name = "Lbl_Conta";
            this.Lbl_Conta.Size = new System.Drawing.Size(354, 41);
            this.Lbl_Conta.TabIndex = 21;
            this.Lbl_Conta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // F_Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(390, 370);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Igual;
        private System.Windows.Forms.Button Btn_OpAdi;
        private System.Windows.Forms.Button Btn_CasaDec;
        private System.Windows.Forms.Button Btn_Num0;
        private System.Windows.Forms.Button Btn_OpSub;
        private System.Windows.Forms.Button Btn_Num3;
        private System.Windows.Forms.Button Btn_Num2;
        private System.Windows.Forms.Button Btn_Num1;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_OpMut;
        private System.Windows.Forms.Button Btn_Num6;
        private System.Windows.Forms.Button Btn_Num5;
        private System.Windows.Forms.Button Btn_Num4;
        private System.Windows.Forms.Button Btn_AllClear;
        private System.Windows.Forms.Button Btn_OpDiv;
        private System.Windows.Forms.Button Btn_Num9;
        private System.Windows.Forms.Button Btn_Num8;
        private System.Windows.Forms.Button Btn_Num7;
        private System.Windows.Forms.Label Lbl_Display;
        private System.Windows.Forms.Label Lbl_Conta;
    }
}


namespace CS_scientific_Calculator02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResult = new TextBox();
            BtnBS = new Button();
            BtnClear = new Button();
            BtnClearEntry = new Button();
            BtnPM = new Button();
            BtnPlus = new Button();
            Btn9 = new Button();
            Btn8 = new Button();
            Btn7 = new Button();
            BtnMinus = new Button();
            Btn6 = new Button();
            Btn5 = new Button();
            Btn4 = new Button();
            BtnMuti = new Button();
            Btn3 = new Button();
            Btn2 = new Button();
            Btn1 = new Button();
            BtnDiv = new Button();
            BtnEquals = new Button();
            Btndot = new Button();
            Btn0 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            scientificToolStripMenuItem = new ToolStripMenuItem();
            simpleToolStripMenuItem = new ToolStripMenuItem();
            BtnPi = new Button();
            BtnLog = new Button();
            BtnSq = new Button();
            Btnx2 = new Button();
            Btnx3 = new Button();
            BtnDec = new Button();
            BtnSin = new Button();
            BtnSinh = new Button();
            Btnlnx = new Button();
            BtnHex = new Button();
            BtnTan = new Button();
            BtnTanh = new Button();
            Btn1x = new Button();
            BtnBin = new Button();
            BtnCos = new Button();
            BtnCosh = new Button();
            BtnPer = new Button();
            BtnOct = new Button();
            BtnMod = new Button();
            BtnExp = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Location = new Point(12, 27);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(330, 39);
            txtResult.TabIndex = 0;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnBS
            // 
            BtnBS.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBS.Location = new Point(12, 75);
            BtnBS.Name = "BtnBS";
            BtnBS.Size = new Size(78, 71);
            BtnBS.TabIndex = 1;
            BtnBS.Text = "⌫";
            BtnBS.UseVisualStyleBackColor = true;
            BtnBS.Click += BtnBS_Click;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnClear.Location = new Point(96, 75);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(78, 71);
            BtnClear.TabIndex = 2;
            BtnClear.Text = "CE";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnClearEntry
            // 
            BtnClearEntry.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnClearEntry.Location = new Point(180, 75);
            BtnClearEntry.Name = "BtnClearEntry";
            BtnClearEntry.Size = new Size(78, 71);
            BtnClearEntry.TabIndex = 3;
            BtnClearEntry.Text = "C";
            BtnClearEntry.UseVisualStyleBackColor = true;
            BtnClearEntry.Click += BtnClearEntry_Click;
            // 
            // BtnPM
            // 
            BtnPM.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPM.Location = new Point(264, 75);
            BtnPM.Name = "BtnPM";
            BtnPM.Size = new Size(78, 71);
            BtnPM.TabIndex = 4;
            BtnPM.Text = "±";
            BtnPM.UseVisualStyleBackColor = true;
            BtnPM.Click += BtnPM_Click;
            // 
            // BtnPlus
            // 
            BtnPlus.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPlus.Location = new Point(264, 152);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(78, 71);
            BtnPlus.TabIndex = 8;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = true;
            BtnPlus.Click += NumberOper;
            // 
            // Btn9
            // 
            Btn9.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn9.Location = new Point(180, 152);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(78, 71);
            Btn9.TabIndex = 7;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += EnterNumbers;
            // 
            // Btn8
            // 
            Btn8.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn8.Location = new Point(96, 152);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(78, 71);
            Btn8.TabIndex = 6;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += EnterNumbers;
            // 
            // Btn7
            // 
            Btn7.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn7.Location = new Point(12, 152);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(78, 71);
            Btn7.TabIndex = 5;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += EnterNumbers;
            // 
            // BtnMinus
            // 
            BtnMinus.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMinus.Location = new Point(264, 229);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(78, 71);
            BtnMinus.TabIndex = 12;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = true;
            BtnMinus.Click += NumberOper;
            // 
            // Btn6
            // 
            Btn6.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn6.Location = new Point(180, 229);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(78, 71);
            Btn6.TabIndex = 11;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += EnterNumbers;
            // 
            // Btn5
            // 
            Btn5.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn5.Location = new Point(96, 229);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(78, 71);
            Btn5.TabIndex = 10;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += EnterNumbers;
            // 
            // Btn4
            // 
            Btn4.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn4.Location = new Point(12, 229);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(78, 71);
            Btn4.TabIndex = 9;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += EnterNumbers;
            // 
            // BtnMuti
            // 
            BtnMuti.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMuti.Location = new Point(264, 306);
            BtnMuti.Name = "BtnMuti";
            BtnMuti.Size = new Size(78, 71);
            BtnMuti.TabIndex = 16;
            BtnMuti.Text = "*";
            BtnMuti.UseVisualStyleBackColor = true;
            BtnMuti.Click += NumberOper;
            // 
            // Btn3
            // 
            Btn3.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn3.Location = new Point(180, 306);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(78, 71);
            Btn3.TabIndex = 15;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += EnterNumbers;
            // 
            // Btn2
            // 
            Btn2.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn2.Location = new Point(96, 306);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(78, 71);
            Btn2.TabIndex = 14;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += EnterNumbers;
            // 
            // Btn1
            // 
            Btn1.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn1.Location = new Point(12, 306);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(78, 71);
            Btn1.TabIndex = 13;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += EnterNumbers;
            // 
            // BtnDiv
            // 
            BtnDiv.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDiv.Location = new Point(264, 383);
            BtnDiv.Name = "BtnDiv";
            BtnDiv.Size = new Size(78, 71);
            BtnDiv.TabIndex = 20;
            BtnDiv.Text = "/";
            BtnDiv.UseVisualStyleBackColor = true;
            BtnDiv.Click += NumberOper;
            // 
            // BtnEquals
            // 
            BtnEquals.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEquals.Location = new Point(180, 383);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(78, 71);
            BtnEquals.TabIndex = 19;
            BtnEquals.Text = "=";
            BtnEquals.UseVisualStyleBackColor = true;
            BtnEquals.Click += BtnEquals_Click;
            // 
            // Btndot
            // 
            Btndot.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btndot.Location = new Point(96, 383);
            Btndot.Name = "Btndot";
            Btndot.Size = new Size(78, 71);
            Btndot.TabIndex = 18;
            Btndot.Text = ".";
            Btndot.UseVisualStyleBackColor = true;
            Btndot.Click += EnterNumbers;
            // 
            // Btn0
            // 
            Btn0.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn0.Location = new Point(12, 383);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(78, 71);
            Btn0.TabIndex = 17;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += EnterNumbers;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(751, 24);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scientificToolStripMenuItem, simpleToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // scientificToolStripMenuItem
            // 
            scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            scientificToolStripMenuItem.Size = new Size(123, 22);
            scientificToolStripMenuItem.Text = "Scientific";
            scientificToolStripMenuItem.Click += ScientificToolStripMenuItem_Click;
            // 
            // simpleToolStripMenuItem
            // 
            simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            simpleToolStripMenuItem.Size = new Size(123, 22);
            simpleToolStripMenuItem.Text = "Standard";
            simpleToolStripMenuItem.Click += StandardToolStripMenuItem_Click;
            // 
            // BtnPi
            // 
            BtnPi.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPi.Location = new Point(376, 75);
            BtnPi.Name = "BtnPi";
            BtnPi.Size = new Size(78, 71);
            BtnPi.TabIndex = 22;
            BtnPi.Text = "π";
            BtnPi.UseVisualStyleBackColor = true;
            BtnPi.Click += BtnPi_Click;
            // 
            // BtnLog
            // 
            BtnLog.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLog.Location = new Point(460, 75);
            BtnLog.Name = "BtnLog";
            BtnLog.Size = new Size(78, 71);
            BtnLog.TabIndex = 23;
            BtnLog.Text = "Log";
            BtnLog.UseVisualStyleBackColor = true;
            BtnLog.Click += BtnLog_Click;
            // 
            // BtnSq
            // 
            BtnSq.Font = new Font("Malgun Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSq.Location = new Point(544, 75);
            BtnSq.Name = "BtnSq";
            BtnSq.Size = new Size(78, 71);
            BtnSq.TabIndex = 24;
            BtnSq.Text = "Sqrt";
            BtnSq.UseVisualStyleBackColor = true;
            BtnSq.Click += BtnSq_Click;
            // 
            // Btnx2
            // 
            Btnx2.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btnx2.Location = new Point(628, 75);
            Btnx2.Name = "Btnx2";
            Btnx2.Size = new Size(78, 71);
            Btnx2.TabIndex = 25;
            Btnx2.Text = "x²";
            Btnx2.UseVisualStyleBackColor = true;
            Btnx2.Click += Btnx2_Click;
            // 
            // Btnx3
            // 
            Btnx3.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btnx3.Location = new Point(628, 152);
            Btnx3.Name = "Btnx3";
            Btnx3.Size = new Size(78, 71);
            Btnx3.TabIndex = 29;
            Btnx3.Text = "x³";
            Btnx3.UseVisualStyleBackColor = true;
            // 
            // BtnDec
            // 
            BtnDec.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDec.Location = new Point(544, 152);
            BtnDec.Name = "BtnDec";
            BtnDec.Size = new Size(78, 71);
            BtnDec.TabIndex = 28;
            BtnDec.Text = "Dec";
            BtnDec.UseVisualStyleBackColor = true;
            BtnDec.Click += BtnDec_Click;
            // 
            // BtnSin
            // 
            BtnSin.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSin.Location = new Point(460, 152);
            BtnSin.Name = "BtnSin";
            BtnSin.Size = new Size(78, 71);
            BtnSin.TabIndex = 27;
            BtnSin.Text = "Sin";
            BtnSin.UseVisualStyleBackColor = true;
            BtnSin.Click += BtnSin_Click;
            // 
            // BtnSinh
            // 
            BtnSinh.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSinh.Location = new Point(376, 152);
            BtnSinh.Name = "BtnSinh";
            BtnSinh.Size = new Size(78, 71);
            BtnSinh.TabIndex = 26;
            BtnSinh.Text = "Sinh";
            BtnSinh.UseVisualStyleBackColor = true;
            BtnSinh.Click += BtnSinh_Click;
            // 
            // Btnlnx
            // 
            Btnlnx.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btnlnx.Location = new Point(628, 306);
            Btnlnx.Name = "Btnlnx";
            Btnlnx.Size = new Size(78, 71);
            Btnlnx.TabIndex = 37;
            Btnlnx.Text = "ln x";
            Btnlnx.UseVisualStyleBackColor = true;
            // 
            // BtnHex
            // 
            BtnHex.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtnHex.Location = new Point(544, 306);
            BtnHex.Name = "BtnHex";
            BtnHex.Size = new Size(78, 71);
            BtnHex.TabIndex = 36;
            BtnHex.Text = "Hex";
            BtnHex.UseVisualStyleBackColor = true;
            BtnHex.Click += BtnHex_Click;
            // 
            // BtnTan
            // 
            BtnTan.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTan.Location = new Point(460, 306);
            BtnTan.Name = "BtnTan";
            BtnTan.Size = new Size(78, 71);
            BtnTan.TabIndex = 35;
            BtnTan.Text = "Tan";
            BtnTan.UseVisualStyleBackColor = true;
            // 
            // BtnTanh
            // 
            BtnTanh.Font = new Font("Malgun Gothic", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTanh.Location = new Point(376, 306);
            BtnTanh.Name = "BtnTanh";
            BtnTanh.Size = new Size(78, 71);
            BtnTanh.TabIndex = 34;
            BtnTanh.Text = "Tanh";
            BtnTanh.UseVisualStyleBackColor = true;
            // 
            // Btn1x
            // 
            Btn1x.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn1x.Location = new Point(628, 229);
            Btn1x.Name = "Btn1x";
            Btn1x.Size = new Size(78, 71);
            Btn1x.TabIndex = 33;
            Btn1x.Text = "1/x";
            Btn1x.UseVisualStyleBackColor = true;
            // 
            // BtnBin
            // 
            BtnBin.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBin.Location = new Point(544, 229);
            BtnBin.Name = "BtnBin";
            BtnBin.Size = new Size(78, 71);
            BtnBin.TabIndex = 32;
            BtnBin.Text = "Bin";
            BtnBin.UseVisualStyleBackColor = true;
            BtnBin.Click += BtnBin_Click;
            // 
            // BtnCos
            // 
            BtnCos.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCos.Location = new Point(460, 229);
            BtnCos.Name = "BtnCos";
            BtnCos.Size = new Size(78, 71);
            BtnCos.TabIndex = 31;
            BtnCos.Text = "Cos";
            BtnCos.UseVisualStyleBackColor = true;
            // 
            // BtnCosh
            // 
            BtnCosh.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCosh.Location = new Point(376, 229);
            BtnCosh.Name = "BtnCosh";
            BtnCosh.Size = new Size(78, 71);
            BtnCosh.TabIndex = 30;
            BtnCosh.Text = "Cosh";
            BtnCosh.UseVisualStyleBackColor = true;
            // 
            // BtnPer
            // 
            BtnPer.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPer.Location = new Point(628, 383);
            BtnPer.Name = "BtnPer";
            BtnPer.Size = new Size(78, 71);
            BtnPer.TabIndex = 41;
            BtnPer.Text = "%";
            BtnPer.UseVisualStyleBackColor = true;
            BtnPer.Click += BtnPer_Click;
            // 
            // BtnOct
            // 
            BtnOct.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOct.Location = new Point(544, 383);
            BtnOct.Name = "BtnOct";
            BtnOct.Size = new Size(78, 71);
            BtnOct.TabIndex = 40;
            BtnOct.Text = "Oct";
            BtnOct.UseVisualStyleBackColor = true;
            BtnOct.Click += BtnOct_Click;
            // 
            // BtnMod
            // 
            BtnMod.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMod.Location = new Point(460, 383);
            BtnMod.Name = "BtnMod";
            BtnMod.Size = new Size(78, 71);
            BtnMod.TabIndex = 39;
            BtnMod.Text = "Mod";
            BtnMod.UseVisualStyleBackColor = true;
            // 
            // BtnExp
            // 
            BtnExp.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExp.Location = new Point(376, 383);
            BtnExp.Name = "BtnExp";
            BtnExp.Size = new Size(78, 71);
            BtnExp.TabIndex = 38;
            BtnExp.Text = "Exp";
            BtnExp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 483);
            Controls.Add(BtnPer);
            Controls.Add(BtnOct);
            Controls.Add(BtnMod);
            Controls.Add(BtnExp);
            Controls.Add(Btnlnx);
            Controls.Add(BtnHex);
            Controls.Add(BtnTan);
            Controls.Add(BtnTanh);
            Controls.Add(Btn1x);
            Controls.Add(BtnBin);
            Controls.Add(BtnCos);
            Controls.Add(BtnCosh);
            Controls.Add(Btnx3);
            Controls.Add(BtnDec);
            Controls.Add(BtnSin);
            Controls.Add(BtnSinh);
            Controls.Add(Btnx2);
            Controls.Add(BtnSq);
            Controls.Add(BtnLog);
            Controls.Add(BtnPi);
            Controls.Add(BtnDiv);
            Controls.Add(BtnEquals);
            Controls.Add(Btndot);
            Controls.Add(Btn0);
            Controls.Add(BtnMuti);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(BtnMinus);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(BtnPlus);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(BtnPM);
            Controls.Add(BtnClearEntry);
            Controls.Add(BtnClear);
            Controls.Add(BtnBS);
            Controls.Add(txtResult);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += EnterNumbers;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button BtnBS;
        private Button BtnClear;
        private Button BtnClearEntry;
        private Button BtnPM;
        private Button BtnPlus;
        private Button Btn9;
        private Button Btn8;
        private Button Btn7;
        private Button BtnMinus;
        private Button Btn6;
        private Button Btn5;
        private Button Btn4;
        private Button BtnMuti;
        private Button Btn3;
        private Button Btn2;
        private Button Btn1;
        private Button BtnDiv;
        private Button BtnEquals;
        private Button Btndot;
        private Button Btn0;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private ToolStripMenuItem simpleToolStripMenuItem;
        private Button BtnPi;
        private Button BtnLog;
        private Button BtnSq;
        private Button Btnx2;
        private Button Btnx3;
        private Button BtnDec;
        private Button BtnSin;
        private Button BtnSinh;
        private Button Btnlnx;
        private Button BtnHex;
        private Button BtnTan;
        private Button BtnTanh;
        private Button Btn1x;
        private Button BtnBin;
        private Button BtnCos;
        private Button BtnCosh;
        private Button BtnPer;
        private Button BtnOct;
        private Button BtnMod;
        private Button BtnExp;
    }
}
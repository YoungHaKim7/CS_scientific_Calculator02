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
            btnBS = new Button();
            btnClear = new Button();
            btnClearEntry = new Button();
            btnPM = new Button();
            btnPlus = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnMinus = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMuti = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDiv = new Button();
            btnEquals = new Button();
            btndot = new Button();
            btn0 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            scientificToolStripMenuItem = new ToolStripMenuItem();
            simpleToolStripMenuItem = new ToolStripMenuItem();
            btnPi = new Button();
            btnLog = new Button();
            btnSq = new Button();
            btnx2 = new Button();
            btnx3 = new Button();
            btnDec = new Button();
            btnSin = new Button();
            btnSinh = new Button();
            btnlnx = new Button();
            btnHex = new Button();
            btnTan = new Button();
            btnTanh = new Button();
            btn1x = new Button();
            btnBin = new Button();
            btnCos = new Button();
            btnCosh = new Button();
            btnPer = new Button();
            btnOct = new Button();
            btnMod = new Button();
            btnExp = new Button();
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
            // btnBS
            // 
            btnBS.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBS.Location = new Point(12, 75);
            btnBS.Name = "btnBS";
            btnBS.Size = new Size(78, 71);
            btnBS.TabIndex = 1;
            btnBS.Text = "⌫";
            btnBS.UseVisualStyleBackColor = true;
            btnBS.Click += BtnBS_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(96, 75);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 71);
            btnClear.TabIndex = 2;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearEntry.Location = new Point(180, 75);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(78, 71);
            btnClearEntry.TabIndex = 3;
            btnClearEntry.Text = "C";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += BtnClearEntry_Click;
            // 
            // btnPM
            // 
            btnPM.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPM.Location = new Point(264, 75);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(78, 71);
            btnPM.TabIndex = 4;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += BtnPM_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(264, 152);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(78, 71);
            btnPlus.TabIndex = 8;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += NumberOper;
            // 
            // btn9
            // 
            btn9.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(180, 152);
            btn9.Name = "btn9";
            btn9.Size = new Size(78, 71);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += EnterNumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(96, 152);
            btn8.Name = "btn8";
            btn8.Size = new Size(78, 71);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += EnterNumbers;
            // 
            // btn7
            // 
            btn7.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 152);
            btn7.Name = "btn7";
            btn7.Size = new Size(78, 71);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += EnterNumbers;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.Location = new Point(264, 229);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(78, 71);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += NumberOper;
            // 
            // btn6
            // 
            btn6.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(180, 229);
            btn6.Name = "btn6";
            btn6.Size = new Size(78, 71);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += EnterNumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(96, 229);
            btn5.Name = "btn5";
            btn5.Size = new Size(78, 71);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += EnterNumbers;
            // 
            // btn4
            // 
            btn4.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 229);
            btn4.Name = "btn4";
            btn4.Size = new Size(78, 71);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += EnterNumbers;
            // 
            // btnMuti
            // 
            btnMuti.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMuti.Location = new Point(264, 306);
            btnMuti.Name = "btnMuti";
            btnMuti.Size = new Size(78, 71);
            btnMuti.TabIndex = 16;
            btnMuti.Text = "*";
            btnMuti.UseVisualStyleBackColor = true;
            btnMuti.Click += NumberOper;
            // 
            // btn3
            // 
            btn3.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(180, 306);
            btn3.Name = "btn3";
            btn3.Size = new Size(78, 71);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += EnterNumbers;
            // 
            // btn2
            // 
            btn2.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(96, 306);
            btn2.Name = "btn2";
            btn2.Size = new Size(78, 71);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += EnterNumbers;
            // 
            // btn1
            // 
            btn1.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 306);
            btn1.Name = "btn1";
            btn1.Size = new Size(78, 71);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += EnterNumbers;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(264, 383);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(78, 71);
            btnDiv.TabIndex = 20;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += NumberOper;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(180, 383);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(78, 71);
            btnEquals.TabIndex = 19;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += BtnEquals_Click;
            // 
            // btndot
            // 
            btndot.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btndot.Location = new Point(96, 383);
            btndot.Name = "btndot";
            btndot.Size = new Size(78, 71);
            btndot.TabIndex = 18;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = true;
            btndot.Click += EnterNumbers;
            // 
            // btn0
            // 
            btn0.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(12, 383);
            btn0.Name = "btn0";
            btn0.Size = new Size(78, 71);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += EnterNumbers;
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
            // btnPi
            // 
            btnPi.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPi.Location = new Point(376, 75);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(78, 71);
            btnPi.TabIndex = 22;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = true;
            btnPi.Click += BtnPi_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLog.Location = new Point(460, 75);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(78, 71);
            btnLog.TabIndex = 23;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += BtnLog_Click;
            // 
            // btnSq
            // 
            btnSq.Font = new Font("Malgun Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSq.Location = new Point(544, 75);
            btnSq.Name = "btnSq";
            btnSq.Size = new Size(78, 71);
            btnSq.TabIndex = 24;
            btnSq.Text = "Sqrt";
            btnSq.UseVisualStyleBackColor = true;
            btnSq.Click += BtnSq_Click;
            // 
            // btnx2
            // 
            btnx2.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnx2.Location = new Point(628, 75);
            btnx2.Name = "btnx2";
            btnx2.Size = new Size(78, 71);
            btnx2.TabIndex = 25;
            btnx2.Text = "x²";
            btnx2.UseVisualStyleBackColor = true;
            btnx2.Click += Btnx2_Click;
            // 
            // btnx3
            // 
            btnx3.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnx3.Location = new Point(628, 152);
            btnx3.Name = "btnx3";
            btnx3.Size = new Size(78, 71);
            btnx3.TabIndex = 29;
            btnx3.Text = "x³";
            btnx3.UseVisualStyleBackColor = true;
            // 
            // btnDec
            // 
            btnDec.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDec.Location = new Point(544, 152);
            btnDec.Name = "btnDec";
            btnDec.Size = new Size(78, 71);
            btnDec.TabIndex = 28;
            btnDec.Text = "Dec";
            btnDec.UseVisualStyleBackColor = true;
            btnDec.Click += BtnDec_Click;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSin.Location = new Point(460, 152);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(78, 71);
            btnSin.TabIndex = 27;
            btnSin.Text = "Sin";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += BtnSin_Click;
            // 
            // btnSinh
            // 
            btnSinh.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSinh.Location = new Point(376, 152);
            btnSinh.Name = "btnSinh";
            btnSinh.Size = new Size(78, 71);
            btnSinh.TabIndex = 26;
            btnSinh.Text = "Sinh";
            btnSinh.UseVisualStyleBackColor = true;
            btnSinh.Click += BtnSinh_Click;
            // 
            // btnlnx
            // 
            btnlnx.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnlnx.Location = new Point(628, 306);
            btnlnx.Name = "btnlnx";
            btnlnx.Size = new Size(78, 71);
            btnlnx.TabIndex = 37;
            btnlnx.Text = "ln x";
            btnlnx.UseVisualStyleBackColor = true;
            // 
            // btnHex
            // 
            btnHex.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnHex.Location = new Point(544, 306);
            btnHex.Name = "btnHex";
            btnHex.Size = new Size(78, 71);
            btnHex.TabIndex = 36;
            btnHex.Text = "Hex";
            btnHex.UseVisualStyleBackColor = true;
            btnHex.Click += BtnHex_Click;
            // 
            // btnTan
            // 
            btnTan.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTan.Location = new Point(460, 306);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(78, 71);
            btnTan.TabIndex = 35;
            btnTan.Text = "Tan";
            btnTan.UseVisualStyleBackColor = true;
            // 
            // btnTanh
            // 
            btnTanh.Font = new Font("Malgun Gothic", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTanh.Location = new Point(376, 306);
            btnTanh.Name = "btnTanh";
            btnTanh.Size = new Size(78, 71);
            btnTanh.TabIndex = 34;
            btnTanh.Text = "Tanh";
            btnTanh.UseVisualStyleBackColor = true;
            // 
            // btn1x
            // 
            btn1x.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1x.Location = new Point(628, 229);
            btn1x.Name = "btn1x";
            btn1x.Size = new Size(78, 71);
            btn1x.TabIndex = 33;
            btn1x.Text = "1/x";
            btn1x.UseVisualStyleBackColor = true;
            // 
            // btnBin
            // 
            btnBin.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBin.Location = new Point(544, 229);
            btnBin.Name = "btnBin";
            btnBin.Size = new Size(78, 71);
            btnBin.TabIndex = 32;
            btnBin.Text = "Bin";
            btnBin.UseVisualStyleBackColor = true;
            btnBin.Click += BtnBin_Click;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCos.Location = new Point(460, 229);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(78, 71);
            btnCos.TabIndex = 31;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = true;
            // 
            // btnCosh
            // 
            btnCosh.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCosh.Location = new Point(376, 229);
            btnCosh.Name = "btnCosh";
            btnCosh.Size = new Size(78, 71);
            btnCosh.TabIndex = 30;
            btnCosh.Text = "Cosh";
            btnCosh.UseVisualStyleBackColor = true;
            // 
            // btnPer
            // 
            btnPer.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPer.Location = new Point(628, 383);
            btnPer.Name = "btnPer";
            btnPer.Size = new Size(78, 71);
            btnPer.TabIndex = 41;
            btnPer.Text = "%";
            btnPer.UseVisualStyleBackColor = true;
            btnPer.Click += BtnPer_Click;
            // 
            // btnOct
            // 
            btnOct.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOct.Location = new Point(544, 383);
            btnOct.Name = "btnOct";
            btnOct.Size = new Size(78, 71);
            btnOct.TabIndex = 40;
            btnOct.Text = "Oct";
            btnOct.UseVisualStyleBackColor = true;
            btnOct.Click += BtnOct_Click;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMod.Location = new Point(460, 383);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(78, 71);
            btnMod.TabIndex = 39;
            btnMod.Text = "Mod";
            btnMod.UseVisualStyleBackColor = true;
            // 
            // btnExp
            // 
            btnExp.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExp.Location = new Point(376, 383);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(78, 71);
            btnExp.TabIndex = 38;
            btnExp.Text = "Exp";
            btnExp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 483);
            Controls.Add(btnPer);
            Controls.Add(btnOct);
            Controls.Add(btnMod);
            Controls.Add(btnExp);
            Controls.Add(btnlnx);
            Controls.Add(btnHex);
            Controls.Add(btnTan);
            Controls.Add(btnTanh);
            Controls.Add(btn1x);
            Controls.Add(btnBin);
            Controls.Add(btnCos);
            Controls.Add(btnCosh);
            Controls.Add(btnx3);
            Controls.Add(btnDec);
            Controls.Add(btnSin);
            Controls.Add(btnSinh);
            Controls.Add(btnx2);
            Controls.Add(btnSq);
            Controls.Add(btnLog);
            Controls.Add(btnPi);
            Controls.Add(btnDiv);
            Controls.Add(btnEquals);
            Controls.Add(btndot);
            Controls.Add(btn0);
            Controls.Add(btnMuti);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMinus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnPlus);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnPM);
            Controls.Add(btnClearEntry);
            Controls.Add(btnClear);
            Controls.Add(btnBS);
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
        private Button btnBS;
        private Button btnClear;
        private Button btnClearEntry;
        private Button btnPM;
        private Button btnPlus;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnMinus;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnMuti;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDiv;
        private Button btnEquals;
        private Button btndot;
        private Button btn0;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private ToolStripMenuItem simpleToolStripMenuItem;
        private Button btnPi;
        private Button btnLog;
        private Button btnSq;
        private Button btnx2;
        private Button btnx3;
        private Button btnDec;
        private Button btnSin;
        private Button btnSinh;
        private Button btnlnx;
        private Button btnHex;
        private Button btnTan;
        private Button btnTanh;
        private Button btn1x;
        private Button btnBin;
        private Button btnCos;
        private Button btnCosh;
        private Button btnPer;
        private Button btnOct;
        private Button btnMod;
        private Button btnExp;
    }
}
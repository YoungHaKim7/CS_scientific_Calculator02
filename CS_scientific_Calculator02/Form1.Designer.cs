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
            btnBS.Click += btnBS_Click;
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
            btnClear.Click += btnClear_Click;
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
            btnPM.Click += btnPM_Click;
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
            btnPlus.Click += numberOper;
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
            btnMinus.Click += numberOper;
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
            btnMuti.Click += numberOper;
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
            btnDiv.Click += numberOper;
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
            btnEquals.Click += btnEquals_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
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
            Name = "Form1";
            Text = "Form1";
            Click += EnterNumbers;
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
    }
}
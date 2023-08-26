namespace CS_scientific_Calculator02
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = sender as Button;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text += num.Text;
                }
                else
                {
                    txtResult.Text += num.Text;
                }
            }
        }

        private void NumberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {

            double v = Convert.ToDouble(txtResult.Text);
            enterSecondValue = v;

            switch (op)
            {
                case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;

                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;

                case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;

                case "/":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;

                default: break;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void BtnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            String f, s;

            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 370; // 767
            txtResult.Width = 330;
        }
        private void ScientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 760;
            txtResult.Width = 690;
        }

        private void StandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 370;
            txtResult.Width = 330;
        }

        private void BtnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.14159265358979323";
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);
        }

        private void BtnSq_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Sqrt(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void Btnx2_Click(object sender, EventArgs e)
        {
            double x;

            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void BtnSinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtResult.Text);
            sh = Math.Sinh(sh);
            txtResult.Text = Convert.ToString(sh);
        }

        private void BtnSin_Click(object sender, EventArgs e)
        {

            double si = Convert.ToDouble(txtResult.Text);
            si = Math.Sin(si);
            txtResult.Text = Convert.ToString(si);
        }
         
        private void BtnPer_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);

            txtResult.Text = Convert.ToString(a);
        }

        private void BtnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);

            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtResult.Text = Convert.ToString(i2);
        }

        private void BtnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void BtnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void BtnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }
    }
}
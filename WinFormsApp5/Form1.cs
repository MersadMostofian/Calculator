namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        double num1, num2;
        string symbol;
        Boolean flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Numbers(object sender, MouseEventArgs e)
        {
            txtdisplay.Text += ((Button)sender).Text;
            btnpoint.Enabled = !txtdisplay.Text.Contains(".");
            if (flag == true)
            {
                txtdisplay.Text = "";
                flag = false;
            }
        }

        private void Operators(object sender, MouseEventArgs e)
        {
            if (symbol != null)
            {
                btnequal_Click(null, null);
            }
            num1 = Convert.ToDouble(txtdisplay.Text);
            symbol = ((Button)sender).Text;
            flag = true;
        }

        private void btnequal_Click(object sender, MouseEventArgs e)
        {
            num2 = Convert.ToDouble(txtdisplay.Text);
            txtdisplay.Text = "";
            switch (symbol)
            {
                case "+":
                    txtdisplay.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    txtdisplay.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    txtdisplay.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    txtdisplay.Text = Convert.ToString(num1 / num2);
                    break;

            }
            symbol = null;
        }

        private void btnclear_MouseClick(object sender, MouseEventArgs e)
        {
            txtdisplay.Text = "";
        }

        private void btndelet_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtdisplay.Text != "")
                txtdisplay.Text = txtdisplay.Text.Substring(0, (txtdisplay.Text.Length) - 1);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button temp = new Button();
            temp.Text = e.KeyChar.ToString();
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.')
                Numbers(temp, null);
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                Operators(temp, null);
            else if (e.KeyChar == '=')
                btnequal_Click(null, null);
            else if (e.KeyChar.ToString() == "\u0008")
                btndelet_MouseClick(null, null);
            else if (e.KeyChar.ToString() == "\u2421")
                btnclear_MouseClick(null, null);

            foreach (Button btn in panel1.Controls)
            {
                if (btn.Text == e.KeyChar.ToString())
                {
                    btn.Focus();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnequal_Click(null, null);
                btnequal.Focus();
            }
            if (e.KeyValue == '.')
            {
                btnpoint.Enabled = false;
            }
        }

        private void btnonoff_Click(object sender, EventArgs e)
        {
            panel1.Enabled = !panel1.Enabled;
            if (btnonoff.Text == "ON")
            {
                btnonoff.Text = "OFF";
                this.KeyPreview = true;
            }
            else
            {
                btnonoff.Text = "ON";
                this.KeyPreview = false;
            }
        }
    }
}
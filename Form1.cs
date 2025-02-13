namespace CALC_MATH
{
    public partial class Form1 : Form
    {
        float vResultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
            lblResultado.Text = vResultado.ToString();
            lblZigno.Text = "+";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text);
            lblResultado.Text = vResultado.ToString();
            lblZigno.Text = "-";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtNum2.Text);
            lblResultado.Text = vResultado.ToString();
            lblZigno.Text = "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) / Convert.ToInt32(txtNum2.Text);
            lblResultado.Text = vResultado.ToString();
            lblZigno.Text = "/";
        }

        private void txtNum1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResultado.Text = "000";
            lblZigno.Text = "□";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

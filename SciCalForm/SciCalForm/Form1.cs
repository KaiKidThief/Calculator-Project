using System.Runtime.Intrinsics.Arm;

namespace SciCalForm
{
    public partial class CALCULATOR : Form
    {
        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 + num2;
            textBoxResult.Text = result.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 - num2;
            textBoxResult.Text = result.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 * num2;
            textBoxResult.Text = result.ToString();

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 / num2;
            textBoxResult.Text = result.ToString();

        }

        private void buttonModulo_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 % num2;
            textBoxResult.Text = result.ToString();

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            bool result = (num1 == num2);
            textBoxResult.Text = result.ToString();

        }

        private void buttonGreaterThan_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            bool result = (num1 > num2);
            textBoxResult.Text = result.ToString();

        }

        private void buttonLessThan_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            bool result = (num1 < num2);
            textBoxResult.Text = result.ToString();

        }

        private void buttonGreaterEqual_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            bool result = (num1 >= num2);
            textBoxResult.Text = result.ToString();

        }

        private void buttonLessEqual_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            bool result = (num1 <= num2);
            textBoxResult.Text = result.ToString();

        }

        private void buttonNotEqual_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            bool result = (num1 != num2);
            textBoxResult.Text = result.ToString();

        }

        private void buttonAND_Click(object sender, EventArgs e)
        {
            try
            {
                bool num1 = Convert.ToBoolean(textBox1.Text);
                bool num2 = Convert.ToBoolean(textBox2.Text);
                bool result = (num1 && num2);
                textBoxResult.Text = result.ToString().ToUpper();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }


        }

        private void buttonOR_Click(object sender, EventArgs e)
        {
            try
            {
                bool num1 = Convert.ToBoolean(textBox1.Text);
                bool num2 = Convert.ToBoolean(textBox2.Text);
                bool result = (num1 || num2);
                textBoxResult.Text = result.ToString().ToUpper();
            }
            catch (FormatException)
            {

               MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonNOT_Click(object sender, EventArgs e)
        {

            try
            {
                bool num1 = Convert.ToBoolean(textBox1.Text);
                bool num2 = Convert.ToBoolean(textBox2.Text);
                bool result = (!(num1&&num2 ));
                textBoxResult.Text = result.ToString().ToUpper();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonSimpleAss_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = (num1 = num2);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonAddAss_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = (num1 += num2);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonSubtractAss_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = (num1 -= num2);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonMultiplyAdd_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = (num1 *= num2);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonDivisionAss_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = (num1 /= num2);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonModuloAss_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = (num1 %= num2);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonLeftShiftAss_Click(object sender, EventArgs e)
        {

            try
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                int result = num1 <<= num2;
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonRightShiftAss_Click(object sender, EventArgs e)
        {

            try
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                int result = num1 >>= num2;
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonBitwiseAndAss_Click(object sender, EventArgs e)
        {

            try
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                int result = num1 &= num2;
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonBitwiseExclusiveAss_Click(object sender, EventArgs e)
        {

            try
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                int result = num1 ^= num2;
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonBitwiseInclusiveOrAss_Click(object sender, EventArgs e)
        {

            try
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                int result = num1 |= num2;
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonPI_Click(object sender, EventArgs e)
        {

            try
            {
                double result = Math.PI;
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input");

            }

        }

        private void buttonE_Click(object sender, EventArgs e)
        {

            try
            {
                double result = Math.E;
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input");

            }

        }

        private void buttonMaxClass_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = Math.Max(num1,num2);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonMinClass_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = Math.Min(num1, num2);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill two text box to achieve the result");

            }

        }

        private void buttonSquareRootAss_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Sqrt(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input");

            }
        }

        private void buttonAbsolutePower_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Abs(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill Only One Text Box");

            }

        }

        private void buttonRound_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Round(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill Only One Text Box to round of a Desire Number");

            }

        }

        private void buttonCosine_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Cos(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill Only One Text Box");

            }

        }

        private void buttonSin_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Sin(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill Only One Text Box");

            }

        }

        private void buttonTangent_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Tan(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill Only One Text Box");

            }

        }

        private void buttonAsin_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Asin(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill Only One Text Box");

            }

        }

        private void buttonAcos_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Acos(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill Only One Text Box");

            }

        }

        private void buttonAtan_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Atan(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill Only One Text Box");

            }

        }

        private void buttonFLoor_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Floor(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill Only One Text Box");

            }

        }

        private void buttonLog_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Log(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill Only One Text Box");

            }

        }

        private void buttonLog10_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Log10(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill Only One Text Box");

            }

        }

        private void buttonExponent_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double result = Math.Exp(num1);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Error!! Invalid Input Please fill Only One Text Box");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void timerColor_Tick(object sender, EventArgs e)
        {


        }
    }
}
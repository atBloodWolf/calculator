namespace WinFormsApp1
{
    public partial class Form1 : Form

    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        private bool isOperationPeroformed;

        public bool IsOperationPerformed { get => isOperationPerformed; set => isOperationPerformed = value; }

        public Form1()
        {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Button_click(object sender, EventArgs e)
        {
            isOperationPerformed = false;
            if (textBox_Result.Text == "0")
            {
                object value =  isOperationPeroformed;
            }

            textBox_Result.Clear();
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text=resultValue + " " + operationPerformed;
            isOperationPerformed = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
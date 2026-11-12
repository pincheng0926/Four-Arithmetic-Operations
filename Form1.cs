namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            bool result1, result2;

            result1 = int.TryParse(textBox1.Text, out num1);
            result2 = int.TryParse(textBox3.Text, out num2);
            if (result1 == true && result2 == true)
            {
                switch (textBox2.Text)
                {
                    case "+":  //判斷運算子是否為「+」
                        num1 += num2;
                        break;
                    case "-":  //判斷運算子是否為「-」
                        num1 -= num2;
                        break;
                    case "*":  //判斷運算子是否為「*」
                        num1 *= num2;
                        break;
                    case "/":  //判斷運算子是否為「/」
                        if (num2 != 0)  //判斷除數是否不為0
                            num1 /= num2;
                        else
                            label4.Text = "除數不可為0";
                        result1 = false;
                        break;
                    default:  //不符合上列條件者為錯誤的輸入
                       label4.Text = "輸入錯誤：限輸入四則運算子(+,-,*,/)";
                        result1 = false;
                        break;
                }
                if (result1 == true)
                    label4.Text = $"{textBox1.Text} {textBox2.Text} {textBox3.Text} = {num1}";
            }
            else
                label4.Text = "輸入錯誤：請輸入整數數值";
        }
    }
    }


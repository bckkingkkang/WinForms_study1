using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kahyun_WinFormsApp1.practice
{
    public partial class Form3 : Form
    {
        enum Operators
        {
            None,
            Plus,
            Minus,
            Multiply,
            Divide,
            Result
        }
        
        // 초기값 세팅
        // 열거형 변수
        Operators currentOperator = Operators.None;
        // 연산자가 눌렸는지 확인
        Boolean operatorChangeFlag = false;
        int firstOper = 0;
        int secondOper = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 결과(=) 버튼 클릭 시
            secondOper = Int32.Parse(display.Text);

            if (currentOperator == Operators.Plus)
            {
                firstOper += secondOper;
                display.Text = firstOper.ToString();
            }
            else if (currentOperator == Operators.Minus)
            {
                firstOper -= secondOper;
                display.Text = firstOper.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOper *= secondOper;
                display.Text = firstOper.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOper == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    firstOper /= secondOper;
                    display.Text = firstOper.ToString();
                }
            }
        }


        // 연산자 버튼 클릭 시
        private void btnPlus_Click(object sender, EventArgs e)
        {
            // 덧셈
            firstOper = Int32.Parse(display.Text);
            currentOperator = Operators.Plus;
            operatorChangeFlag = true;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            // 곱셈
            firstOper = Int32.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            // 뺄셈
            firstOper = Int32.Parse(display.Text);
            currentOperator = Operators.Minus;
            operatorChangeFlag = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            // 나눗셈
            firstOper = Int32.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "0";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            /*String strNumber = display.Text += "1";*/

            // 1. "1"을 display.Text에 덧붙인다.
            display.Text = display.Text + "1";

            // 2. 덧붙인 결과를 strNumber 변수에 저장한다.
            String strNumber = display.Text;

            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            String strNumber = display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            firstOper = 0;
            secondOper = 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }
    }
}

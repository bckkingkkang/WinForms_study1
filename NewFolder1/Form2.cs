using System;

using System.Windows.Forms;

namespace kahyun_WinFormsApp1
{
    public partial class Form2 : Form
    {
        // 정답
        private int answer = 0;
        // 기회
        private int chance = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void startBtn(object sender, EventArgs e)
        {
            // 시작 버튼 클릭 시 랜덤 변수 생성
            var rand = new Random();
            // 1 이상 6 미만
            answer = rand.Next(1, 6);
            chance = 10;
            display.Text = "정답을 입력하세요";
        }

        // 입력 버튼 클릭 시
        private void inputBtn_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(inputNum.Text);

            if (num == answer)
            {
                display.Text = "WIN";
            } else
            {
                // 기회 1회 감소
                chance--;
                display.Text = "오답입니다. 기회는 " + chance + "번 남았습니다.";
            }

            if(chance <= 0)
            {
                display.Text = "LOSE";
            }

        }
    }
}

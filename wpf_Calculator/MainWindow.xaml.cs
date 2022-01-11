using System.Windows;
using System.Windows.Controls;

namespace wpf_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool newButton;     // 새로 숫자가 시작되어야 하는 것을 알려주는 flag
        private char myOperator;    // 현재 계산할 Operator
        private double savedValue;  // 4칙 연산자를 누르면 txtResult 값을 저장
        private double num = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        // 숫자 버튼의 처리
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();
            if (txtResult.Text == "0" || newButton == true)
            {
                txtResult.Text = number;
                newButton = false;
            }
            else
            {
                txtResult.Text = txtResult.Text + number;
            }

        }

        private void btnOp_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            savedValue = double.Parse(txtResult.Text);
            myOperator = btn.Content.ToString()[0];
            newButton = true;
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text.Contains(".") == false)
                txtResult.Text += ".";
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            if (myOperator == '+')
            {
                txtResult.Text = (savedValue + double.Parse(txtResult.Text)).ToString();
            }
        }

        // 'C' 버튼을 누르면 계산 초기화
        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            myOperator = btn.Content.ToString()[0];
            if (myOperator == 'C')
            {
                txtResult.Text = "0";
                savedValue = 0;
            }
        }
    }
}

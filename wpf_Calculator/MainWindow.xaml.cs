using System.Windows;
using System.Windows.Controls;

namespace wpf_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

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

            saveValue = double.Parse(txtResult.Text);
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
    }
}

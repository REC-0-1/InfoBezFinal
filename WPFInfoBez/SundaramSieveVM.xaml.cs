using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFInfoBez
{
    /// <summary>
    /// Логика взаимодействия для SundaramSieveVM.xaml
    /// </summary>
    public partial class SundaramSieveVM : UserControl
    {
        public SundaramSieveVM()
        {
            InitializeComponent();
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            int numberN = Convert.ToInt32(NumberN.Text);

            for (int i = 1; i <= (Math.Sqrt(2 * numberN + 1) - 1) / 2; i++)
            {
                for (int j = i; j <= (numberN - i) / (2 * i + 1); j++)
                {
                    int num = i + j + 2 * i * j;
                    if (num <= numberN)
                    {
                        FilterBox.Text += $"Исключаем число: {num}\n";
                    }
                    else
                    {
                        int result = 2 * num + 1;
                        FilterBox.Text += $"Обрабатываем оставшееся число: {result}\n";
                    }
                }
            }
        }
    }
}

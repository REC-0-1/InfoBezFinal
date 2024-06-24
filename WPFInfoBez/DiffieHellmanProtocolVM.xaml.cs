using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
    /// Логика взаимодействия для DiffieHellmanProtocolVM.xaml
    /// </summary>
    public partial class DiffieHellmanProtocolVM : UserControl
    {
        public DiffieHellmanProtocolVM()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Генерация простого числа p и генератора g
            BigInteger p =DiffieHellmanProtocol.GeneratePrimeNumber();
            BigInteger g = DiffieHellmanProtocol.GenerateGenerator(p);

            // Генерация секретных ключей x и y
            BigInteger x = DiffieHellmanProtocol.GenerateSecretKey(p);
            BigInteger y = DiffieHellmanProtocol.GenerateSecretKey(p);

            // Вычисление открытых ключей Ka и Kb
            BigInteger Ka = BigInteger.ModPow(g, x, p);
            BigInteger Kb = BigInteger.ModPow(g, y, p);

            // Вычисление общего секретного ключа
            BigInteger K = BigInteger.ModPow(Kb, x, p);

            KeyA.Text = Convert.ToString(Ka);
            KeyB.Text = Convert.ToString(Kb);
            AiBKey.Text = Convert.ToString(K);
        }
    }
}

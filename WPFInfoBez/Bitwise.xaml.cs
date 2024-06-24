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
    /// Логика взаимодействия для Bitwise.xaml
    /// </summary>
    public partial class Bitwise : UserControl
    {
        public Bitwise()
        {
            InitializeComponent();
        }

        private void CryptBut_Click(object sender, RoutedEventArgs e)
        {
            string originalText = TextCode.Text;

            string result = CharacterProcessing.Encrypt(originalText);

            Crypted.Text = result;
        }

        private void DecryptBut_Click(object sender, RoutedEventArgs e)
        {
            string CruptedText = Crypted.Text;

            string result = CharacterProcessing.Decrypt(CruptedText);

            Decrypted.Text = result;
        }
    }
}

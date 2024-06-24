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
    /// Логика взаимодействия для AffinCaesarVM.xaml
    /// </summary>
    public partial class AffinCaesarVM : UserControl
    {
        public AffinCaesarVM()
        {
            InitializeComponent();
        }

        private void CryptBut_Click(object sender, RoutedEventArgs e)
        {
            int A = Convert.ToInt32(parA.Text);
            int B = Convert.ToInt32(ParB.Text);
            string OriginalText = TextCrypted.Text;

            string encryptedMessage =  AffinCaesar.Encrypt(OriginalText, A, B);

            CrypText.Text = encryptedMessage;
           

        }

        private void DecryptBut_Click(object sender, RoutedEventArgs e)
        {
            int A = Convert.ToInt32(parA.Text);
            int B = Convert.ToInt32(ParB.Text);
            string encryptedMessage = CrypText.Text;

            string decodingMessage = AffinCaesar.Decrypt(encryptedMessage, A, B);

            DecryptText.Text = decodingMessage;
        }
    }
}

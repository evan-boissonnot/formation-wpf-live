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

namespace DecouverteBinding
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.UpdateSizeOfTextBox();
        }

        private void txtTailleFont_KeyDown(object sender, KeyEventArgs e)
        {
            this.UpdateSizeOfTextBox();
        }

        private void UpdateSizeOfTextBox()
        {
            this.UpdateSizeOfTextBox(this.lblInfo, this.txtTailleFont);
        }

        private void UpdateSizeOfTextBox(Label label, TextBox textBox)
        {
            int size = 0;

            int.TryParse(this.txtTailleFont.Text, out size);
            label.FontSize = size == 0 ? 50 : size;
        }
    }
}

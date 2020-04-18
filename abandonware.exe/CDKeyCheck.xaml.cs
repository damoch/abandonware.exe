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
using System.Windows.Shapes;

namespace abandonware.exe
{
    /// <summary>
    /// Logika interakcji dla klasy CDKeyCheck.xaml
    /// </summary>
    public partial class CDKeyCheck : Window
    {
        private const string _cdkey = "F0RR-TH33-EV1L-G0D5";
        public Action FinishAction { get; set; }
        public CDKeyCheck()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(cdkeyTextBox.Text != _cdkey)
            {
                MessageBox.Show("Incorrect CD-Key", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                FinishAction.Invoke();
                Close();
            }
        }
    }
}

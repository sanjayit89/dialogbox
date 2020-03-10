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

namespace ResponsiveLayout
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

        private void btnADD_Click(object sender, RoutedEventArgs e)
        {
            //txtMessageListInput.Text = txtDCCHInput.Text;
            txtMessageListInput.Items.Add(txtDCCHInput.Text);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            string lstCount = txtMessageListInput.SelectedItem.ToString();
            MessageBox.Show(lstCount);
        }

        private void btnAnalyze_Click(object sender, RoutedEventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            dialogBox.ShowDialog();
            
        }
    }
 }


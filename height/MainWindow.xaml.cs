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

namespace height
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private list contr;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            contr = new list();
        }

        /// <summary>
        /// загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            list controller = new list();
            cb.ItemsSource = controller.Sex;
            tb1.Text = "1";
            tb2.Text = "1";
        }

        private void cal(object sender, RoutedEventArgs e)
        {
            if (cb.SelectedIndex < 0 || cb.SelectedIndex > cb.Items.Count)
            {
                MessageBox.Show("Неверные  параметры ");
                return;
            }



            try
            {
                var valuetb1 = Convert.ToDouble(tb1.Text);
                var valuetb2 = Convert.ToDouble(tb2.Text);


                double boy = (valuetb1 + valuetb2) / 2 + 6;
                double girl = (valuetb1 + valuetb2) / 2 - 6;


                string v = cb.SelectedItem.ToString();
                if (v == "Девочка")
                {
                    otvet.Content = $"{girl} приблизительный \n\tрост ребенка"; ;
                }
                else if (v == "Мальчик")
                {
                    otvet.Content = $"{boy} приблизительный \n\tрост ребенка"; ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
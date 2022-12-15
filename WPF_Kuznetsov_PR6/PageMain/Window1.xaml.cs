using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Kuznetsov_PR6.PageMain
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        DateTime d1;
        DateTime d2;
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan x = d2 - d1;
            txbBlock.Text = ("Вы отдохнете " + x + "дней");
        }

        private void date2_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            d2 = date2.SelectedDate.Value;
        }

        private void date1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            d1 = date1.SelectedDate.Value;
        }
    }
}

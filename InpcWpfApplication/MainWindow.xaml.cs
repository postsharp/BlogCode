using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using InpcWpfApplication.DTO;
using InpcWpfApplication.ModelView;

namespace InpcWpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Address address = new Address();
        private Customer customer1;

        public MainWindow()
        {
         
            customer1 = new Customer() { Address = address };
            InitializeComponent();

            this.customer1Control.DataContext = new CustomerModelView(customer1);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            customer1.Reset();
        }
    }
}

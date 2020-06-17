using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Microsoft.Toolkit.Uwp.UI.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DataGridUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            List<Customer> customers = GetCustomers();
            dataGrid1.ItemsSource = customers;
        }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>(new Customer[4] {
                new Customer("Abigail", "Adams", "100 Elm Street"),
                new Customer("Bill", "Bailey", "220 Maple Drive"),
                new Customer("Charlie", "Chaplin", "330 Hickory Drive"),
                new Customer("Don", "Drysdale", "44 Pine Street")
                });
        }

        private void dataGrid1_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;

            // All of the columns will be text columns
            DataGridTextColumn column = e.Column as DataGridTextColumn;

            dataGrid1ColumnNamesTextBlock.Text += Environment.NewLine + column.Header;
        }

    }
}

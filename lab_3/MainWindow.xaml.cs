﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using lab1_E.View;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab1_E
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AccountPlan_OnClick(object sender, RoutedEventArgs e)
        {
            WindowAccountPlan accountPlan = new WindowAccountPlan();
            accountPlan.Show();
        }
        private void Deal_OnClick(object sender, RoutedEventArgs e)
        {
            WindowDeal deal = new WindowDeal();
            deal.Show();
        }
        private void Operation_OnClick(object sender, RoutedEventArgs e)
        {
            WindowOperation operation = new WindowOperation();
            operation.Show();
        }
        private void SubAccount_OnClick(object sender, RoutedEventArgs e)
        {
            WindowSubAccount subAccount = new WindowSubAccount();
            subAccount.Show();
        }
    }
}

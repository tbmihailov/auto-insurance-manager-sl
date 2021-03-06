﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Messaging;
using AutoInsurance.Messages;

namespace AutoInsurance.Views
{
    public partial class InsurancePolicy : Page
    {
        public InsurancePolicy()
        {
            InitializeComponent();
            RegisterMessage();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void RegisterMessage()
        {
            Messenger.Default.Register<SaveInsuarancePolicyMessageDialog>(this, OnSaveInsuarancePolicy);
        }

        private void OnSaveInsuarancePolicy(SaveInsuarancePolicyMessageDialog msg)
        {
            MessageBox.Show(msg.Content, msg.Caption, msg.Button);
        }
    }
}

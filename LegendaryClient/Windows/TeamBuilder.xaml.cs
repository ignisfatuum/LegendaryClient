﻿using System;
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

namespace LegendaryClient.Windows
{
    /// <summary>
    /// Interaction logic for TeamBuilder.xaml
    /// </summary>
    public partial class TeamBuilder : Page
    {
        public TeamBuilder(bool iscreater)
        {
            InitializeComponent();
            if (iscreater == false)
            {
                Invite.IsEnabled = false;
            }
        }
    }
}

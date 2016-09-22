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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tracer_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static GridLength menuLength;
        private static ColumnDefinition menuMargin;
        private static bool menuIsOpen = false;

        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void gearImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (!menuIsOpen)
            {
                menuLength = MenuColumn.Width;
                MenuColumn.Width = new GridLength(60, GridUnitType.Pixel);
                btnToRight(btnOpenFile);
                btnToRight(btnSaveFile);
                menuIsOpen = true;
            }
            else
            {
                MenuColumn.Width = menuLength;
                menuIsOpen = false;
            }
        }

        private void btnToRight(TextBlock btn)
        {
            btn.FontSize = 10;
            btn.Margin = new Thickness(150, btn.Margin.Top, 0, 0);
            btn.TextAlignment = TextAlignment.Right;
            btn.Width = 60;
        }
    }
}

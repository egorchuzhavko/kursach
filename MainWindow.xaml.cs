using project.Classes;
using project.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Windows;
using MySqlConnector;
using System.Net;
using System.Windows.Input;

namespace project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Product> basket { get; set; }
        public static User user;

        public MainWindow(User u)
        {
            InitializeComponent();
            basket = new List<Product>();
            user = u;
            UserShowNickname.Text = user.Login;
        }

        private void Button_Click(object sender, RoutedEventArgs e)//Выход из проги
        {
            this.Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}

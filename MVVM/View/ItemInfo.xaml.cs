using project.Classes;
using System.Windows;

namespace project.MVVM.View
{
    public partial class ItemInfo : Window
    {
        public ItemInfo()
        {
            InitializeComponent();
        }
        public ItemInfo(Product product)
        {
            InitializeComponent();
            DataContext = product;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

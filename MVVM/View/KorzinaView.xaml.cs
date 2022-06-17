using project.Classes;
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

namespace project.MVVM.View
{
    public partial class KorzinaView : UserControl
    {
        public int ind = 0;
        public static List<Product> basketproducts { get; set; }
        public KorzinaView()
        {
            InitializeComponent();
            basketproducts = new List<Product>();
            ComboMode.SelectedIndex = 0;
            basketproducts = MainWindow.basket;
            BasketList.ItemsSource = basketproducts;
        }

        private void MonVib_Selected(object sender, RoutedEventArgs e)//Множественный выбор выделения элементов
        {
            BasketList.SelectionMode = SelectionMode.Multiple;
        }

        private void OdVib_Selected(object sender, RoutedEventArgs e)//Одиночный выбор выделения элементов
        {
            BasketList.SelectionMode = SelectionMode.Single;
        }

        private void ListViewStuf_MouseDoubleClick(object sender, MouseButtonEventArgs e)//даблклик на элемент списка
        {
            if (ComboMode.SelectedIndex == 0)
            {
                ind = BasketList.SelectedIndex;
                ItemInfo check = new ItemInfo(basketproducts[ind]);
                check.ShowDialog();
            }
            else
            {
                MessageBox.Show("Переключите режим выборки на одиночный, чтобы смотреть информацию об предмете", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearBasket_Click(object sender, RoutedEventArgs e)// очистка корзицы
        {
            MainWindow.basket.Clear();
            basketproducts = MainWindow.basket;
            BasketList.ItemsSource = null;
            BasketList.Items.Clear();
        }

        private void ClearItemsFromBasket_Click(object sender, RoutedEventArgs e)//удалить объекты из корзины
        {
            foreach(var item in BasketList.SelectedItems)
            {
                foreach(var stuf in basketproducts)
                {
                    if ((item as Product).Id == stuf.Id)
                    {
                        basketproducts.Remove(stuf);
                        break;
                    }
                }
            }
            BasketList.ItemsSource = null;
            BasketList.Items.Clear();
            BasketList.ItemsSource=basketproducts;
        }

        private void OformZakaz_Click(object sender, RoutedEventArgs e)
        {
            if (basketproducts.Count == 0)
                MessageBox.Show("Вам необходимо заполнить корзину хотя бы 1 предметом для аренды!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                MakeOrder mo = new MakeOrder(this);
                mo.ShowDialog();
            }
        }
    }
}

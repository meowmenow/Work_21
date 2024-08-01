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

namespace Адовые_интерфейсы__19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dob(object sender, RoutedEventArgs e)
        {
            listdrist.Items.Add(spis.Text); //Добавление в список из поля ввода
        }

        private void del(object sender, RoutedEventArgs e)
        {
            listdrist.Items.RemoveAt(listdrist.SelectedIndex); //Удаление записи
        }

        private void clear(object sender, RoutedEventArgs e)
        {
            listdrist.Items.Clear(); //Очистка списка
        }

        private void zap(object sender, RoutedEventArgs e) //Заполнение заданным количеством
        {
            Random rnd = new Random(); //Создаём рандомные объекты
            int i, n = Convert.ToInt32(kol.Text); 
            for (i = 1; i <= n; i++) //Заполняем в список случайных не случайностей
            {
                listdrist.Items.Add(rnd.Next(20));
            }
        }

        private void ras(object sender, RoutedEventArgs e) //Подсчёт по условию
        {
            int i, sum; //Счётчик и  сумма
            sum = 0;
            //Складываем элемент списка
            for (i = 0; i < listdrist.Items.Count; i++)
            {
                double x = Convert.ToDouble(listdrist.Items[i]);
                if (x < 15)
                {
                    sum = sum + Convert.ToInt32(listdrist.Items[i]);
                    Rez.Text = sum.ToString(); //Выводим ответ
                }

            }
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Горе-дизайнер Бирюков Георгий, ИСП-23. Вариант №6: Ввести n целых чисел. Найти сумму чисел < 15. Результат вывести на экран");
        }

        private void poka(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

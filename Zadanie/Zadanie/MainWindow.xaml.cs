using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Zadanie.Данные;
using Zadanie.Сервис;


namespace Zadanie
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList.json";
        private BindingList<Date> _toDataList;
        private FitServise _fitServise;



        public MainWindow()
        {
            InitializeComponent();

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _fitServise = new FitServise(PATH);

            try
            {
                _toDataList = _fitServise.LoadDate();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Close();
            }



            Dann.ItemsSource = _toDataList;
            _toDataList.ListChanged += _toDataList_ListChanged;

        }

        private void _toDataList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _fitServise.SaveDate(sender);

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    Close();
                }
            }


        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 w1 = new Window1();
            w1.Show();
        }


    }


}


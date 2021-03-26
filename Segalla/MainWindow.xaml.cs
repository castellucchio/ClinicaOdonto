using MaterialDesignThemes.Wpf;
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

namespace Segalla
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Desconectar_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void DarkModeToggleButton_Click(object sender, RoutedEventArgs e) => ModifyTheme(DarkModeToggleButton.IsChecked == true);
        

        private static void ModifyTheme(bool isDarkTheme)
        {
            var paletteHelper = new PaletteHelper();
            var theme = paletteHelper.GetTheme();

            theme.SetBaseTheme(isDarkTheme ? Theme.Dark : Theme.Light);
            paletteHelper.SetTheme(theme);
        }

        private void Sobre_Click(object sender, RoutedEventArgs e)
        {
            this.Panel.Navigate(new Views.Sobre());
        }

        private void Ajuda_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Inicio_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pacientes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Consultas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Financeiro_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

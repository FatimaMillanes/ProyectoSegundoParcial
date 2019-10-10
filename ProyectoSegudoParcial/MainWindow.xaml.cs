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

namespace ProyectoSegudoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool validacion = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
           
                btnGuardar.Visibility = Visibility.Visible;
                btnCancelar.Visibility = Visibility.Visible;
                gridInfo.Children.Clear();
                switch (cbItems.SelectedIndex)

                {
                    case 0:

                        gridInfo.Children.Add(new ParametrosCafes());
                        break;

                    case 1:

                        gridInfo.Children.Add(new ParamentrosTes());
                        break;

                    case 2:

                        gridInfo.Children.Add(new ParametrosTonics());
                        break;

                    case 3:

                        gridInfo.Children.Add(new ParametrosSundaes());
                        break;

                    case 4:

                        gridInfo.Children.Add(new ParametrosReposteria());
                        break;

                    case 5:

                        gridInfo.Children.Add(new ParametrosComida());
                        break;
                }
            
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            gridInfo.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if(validacion)
            {
                gridValidacion.Children.Clear();
                btnGuardar.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Hidden;
            }
            else
            {
                gridValidacion.Children.Add(new Validacion());
            }

        }
    }
}

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
     // ParametrosCafes ParametrosCafes = new ParametrosCafes();

        //public bool validacion { get; set; }
       // public int Vs { get; set; }

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
            gridValidacion.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }
 


        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            switch (cbItems.SelectedIndex)
            {
                case 0:
                    //Cafes
                    if ((
                    ((ParametrosCafes)(gridInfo.Children[0])).cbElegir.SelectedIndex == 0 ||
                    ((ParametrosCafes)(gridInfo.Children[0])).rbHelado.IsChecked == false &&
                    ((ParametrosCafes)(gridInfo.Children[0])).rbCaliente.IsChecked == false ||
                    ((ParametrosCafes)(gridInfo.Children[0])).chbSin.IsChecked == false &&
                    ((ParametrosCafes)(gridInfo.Children[0])).chbDes.IsChecked == false &&
                    ((ParametrosCafes)(gridInfo.Children[0])).chbEnt.IsChecked == false &&
                    ((ParametrosCafes)(gridInfo.Children[0])).chbSoya.IsChecked == false &&
                    ((ParametrosCafes)(gridInfo.Children[0])).chbCoc.IsChecked == false &&
                    ((ParametrosCafes)(gridInfo.Children[0])).chbAv.IsChecked == false ||
                    ((ParametrosCafes)(gridInfo.Children[0])).rbRegular.IsChecked == false &&
                    ((ParametrosCafes)(gridInfo.Children[0])).rbDescafeinado.IsChecked == false ||
                    ((ParametrosCafes)(gridInfo.Children[0])).rbChico.IsChecked == false &&
                    ((ParametrosCafes)(gridInfo.Children[0])).rbMediano.IsChecked == false &&
                    ((ParametrosCafes)(gridInfo.Children[0])).rbGrande.IsChecked == false &&
                    ((ParametrosCafes)(gridInfo.Children[0])).rbRefil.IsChecked == false ||
                    ((ParametrosCafes)(gridInfo.Children[0])).cbEndulzante.SelectedIndex == 0 ||
                    string.IsNullOrEmpty(((ParametrosCafes)(gridInfo.Children[0])).txtCodigo.Text) ||
                    string.IsNullOrEmpty(((ParametrosCafes)(gridInfo.Children[0])).txtPrecio.Text)))
                        {
                        gridValidacion.Children.Add(new Validacion());
                        }
                    else
                    {
                        gridValidacion.Children.Clear();
                        gridInfo.Children.Clear();
                        btnGuardar.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                    break;

                case 1:
                    //Tes
                    if ((
                    ((ParamentrosTes)(gridInfo.Children[0])).cbElegir.SelectedIndex == 0 ||
                    ((ParamentrosTes)(gridInfo.Children[0])).rbHelado.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).rbCaliente.IsChecked == false ||
                    ((ParamentrosTes)(gridInfo.Children[0])).chbSin.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).chbDes.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).chbEnt.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).chbSoya.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).chbCoc.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).chbAv.IsChecked == false ||
                    ((ParamentrosTes)(gridInfo.Children[0])).rbRegular.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).rbDescafeinado.IsChecked == false ||
                    ((ParamentrosTes)(gridInfo.Children[0])).rbChico.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).rbMediano.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).rbGrande.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).rbRefil.IsChecked == false ||
                    ((ParamentrosTes)(gridInfo.Children[0])).cbEndulzante.SelectedIndex == 0 ||
                    string.IsNullOrEmpty(((ParamentrosTes)(gridInfo.Children[0])).txtCodigo.Text) ||
                    string.IsNullOrEmpty(((ParamentrosTes)(gridInfo.Children[0])).txtPrecio.Text)))
                        {
                            gridValidacion.Children.Add(new Validacion());
                        }
                    else
                    {
                        gridValidacion.Children.Clear();
                        gridInfo.Children.Clear();
                        btnGuardar.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                    break;

                case 2:
                    //Tonics
                    if ((
                    ((ParametrosTonics)(gridInfo.Children[0])).cbElegir.SelectedIndex == 0 ||
                    ((ParametrosTonics)(gridInfo.Children[0])).rbHelado.IsChecked == false &&
                    ((ParametrosTonics)(gridInfo.Children[0])).rbCaliente.IsChecked == false ||
                    ((ParametrosTonics)(gridInfo.Children[0])).chbSin.IsChecked == false &&
                    ((ParametrosTonics)(gridInfo.Children[0])).chbUva.IsChecked == false &&
                    ((ParametrosTonics)(gridInfo.Children[0])).chbLim.IsChecked == false &&
                    ((ParametrosTonics)(gridInfo.Children[0])).chbFres.IsChecked == false &&
                    ((ParametrosTonics)(gridInfo.Children[0])).chbManz.IsChecked == false &&
                    ((ParametrosTonics)(gridInfo.Children[0])).chbDura.IsChecked == false ||
                    ((ParametrosTonics)(gridInfo.Children[0])).rbRegular.IsChecked == false &&
                    ((ParametrosTonics)(gridInfo.Children[0])).rbDescafeinado.IsChecked == false ||
                    ((ParametrosTonics)(gridInfo.Children[0])).rbChico.IsChecked == false &&
                    ((ParametrosTonics)(gridInfo.Children[0])).rbMediano.IsChecked == false &&
                    ((ParametrosTonics)(gridInfo.Children[0])).rbGrande.IsChecked == false &&
                    ((ParametrosTonics)(gridInfo.Children[0])).rbRefil.IsChecked == false ||
                    ((ParametrosTonics)(gridInfo.Children[0])).cbEndulzante.SelectedIndex == 0 ||
                    string.IsNullOrEmpty(((ParametrosTonics)(gridInfo.Children[0])).txtCodigo.Text) ||
                    string.IsNullOrEmpty(((ParametrosTonics)(gridInfo.Children[0])).txtPrecio.Text)))
                    {
                        gridValidacion.Children.Add(new Validacion());
                    }
                    else
                    {
                        gridValidacion.Children.Clear();
                        gridInfo.Children.Clear();
                        btnGuardar.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                    break;

                case 3:
                    //Sunddaes
                    if ((
                    ((ParametrosSundaes)(gridInfo.Children[0])).cbElegir.SelectedIndex == 0 ||
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbSin.IsChecked == false &&
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbVai.IsChecked == false &&
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbCar.IsChecked == false &&
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbMok.IsChecked == false &&
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbMap.IsChecked == false ||
                    ((ParamentrosTes)(gridInfo.Children[0])).chbSin.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).chbDes.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).chbEnt.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).chbSoya.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).chbCoc.IsChecked == false &&
                    ((ParamentrosTes)(gridInfo.Children[0])).chbAv.IsChecked == false ||
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbNo.IsChecked == false &&
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbNuez.IsChecked == false &&
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbChispas.IsChecked == false &&
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbChispch.IsChecked == false ||
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbChico.IsChecked == false &&
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbMediano.IsChecked == false &&
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbGrande.IsChecked == false &&
                    ((ParametrosSundaes)(gridInfo.Children[0])).rbRefil.IsChecked == false ||
                    ((ParametrosSundaes)(gridInfo.Children[0])).cbEndulzante.SelectedIndex == 0 ||
                    string.IsNullOrEmpty(((ParametrosSundaes)(gridInfo.Children[0])).txtCodigo.Text) ||
                    string.IsNullOrEmpty(((ParametrosSundaes)(gridInfo.Children[0])).txtPrecio.Text)))
                    {
                        gridValidacion.Children.Add(new Validacion());
                    }
                    else
                    {
                        gridValidacion.Children.Clear();
                        gridInfo.Children.Clear();
                        btnGuardar.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                   
                    break;

                case 4:
                    //Reposteria
                    if ((
                    ((ParametrosReposteria)(gridInfo.Children[0])).cbElegir.SelectedIndex == 0 ||
                    ((ParametrosReposteria)(gridInfo.Children[0])).rbCho.IsChecked == false &&
                    ((ParametrosReposteria)(gridInfo.Children[0])).rbVai.IsChecked == false &&
                    ((ParametrosReposteria)(gridInfo.Children[0])).rbFre.IsChecked == false ||
                    ((ParametrosReposteria)(gridInfo.Children[0])).chbSin.IsChecked == false &&
                    ((ParametrosReposteria)(gridInfo.Children[0])).chbDes.IsChecked == false &&
                    ((ParametrosReposteria)(gridInfo.Children[0])).chbEnt.IsChecked == false &&
                    ((ParametrosReposteria)(gridInfo.Children[0])).chbSoya.IsChecked == false ||
                    ((ParametrosReposteria)(gridInfo.Children[0])).rbRegular.IsChecked == false &&
                    ((ParametrosReposteria)(gridInfo.Children[0])).rbDescafeinado.IsChecked == false ||
                    ((ParametrosReposteria)(gridInfo.Children[0])).rbChico.IsChecked == false &&
                    ((ParametrosReposteria)(gridInfo.Children[0])).rbMediano.IsChecked == false &&
                    ((ParametrosReposteria)(gridInfo.Children[0])).rbGrande.IsChecked == false ||
                    ((ParametrosReposteria)(gridInfo.Children[0])).cbEndulzante.SelectedIndex == 0 ||
                    string.IsNullOrEmpty(((ParametrosReposteria)(gridInfo.Children[0])).txtCodigo.Text) ||
                    string.IsNullOrEmpty(((ParametrosReposteria)(gridInfo.Children[0])).txtPrecio.Text)))
                    {
                        gridValidacion.Children.Add(new Validacion());
                    }
                    else
                    {
                        gridValidacion.Children.Clear();
                        gridInfo.Children.Clear();
                        btnGuardar.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                    break;

                case 5:
                    //Comida
                    if ((
                    ((ParametrosComida)(gridInfo.Children[0])).cbElegir.SelectedIndex == 0 ||
                    ((ParametrosComida)(gridInfo.Children[0])).rbTri.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).rbInt.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).rbMai.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).rbEsp.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).rbGer.IsChecked == false ||
                    ((ParametrosComida)(gridInfo.Children[0])).chbSin.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).chbDes.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).chbEnt.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).chbSoya.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).chbCoc.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).chbAv.IsChecked == false ||
                    ((ParametrosComida)(gridInfo.Children[0])).rbNo.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).rbPo.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).rbPa.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).rbCa.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).rbJa.IsChecked == false ||
                    ((ParametrosComida)(gridInfo.Children[0])).rbChico.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).rbMediano.IsChecked == false &&
                    ((ParametrosComida)(gridInfo.Children[0])).rbGrande.IsChecked == false ||
                    ((ParametrosComida)(gridInfo.Children[0])).cbEndulzante.SelectedIndex == 0 ||
                    string.IsNullOrEmpty(((ParametrosComida)(gridInfo.Children[0])).txtCodigo.Text) ||
                    string.IsNullOrEmpty(((ParametrosComida)(gridInfo.Children[0])).txtPrecio.Text)))
                    {
                        gridValidacion.Children.Add(new Validacion());
                    }
                    else
                    {
                        gridValidacion.Children.Clear();
                        gridInfo.Children.Clear();
                        btnGuardar.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                    break;

              
            }

        }
    }
}


/* 
         if (parametrosCafes.Validacion())
         {
             validacion = true;
         }
         else
         {
             validacion = false;
         }
         
      if (string.IsNullOrEmpty(parametrosCafes.txtCodigo.Text))
            {

                Vs = 0;

            }

            else
            {

                Vs = 1;

            }
     
     */
/* public bool Validacion()
{
 if (string.IsNullOrEmpty(parametrosCafes.txtCodigo.Text))
 {
     return (validacion=false);
 }
 else
 {
     return validacion=true;
 }
}*/

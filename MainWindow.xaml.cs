using Login_Construccion.Modelo;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login_Construccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        usuariosEntities db = new usuariosEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegistroUsers Ventana = new RegistroUsers();
            Ventana.Show();
            this.Close();
            
        }

        private void Boton_Ingresar_Click(object sender, RoutedEventArgs e)
        {
            Users Usuario_Busqueda = db.Users.SingleOrDefault(
                us => us.NombreUsuario.Equals(tB1.Text));
            Users Usuario_Busqueda2 = db.Users.SingleOrDefault(
                us => us.Contraseña.Equals(pB1.Password));
            if(Usuario_Busqueda !=null && Usuario_Busqueda2 != null)
            {
                if (Usuario_Busqueda.IdUser == Usuario_Busqueda2.IdUser)
                {
                    MessageBox.Show("Exito! al Ingresar", "Erstick");
                }
                else
                {
                    MessageBox.Show("Acceso denegado", "Erstick");
                }

            }
            else { MessageBox.Show("Acceso denegado", "Erstick"); }
         





        }
    }
}

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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Login_Construccion
{
    /// <summary>
    /// Lógica de interacción para RegistroUsers.xaml
    /// </summary>
    public partial class RegistroUsers : Window
    {
        usuariosEntities db = new usuariosEntities();
        public RegistroUsers()
        {
            InitializeComponent();
        }

        private void Boton_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Ventana = new MainWindow();
            Ventana.Show();
            this.Close();
        }

        private void Boton_Registrar_Click(object sender, RoutedEventArgs e)
        {
            Users NuevoUsuario = new Users()
            {
                NombreUsuario = TextBox_Usuario.Text,
                Contraseña = PasswordBox_Usuario.Password,
                NombrePila = TextBox_Nombre.Text,
                Apellidos = TextBox_Apellidos.Text,
                Fecha_nacimiento = Convert.ToDateTime("10/09/1996"),
                Genero = Textbox_Genero.Text,
                Correo = Textbox_Correo.Text
            };
            db.Users.Add(NuevoUsuario);
            db.SaveChanges();

            MainWindow Ventana = new MainWindow();
            Ventana.Show();
            this.Close();
        }
    }
}

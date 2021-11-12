using ExamenUnidad2.Modelos.DAO;
using ExamenUnidad2.Modelos.Entidades;
using ExamenUnidad2.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUnidad2.Controladores
{
    public class LoginController
    {
        LoginView vista;

        //Creación del Constructor: 
        public LoginController(LoginView view)
        {
            vista = view;
            vista.btnAceptar.Click += new EventHandler(ValidarUsuario);
        }

        //Creación de Método Para validar si el usuario ingresado es correcto:
        private void ValidarUsuario(object serder, EventArgs e)
        {
            UsuarioDAO userDao = new UsuarioDAO();
            Usuario user = new Usuario();
            user.EMAIL = vista.txtEmail.Text;
            //user.CLAVE = EncriptarClave(vista.txtClave.Text);
            user.CLAVE = vista.txtClave.Text;

            bool valido = userDao.ValidarUsuario(user);
            if (valido)
            {
                MessageBox.Show("Usuario Correcto");
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }

        public static string EncriptarClave(string str)
        {
            string cadena = str + "MiClavePeronal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}

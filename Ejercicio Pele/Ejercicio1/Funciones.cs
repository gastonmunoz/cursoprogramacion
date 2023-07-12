namespace Ejercicio1
{
    public class Funciones
    {
        public void errorMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        
        public bool emailValido(string email)
        {
            var emailSinEspacios = email.Trim();

            if (emailSinEspacios.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr != null;
            }
            catch
            {
                return false;
            }
        }
    }
}

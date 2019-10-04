using System.Windows.Forms;
using System;


namespace Login
{
    internal class Usuario
    {

        private string name;
        private string email;
        private string estado;
        private string cidade;
        private string password;
        private string confirmPassword;

       public void setUser(string name, string email, string estado, string cidade, string password, string confirmPassword)
        {
            this.name = name;
            this.email = email;
            this.estado = estado;
            this.cidade = cidade;
            this.password = password;
            this.confirmPassword = confirmPassword;
        }
        public object getUser()
        {
           object[] userCreated = new[] { name, email, estado, cidade, password, confirmPassword };

           return userCreated;
        }
    }
}
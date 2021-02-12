using LoginConMatriz.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginConMatriz.NEGOCIO
{
    class ClsLogin
    {
        public int Acceso(Login log)
        {
            string[] Users = new string[5]{ "Carlos", "Griselda", "Walter", "Giselle", "Francisco" };
            string[] Passwords = new string[6] { "001", "001", "002", "003", "004", "005" };

            Users = Users.Distinct().ToArray();
            Passwords = Passwords.Distinct().ToArray();

            int estado = 0;

            for(int i = 0; i < Users.Length; i++)
            {
             
                if (log.User.Equals(Users[i]) && log.Password.Equals(Passwords[i]))
                {
                    estado = 1;
                }
            }
            return estado;
        }
    }
}

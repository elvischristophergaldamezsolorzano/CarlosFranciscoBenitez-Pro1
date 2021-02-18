using CarlosB01.DAO;
using CarlosB01.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosB01.NEGOCIO
{
    class ClsLogin
    {
        public int Acceso(Login log)
        {
            ClsListaUsuarios cls = new ClsListaUsuarios();

            int estado = 0;
            for (int i = 0; i < cls.Users.Length; i++)
            {
                if (log.Usuario.Equals(cls.Users[i]) && log.Password.Equals(cls.Passwords[i]))
                {
                    estado = 1;
                }
            }
            return estado;
        }

        public int accesoBidimecional(Login log)
        {
            string[][] usuarios;
            usuarios = new string[2][];
            usuarios[0] = new string[7] { "Carlos", "Griselda", "Walter", "Giselle", "Francisco", "Francisco", "Francisco" };
            usuarios[1] = new string[7] { "001", "002", "003", "004", "005", "005", "005" };

            usuarios = usuarios.Distinct().ToArray();

            int estado = 0;

            for (int i = 0; i < usuarios.Length; i++)
            {
                for (int j = 0; j < usuarios[i].Length; j++)
                {
                    if (log.Usuario.Equals(usuarios[i][j]) && log.Password.Equals(usuarios[i + 1][j]))
                    {
                        estado = 1;
                    }
                }
            }
            return estado;
        }
    }
}

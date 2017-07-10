using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Domain
{
    public class Funcionario
    {
        private int idFuncionario;
        private String nombreFuncionario;
        private String userName;
        private String password;
        private String telefonoFuncionario;
        private String emailFuncionario;
        private Rol rol;

        public Funcionario()
        {
            this.rol = new Rol();
        }//constructor

        public int IdFuncionario
        {
            get
            {
                return idFuncionario;
            }

            set
            {
                idFuncionario = value;
            }
        }

        public string NombreFuncionario
        {
            get
            {
                return nombreFuncionario;
            }

            set
            {
                nombreFuncionario = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string TelefonoFuncionario
        {
            get
            {
                return telefonoFuncionario;
            }

            set
            {
                telefonoFuncionario = value;
            }
        }

        public string EmailFuncionario
        {
            get
            {
                return emailFuncionario;
            }

            set
            {
                emailFuncionario = value;
            }
        }

        public Rol Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
            }
        }
    }//Funcionario

}//namespace

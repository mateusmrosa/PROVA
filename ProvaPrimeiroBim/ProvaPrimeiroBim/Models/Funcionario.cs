using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaPrimeiroBim.Models
{
    public class Funcionario
    {
        private string _usuario;
        private string _senha;

        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Senha { get => _senha; set => _senha = value; }

        public bool Logar(out string msg)
        {
            msg = "";
            

            if(this._usuario == "mateus" && this._senha == "123")
            {
                msg = "Usuario Correto";
            }
            else
            {
                msg = "Usuario Invalido";
            }



            return

        }
    }
}

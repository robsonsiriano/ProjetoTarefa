using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        private int id;
        private int nome;
        private int senha;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}

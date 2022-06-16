using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tarefa
    {
        private int id;
        private int id_usuario;
        private string descricao;
        private string estatus;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_Usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Estatus 
        {
            get { return estatus; }
            set { estatus = value; }
        }

    }
}

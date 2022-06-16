using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comentario
    {
        private int id;
        private int id_usuario;
        private int id_tarefa;
        private string descricao;
        

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

        public int Id_Tarefa
        {
            get { return id_tarefa; }
            set { id_tarefa = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}

using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ComentarioBLL
    {
        public Comentario Inserir(Comentario _comentario)
        {
            ComentarioDAL comentarioDAL = new ComentarioDAL();
            return comentarioDAL.Inserir(_comentario);
        }

        public DataTable Buscar(string _filtro)
        {
            ComentarioDAL comentarioDAL = new ComentarioDAL();
            return comentarioDAL.Buscar(_filtro);
        }
    }
}

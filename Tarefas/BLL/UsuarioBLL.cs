using DAL;
using System.Data;

namespace BLL
{
    public class UsuarioBLL
    {
        public DataTable BuscarUsuario(string _nome)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarUsuario(_nome);
        }

    }
}

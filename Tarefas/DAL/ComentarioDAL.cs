using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ComentarioDAL
    {
        public Comentario Inserir(Comentario _Comentario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirComentario";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _Comentario.Id;
                cmd.Parameters.Add(pid);

                SqlParameter pid_tarefa = new SqlParameter("Id_Tarefa", SqlDbType.Int);
                pid_tarefa.Value = _Comentario.Id_Tarefa;
                cmd.Parameters.Add(pid_tarefa);

                SqlParameter pid_Usuario = new SqlParameter("Id_Usuario", SqlDbType.Int);
                pid_Usuario.Value = _Comentario.Id_Usuario;
                cmd.Parameters.Add(pid_Usuario);

                SqlParameter pdescricao = new SqlParameter("Descricao", SqlDbType.VarChar);
                pdescricao.Value = _Comentario.Descricao;
                cmd.Parameters.Add(pdescricao);

                return _Comentario;

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable Buscar(string _tarefa)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarComentario";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter ptarefa = new SqlParameter("@Filtro", SqlDbType.VarChar);
                ptarefa.Value = _tarefa;

                da.SelectCommand.Parameters.Add(ptarefa);

                cn.Open();
                da.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        public bool Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirTarefa";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);



                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não foi possível excluir o usuário: " + _id.ToString());
                return true;

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}

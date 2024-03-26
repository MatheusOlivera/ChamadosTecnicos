using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TecnicoDAO
    {
        private string _conexao;

        // Metodo Construtor => Inicializa Objeto buscando Conexao
        public TecnicoDAO(string conexao)
        {
            // RECEBA Conexão 
            _conexao = conexao;
        }

        // Inserir Cliente Vulgo XUXAR
        public void IncluiTecnico(Tecnico tecnico)
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            {
                string sql = "insert into Tecnicos (Nome,Especialidade,Email,Senha,Obs) values (@Nome,@Especialidade,@Email,@Senha,@Obs)";

                using (SqlCommand comando = new SqlCommand(sql, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@Nome", tecnico.Nome);
                    comando.Parameters.AddWithValue("@Especialidade", tecnico.Especialidade);
                    comando.Parameters.AddWithValue("@Email", tecnico.Email);
                    comando.Parameters.AddWithValue("@Senha", tecnico.Senha);
                    comando.Parameters.AddWithValue("@Obs", tecnico.Obs);
                    try
                    {
                        conexaoBd.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao Incluir Tecnico:" + ex.Message);
                    }
                }

            }
        }
    }


















}


using System.Data.SqlClient;
using System.Data;

namespace PlataformaWeb.Recursos
{
    public class Comentarios
    {
        public static string cadenaConexion = "user=Marjosue12_SQLLogin_1;pwd=qbozh2ttw8;data source=Proyecto_Graduacion.mssql.somee.com;Initial Catalog=proyecto_graduacion;";
        public static DataTable ingresaComentario(string nombreProcedimiento, List<ParametrosComentarios> parametros = null)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(nombreProcedimiento, conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                if (parametros != null)
                {
                    foreach (var parametro in parametros)
                    {

                        cmd.Parameters.AddWithValue(parametro.N_Nombre, parametro.Nombre);
                        cmd.Parameters.AddWithValue(parametro.N_Comentario, parametro.Comentario);
                    }
                }
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Dictionary<string, object>> recuperaComentarios(string nombreProcedimiento)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(nombreProcedimiento, conexion);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

                        while (reader.Read())
                        {
                            var rowData = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData[reader.GetName(i)] = reader[i];
                            }
                            result.Add(rowData);
                        }

                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                // Maneja la excepción aquí, puedes registrarla o lanzar una excepción personalizada si lo deseas.
                // Por ejemplo:
                Console.WriteLine("Error en recuperaDatos: " + ex.Message);
                throw;
            }
        }
    }
}

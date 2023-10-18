using System.Data.SqlClient;
using System.Data;

namespace PlataformaWeb.Recursos
{
    public class DatosLogin
    {
        public static string cadenaConexion = "user=Marjosue12_SQLLogin_1;pwd=qbozh2ttw8;data source=Proyecto_Graduacion.mssql.somee.com;Initial Catalog=proyecto_graduacion;";

        public static DataTable Ejecutar(string nombreProcedimiento, List<Parametro> parametros = null)
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

                        cmd.Parameters.AddWithValue(parametro.Nombre_usr, parametro.Usuario);
                        cmd.Parameters.AddWithValue(parametro.Nombre_pwd, parametro.Clave);

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
    }
}

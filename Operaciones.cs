using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoRoles
{
    public class Operaciones
    {
        public bool SubirDatos(DataTable tbData)
        {
            bool resultado = true;
            using (SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion))
            {
                conexion.Open();
                using (SqlBulkCopy subir = new SqlBulkCopy(conexion))
                {
                                           //columExcel   columTable
                    subir.ColumnMappings.Add("cedula", "cedula");
                    subir.ColumnMappings.Add("nombre", "nombre");
                    subir.ColumnMappings.Add("cargo", "cargo");
                    //tabla a la que vamos a apuntar
                    subir.DestinationTableName = "Nomina";

                    subir.BulkCopyTimeout = 1500;
                    try
                    {
                        subir.WriteToServer(tbData);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al subir los datos a la base, revisa excel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultado = false;
                    }
                    
               }
            }
            return resultado;
        }
    }
}

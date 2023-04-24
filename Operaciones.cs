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
        public bool SubirDatosTrabajadores(DataTable tbData)
        {
            bool resultado = true;
            using (SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion))
            {
                conexion.Open();
                using (SqlBulkCopy subir = new SqlBulkCopy(conexion))
                {
                                           //columExcel   columTable
                    subir.ColumnMappings.Add("cedula", "CEDULA");
                    subir.ColumnMappings.Add("localidad", "IdLocalidad");
                    subir.ColumnMappings.Add("departamento", "IdDepartamento");
                    subir.ColumnMappings.Add("nombres", "NOMBRES");
                    subir.ColumnMappings.Add("fecha de ingreso", "FECHA_INGRESO");
                    subir.ColumnMappings.Add("cargo", "CARGO");
                    subir.ColumnMappings.Add("sueldo base", "SUELDO_BASE");
                    subir.ColumnMappings.Add("personal con discapacidad","PER_DISCAPACIDAD");
                    //tabla a la que vamos a apuntar
                    subir.DestinationTableName = "TRABAJADORES";

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

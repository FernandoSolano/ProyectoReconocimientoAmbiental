﻿using ReconocimientoAmbientalLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoAmbientalLibrary.Data
{
    public class AreaTematicaData
    {
        private String cadenaConexion;

        public AreaTematicaData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }//constructor

        public void AgregarAreaTematica(String nombreAreaTematica, String descripcionArea, String siglaArea)
        {
            SqlConnection sqlConnection1 = new SqlConnection(cadenaConexion);
            sqlConnection1.Open();
            SqlTransaction transaccion = sqlConnection1.BeginTransaction();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("sp_agregar_area_tematica", sqlConnection1, transaccion);//agrego mi procedimiento almacenado para utilizarlo
                cmd.CommandType = System.Data.CommandType.StoredProcedure;//indico que voy a utilizar un procedimiento almacenado

                //***aqui va el parametro que quiero enviarle al procedimiento
                cmd.Parameters.AddWithValue("@nombreAreaTematica", nombreAreaTematica);
                cmd.Parameters.AddWithValue("@descripcionArea", descripcionArea);
                cmd.Parameters.AddWithValue("@siglaArea", siglaArea);

                cmd.ExecuteNonQuery();//ejecuto el procedimiento almacenado

                transaccion.Commit();//si se ejecuta bien la transaccion hace el cambio en la base de datos=commit

            }//try
            catch (Exception ex)
            {
                transaccion.Rollback();//si se ejecuto mal que no haga ningun cambio en la base de datos
            }//catch
            sqlConnection1.Close();
        }//AgregarAreaTematica


        public LinkedList<AreaTematica> ObtenerAreasTematicas()
        {

            //paso 1
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("sp_obtener_area_tematica", connection);
            connection.Open();
            SqlDataReader drAreas = cmd.ExecuteReader();
            LinkedList<AreaTematica> areasTematicas = new LinkedList<AreaTematica>();
            while (drAreas.Read())
            {

                AreaTematica areaTematica = new AreaTematica();
                areaTematica.NombreAreaTematica = drAreas["nombreAreaTematica"].ToString();
                areaTematica.IdArea = Int32.Parse(drAreas["idArea"].ToString());

                areasTematicas.AddLast(areaTematica);
            }//while
            connection.Close();
            return areasTematicas;

        }//ObtenerAreasTematicas()

    }//AreaTematicaData

}//namespace
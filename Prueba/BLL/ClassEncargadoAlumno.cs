using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetEncargadoTableAdapters;
using System.Data;

namespace BLL
{
    class ClassEncargadoAlumno
    {
        #region Atributos
        private Encargado_AlumnoTableAdapter encargado = new Encargado_AlumnoTableAdapter();
        #endregion
        #region Propiedades
        private Encargado_AlumnoTableAdapter ENCARGADO
        {
            get { return encargado; }
        }
        #endregion

        #region Metodos
        #region ListarEncargado
        /// <summary>
        /// Lista todos los encargado devuelve un datatable
        /// </summary>
        /// <returns></returns>
        public DataTable ListarEncargado()
        {
            return ENCARGADO.GetDataEncargadoCliente();
        }
        #endregion

        #region InsertarEncargado
        /// <summary>
        /// Inserta un nuevo encargado de alumno
        /// </summary>
        /// <returns></returns>
        public string InsertarEncargado(string primernombre, string segundonombre, string primerapellido,
            string segundoapellido, string direccion, string telefono, string correo)
        {
            string res = "";
            try
            {
                ENCARGADO.sp_InsetarEncargadoAlumno(primernombre, segundonombre, primerapellido, segundoapellido, direccion, telefono, correo, ref res);
            }
            catch (Exception error)
            {

                res = error.Message;
            }
            return res;
        }
        #endregion
        #region ActualizarEncargado
        /// <summary>
        /// /Procedimiento que actualiza un encargado de alumno
        /// </summary>
        /// <param name="id"></param>
        /// <param name="primernombre"></param>
        /// <param name="segundonombre"></param>
        /// <param name="primerapellido"></param>
        /// <param name="segundoapellido"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <returns></returns>
        public string ActualizarEncargado(string id, string primernombre, string segundonombre, string primerapellido, string segundoapellido, string direccion, string telefono, string correo)
        {
            string respuesta = "";
            try
            {
                ENCARGADO.sp_ActualizarEncargadoAlumno(Convert.ToInt32(id), primernombre, segundonombre, primerapellido, segundoapellido, direccion, telefono, correo, ref respuesta);
            }
            catch (Exception error)
            {

                respuesta = error.Message;
            }
            return respuesta;
        }
        #endregion

        #region EliminarEncargado
        /// <summary>
        /// Elimina un encargado recibe como parametro el id del encargado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string EliminarEncargado(string id)
        {
            string respuesta = "";
            try
            {
                ENCARGADO.sp_EliminarEncargadoAlumno(Convert.ToInt32(id), ref respuesta);
            }
            catch (Exception error)
            {

                respuesta = error.Message;
            }
            return respuesta;
        }
        #endregion
        #endregion
    }
}

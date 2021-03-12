using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_5_3
{
    class CDocumento
    {
        protected string Autor;
        protected string Titulo;
        protected string Ubicacion;
        public void SetAutor(string Autor)
        {
            this.Autor = Autor;
        }
        public void SetTitulo(string Titulo)
        {
            this.Titulo = Titulo;
        }
        public void SetUbicacion(string Ubicacion)
        {
            this.Ubicacion = Ubicacion;
        }
        public string GetAutor()
        {
            return this.Autor;
        }
        public string GetTitulo()
        {
            return this.Titulo;
        }
        public string GetUbicacion()
        {
            return this.Ubicacion;
        }
    }
}

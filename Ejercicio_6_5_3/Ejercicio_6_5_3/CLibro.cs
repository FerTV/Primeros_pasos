using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_5_3
{
    class CLibro : CDocumento
    {
        private int paginas;

        public int GetPaginas()
        {
            return this.paginas;
        }
        public void SetPaginas(int paginas)
        {
            this.paginas = paginas;
        }
    }
}

namespace Ejercicio_6_6_2
{
    class CLibro : CDocumento
    {
        private int paginas;

        public CLibro()
        {}
        public CLibro(string autor, string titulo, string ubicacion, int paginas) : base(autor, titulo, ubicacion)
        {
            this.paginas = paginas;
        }
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

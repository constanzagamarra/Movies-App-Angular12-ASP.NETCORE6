using back_end.Entidades;

namespace back_end.Repositorio
{
    public class RepoEnMemoria
    {
        private List<Genero> _generos;

        public RepoEnMemoria()
        {
            _generos = new List<Genero>()
            {
                new Genero(){ Id= 1 ,Nombre="Comedia"},
                new Genero(){ Id= 2 ,Nombre="Accion"},
            };
        }

    public List<Genero> ObtenerTodos()
        {
            return _generos;
        }
    }
}

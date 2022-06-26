using back_end.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace back_end.Controllers
{
    public class GenerosController
    {
        private readonly IRepoEnMemoria repositorio;
        public GenerosController(IRepoEnMemoria repositorio)
        {
            this.repositorio = repositorio;
        }
    }
}
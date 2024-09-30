using WebApi8_Video.Data;
using WebApi8_Video.Models;

namespace WebApi8_Video.Services.Authors
{
    public class AutorService : IAutorInterface
    {

        private readonly AppDBContext _context;
        public AutorService(AppDBContext context)
        {
            _context = context;
        }


        public Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AutorModel>> BuscarAutorporIdLivro(int idLivro)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<AutorModel>>> ListarAutores()
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.AspNetCore.DataProtection.Repositories;
using WebApi8_Video.Models;

namespace WebApi8_Video.Services.Authors
{
    public interface IAutorInterface
    {
        Task<ResponseModel<List<AutorModel>>> ListarAutores();
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor);
        Task<ResponseModel<AutorModel>> BuscarAutorporIdLivro(int idLivro);
    }
}

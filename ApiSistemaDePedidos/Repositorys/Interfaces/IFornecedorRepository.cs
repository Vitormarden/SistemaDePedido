using ApiSistemaDePedidos.Models;

namespace ApiSistemaDePedidos.Repositorys.Interfaces
{
    public interface IFornecedorRepository
    {
        Task<List<Fornecedor>> ListaDeFornecedores();
        Task <IEnumerable<Fornecedor>> BuscarFornecedorByCnpj(string cnpj);
        Task CriarFornecedor(Fornecedor fornecedor);
        Task AtualizarFornecedor(Fornecedor fornecedor);
        Task DeletarFornecedor(string cnpj);
    }
}

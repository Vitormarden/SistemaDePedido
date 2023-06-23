using ApiSistemaDePedidos.Models;
using ApiSistemaDePedidos.Repositorys.Interfaces;
using ApiSistemaDePedidos.Services.Interface;

namespace ApiSistemaDePedidos.Services
{
    public class FornecedorServices : IFornecedorServices
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        public FornecedorServices(IFornecedorRepository fornecedorRepository) => _fornecedorRepository = fornecedorRepository;
        

        public async Task<List<Fornecedor>> ListaDeFornecedores() => await _fornecedorRepository.ListaDeFornecedores();

        public async Task<IEnumerable<Fornecedor>> BuscarFornecedorByCnpj(string cnpj) => await _fornecedorRepository.BuscarFornecedorByCnpj(cnpj);
        
        public async Task CriarFornecedor(Fornecedor fornecedor)
        {
            await _fornecedorRepository.CriarFornecedor(fornecedor);
        }
        public async Task AtualizarFornecedor(Fornecedor fornecedor)
        {
            await _fornecedorRepository.AtualizarFornecedor(fornecedor);
            
        }

        public async Task DeletarFornecedor(string cnpj)
        {
            await _fornecedorRepository.DeletarFornecedor(cnpj);
        }

    }
}

using ApiSistemaDePedidos.Context;
using ApiSistemaDePedidos.Models;
using ApiSistemaDePedidos.Repositorys.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSistemaDePedidos.Repositorys
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly AppDbContext _context;
        public FornecedorRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Fornecedor>> ListaDeFornecedores()
        {
            return await _context.fornecedores.ToListAsync();
        }
        public async  Task<IEnumerable<Fornecedor>> BuscarFornecedorByCnpj(string cnpj)
        {
            IEnumerable<Fornecedor> fornecedores;
            if (!string.IsNullOrWhiteSpace(cnpj))
            {
                fornecedores = await _context.fornecedores.Where(c => c.Cnpj.Contains(cnpj)).ToListAsync(); 
            }
            else
            {
                fornecedores = await ListaDeFornecedores();
            }
            return fornecedores;
        }
        public async Task CriarFornecedor(Fornecedor fornecedor)
        {
            _context.fornecedores.Add(fornecedor);
            await _context.SaveChangesAsync();
        }
        public async Task AtualizarFornecedor(Fornecedor fornecedor)
        {
            //ele vai salvar essa entidade porque o estado dela foi alterado 
            _context.Entry(fornecedor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeletarFornecedor(string cnpj)
        {

            _context.fornecedores.Remove((Fornecedor)await BuscarFornecedorByCnpj(cnpj));
            await _context.SaveChangesAsync();
        }

    }
}

using ApiSistemaDePedidos.Models;
using ApiSistemaDePedidos.Services.Interface;
using Grpc.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSistemaDePedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private IFornecedorServices _fornecedorServices;

        public FornecedorController(IFornecedorServices fornecedorServices) => _fornecedorServices = fornecedorServices;


        [HttpGet]
        public async Task<IActionResult> GetFornecedores()
        {
            try
            {
                var fornecedores = await _fornecedorServices.ListaDeFornecedores();
                if (fornecedores.Count() == 0)
                    return NotFound($"não existe fornecedores");
                return Ok(fornecedores);
            }
            catch
            {

                return StatusCode(500, "Erro ao obter lista de fornecedores");

            }

        }

        [HttpGet("FornecedorPorCnpj")]
        public async Task<IActionResult> GetFornecedoresByCnpj(string cnpj)
        {

            try
            {
                var fornecedores = await _fornecedorServices.BuscarFornecedorByCnpj(cnpj);
                if (fornecedores.Count() == null)
                    return NotFound($"Não existe Fornecedor com esse CNPJ {cnpj}");
                return Ok(fornecedores);
            }
            catch
            {

                return StatusCode(500, "Erro ao obter lista de fornecedores");
            }


        }
        [HttpPost]
        public async Task<IActionResult> Create(Fornecedor fornecedor)
        {
            try
            {
                await _fornecedorServices.CriarFornecedor(fornecedor);
                return CreatedAtRoute(nameof(GetFornecedoresByCnpj), new { cpnj = fornecedor.Cnpj }, fornecedor);
                // retorna 201, retorna o recurso recem criado pelo cnpj, uso o get aluno para retornar o  fornecedor que foi criado agora.]

            }
            catch
            {

                return StatusCode(500, "Erro ao adicioanr  fornecedores");

            }

        }

        [HttpPut("{cnpj:string}")]
        public async Task<IActionResult> Update(string cnpj, [FromBody] Fornecedor fornecedor)
        {
            try
            {
                await _fornecedorServices.AtualizarFornecedor(fornecedor);
                return NoContent();
            }
            catch 
            {

                return StatusCode(500, "Erro ao atualizar fornecedores");
            }
        }
    }
}
    
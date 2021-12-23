using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.Repositories;

namespace WebApi.Controllers
{
    
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        IProductService produtos = new ProductService();

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "ProdutoDetalhes")]
        public IEnumerable<Product> GeProdutos()
        {
            IEnumerable<Product> produto = new List<Product>();
            try
            {
                produto = produtos.GetAll();
            }
            catch (ApplicationException ex)
            {
                new HttpRequestException(ex.Message);
            }

            return produto;
        }

        [HttpPost(Name = "InserirProduto")]
        public string IserirProdutos(Product produto)
        {
            //string alunos1;
            try
            {
                this.produtos.Create(produto);
            }
            catch (ApplicationException ex)
            {
                new HttpRequestException(ex.Message);
            }

            return Ok(produto.Id).ToString();
        }

        [HttpPut(Name = "UpdateProduto")]
        public string UpdatreProdutos(Product produto)
        {
            try
            {
                this.produtos.Update(produto);
            }
            catch (Exception ex)
            {
                new HttpRequestException(ex.Message);
            }

            return Ok(produto.Id).ToString();
        }

        [HttpDelete(Name = "ExcluirProduto")]
        public string DeleteProdutos(int id)
        {
            try
            {
                this.produtos.Delete(id);
            }
            catch (Exception ex)
            {
                new HttpRequestException(ex.Message);
            }

            return Ok(produtos).ToString();

        }
    }    
}

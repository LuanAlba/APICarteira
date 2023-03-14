using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using APICarteira.Context.Repository;
using APICarteira.Entities;
using APICarteira.Models;

namespace APICarteira.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransacaoController : ControllerBase
{
    private readonly IMapper mapper;
    private readonly ITransacaoRepository repository;


    public TransacaoController(IMapper mapper, ITransacaoRepository repository)
    {
        this.mapper = mapper;
        this.repository = repository;
    }

    [HttpGet]
    public IActionResult ObterTodos()
    {   
        var transacoes = repository.ObterTodas();
        return Ok(transacoes);
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
        var transacao = repository.ObterPorId(id);

        if(transacao == null)
            return NotFound();

        return Ok(transacao);
    }

    [HttpPost]
    public IActionResult Adicionar(AdicionarTransacaoModel model)
    {
        var transacao = mapper.Map<Transacao>(model);

        // var transacao = new Transacao(model.valor, 0, model.descricao, DateTime.Now, 0,  0 );

        repository.Adicionar(transacao);
                    
        return CreatedAtAction(nameof(ObterPorId), new { id = transacao.Id }, model);
    }

    [HttpPut("{id}")]
    public IActionResult Editar(int id, AtualizarTransacaoModel model)
    {
        var transacao = repository.ObterPorId(id);

        if(transacao == null)
            return NotFound();

        transacao.Atualizar(model.valor, model.descricao, DateTime.Now, model.categoriaId);

        repository.Atualizar(transacao);

        return NoContent();
    }

}



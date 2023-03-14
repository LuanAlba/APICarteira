using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using APICarteira.Context.Repository;
using APICarteira.Entities;
using APICarteira.Models;

namespace APICarteira.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriaController : ControllerBase
{
    private readonly IMapper mapper;
    private readonly ICategoriaRepository repository;


    public CategoriaController(IMapper mapper, ICategoriaRepository repository)
    {
        this.mapper = mapper;
        this.repository = repository;
    }

    [HttpGet]
    public IActionResult ObterTodos()
    {   
        var categorias = repository.ObterTodas();
        return Ok(categorias);
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
        var categoria = repository.ObterPorId(id);

        if(categoria == null)
            return NotFound();

        return Ok(categoria);
    }

    [HttpPost]
    public IActionResult Adicionar(AdicionarCategoriaModel model)
    {
        var categoria = mapper.Map<Categoria>(model);

        repository.Adicionar(categoria);
                    
        return CreatedAtAction(nameof(ObterPorId), new { id = categoria.Id }, model);
    }

    [HttpDelete]
    public IActionResult Excluir(int id)
    {
        var categoria = repository.ObterPorId(id);

        if(categoria == null)
            return NotFound();

        repository.Excluir(categoria);
        

        return NoContent();
    }

}



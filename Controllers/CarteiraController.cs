using AutoMapper;
using Microsoft.AspNetCore.Mvc;


namespace APICarteira.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarteiraController : ControllerBase
{
    private readonly IMapper mapper;
    //Repos

    public CarteiraController(IMapper mapper)
    {
        this.mapper = mapper;
    }


}



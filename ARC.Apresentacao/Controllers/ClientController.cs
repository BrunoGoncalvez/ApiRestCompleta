using ARC.Data.Repository;
using ARC.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARC.Apresentacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        private readonly IClientRepository _repository;

        public ClientController(IClientRepository repository)
        {

            _repository = repository;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Add(Client client)
        {
            try
            {
                await _repository.Add(client);
                return StatusCode(201);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
            
        }

    }
}

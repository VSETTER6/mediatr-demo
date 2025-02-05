﻿using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<PersonModel>> Get()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        // Detta är likadant som det som är skriven ovan och nedan fast i en rad.
        public async Task<PersonModel> Get(int id) => await _mediator.Send(new GetPersonByIdQuery(id));

        // POST api/<PersonController>
        [HttpPost]
        public async Task<PersonModel> Post([FromBody] PersonModel value)
        {
            var model = new InsertPersonCommand(value.FirstName, value.LastName);

            return await _mediator.Send(model);

            // Man kan även skriva så här;
            //return await _mediator.Send(new InsertPersonCommand(value.FirstName, value.LastName));
        }



        // PUT api/<PersonController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<PersonController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

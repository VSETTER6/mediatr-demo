using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;



    // Ifall det varit en klass hade det sett ungefär likadant ut.
    // : IRequest<List<PersonModel>>; visar vad vi retunerar.

    //public class GetPersonListQuery : IRequest<List<PersonModel>>;
    //{  
    //}
}

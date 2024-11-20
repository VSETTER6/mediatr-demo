using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commands
{
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;

    // Detta ersätts av raden ovan.
    //public class InsertPersonCommand
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int Id { get; set; }

    //    public InsertPersonCommand(string firstName, string lastName, int id)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //        Id = id;
    //    }
    //}
}

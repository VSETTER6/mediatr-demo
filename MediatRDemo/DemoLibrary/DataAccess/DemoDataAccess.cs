using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> personModelList = new();

        public DemoDataAccess()
        {
            personModelList.Add(new PersonModel { Id = 1, FirstName = "John", LastName = "Dough" });
            personModelList.Add(new PersonModel { Id = 2, FirstName = "Sue", LastName = "Strom" });
        }

        public List<PersonModel> GetPeople()
        {
            return personModelList;
        }

        public PersonModel InsertPeople(string firstName, string lastName)
        {
            PersonModel personModel = new() { FirstName = firstName, LastName = lastName };
            personModel.Id = personModelList.Max(maxAmountOfPeople => maxAmountOfPeople.Id) + 1;
            personModelList.Add(personModel);
            return personModel;
        }
    }
}

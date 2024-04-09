using System;
using System.Collections.Generic;
using System.Text;
using Application.Interfaces;
using Application.DTOs;

namespace Application.Services
{   
    internal class PersonService
        {
            private readonly IPersonRepository _personRepository;
            public PersonService(IPersonRepository personRepository)
            {
                _personRepository = personRepository;
            }
            public PersonGetByIdResponse GetById(Guid id)
            {
                var person = _personRepository.GetByID(id);//нет реализации
                //TODO: AutoMapper
                throw new NotImplementedException();
            }
     }
}



//var response = new PersonGetByIdResponse
// TODO: mapping  AutoMapping

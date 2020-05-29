using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    public class StaffController : ApiController
    {
        // GET: Staff
        IRepository<Person> db;

        public StaffController(IRepository<Person> rep)
        {
            db = rep;
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return db.GetAll();
        }

        public Person GetPerson(int id)
        {
            return db.Get(id);
        }

        public Person PostPerson(Person person)
        {
            return db.Create(person);
        }

        public bool PutPerson(Person person)
        {
            return db.Update(person);
        }

        public void DeletePerson(int id)
        {
            db.Remove(id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.EF;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class StaffRepository : IRepository<Person>
    {
        StaffContext db;
        public StaffRepository()
        {
            db = new StaffContext();

        }
        public StaffRepository(StaffContext context)
        {
            db = context;

        }
        public Person Create(Person item)
        {
            db.People.Add(item);
            this.Save();
            return item;
        }
        public Person Get(int id)
        {
            Person person = db.People.Find(id);
            return person;
        }
        public IEnumerable<Person> GetAll()
        {
            return db.People.ToList();
        }
        public void Remove(int id)
        {
            Person person = Get(id);
            if (person != null)
            {
                db.People.Remove(person);
                this.Save();
            }
        }

        public bool Update(Person item)
        {
            Person selected = Get(item.Id);
            if (selected != null)
            {
                selected.Name = item.Name;
                selected.Age = item.Age;
                selected.Married = item.Married;
                db.Entry(selected).State = EntityState.Modified;
                this.Save();
                return true;
            }
            return false;
        }

        public void Save()
        {
            db.SaveChanges();
        }
        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }


    }
}
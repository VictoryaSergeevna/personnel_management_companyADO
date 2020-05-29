using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.EF
{
    public class StaffInitializer : DropCreateDatabaseIfModelChanges<StaffContext>
    {
        protected override void Seed(StaffContext context)
        {

            IList<Person> peoples = new List<Person>();
            peoples.Add(new Person() { Name = "Сушко Виктория Сергеевна", Age = 34, Married = true});
            peoples.Add(new Person() { Name = "Яковлев Павел Николаевич", Age = 28, Married = false});
            peoples.Add(new Person() { Name = "Похил Влад Сергеевич", Age = 23, Married = false});
            peoples.Add(new Person() { Name = "Николаенко Надежда Олеговна", Age = 25, Married = false});
            peoples.Add(new Person() { Name = "Cидоров Олег Петрович", Age = 30, Married = true});


            context.People.AddRange(peoples);
            context.SaveChanges();
            // base.Seed(context);
        }
    }
}
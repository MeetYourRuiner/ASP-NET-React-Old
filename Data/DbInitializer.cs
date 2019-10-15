﻿using WebApplication2;
using System;
using System.Linq;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class DbInitializer
    {
        public static void Initialize(EmployeeContext context)
        {
            context.Database.EnsureCreated();
            if (context.Employees.Any())
                return;
            var employees = new Employee[]
            {
                new Employee{Name = "John", Email = "john1@gmail.com", BDay = new DateTime(1998,6,5), Salary = 10000},
                new Employee{Name = "Boris", Email = "john2@gmail.com", BDay = new DateTime(1998,2,5), Salary = 11000},
                new Employee{Name = "Andrew", Email = "john3@gmail.com", BDay = new DateTime(1998,7,5), Salary = 13000},
                new Employee{Name = "Roman", Email = "john4@gmail.com", BDay = new DateTime(1998,1,5), Salary = 14000},
                new Employee{Name = "Gena", Email = "john5@gmail.com", BDay = new DateTime(1998,1,5), Salary = 14000},
                new Employee{Name = "Man", Email = "john6@gmail.com", BDay = new DateTime(1998,1,5), Salary = 14000},
                new Employee{Name = "Oman", Email = "john8@gmail.com", BDay = new DateTime(1998,1,5), Salary = 14000},
                new Employee{Name = "Thomas", Email = "john7@gmail.com", BDay = new DateTime(1998,1,5), Salary = 14000},
                new Employee{Name = "Pier", Email = "john9@gmail.com", BDay = new DateTime(1998,1,5), Salary = 14000},
                new Employee{Name = "Dunn", Email = "john0@gmail.com", BDay = new DateTime(1998,1,5), Salary = 14000},
                new Employee{Name = "Homer", Email = "john11@gmail.com", BDay = new DateTime(1998,1,5), Salary = 14000},
                new Employee{Name = "Bart", Email = "john12@gmail.com", BDay = new DateTime(1998,1,5), Salary = 14000},
                new Employee{Name = "Peter", Email = "john13@gmail.com", BDay = new DateTime(1998,1,5), Salary = 14000},
            };
            foreach(Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();
        }
    }
}

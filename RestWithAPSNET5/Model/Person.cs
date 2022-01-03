using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithAPSNET5.Model;
using RestWithAPSNET5.Services.Implementations;

namespace RestWithAPSNET5.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}

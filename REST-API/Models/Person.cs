using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST_API.Models
{
    /// <summary>
    /// Represents a person
    /// </summary>
    public class Person
    {
        public int id { get; set; } = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
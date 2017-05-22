using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryingAgain.Entities;

namespace TryingAgain.Models
{
    public class CreateVisitorViewModel
    {
        public List<Visitor> Visitors { get; set; }

        public CreateVisitorViewModel()
        {
            Visitors = new List<Visitor>();
        }
    }
}
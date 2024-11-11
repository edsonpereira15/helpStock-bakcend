using HelpStockApp.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpStockApp.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }

        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
            ValidationDomain(id);
        }
    }

    public ICollection<Product> Product { get; set; }
    private void ValidateDomain(string name)
    {
        DomainExceptionValidation.When(string.IsNullEmpty(name), "Invalid name, name is required");
        DomainExceptionValidation.When(name.Length < 3, "name is too short");
    }

    
}

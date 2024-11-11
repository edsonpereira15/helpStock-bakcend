using HelpStockApp.Domain.Entities;
using HelpStockApp.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using Xunit;
using FluentAssertions;
using System.Reflection;
using System.Xml.Linq;

namespace HelpStockApp.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }
        public Product(int id, string name, string description, decimal price, int stock, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }

        private void  ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(price < 0, "Invalid price, price negative value unlikely");
            DomainExceptionValidation.When(name.Length <= 0, "Invalid name, don't exist null name.");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name, this name's very short to validate your authenticity.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid description. The description is not null.");
            DomainExceptionValidation.When(price < 0, "The price's invalid. The price's can't be negative.");
            DomainExceptionValidation.When(stock < 0, "The stock's invalid. The stock not is negative.");
            DomainExceptionValidation.When(image.Length > 250, "Invalid url image, the url image should be until 250 chars.");
        }
    }


    /*
    nome nulo
    nome menor do 3 caracteres
    descrição menor que  5 caracteres
    stock negativo e/ou nulo
    url de imagem maior que 250 caracteres
    */


    

}





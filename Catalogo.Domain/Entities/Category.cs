using System;
using System.Collections.Generic;
using Catalogo.Domain.Validation;
 
namespace Catalogo.Domain.Entities
{
    public sealed class Category : Entity
    {
        public Category(string name, string imageUrl)
        {
            ValidateDomain(name, imageUrl);
         }
    }
}

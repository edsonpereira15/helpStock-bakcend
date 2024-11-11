using HelpStockApp.Domain.Entities;
using FluentAssertions;
using Xunit;
using HelpStockApp.Domain.Validation;
using System;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace HelpStockApp.Domain.Test
{
    public class CategoryUnityTest
    {
        [Fact(DisplayName = "Create category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObject()
        {
            Action action = () => new Category(1, "EletrÔnicos");
        action.Should().NotThrow<DomainExceptionValidation> Category;
        }
    }
}

    [Fact(DisplayName = "Create category With Invalid Id")]
    public void CreateCategory_WithInValidParameters_ResultObjects()
    {
        Action action = () => new Category(1, "EletrÔnicos");
    action.Should().Throw<DomainExceptionValidation>().Withmessage("Invalid Id value");
}


[Fact(DisplayName = "Create category With Invalid Id")]
public void CreateCategory_WithInValidParameters
{
    Action action = () => new Category(1, "EletrÔnicos");
action.Should().Throw<DomainExceptionValidation>().Withmessage("Invalid Id value");
}
 

    /*
        Create category With Name Too Short Parameter
        Create category With Name Null Parameter
        Ceate Category With Name Missing Parameters
        create csategory with Id Character Parameter
        Create category with Category Name Along parameter 
     */

//---------------------------------------------------------------------------------------------------------------------------------------------

    public class ProductUnityTest
{
    A partir das tarefas a seguir crie o código correspondente dos testes

 Criação de Produto
        Id invalido
        Nome Invalido
        Imagem longa
    Imagem Nula
        Imagem Vazia
        Stock negativo
        Preço negativo

// O código deve ser como o exemplo a seguir: 

public class ProductUnityTest
    {
        [Fact(DisplayName = "Create Product With Valid State")]
        public void CreateProduct_WithValidParameters_ResultObject()
        {
            Action action = () => new Product(1, "Triex Neutro", "Detergente neutro", 2.79m, 300, "https://savegnagoio.vtexassets.com/arquivos/ids/350425/DetergenteLiquidoTriex500mlNeutro.jpg?v=638080366871070000");
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Invalid Id")]
        public void CreateProduct_WithInValidId()
        {
            Action action = () => new Product(-1, "Triex Neutro", "Detergente neutro", 2.79m, 300, "https://savegnagoio.vtexassets.com/arquivos/ids/350425/DetergenteLiquidoTriex500mlNeutro.jpg?v=638080366871070000");
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid Id value is not accept by system.");
        }

        [Fact(DisplayName = "Create Product With Invalid Name")]
        public void CreateProduct_WithInValidName()
        {
            Action action = () => new Product(1, "Triex Neutro", "Detergente neutro", 2.79m, 300, "https://savegnagoio.vtexassets.com/arquivos/ids/350425/DetergenteLiquidoTriex500mlNeutro.jpg?v=638080366871070000");
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid Name value");
        }

    }

}

    /*
     Testes de validação:

        Criação de Produto
        Id invalido
        Nome Invalido
        Imagem longa
        Imagem Nula
        Imagem Vazia
        Stock negativo
        Preço negativo
     */


}

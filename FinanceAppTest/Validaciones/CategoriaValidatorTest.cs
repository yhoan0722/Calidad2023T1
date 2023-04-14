using FinanceApp.web;
using FinanceApp.web.Models;
using FinanceApp.web.Validators;
using Microsoft.EntityFrameworkCore;
using Moq;


namespace FinanceAppTest.Validaciones;

public class CategoriaValidatorTest
{
    [Test]
    public void hasValidTypeCaso01()
    {
        var validator = new CategoriaValidator();
        var result = validator.hasValidType(new Categoria { Nombre = "Ingreso"});
        
        Assert.AreEqual(false, result);
    }
    
    
    [Test]
    public void hasValidTypeCaso02()
    {
        var validator = new CategoriaValidator();
        var result = validator.hasValidType(new Categoria { Nombre = "Egreso"});
        
        Assert.AreEqual(false, result);
    }
    
    [Test]
    public void hasValidTypeCaso03()
    {
        var validator = new CategoriaValidator();
        var result = validator.hasValidType(new Categoria { Nombre = "Ingreso"});
        
        Assert.AreEqual(false, result);
    }
    
    
    
    /*
        [Test]
        public void hasUniqueNameCaso01()
        {
            var contextMock = new Mock<DbEntities>(new DbContextOptions<DbEntities>());
            contextMock.Setup(o => o.Categorias).ReturnsDbSet(new List<Categoria>
            {
                new Categoria {Nombre = "Ingreso"},
                new Categoria {Nombre = "Egreso"},
            });

            var context = contextMock.Object;

            var validator = new CategoriaValidator();
            var result = validator.hasUniqueName(context, new Categoria { Nombre = "Ingreso"});
            
            Assert.AreEqual(false, result);
        }
        */
}



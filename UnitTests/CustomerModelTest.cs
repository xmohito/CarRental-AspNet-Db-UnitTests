using CarWise.Models;
using System;
using Xunit;

namespace CarWise.Tests.Models
{
    public class CustomerTests
    {
        [Fact]
        public void TestCustomer()
        {
            // Arrange
            var customer = new Customer
            {
                Id = 1,
                Name = "John",
                Surname = "Doe",
                BirthDate = new DateTime(1990, 1, 1),
                PhoneNumber = 1234567890,
                Email = "johndoe@example.com"
            };

            // Assert
            Assert.Equal(1, customer.Id);
            Assert.Equal("John", customer.Name);
            Assert.Equal("Doe", customer.Surname);
            Assert.Equal(new DateTime(1990, 1, 1), customer.BirthDate);
            Assert.Equal(1234567890, customer.PhoneNumber);
            Assert.Equal("johndoe@example.com", customer.Email);
        }
    }
}

//Przyk³adowy test, który napisa³em dla modelu Customer weryfikuje, czy w³aœciwoœci obiektu Customer s¹ ustawione poprawnie.

//Test najpierw tworzy nowy obiekt Customer, ustawia jego w³aœciwoœci na okreœlone wartoœci, a nastêpnie porównuje ka¿d¹ w³aœciwoœæ z oczekiwan¹ wartoœci¹.

//Konkretnie, test weryfikuje, czy:

//    Id w³aœciwoœæ jest ustawiona na 1
//    Name w³aœciwoœæ jest ustawiona na "John"
//    Surname w³aœciwoœæ jest ustawiona na "Doe"
//    BirthDate w³aœciwoœæ jest ustawiona na datê 1 stycznia 1990 roku
//    PhoneNumber w³aœciwoœæ jest ustawiona na 1234567890
//    Email w³aœciwoœæ jest ustawiona na "johndoe@example.com"

//Jeœli którykolwiek z tych warunków jest nieprawid³owy, test nie przejdzie i zostanie zg³oszony b³¹d.
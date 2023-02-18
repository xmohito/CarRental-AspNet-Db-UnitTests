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

//Przyk�adowy test, kt�ry napisa�em dla modelu Customer weryfikuje, czy w�a�ciwo�ci obiektu Customer s� ustawione poprawnie.

//Test najpierw tworzy nowy obiekt Customer, ustawia jego w�a�ciwo�ci na okre�lone warto�ci, a nast�pnie por�wnuje ka�d� w�a�ciwo�� z oczekiwan� warto�ci�.

//Konkretnie, test weryfikuje, czy:

//    Id w�a�ciwo�� jest ustawiona na 1
//    Name w�a�ciwo�� jest ustawiona na "John"
//    Surname w�a�ciwo�� jest ustawiona na "Doe"
//    BirthDate w�a�ciwo�� jest ustawiona na dat� 1 stycznia 1990 roku
//    PhoneNumber w�a�ciwo�� jest ustawiona na 1234567890
//    Email w�a�ciwo�� jest ustawiona na "johndoe@example.com"

//Je�li kt�rykolwiek z tych warunk�w jest nieprawid�owy, test nie przejdzie i zostanie zg�oszony b��d.
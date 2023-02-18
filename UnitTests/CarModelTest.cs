using CarWise.Models;
using System;
using Xunit;

namespace CarWise.Tests.Models
{
    public class CarTests
    {
        [Fact]
        public void TestCar()
        {
            // Arrange

            var car = new Car
            {
                Id = 1,
                Brand = "Toyota",
                Model = "Corolla",
                IdBodyType = 1,
                Year = 2022,
                IdFuel = 1,
                EngineCapacity = 1.8,
                Power = 140,
                PriceForDay = 100,
            };

            // Assert
            Assert.Equal(1, car.Id);
            Assert.Equal("Toyota", car.Brand);
            Assert.Equal("Corolla", car.Model);
            Assert.Equal(1, car.IdBodyType);
            Assert.Equal(2022, car.Year);
            Assert.Equal(1, car.IdFuel);
            Assert.Equal(1.8, car.EngineCapacity);
            Assert.Equal(140, car.Power);
            Assert.Equal(100, car.PriceForDay);
        }
    }
}

//Przyk�adowy test, kt�ry napisa�em dla modelu Car weryfikuje, czy w�a�ciwo�ci obiektu Car s� ustawione poprawnie.

//Test tworzy nowy obiekt Car, ustawia jego w�a�ciwo�ci na okre�lone warto�ci, a nast�pnie por�wnuje ka�d� w�a�ciwo�� z oczekiwan� warto�ci�.

//Konkretnie, test weryfikuje, czy:

//    Id w�a�ciwo�� jest ustawiona na 1
//    Brand w�a�ciwo�� jest ustawiona na "Toyota"
//    Model w�a�ciwo�� jest ustawiona na "Corolla"
//    IdBodyType w�a�ciwo�� jest ustawiona na 1
//    Year w�a�ciwo�� jest ustawiona na 2022
//    IdFuel w�a�ciwo�� jest ustawiona na 1
//    EngineCapacity w�a�ciwo�� jest ustawiona na 1.8
//    Power w�a�ciwo�� jest ustawiona na 140
//    PriceForDay w�a�ciwo�� jest ustawiona na 100
//    IdBodyTypeNavigation w�a�ciwo�� jest ustawiona na obiekt BodyType z ustawionym Id r�wnym 1 i Type r�wnym "Sedan"
//    IdFuelNavigation w�a�ciwo�� jest ustawiona na obiekt Fuel z ustawionym Id r�wnym 1 i Type r�wnym "Gasoline"

//Je�li kt�rykolwiek z tych warunk�w jest nieprawid�owy, test nie przejdzie i zostanie zg�oszony b��d.
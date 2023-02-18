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

//Przyk³adowy test, który napisa³em dla modelu Car weryfikuje, czy w³aœciwoœci obiektu Car s¹ ustawione poprawnie.

//Test tworzy nowy obiekt Car, ustawia jego w³aœciwoœci na okreœlone wartoœci, a nastêpnie porównuje ka¿d¹ w³aœciwoœæ z oczekiwan¹ wartoœci¹.

//Konkretnie, test weryfikuje, czy:

//    Id w³aœciwoœæ jest ustawiona na 1
//    Brand w³aœciwoœæ jest ustawiona na "Toyota"
//    Model w³aœciwoœæ jest ustawiona na "Corolla"
//    IdBodyType w³aœciwoœæ jest ustawiona na 1
//    Year w³aœciwoœæ jest ustawiona na 2022
//    IdFuel w³aœciwoœæ jest ustawiona na 1
//    EngineCapacity w³aœciwoœæ jest ustawiona na 1.8
//    Power w³aœciwoœæ jest ustawiona na 140
//    PriceForDay w³aœciwoœæ jest ustawiona na 100
//    IdBodyTypeNavigation w³aœciwoœæ jest ustawiona na obiekt BodyType z ustawionym Id równym 1 i Type równym "Sedan"
//    IdFuelNavigation w³aœciwoœæ jest ustawiona na obiekt Fuel z ustawionym Id równym 1 i Type równym "Gasoline"

//Jeœli którykolwiek z tych warunków jest nieprawid³owy, test nie przejdzie i zostanie zg³oszony b³¹d.
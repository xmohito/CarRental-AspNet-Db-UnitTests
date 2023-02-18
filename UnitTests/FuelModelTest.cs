using CarWise.Models;
using Xunit;

namespace CarWise.Tests.Models
{
    public class FuelTests
    {
        [Fact]
        public void Fuel_TypeOfFuel_CanBeSetAndRetrieved()
        {
            // Arrange
            var fuel = new Fuel();
            string expectedTypeOfFuel = "Diesel";

            // Act
            fuel.TypeOfFuel = expectedTypeOfFuel;
            string actualTypeOfFuel = fuel.TypeOfFuel;

            // Assert
            Assert.Equal(expectedTypeOfFuel, actualTypeOfFuel);
        }
    }
}

//Ten test weryfikuje, czy warto�� w�a�ciwo�ci TypeOfFuel obiektu klasy Fuel mo�e by� ustawiona i pobrana poprawnie.

//Najpierw tworzony jest nowy obiekt klasy Fuel, a nast�pnie do w�a�ciwo�ci TypeOfFuel przypisywana jest testowa warto��.
//Nast�pnie warto�� w�a�ciwo�ci jest pobierana i por�wnywana z oczekiwan� warto�ci�. Je�li warto�� otrzymana jest r�na od oczekiwanej, test ko�czy si� niepowodzeniem.

//Ten test pozwala zweryfikowa�, czy w�a�ciwo�� TypeOfFuel dzia�a poprawnie, co mo�e by� szczeg�lnie wa�ne, je�li ta warto�� jest p�niej wykorzystywana w innych cz�ciach kodu aplikacji.
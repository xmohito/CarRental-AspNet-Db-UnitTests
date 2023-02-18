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

//Ten test weryfikuje, czy wartoœæ w³aœciwoœci TypeOfFuel obiektu klasy Fuel mo¿e byæ ustawiona i pobrana poprawnie.

//Najpierw tworzony jest nowy obiekt klasy Fuel, a nastêpnie do w³aœciwoœci TypeOfFuel przypisywana jest testowa wartoœæ.
//Nastêpnie wartoœæ w³aœciwoœci jest pobierana i porównywana z oczekiwan¹ wartoœci¹. Jeœli wartoœæ otrzymana jest ró¿na od oczekiwanej, test koñczy siê niepowodzeniem.

//Ten test pozwala zweryfikowaæ, czy w³aœciwoœæ TypeOfFuel dzia³a poprawnie, co mo¿e byæ szczególnie wa¿ne, jeœli ta wartoœæ jest póŸniej wykorzystywana w innych czêœciach kodu aplikacji.
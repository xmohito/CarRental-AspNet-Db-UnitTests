using CarWise.Models;
using Xunit;

namespace CarWise.Tests.Models
{
    public class BodyTypeTests
    {
        [Fact]
        public void BodyType_Type_CanBeSetAndRetrieved()
        {
            // Arrange
            var bodyType = new BodyType();
            string expectedType = "SUV";

            // Act
            bodyType.Type = expectedType;
            string actualType = bodyType.Type;

            // Assert
            Assert.Equal(expectedType, actualType);
        }
    }
}

//Test ten sprawdza, czy warto�� w�a�ciwo�ci Type obiektu klasy BodyType mo�e zosta� ustawiona i pobrana poprawnie.

//Najpierw w te�cie tworzony jest nowy obiekt klasy BodyType. Nast�pnie do w�a�ciwo�ci Type przypisywana jest testowa warto��, a zwr�cona warto�� z tej w�a�ciwo�ci por�wnywana jest z oczekiwan� warto�ci�. Je�li warto�� otrzymana jest r�na od oczekiwanej, test ko�czy si� niepowodzeniem.

//Test ten pozwala zweryfikowa�, czy w�a�ciwo�� Type dzia�a poprawnie, co mo�e by� szczeg�lnie wa�ne, je�li ta warto�� jest p�niej wykorzystywana w innych cz�ciach kodu aplikacji.
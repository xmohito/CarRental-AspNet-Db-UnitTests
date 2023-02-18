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

//Test ten sprawdza, czy wartoœæ w³aœciwoœci Type obiektu klasy BodyType mo¿e zostaæ ustawiona i pobrana poprawnie.

//Najpierw w teœcie tworzony jest nowy obiekt klasy BodyType. Nastêpnie do w³aœciwoœci Type przypisywana jest testowa wartoœæ, a zwrócona wartoœæ z tej w³aœciwoœci porównywana jest z oczekiwan¹ wartoœci¹. Jeœli wartoœæ otrzymana jest ró¿na od oczekiwanej, test koñczy siê niepowodzeniem.

//Test ten pozwala zweryfikowaæ, czy w³aœciwoœæ Type dzia³a poprawnie, co mo¿e byæ szczególnie wa¿ne, jeœli ta wartoœæ jest póŸniej wykorzystywana w innych czêœciach kodu aplikacji.
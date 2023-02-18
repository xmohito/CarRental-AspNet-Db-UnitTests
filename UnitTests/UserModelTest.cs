using Xunit;
using CarWise.Models;

namespace CarWise.Tests.Models
{
    public class UserTests
    {
        [Fact]
        public void TestUserProperties()
        {
            // Arrange
            int expectedId = 1;
            string expectedUsername = "johndoe";
            string expectedPassword = "secretpassword";

            // Act
            var user = new User
            {
                Id = expectedId,
                Username = expectedUsername,
                Password = expectedPassword
            };

            // Assert
            Assert.Equal(expectedId, user.Id);
            Assert.Equal(expectedUsername, user.Username);
            Assert.Equal(expectedPassword, user.Password);
        }
    }
}

//Test ten sprawdza, czy obiekt klasy User poprawnie zwraca warto�ci swoich w�a�ciwo�ci.
//Tworzony jest obiekt User z przypisanymi warto�ciami oczekiwanymi do w�a�ciwo�ci
//Id, Username i Password, a nast�pnie por�wnywane s� one z warto�ciami zwracanymi przez te w�a�ciwo�ci obiektu User
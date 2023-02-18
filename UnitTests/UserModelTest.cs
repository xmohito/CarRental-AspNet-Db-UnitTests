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

//Test ten sprawdza, czy obiekt klasy User poprawnie zwraca wartoœci swoich w³aœciwoœci.
//Tworzony jest obiekt User z przypisanymi wartoœciami oczekiwanymi do w³aœciwoœci
//Id, Username i Password, a nastêpnie porównywane s¹ one z wartoœciami zwracanymi przez te w³aœciwoœci obiektu User
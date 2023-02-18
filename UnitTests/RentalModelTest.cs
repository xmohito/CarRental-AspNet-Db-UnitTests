using CarWise.Models;
using System;
using Xunit;

namespace CarWise.Tests
{
    public class RentalTests
    {
        [Fact]
        public void Rental_GetProperties_ReturnExpectedValues()
        {
            // Arrange
            var rental = new Rental
            {
                Id = 1,
                IdCar = 2,
                IdCustomer = 3,
                ReceiptDate = DateTime.Now.AddDays(-1),
                ReturnDate = DateTime.Now,
                ToPay = 100,
                Pay = false
            };

            // Act
            var id = rental.Id;
            var idCar = rental.IdCar;
            var idCustomer = rental.IdCustomer;
            var receiptDate = rental.ReceiptDate;
            var returnDate = rental.ReturnDate;
            var toPay = rental.ToPay;
            var pay = rental.Pay;

            // Assert
            Assert.Equal(1, id);
            Assert.Equal(2, idCar);
            Assert.Equal(3, idCustomer);
            Assert.Equal(DateTime.Now.AddDays(-1).Date, receiptDate.Date);
            Assert.Equal(DateTime.Now.Date, returnDate.Date);
            Assert.Equal(100, toPay);
            Assert.False(pay);
        }
    }
}

//Ten test sprawdza, czy obiekt klasy Rental poprawnie zwraca warto�ci swoich w�a�ciwo�ci.
//Konkretnie testuje, czy warto�ci zwracane przez w�a�ciwo�ci Id, IdCar, IdCustomer, ReceiptDate, ReturnDate, ToPay i Pay s� r�wne warto�ciom,
//kt�re zosta�y przypisane do tych w�a�ciwo�ci.
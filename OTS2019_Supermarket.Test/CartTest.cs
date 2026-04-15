using NUnit.Framework;
using OTS_Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket.Test
{
    [TextFixture]

    public class CartTest
    {
        [Test]

        public void AddOneToCart_ShouldAddItemToCart_Success()
        {
            // arrange
            Cart cart = new Cart();
            Monitor monitor = new Monitor();

            // act
            card.AddOneToCart(monitor);

            // assert
            Assert.That(cart.Size, Is.EqualTo(1));
            Assert.That(cart.Amount, Is.EqualTo(100));

            // dozvoljene su nam 2 asertacije jer su promenjene JEDNOM metodom, INACE!! samo jedna asertacija!
        }
    }
}

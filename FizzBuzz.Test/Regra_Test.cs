using LibFizzBuzz;
using System;
using Xunit;

namespace FizzBuzz
{
    public class Regra_Test
    {
        [Fact]
        public void Quando_Passar_1_Devolve_1()
        {
            //Arrange
            var num = 1;

            //Act
            var result = Regra.ResolveFizzBuzz(num);

            //Assert
            Assert.Equal("1", result);
        }        

        [Fact]
        public void Quando_Passar_2_Devolve_2()
        {
            //Arrange
            var num = 2;

            //act
            var result = Regra.ResolveFizzBuzz(num);

            //Assert
            Assert.Equal("2", result);


        }
        [Fact]
        public void Quando_passar_3_Devolve_Fizz()
        {
            //Arrange 
            var num = 3;

            //Act
            var result = Regra.ResolveFizzBuzz(num);

            //Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Quando_passar_4_Devolve_4()
        {
            var num = 4;
            var result = Regra.ResolveFizzBuzz(num);
            Assert.Equal("4", result);
        }

        [Fact]
        public void Quando_passar_5_Devolve_Buzz()
        {
            var num = 5;
            var result = Regra.ResolveFizzBuzz(num);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Quando_passar_6_devolve_Fizz()
        {
            var num = 6;
            var result = Regra.ResolveFizzBuzz(num);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Quando_passar_10_devolve_Buzz()
        {
            var num = 10;
            var result = Regra.ResolveFizzBuzz(num);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Quando_passar_15_devolve_FizzBuzz()
        {
            var num = 15;
            var result = Regra.ResolveFizzBuzz(num);
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Quando_passar_0_devolve_None()
        {
            var num = 0;
            var result = Regra.ResolveFizzBuzz(num);
            Assert.Equal("None", result);
        }

        [Fact]
        public void Quando_passar_101_devolve_None()
        {
            var num = 101;
            var result = Regra.ResolveFizzBuzz(num);
            Assert.Equal("None", result);
        }
        
    }
}

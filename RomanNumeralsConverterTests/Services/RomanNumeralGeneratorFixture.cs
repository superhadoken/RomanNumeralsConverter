using RomanNumeralsConverter.Services;
using Xunit;

namespace RomanNumeralsConverterTests.Services
{
    public class RomanNumeralGeneratorFixture
    {
        private readonly RomanNumeralGenerator _sut;

        public RomanNumeralGeneratorFixture()
        {
            _sut = new RomanNumeralGenerator();
        }

        [Fact]
        public void GenerateWillReturnNullIf0()
        {
            // Act
            var result = _sut.Generate(0);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GenerateReturnsNullIf4000()
        {
            // Act
            var result = _sut.Generate(4000);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GenerateWillReturnIFor1()
        {
            // Act
            var result = _sut.Generate(1);

            // Assert
            Assert.Equal("I", result);
        }

        [Fact]
        public void GenerateWillReturnIIFor2()
        {
            // Act
            var result = _sut.Generate(2);

            // Assert
            Assert.Equal("II", result);
        }

        [Fact]
        public void GenerateWillReturnIIIFor3()
        {
            // Act
            var result = _sut.Generate(3);

            // Assert
            Assert.Equal("III", result);
        }

        [Fact]
        public void GenerateWillReturnIVFor4()
        {
            // Act
            var result = _sut.Generate(4);

            // Assert
            Assert.Equal("IV", result);
        }

        [Fact]
        public void GenerateWillReturnVFor5()
        {
            // Act
            var result = _sut.Generate(5);

            // Assert
            Assert.Equal("V", result);
        }

        [Fact]
        public void GenerateWillReturnVIFor6()
        {
            // Act
            var result = _sut.Generate(6);

            // Assert
            Assert.Equal("VI", result);
        }

        [Fact]
        public void GenerateWillReturnVIIFor7()
        {
            // Act
            var result = _sut.Generate(7);

            // Assert
            Assert.Equal("VII", result);
        }

        [Fact]
        public void GenerateWillReturnIXFor9()
        {
            // Act
            var result = _sut.Generate(9);

            // Assert
            Assert.Equal("IX", result);
        }

        [Fact]
        public void GenerateWillReturnXFor10()
        {
            // Act
            var result = _sut.Generate(10);

            // Assert
            Assert.Equal("X", result);
        }

        [Fact]
        public void GenerateWillReturnMFor1000()
        {
            // Act
            var result = _sut.Generate(1000);

            // Assert
            Assert.Equal("M", result);
        }

        [Fact]
        public void GenerateWillReturnCFor100()
        {
            // Act
            var result = _sut.Generate(100);

            // Assert
            Assert.Equal("C", result);
        }

        [Fact]
        public void GenerateWillReturnLFor50()
        {
            // Act
            var result = _sut.Generate(50);

            // Assert
            Assert.Equal("L", result);
        }

        [Fact]
        public void GenerateWillReturnLFor500()
        {
            // Act
            var result = _sut.Generate(500);

            // Assert
            Assert.Equal("D", result);
        }

        [Fact]
        public void GenerateWillReturnCMFor900()
        {
            // Act
            var result = _sut.Generate(900);

            // Assert
            Assert.Equal("CM", result);
        }

        [Fact]
        public void GenerateWillReturnMMVFor2005()
        {
            // Act
            var result = _sut.Generate(2005);

            // Assert
            Assert.Equal("MMV", result);
        }

        [Fact]
        public void GenerateWillReturnMMVFor3495()
        {
            // Act
            var result = _sut.Generate(3495);

            // Assert
            Assert.Equal("MMMCDXCV", result);
        }
    }
}
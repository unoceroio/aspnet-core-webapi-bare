using System.Collections.Generic;
using api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace api.tests
{
    public class ValuesControllerTests
    {
        private readonly ValuesController _sut;

        public ValuesControllerTests()
        {
            _sut = new ValuesController();
        }

        #region Get()

        [Fact]
        public void Get_ReturnsStringEnumerable()
        {
            // arrange

            // act
            var result = _sut.Get();

            // assert
            Assert.IsAssignableFrom<IEnumerable<string>>(result);
        }

        [Fact]
        public void Get_ReturnsNotEmptyStringArray()
        {
            // arrange

            // act
            var result = _sut.Get();

            // assert
            Assert.NotEmpty(result);
        }

        #endregion Get()

        #region Get(int)

        [Fact]
        public void Get_int_ReturnsString()
        {
            // arrange
            const int id = 1;

            // act
            var result = _sut.Get(id);

            // assert
            Assert.IsAssignableFrom<string>(result);
        }

        [Fact]
        public void Get_int_ReturnsNotNullString()
        {
            // arrange
            const int id = 1;

            // act
            var result = _sut.Get(id);

            // assert
            Assert.NotNull(result);
        }

        #endregion Get(int)
    }
}

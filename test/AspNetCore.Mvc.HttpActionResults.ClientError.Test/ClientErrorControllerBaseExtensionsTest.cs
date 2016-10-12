﻿namespace AspNetCore.Mvc.HttpActionResults.ClientError.Test
{
    using Microsoft.AspNetCore.Mvc;
    using Xunit;

    public class ClientErrorControllerBaseExtensionsTest
    {
        [Fact]
        public void LengthRequiredShouldReturnLengthRequiredResult()
        {
            var controller = new HomeController();

            var result = controller.TestLengthRequiredResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<LengthRequiredResult>(result);
        }

        [Fact]
        public void UnsupportedMediaTypeShouldReturnUnsupportedMediaTypeResult()
        {
            var controller = new HomeController();

            var result = controller.TestUnsupportedMediaTypeResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<UnsupportedMediaTypeResult>(result);
        }

        [Fact]
        public void RequestTimeoutShouldReturnRequestTimeoutResult()
        {
            var controller = new HomeController();

            var result = controller.TestRequestTimeoutResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<RequestTimeoutResult>(result);
        }

        [Fact]
        public void ImATeapotShouldReturnImATeapotResult()
        {
            var controller = new HomeController();

            var result = controller.TestImATeapotResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<ImATeapotResult>(result);
        }

        private class HomeController : ControllerBase
        {
            public IActionResult TestLengthRequiredResult()
            {
                return this.LengthRequired();
            }

            public IActionResult TestUnsupportedMediaTypeResult()
            {
                return this.UnsupportedMediaType();
            }

            public IActionResult TestRequestTimeoutResult()
            {
                return this.RequestTimeout();
            }

            public IActionResult TestImATeapotResult()
            {
                return this.ImATeapot();
            }
        }
    }
}

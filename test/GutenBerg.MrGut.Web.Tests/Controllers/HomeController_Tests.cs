using System.Threading.Tasks;
using GutenBerg.MrGut.Models.TokenAuth;
using GutenBerg.MrGut.Web.Controllers;
using Shouldly;
using Xunit;

namespace GutenBerg.MrGut.Web.Tests.Controllers
{
    public class HomeController_Tests: MrGutWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
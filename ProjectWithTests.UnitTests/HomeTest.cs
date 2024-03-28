using Bunit;
using ProjectWithTests.Pages;


namespace ProjectWithTests.UnitTests
{
    public class HomeTest:TestContext
    {
        [Fact]
        public void HomePageRendersTheCorrectCOntentWhenOpend()
        {
            //Act
            var cut = RenderComponent<Home>();

            //Assert
            cut.MarkupMatches("<h1>Hello this is richard</h1>");
        }
    }
}

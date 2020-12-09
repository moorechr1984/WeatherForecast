using AngleSharp.Dom;
using Bunit;
using System;
using TechTalk.SpecFlow;

namespace Weather.Forecast.UI.Specs.Steps
{
    [Binding]
    public class WeatherForecastSteps
    {
        private TestContext _testContext = new TestContext();
        private IRenderedComponent<Pages.Index> _mainLayout;
        private IElement _btnTodaysForecast;

        private readonly ScenarioContext _scenarioContext;

        public WeatherForecastSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"the user is viewing the home page")]
        public void GivenTheUserIsViewingTheHomePage()
        {
            _mainLayout = _testContext.RenderComponent<Pages.Index>();
        }
        
        [When(@"he/she clicks today's forecast")]
        public void WhenHeSheClicksTodaySForecast()
        {
            _btnTodaysForecast = _mainLayout.Find("#btnTodaysForecast");
            _btnTodaysForecast.Click();
        }

        [When(@"clicks Clear Me")]
        public void WhenClicksClearMe()
        {
            _btnTodaysForecast = _mainLayout.Find("#btnTodaysForecastCleared");
            _btnTodaysForecast.Click();
        }

        [Then(@"he should see ""(.*)""")]
        public void ThenHeShouldSee(string p0)
        {
            var divResult = _mainLayout.Find("#divResult");
            Equals(p0, divResult.InnerHtml);
        }
    }
}

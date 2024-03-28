using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjectWithTests.EndToEndTest.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinition
    {
        private double firstNumber;
        private double secondNumber;
        private double sum;
        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"the first number to be (.*)")]
        public void GivenTheFirstNumberToBe(int p0)
        {
            firstNumber = p0;
        }

        [Given(@"the second number to be (.*)")]
        public void GivenTheSecondNumberToBe(int p0)
        {
            secondNumber = p0;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
           sum = firstNumber + secondNumber;
        }

        [Then(@"the answere should be (.*)")]
        public void ThenTheAnswereShouldBe(int p0)
        {
            Assert.True(sum == p0);
        }
    }
}

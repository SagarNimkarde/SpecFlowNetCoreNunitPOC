using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowNetCoreNunitPOC
{
    [Binding]
    public class AdditionSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
           
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Thread.Sleep(3000);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            
        }
    }
}

using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowNetCoreNunitPOC
{
    [Binding]
    public class DivisionSteps
    {
        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            Thread.Sleep(5000);
        }
    }
}

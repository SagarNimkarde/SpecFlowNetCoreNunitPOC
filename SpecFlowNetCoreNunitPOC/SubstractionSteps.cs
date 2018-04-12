using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowNetCoreNunitPOC
{
    [Binding]
    public class SubstractionSteps
    {
        [When(@"I press substract")]
        public void WhenIPressSubstract()
        {
            Thread.Sleep(1000);
        }
    }
}

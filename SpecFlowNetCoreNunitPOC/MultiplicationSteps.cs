using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowNetCoreNunitPOC
{
    [Binding]
    public class MultiplicationSteps
    {
        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            Thread.Sleep(2000);
        }
    }
}

using Harrods.Core;
using TechTalk.SpecFlow;

namespace Harrods.StepDefinitions
{
    [Binding]
    public sealed class ScenarioHooks : BaseSteps
    {
        [AfterScenario("signout")]
        public void AfterScenario()
        {
            AccountPage.SignOut();
        }

        [AfterScenario]
        public void DisposeDriver()
        {
            Context.DisposeDriver();
        }
    }
}

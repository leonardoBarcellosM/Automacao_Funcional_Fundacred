using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    class ScopeFeatures
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureInfo featureInfo)
        {
            ClassDriver.GetInstance().StartDriver();
        }

        [BeforeScenario]
        public static void BeforeScenario(FeatureInfo featureInfo)
        {
           
        }

        [BeforeStep]
        public static void BeforeStep()
        {

        }

        [AfterStep]
        public static void AfterStep()
        {
          
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            ClassDriver.GetInstance().QuitDriver();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {

        }           
    }
}

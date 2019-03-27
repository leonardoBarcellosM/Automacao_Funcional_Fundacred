using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class NavegarIesSteps
    {
        NavegarPortalIesActions pageAction = new NavegarPortalIesActions();

        [Given(@"Acesso o dashboard")]
        public void GivenAcessoODashboard()
        {
            bool result = pageAction.ClicarDashboard();

            Assert.True(result, "Erro - Acesso o dashboard!");
        }
        [When(@"Clico em ""(.*)""")]
        public void WhenClicarEmNovaSolicitacao(string arg)
        {
            bool result = false;

            switch (arg)
            {
                case "Solicitações Iniciadas":
                    result = pageAction.ClicarFunil(0);
                    break;
                case "Reprovados Fundacred":
                    result = pageAction.ClicarFunil(1);
                    break;
                case "Pendente Análise Fundacred":
                    result = pageAction.ClicarFunil(2);
                    break;
                case "Pendente Análise Ies":
                    result = pageAction.ClicarFunil(3);
                    break;
                case "Reprovadas IES":
                    result = pageAction.ClicarFunil(4);
                    break;
                case "Aprovadas":
                    result = pageAction.ClicarFunil(5);
                    break;
                case "Fila De Espera":
                    result = pageAction.ClicarFunil(6);
                    break;
            }

            Assert.True(result, "Erro - " + arg);
        }



    }
}

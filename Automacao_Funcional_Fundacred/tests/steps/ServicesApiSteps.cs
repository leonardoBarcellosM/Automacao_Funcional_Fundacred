using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class ServicesApiSteps
    {
        ServicesApi PageActions = new ServicesApi();

        [Given(@"Consultar o servico de carregar a solicitacao")]
        public void GivenConsultarCarregarSolicitacao()
        {
           bool result = PageActions.CarregarSolicitacao();
                
           Assert.True(result, "Service - Erro ao carregar a solicitacao em andamento!");
        }
    }
}

using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class AccessSteps
    {
        AcessPageActions pageActions = new AcessPageActions();

        [Given(@"Acessar o endereco ""(.*)""")]
        public void GivenAcessarOEndereco(string url)
        {
            var result = pageActions.AccessPage(url);

                Assert.True(result, "Erro ao acessar a URL -> " + url);
        }
        
        [Then(@"Validar o carregamento")]
        public void ThenValidarOCarregamentoComSucesso()
        {
            var result = pageActions.ValidAccessPage();

            Assert.True(result, "Erro ao acessar a endereço solicitado");

            
        }
    }
}

using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class PreencherDadosFiadorSteps
    {
        private PreencherDadosFiadorActions pageAction = new PreencherDadosFiadorActions();

        [Given(@"Preencho os dados completos do fiador")]
        public void GivenPreenchoDadosCompletosFiador()
        {
            bool result = pageAction.PreencherDadosFiador();

                Assert.True(result, "Erro ao preencher os dados completos do fiador!");
        }

        [When(@"Preencho contato e endereco")]
        public void WhenPreenchoContatoEEndereco()
        {
            bool result = pageAction.PreencherContatoEndereco();

                Assert.True(result, "Erro ao preencher os dados de endereço e contato do fiador!");
        }

        [When(@"Clico em proximo")]
        public void WhenClicoEmProximo()
        {
            bool result = pageAction.Prosseguir();

                Assert.True(result, "Erro ao prosseguir!");
        }


        [Then(@"Validar direcionamento Dados Curso")]
        public void ThenDirecionamentoDadosCurso()
        {
            var result = pageAction.ValidarDirecionamentoDadosCurso();

                Assert.True(result, "Erro durante o direcionamento para a tela de Dados do Curso/ Erro preenchimento de dados do fiador!");
        }
    }
}

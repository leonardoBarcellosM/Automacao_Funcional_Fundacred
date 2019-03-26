using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class DadosPessoaisSteps
    {
        private DadosPessoaisActions pageAction = new DadosPessoaisActions();

        [Given(@"Inserir os dados pessoais")]
        public void GivenInserirOsDadosPessoais()
        {
            bool result = pageAction.PreencherDadosPessoais();

                Assert.True(result, "Erro ao inserir os dados pessoais do estudante!");
        }

        [When(@"Inserir endereco e contato")]
        public void WhenInserirEnderecoEContato()
        {
            bool result = pageAction.PreencherEndereco();

                Assert.True(result, "Erro ao inserir os dados de endereço e contato!");
        }

        [When(@"Clicar no botao proximo")]
        public void WhenClicarNoBotaoProximo()
        {
            bool result = pageAction.ClicarEmProximo();

                Assert.True(result, "Erro ao avançar!");
        }

        [Then(@"Validar direcionamento dados fiador")]
        public void ThenValidarDirecionamentoDadosFiador()
        {
            var result = pageAction.ValidarDirecionamentoFiador();

                Assert.True(result, "Erro no direcionamento para o formulário de Dados Do Fiador!");
        }
    }
}

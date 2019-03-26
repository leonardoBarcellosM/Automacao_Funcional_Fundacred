using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class DadosDoEstudanteSteps
    {
        private DadosDoEstudanteActions pageAction = new DadosDoEstudanteActions();

        [Given(@"Inserir o numero de integrantes da familia ""(.*)""")]
        public void GivenInserirONumeroDeIntegrantesDaFamilia(string arg)
        {
            bool result = pageAction.InserirIntegrantes(arg);

                Assert.True(result, "Erro ao inserir o número de inetegrantes!");
        }

        [When(@"Inserir a renda bruta mensal ""(.*)""")]
        public void WhenInserirARendaMensal(string arg)
        {
            bool result = pageAction.InserirRenda(arg);

                Assert.True(result, "Erro ao inserir a renda bruta mensal!");
        }

        [Given(@"Preencher os dados do estudante")]
        public void GivenPreencherOsDadosDoEstudante()
        {
            bool result = pageAction.PreencherDados();

                Assert.True(result, "Erro ao preencher os dados do estudante!");
        }

        [Given(@"Clicar no botao enviar")]
        public void GivenClicarNoBotaoEnviar()
        {
            bool result = pageAction.ClicarEnviar();

                Assert.True(result, "Erro ao enviar!");
        }

        [Then(@"Validar direcionamento para etapa 3")]
        public void ThenValidarDirecionamentoParaEtapa3()
        {
            var result = pageAction.ValidarDirecionamentoEtapa3();

                Assert.True(result, "Erro no direcionamento para a etapa 3");
        }

    }
}

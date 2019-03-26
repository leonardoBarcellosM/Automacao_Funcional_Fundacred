using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class DadosDoFiadorSteps
    {
        private const string V = ",";
        private DadosDoFiadorActions pageAction = new DadosDoFiadorActions();

        [Given(@"Inserir nome e cpf ""(.*)""")]
        public void GivenInserirNomeECpf(string arg)
        {
            bool result = pageAction.InserirNomeECpf(arg);

                Assert.True(result, "Erro ao inserir os dados - Nome e CPF!");
        }

        [When(@"Inserir data de nasc e renda ""(.*)""")]
        public void WhenInserirDataDeNascERenda(string arg)
        {
            var items = arg.Split('-');
            bool result = pageAction.InserirDtaERenda(items);

                Assert.True(result, "Erro ao inserir os dados - Data de nascimento e renda!");
        }

        [When(@"Clicar no botao enviar etapa 3")]
        public void WhenClicarNoBotaoEnviar()
        {
            bool result = pageAction.ClicarEnviarEtapa3();

                Assert.True(result, "Erro ao enviar!");
        }

        [Then(@"Validar direcionamento para etapa 4")]
        public void ThenValidarDirecionamentoParaEtapa4()
        {
            var result = pageAction.ValidarDirecionamentoEtapa4();

                Assert.True(result, "Erro no direcionamento para a etapa 4");
        }
    }
}

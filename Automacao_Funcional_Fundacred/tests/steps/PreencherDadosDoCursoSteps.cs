using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class PreencherDadosDoCursoSteps
    {
        private PreencherDadosDoCursoActions pageAction = new PreencherDadosDoCursoActions();

        [Given(@"Preencho matricula e percentual")]
        public void GivenPreenchoMatriculaEPercentual()
        {
            bool result = pageAction.PreencherMatricula();

                Assert.True(result, "Erro ao preencher os dados Matrícula e Percentual!");
        }

        [When(@"Preencho ano e semestre")]
        public void WhenPreenchoAnoESemestre()
        {
            bool result = pageAction.PreencherAnoSemestre();

                Assert.True(result, "Erro ao preencher os dados Ano e Semestre!");
        }

        [When(@"Clico em documentos")]
        public void WhenClicoEmDocumentos()
        {
            bool result = pageAction.AcessarDocumentos();

                Assert.True(result, "Erro ao clicar em documentos!");
        }


        [Then(@"Validar direcionamento documentos")]
        public void ThenValidarDirecionamentoDocumentos()
        {
            var result = pageAction.ValidarDirecionamentoDocumentos();

                Assert.True(result, "Erro durante o direcionamento para a tela de documentos!");
        }
    }

}

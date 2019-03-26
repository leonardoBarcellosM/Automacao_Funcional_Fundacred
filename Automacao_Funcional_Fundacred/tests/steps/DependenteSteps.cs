using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class DependenteSteps
    {
        DependenteCadastroActions pageAction = new DependenteCadastroActions();
        DadosDoEstudanteActions pageAction2 = new DadosDoEstudanteActions();
        ConsultaDB Db = new ConsultaDB();

        [Given(@"Preencho os dados do dependente")]
        public void GivenPreenchoOsDadosDoDependente()
        {
            bool result = pageAction.PreencherDadosDependente();

            Assert.True(result, "Erro ao inserir os dados pessoais do dependente!");
        }

        [When(@"Clico em enviar")]
        public void WhenClicoEmEnviar()
        {
            bool result = pageAction2.ClicarEnviar();

            Assert.True(result, "Erro ao enviar!");
        }

        [Then(@"Os dados do dependente devem ser salvos com sucesso na tabela dependentes")]
        public void ThenOsDadosDevemSerSalvosComSucessoNaTabelaDependentes()
        {
            bool result = pageAction.ValidarCadastroDeDependenteNoBanco();

            Assert.True(result, "Erro ao cadastrar os dados do dependente!");
        }

        [Then(@"Solicitacao iniciada com sucesso para o dependente")]
        public void ThenSolicitacaoIniciadaComSucessoParaODependente()
        {
            bool result = pageAction.ValidarCadastroDeDependenteNoBanco();

            Assert.True(result, "Erro ao cadastrar os dados do dependente!");
        }

        [Then(@"Solicitacao iniciada com sucesso na tabela solicitacoes_web para o dependente")]
        public void ThenSocliticacaoIniciadaComSucessoNaTabelaSolicitacoes_WebParaODependente()
        {
            bool result = Db.ConsultarSolicitacaoDependente();

            Assert.True(result, "Erro ao iniciar a solicitação na tabela de solicitacoes_web para o dependente!");
        }

        [Then(@"O requerente deve ser salvo na tabela pessoas_web")]
        public void ThenORequerenteDeveSerSalvoNaTabelaPessoas_Web()
        {
            bool result = Db.ConsultarCadastroRequerente();

            Assert.True(result, "Erro ao salvar o requerente na tabela PESSOAS_WEB");
        }

    }
}

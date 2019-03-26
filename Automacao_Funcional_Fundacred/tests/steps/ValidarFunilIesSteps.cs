using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class ValidarFunilIesSteps
    {
        ValidarFunilIesActions pageAction = new ValidarFunilIesActions();

        [Given(@"Consulto os dados no banco ""(.*)""")]
        public void GivenConsultoOsDadosNoBanco(string arg)
        {
            bool result = pageAction.ConsultarDB(arg);
            
                Assert.True(result, "Erro ao consultar o banco de dados!"); 
        }

        [Then(@"Consulto os dados do funil")]
        public void ThenConsultoOsDadosDoFunil()
        {
            bool result = pageAction.ConsultarDadosFunil();

            
                Assert.True(result, "Erro ao capturar os dados do funil!");
        }

        [Then(@"Valido solicitacoes iniciadas")]
        public void ThenValidoSolicitacoesIniciadas()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarIniciados(ref result, ref valores);

            Assert.True(result, "Dados não conferem - solicitacoes iniciadas: " + valores);
        }

        [When(@"Valido pendente analise fundacred")]
        public void WhenValidoPendenteFundacred()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarPendenteFundacred(ref result, ref valores);

            Assert.True(result, "Dados não conferem - pendente analise fundacred: " + valores);
        }

        [When(@"Valido Pendente analise ies")]
        public void WhenValidoPendenteAnaliseIes()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarPendenteIes(ref result, ref valores);

            Assert.True(result, "Dados não conferem - Pendente analise ies: " + valores);
        }

        [When(@"Valido aprovados")]
        public void WhenValidoAprovados()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarAprovados(ref result, ref valores);

            Assert.True(result, "Dados não conferem - aprovados: " + valores);
        }

        [When(@"Valido Fila De Espera IES")]
        public void WhenValidoFilaDeEsperaIES()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarFilaDeEsperaIES(ref result, ref valores);

            Assert.True(result, "Dados não conferem - Fila De Espera IES: " + valores);
        }

        [When(@"Valido reprovados fundacred")]
        public void WhenValidoReprovados()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarReprovadosFundacred(ref result, ref valores);

            Assert.True(result, "Dados não conferem - reprovados fundacred: " + valores);
        }

        [When(@"Valido reprovados ies")]
        public void WhenValidoReprovadosIes()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarReprovadosIes(ref result, ref valores);

            Assert.True(result, "Dados não conferem - reprovados ies: " + valores);
        }
        
    }
}

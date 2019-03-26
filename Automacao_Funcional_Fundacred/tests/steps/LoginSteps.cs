using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class LoginSteps
    {
        LoginActions pageAction = new LoginActions();

        LoginIesActions pageActionIes = new LoginIesActions();

        [Given(@"Preencher username e password")]
        public void GivenPreencherUsernameEPassword()
        {
            bool result = pageAction.PreencherUserPassword();

                Assert.True(result, "Erro ao preencher os dados!");
        }

        [When(@"Clico em sign in")]
        public void WhenClicoEmSignIn()
        {
            bool result = pageAction.ClicarSignIn();

                Assert.True(result, "Erro ao clicar no botão SignIn!");
        }

        [Then(@"Validar login com sucesso")]
        public void ThenValidarLoginComSucesso()
        {
            var result = pageAction.ValidarLoginCamunda();

                Assert.True(result, "Erro ao realizar login no camunda!");
        }

        [Given(@"Informo o email ""(.*)""")]
        public void GivenInformoOEmail(string arg)
        {
            bool result = pageActionIes.InformarEmail(arg);

                Assert.True(result, "Erro ao preencher o campo e-mail!");
        }

        [When(@"Informo a senha ""(.*)""")]
        public void WhenInformoASenha(string arg)
        {
            bool result = pageActionIes.InformarSenha(arg);

                Assert.True(result, "Erro ao preencher o campo senha!");
        }

        [When(@"Clico no botao Entrar")]
        public void WhenClicoNoBotaoEntrar()
        {
            bool result = pageActionIes.ClicarEmEntrar();

                Assert.True(result, "Erro ao clicar em entrar!");
        }

        [Then(@"Validar login Ies com sucesso")]
        public void ThenValidarLoginIesComSucesso()
        {
            var result = pageActionIes.ValidarLogin();

                Assert.True(result, "Erro ao realizar login no portal da IES!");
        }

        [Then(@"Validar Acesso ao portal")]
        public void ThenValidarAcessoAoPortalIes()
        {
            var result = pageAction.ValidarAcessoIes();

                Assert.True(result, "Erro ao acessar o portal da IES!");
        }

    }
}

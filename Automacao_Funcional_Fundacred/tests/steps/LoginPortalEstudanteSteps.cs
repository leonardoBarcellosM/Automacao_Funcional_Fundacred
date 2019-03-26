using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class LoginPortalEstudanteSteps
    {
        private LoginActions pageAction = new LoginActions();

        [Given(@"Clico no botao Entrar")]
        public void GivenClicoNoBotaoEntrar()
        {
            bool result = pageAction.AcessarTelaLogin();

            Assert.True(result, "Erro ao acessar a tela de login!");
        }

        [When(@"Preencho os campos nome e senha")]
        public void WhenPreenchoCampoESenha(Table table)
        {
            bool result = pageAction.PreencherCampos(table);

            Assert.True(result, "Erro ao preencher usuário e senha!");
        }

        [When(@"Clico em Entrar")]
        public void WhenClicoEntrar()
        {
            bool result = pageAction.Submit();

            Assert.True(result, "Erro ao clicar em entrar!");
        }


        [Then(@"Login deve ser ralizado com sucesso")]
        public void ThenLoginRealizadoComSucesso()
        {
            var result = pageAction.ValidarLogin();

            Assert.True(result, "Erro ao realizar login!");
        }

        ///////////////////////
        ///

        [When(@"Preencho o campo usuario ""(.*)""")]
        public void WhenPreenchoCampoUsuario(string arg)
        {
            bool result = pageAction.PreencherUsuario(arg);

            Assert.True(result, "Erro ao preencher usuário e senha!");
        }


        //[Then(@"Validar mensagem de senha incorreta")]
        //public void ThenValidarSenhaIncorreta()
        //{
        //var result = pageAction.ValidarSenhaIncorreta();

        //    Assert.True(result, "Erro ao apresentar mensagem de senha incorreta!");
        //}

        [Given(@"Acesso a tela de login")]
        public void GivenAcessoATelaDeLogin()
        {
            var result = pageAction.TelaLogin();

            Assert.True(result, "Erro ao acessar a tela de login!");
        }

        [Then(@"Verifico a mensagem de usuario ou senha incorretos")]
        public void ThenVerificoAMensagemDeUsuarioESenhaIncorretos()
        {
            var result = pageAction.VerificarMsgLoginInvalido();

            Assert.True(result, "Erro ao apresentar mensagem de senha incorreta!");
        }

        [Then(@"Verifico a mensagem de CPF invalido")]
        public void ThenVerificoAMensagemDeCPFInvalido()
        {
            var result = pageAction.VerificarMsgCpfInvalido();

            Assert.True(result, "Erro ao apresentar mensagem de senha incorreta!");
        }


    }
}

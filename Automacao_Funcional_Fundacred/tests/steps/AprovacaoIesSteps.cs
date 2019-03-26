﻿using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class AprovacaoIesSteps
    {
        AprovacaoIesActions pageAction = new AprovacaoIesActions();

        [Given(@"Acesso a opcao aprovacao")]
        public void GivenAcessoAprovacao()
        {
            var result = pageAction.AcessarAprovacao();

            Assert.True(result, "Erro ao acessar a opção aprovação!");
        }

        [When(@"Pesquiso a solicitacao ""(.*)""")]
        public void WhenPesquisoASolicitacaoDesejada(string cpf)
        {
            var result = pageAction.PesquisarSolicitacao(cpf);

            Assert.True(result, "Erro ao pesquisar solicitação com o CPF ->" + cpf);
        }

        [When(@"Clico em prosseguir confirmacao")]
        public void WhenClicoEmProsseguir()
        {
            var result = pageAction.ClicarEmProsseguir();

                Assert.True(result, "Erro ao prosseguir!");
        }

        [Then(@"Valido o acesso a tela aprovar solicitacao")]
        public void ThenValidarAcessoATelaAprovarSolicitacao()
        {
            var result = pageAction.ValidarTelaAprovar();
            //result = false;

                Assert.True(result, "Erro ao acessar o endereço solicitado!");
        }

        [Given(@"Preencho os dados pendentes")]
        public void GivenPreenchoOsDadosPendentes()
        {
            var result = pageAction.InserirDadosPendentes();

                Assert.True(result, "Erro ao preencher os dados pendentes");
        }

        [When(@"Preencho as informacoes de valores")]
        public void WhenPreenchoAsInformacoesDeValores()
        {
            var result = pageAction.InserirValores();

                Assert.True(result, "Erro ao preencher os valores do contrato ou adicionar o arquivo do contrato!");
        }

        [When(@"Clico em aprovar")]
        public void WhenClicoEmAprovar()
        {
            var result = pageAction.ClicarEmAprovar();

                Assert.True(result, "Erro ao clicar em aprovar!");
        }

        [Then(@"Valido solicitacao aprovada com sucesso")]
        public void ThenValidarSolicitacaoAprovada()
        {
            var result = pageAction.ValidarAprovacao();
            //result = false;
                Assert.True(result, "Erro ao aprovar a solicitação!");
        }

        [When(@"Clico em reprovar")]
        public void WhenClicoEmReprovar()
        {
            var result = pageAction.ClicarEmReprovar();
            //result = false;

                Assert.True(result, "Msg de erro");
        }

        [Then(@"Valido o acesso ao modal de reprovacao")]
        public void ThenValidoModalReprovar()
        {
            var result = pageAction.ValidarModalReprovar();
            //result = false;

                Assert.True(result, "Msg de erro");
        }

        /// <summary>
        /// 
        /// </summary>

        [Given(@"Seleciono a justificativa")]
        public void GivenSelecionoAJustificativa()
        {
            var result = pageAction.SelecionarJustificativaOutros();

                Assert.True(result, "Erro ao selecionar a justificativa");
        }

        [When(@"Clico em reprovar solicitacao")]
        public void WhenClicoEmReprovarSolicitacao()
        {
            var result = pageAction.Reprovar();

                Assert.True(result, "Erro ao clicar em reprovar");
        }

        [Then(@"Valido solicitacao reprovada com sucesso")]
        public void ThenValidoSolicitacaoReprovada()
        {
            var result = pageAction.ValidarReprovacaoComSucesso();

                Assert.True(result, "Erro ao reprovar a solicitação!");
        }
    }
}

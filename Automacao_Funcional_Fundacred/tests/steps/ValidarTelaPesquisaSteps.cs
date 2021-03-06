﻿using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    [Binding]
    public class ValidarTelaPesquisaSteps
    {
        ValidarTelaPesquisaAction pageAction = new ValidarTelaPesquisaAction();

        [When(@"Valido o direcionamento para a tela de pesquisa ""(.*)""")]
        public void WhenValidoODirecionamentoParaATelaDePesquisa(string arg)
        {
            bool result = pageAction.ValidarTelaDePesquisa(arg);

            Assert.True(result, "Erro - Valido o direcionamento para a tela de pesquisa!");
        }

        //[When(@"Verifico o filtro selecionado ""(.*)""")]
        //public void WhenVerificoOFiltroSelecionado(string arg)
        //{
        //    bool result = pageAction.ValidarFiltroSelecionado(arg);

        //    Assert.True(result, "Erro - Valido o direcionamento para a tela de pesquisa!");
        //}

        [Then(@"Verifico o total de ""(.*)""")]
        public void ThenVerificoOTotalDeSolicitacoesListadas(string arg)
        {
            bool result = false;
            string vlr = null;
            switch (arg)
            {
                case "Solicitações Iniciadas":
                    pageAction.ValidarTotalDeSolicitacoes(ref result, ref vlr, 0);
                    break;
                case "Reprovados Fundacred":
                    pageAction.ValidarTotalDeSolicitacoes(ref result, ref vlr, 1);
                    break;
                case "Pendente Análise Fundacred":
                     pageAction.ValidarTotalDeSolicitacoes(ref result, ref vlr, 2);
                    break;
                case "Pendente Análise Ies":
                    pageAction.ValidarTotalDeSolicitacoesPendentesIes(ref result, ref vlr, 3);
                    break;
                case "Reprovadas IES":
                    pageAction.ValidarTotalDeSolicitacoes(ref result, ref vlr, 4);
                    break;
                case "Aprovadas":
                    pageAction.ValidarTotalDeSolicitacoes(ref result, ref vlr, 5);
                    break;
                case "Fila De Espera":
                    pageAction.ValidarTotalDeSolicitacoes(ref result, ref vlr, 6);
                    break;

            }

            Assert.True(result, "Erro - Total de solicitacoes: "+ arg + " -> " + vlr);
        }

        [Given(@"Consulto a lista de etapas")]
        public void GivenConsultoAListaDeEtapas()
        {
            bool  result = pageAction.ValidarEtapasFiltro();

            Assert.True(result, "Erro - Consulto a lista de etapas!");
        }

        [Then(@"Verifico as informacoes basicas de listagem de solicitacao")]
        public void ThenConsultoAListaDeEtapas()
        {
            bool result = pageAction.ValidarInformacoesApresentadas();

            Assert.True(result, "Erro - Verifico as informacoes basicas de listagem de solicitacao!");
        }
    }
}

Feature: Portal_Estudante_Fluxo_De_Solicitacao

@01_AcessarPagina
Scenario: 1 Acessar o endereco
Given Acessar o endereco "http://homologacao.fundacred.org.br/estudante-web/#/"	
Then Validar o carregamento

@02_1Etapa
Scenario: 2 Iniciar Fluxo Comece Agora
Given Preencher os dados
When Clicar em Comece agora sem compromisso
Then Validar se o fluxo e iniciado

@02_1Etapa
Scenario: 3 Iniciar Solicitacao
Given Acessar a opcao solicitacao
When Clicar em quero solicitar o credito
Then Validar o direcionamento com sucesso

@02_1Etapa
Scenario: 4 Selecionar Instituicao
Given Selecionar instituicao "USF - UNIVERSIDADE SAO FRANCISCO"
When Selecionar curso "ADMINISTRAÇÃO-NOTURNO-BRAGANÇA"
And Clicar no botao aceito os termos
Then Validar solicitacao enviada

@02_1Etapa
Scenario: 5 Validar DB solicitação iniciada
Then Validar status de solicitacao no db "Solicitacao"

@02_2Etapa
Scenario: 6 Preencher Dados Do Estudante
Given Clicar no botao enviar
Then Validar direcionamento para etapa 3

@02_1Etapa
Scenario: 7 Validar DB atualização do estudante
Then Validar status de solicitacao no db "Estudante"

@03_3Etapa
Scenario: 8 Preencher Dados Do Fiador
Given Inserir nome e cpf " Leonardo Barcellos Teste "
When Inserir data de nasc e renda "5.000,00-06/08/2000"
And Clicar no botao enviar etapa 3
Then Validar direcionamento para etapa 4

@02_1Etapa
Scenario: 9 Validar DB atualização do fiador
Then Validar status de solicitacao no db "Fiador"

#@04_4Etapa
#Scenario: 10 Preencher Dados Pessoais
#Given Inserir os dados pessoais
#When Inserir endereco e contato
#And Clicar no botao proximo
#Then Validar direcionamento dados fiador
#
#@04_4Etapa
#Scenario: 11 Preencher Dados Completos Do Fiador
#Given Preencho os dados completos do fiador
#When Preencho contato e endereco
#And Clico em proximo
#Then Validar direcionamento Dados Curso
#
#@04_4Etapa
#Scenario: 13 Preencher Dados Do Curso
#Given Preencho matricula e percentual
#When Preencho ano e semestre
#And Clico em documentos
#Then Validar direcionamento documentos
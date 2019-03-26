Feature: Portal_Estudante_credNEX
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 'E' for Edge;
	 'H' for Headless Chrome;
	 Default: Chrome

Scenario: Acessar o endereco
Given Acessar o endereco "http://homologacao.fundacred.org.br/estudante-web/#/"	
Then Validar o carregamento

Scenario: Iniciar O Fluxo Comece Agora
Given Preencher os dados
When Clicar em Comece agora sem compromisso
Then Validar se o fluxo e iniciado

Scenario: Iniciar Solicitacao
Given Acessar a opcao solicitacao
When Clicar em quero solicitar o credito
Then Validar o direcionamento com sucesso

Scenario: Selecionar Instituicao E Curso
Given Selecionar instituicao "COLÉGIO ULBRA CRISTO SALVADOR"
When Selecionar curso "ENSINO MÉDIO"
And Seleciono a opcao Sou o responsavel pela assinatura
And Clicar no botao aceito os termos
Then Validar solicitacao enviada

Scenario: Preencher Os Dados Do Dependente E Validar O Banco De Dados
Given Preencho os dados do dependente
When Clico em enviar
Then Os dados do dependente devem ser salvos com sucesso na tabela dependentes
And O requerente deve ser salvo na tabela pessoas_web
And Solicitacao iniciada com sucesso na tabela solicitacoes_web para o dependente

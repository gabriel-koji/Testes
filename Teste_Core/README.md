----- Estrutura 
 - Projeto Teste.Base
 	- Projeto que possui as entidades e as funcionalidades relacionadas ao banco de dados
 - Projeto Teste.Business
 	- Projeto que possui as regras de negócio
 - Projeto Teste.Site
 	- Projeto que possui apenas a interface(Front)

----- Desafio 1 - número estranho
 - Projetos 
 	- Projeto Teste.Business
		- NumeroEstranho 
			- Calculo.cs
			- RetornoCalculo.cs
	- Projeto Teste.Site
		- Controller
			- HomeControler.cs
				- Index
		- Model
			- NumeroModel.cs
		- Views
			- Home
				- Index
				
				
----- Desafio 2 - Conexão com API
 - Projetos 
 	- Projeto Teste.Base
		- Domain
			- Cep.cs
		- Function
			- _CepsData.cs
 	- Projeto Teste.Business
		- CEP
			- GerenciamentoCep.cs
			- RetornoCep.cs
	- Projeto Teste.Site
		- Controller
			- HomeControler.cs
				- Cep
		- Model
			- CEPModel.cs
		- Views
			- Home
				- CEP
				
								
----- Conexão com banco
--- Não é um impeditivo para executar o teste, porém, se configurado irá salvar as informações em uma tabela.

- Criar uma base de dados, estou utilizando SQL Server
- Criar a Tabela CEP - arquivo CEP.sql
- Alterar a connection string da aplicação:
	No caminho: Codigo\Teste.Site\appsettings.Development.json


----- Imagens do resultado
- Na pasta Imagens, contém alguns prints do teste.

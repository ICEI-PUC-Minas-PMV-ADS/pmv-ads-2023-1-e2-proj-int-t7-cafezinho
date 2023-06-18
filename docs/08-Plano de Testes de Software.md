# Plano de Testes de Software

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.

 
| **Caso de Teste** | **CT-01 – Criar conta** 	|
| :---: | :--- |
| Requisito Associado | RF - 01 - Permitir ao usuário gerenciar seu cadastro na plataforma; <br> RF - 03 - Realizar a validação de credenciais do usuário. |
| Objetivo do Teste | Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos | - Abrir o navegador, <br> - Acessar a aplicação; <br> - Clicar em "Entrar"; <br> - Clicar em "Cadastrar";  <br> - Preencher os campos obrigatórios (CPF, nome, e-mail, data de nascimento, CEP, logradouro, cidade, estado e senha); <br> - Clicar em "Salvar". |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|Critério de Falha | - O usuário não consegue concluir o cadastro, e aparece na tela mostrando algum campo com preenchimento obrigatório. |
|  	|  	|
| **Caso de Teste** | **CT-02 – Efetuar login** |
| Requisito Associado | RF - 02 - Permitir ao usuário realizar o login na plataforma. |
| Objetivo do Teste | - Verificar se o usuário consegue fazer o login. |
| Passos | - Abrir o navegador; <br> - Acessar a aplicação; <br> - Clicar em "Entrar";  <br> - Preencher os dados cadastrados (CPF e senha); <br> - Clicar em "Entrar". |
|Critério de Êxito | - O usuário consegue fazer o login. |
|Critério de Falha | - O usuário não consegue fazer o login, e a aplicação retorna uma mensagem de erro: "Email e/ou senha incorreta". |
|  	|  	|
| **Caso de Teste** | **CT - 03 – Busca de ativos** |
| Requisito Associado | RF - 04 - Permitir a busca por nomes e tipos de ativos. |
| Objetivo do Teste | - Verificar se o usuário consegue buscar os ativos filtrando pelo nome ou pelo tipo. |
| Passos | - Clicar em "Registros"; <br> - Buscar o Ticker do ativo. |
|Critério de Êxito | - A aplicação vai retornar o ativo buscado pelo usuário. |
|Critério de Falha | - A aplicação retorna uma mensagem de erro: " O ativo buscado não foi encontrado". |
|  	|  	|
| **Caso de Teste** | **CT-04 – Registrar compra** |
| Requisito Associado | RF - 05 - 	Permitir que o usuário gerencie sua carteira de investimentos; <br> RF - 06 - Registrar a compra de ativos. |
| Objetivo do Teste | - Verificar se o usuário consegue realizar o cadastramento dos ativos na sua carteira. |
| Passos | - Clicar em "Registros"; <br> - Preencher as informações de negociação; <br> - Clicar em "Salvar". |
|Critério de Êxito | - O ativo será registrado na carteira do usuário. |
|Critério de Falha | - A aplicação não vai registrar o ativo e deve retornar uma mensagem de erro: "A ativo não foi registrado". |
|  	|  	|
| **Caso de Teste** | **CT-05 – Registrar venda** |
| Requisito Associado | RF - 05 - 	Permitir que o usuário gerencie sua carteira de investimentos; <br> RF - 07 - Registrar a venda de ativos. |
| Objetivo do Teste | - Verificar se o usuário consegue fazer a liquidação de um ativo da carteira. |
| Passos | - Clicar em "Carteira"; <br> - Escolher o ativo e clicar em "vender"; <br> - Preencher as informações de negociação; <br> - Clicar em "Vender". |
|Critério de Êxito | - O ativo é liquidado da carteira . |
|Critério de Falha | - O ativo não é liquidado, e a aplicação retorna uma mensagem de erro. |
|  	|  	|
| **Caso de Teste** | **CT-06 – Dashboard** |
| Requisito Associado | RF - 09 - Apresentar dashboard principal com recurso visual, identificando por tipos de ativos. |
| Objetivo do Teste | - Verificar se o dashboard apresenta as informações sobre a carteira do usuário. |
| Passos | - Abrir o navegador; <br> - Acessar a aplicação; <br> - Realizar o login;  <br> - Acessar dashboard principal da carteira. |
|Critério de Êxito | - Informações importantes serão apresentadas para o usuário. |
|  	|  	|
| **Caso de Teste** | **CT-07 – Relatórios** |
| Requisito Associado | RF - 08 - Realizar o processamento das informações solicitadas pelo usuário; <br> RF - 10 - Gerar relatório para acompanhamento dos ativos em carteira; <br> RF - 11 - Gerar relatório para acompanhamento da variação percentual dos ativos em carteira; <br> RF - 12 - Gerar relatório de patrimônio total, investido e/ou liquidado; <br> RF - 13 - Gerar relatório de preço médio e valorização/desvalorização médio, de um ativo da carteira do usuário. |
| Objetivo do Teste | - Verificar se a aplicação gera corretamente o relátorio solicitado pelo usuário. |
| Passos | - Abrir o navegador; <br> - Acessar a aplicação; <br> - Realizar o login;  <br> - Clicar em "Gerar relatório". |
|Critério de Êxito | - O relatório será gerado. |
|  	|  	|
| **Caso de Teste** | **CT-08 – Validar CEP** 	|
| Requisito Associado | RF - 03 - Realizar a validação de credenciais do usuário; <br> RF - 14 - Realizar a validação de CEP ao gerenciar cadastro de usuário. |
| Passos | - Abrir o navegador, <br> - Acessar a aplicação; <br> - Clicar em "Entrar"; <br> - Clicar em "Cadastrar";  <br> - Preencher o campo CEP; <br> - Clicar fora do campo CEP ou teclar "tab". |
|Critério de Êxito | - Não retornar as mensagens "Formato de CEP inválido", ao inserir CEP em formato inválido ou "CEP não encontrado", quando o CEP não existir na base de dados da API ViaCEP. |
|  	|  	|
| **Caso de Teste** | **CT-09 – Preencher campos de endereço automaticamente** 	|
| Requisito Associado | RF - 03 - Realizar a validação de credenciais do usuário; <br> RF - 15 - Preencher automaticamente os campos "Logradouro", "Bairro", "Cidade" e "Estado", após inserção de CEP válido, ao gerenciar cadastro de usuário. |
| Objetivo do Teste | Preencher automaticamente os campos "Logradouro", "Bairro", "Cidade" e "Estado". |
| Passos | - Abrir o navegador, <br> - Acessar a aplicação; <br> - Clicar em "Entrar"; <br> - Clicar em "Cadastrar";  <br> - Preencher o campo CEP; <br> - Clicar fora do campo CEP ou teclar "tab". |
|Critério de Êxito | - Preencher automaticamente os campos "Logradouro", "Bairro", "Cidade" e "Estado". |

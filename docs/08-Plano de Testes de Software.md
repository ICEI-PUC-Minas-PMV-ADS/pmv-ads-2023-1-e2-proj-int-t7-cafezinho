# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** | **CT-01 – Criar conta** 	|
| :---: | :--- |
| Requisito Associado | RF - 01 - Permitir ao usuário gerenciar seu cadastro na plataforma. |
| Objetivo do Teste | Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos | - Acessar o navegador; <br> - Informar o endereço do site ( .. ); <br> - Clicar em "Criar conta";  <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular,  senha e confirmação de senha); <br> - Aceitar os termos de uso; <br> - Clicar em "Registrar". |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|Critério de Falha | - ?? |
|  	|  	|
| **Caso de Teste** | **CT-02 – Efetuar login** |
| Requisito Associado | RF - 02 - Permitir ao usuário realizar o login na plataforma. |
| Objetivo do Teste | - Verificar se o usuário consegue fazer o login. |
| Passos | - Acessar o navegador; <br> - Informar o endereço do site ( .. ); <br> - Clicar em "Fazer login";  <br> - Preencher os dados cadastrados (e-mail e senha); <br> - Clicar em "Entrar". |
|Critério de Êxito | - O usuário consegue fazer o login. |
|Critério de Falha | - O usuário não consegue fazer o login, e a aplicação retorna uma mensagem de erro: "Email e/ou senha incorreta". |
|  	|  	|
| **Caso de Teste** | **CT-03 – Recuperar senha** |
| Requisito Associado | RF - 04 - Permitir que o usuário possa solicitar a recuperação de senha. |
| Objetivo do Teste | - Verificar se o usuário consegue redefinir sua senha. |
| Passos | - Acessar o navegador; <br> - Informar o endereço do site ( .. ); <br> - Clicar em "Fazer login";  <br> - Clicar em "Esqueci minha senha"; <br> - Iniciar procedimento de autenticação; <br> - Informar e confirmar nova senha. |
|Critério de Êxito | - Após o processo de redefinição da senha, a aplicação retorna uma mensagem de sucesso: "Sua senha foi redefinida com sucesso!". |
|Critério de Falha | - Caso o procedimento de autenticação não for realizado corretamente a aplicação retorna uma mensagem de erro: "Sua senha não foi redefinida." |
|  	|  	|
| **Caso de Teste** | **CT - 04 – Busca de ativos** |
| Requisito Associado | RF - 05 - Permitir a busca por nomes e tipos de ativos. |
| Objetivo do Teste | - Verificar se o usuário consegue buscar os ativos filtrando pelo nome ou pelo tipo. |
| Passos | - Acessar o navegador; <br> - Informar o endereço do site ( .. ); <br> - Realizar o login;  <br> - Clicar em "Buscar ativos"; <br> - Digitar o ativo procurado.|
|Critério de Êxito | - A aplicação vai retornar o ativo buscado pelo usuário. |
|Critério de Falha | - A aplicação retorna uma mensagem de erro: " O ativo buscado não foi encontrado". |
|  	|  	|
| **Caso de Teste** | **CT-05 – Registrar compra** |
| Requisito Associado | RF - 07 - Registrar a compra de ativos. |
| Objetivo do Teste | - Verificar se o usuário consegue realizar o cadastramento dos ativos na sua carteira. |
| Passos | - ??. |
|Critério de Êxito | - O ativo será registrado na carteira do usuário. |
|Critério de Falha | - A aplicação não vai registrar o ativo e deve retornar uma mensagem de erro: "A ativo não foi registrado". |
|  	|  	|
| **Caso de Teste** | **CT-06 – Registrar venda** |
| Requisito Associado | RF - 08 - Registrar a venda de ativos. |
| Objetivo do Teste | - Verificar se o usuário consegue fazer a liquidação de um ativo da carteira. |
| Passos | - ??. |
|Critério de Êxito | - O ativo é liquidado da carteira . |
|Critério de Falha | - O ativo não é liquidado, e a aplicação retorna uma mensagem de erro. |
|  	|  	|
| **Caso de Teste** | **CT-07 – Dashboard** |
| Requisito Associado | RF - 10 - Apresentar dashboard principal com recurso visual, identificando por tipos de ativos. |
| Objetivo do Teste | - Verificar se o dashboard apresenta as informações sobre a carteira do usuário. |
| Passos | - ??. |
|Critério de Êxito | - Informações importantes serão apresentadas para o usuário. |
|  	|  	|
| **Caso de Teste** | **CT-08 – Relatórios** |
| Requisito Associado | RF - 11 - Gerar relatório para acompanhamento dos ativos em carteira. <br> RF - 12 - Gerar relatório para acompanhamento da variação percentual dos ativos em carteira. <br> RF - 13 - Gerar relatório de patrimônio total, investido e/ou liquidado. <br> RF - 14 - Gerar relatório de preço médio e valorização/desvalorização médio, de um ativo da carteira do usuário. |
| Objetivo do Teste | - Verificar se a aplicação gera corretamente o relátorio solicitado pelo usuário. |
| Passos | - ??. |
|Critério de Êxito | - O relatório será gerado. |


 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)

# Plano de Testes de Usabilidade

## Objetivos do Teste de Usabilidade

O objetivo é avaliar a experiência geral do usuário com a aplicação, buscando analisar não somente a satisfação com o sistema, mas também a sua eficiência (esforço necessário para conclusão de uma tarefa) e eficácia (sucesso ou falha ao realizar uma tarefa) ao utilizar a aplicação.


## Método Utilizado
O teste será realizado remotamente em uma versão da aplicação a ser desenvolvida. Serão selecionados seis voluntários para participar dos testes de usabilidade e será coletado a idade de cada um deles. Ao concluir todo o roteiro de testes o participante irá preencher um questionário de satisfação.

Para cada tarefa que será designada aos participantes do teste, será possível mensurar: 

* Eficiência;
* Erros;
* Quantidade de erros;
* Satisfação.


Ao fim das tarefas a equipe de testes irá registrar todos os resultados obtidos.

## Roteiro de Testes

As tarefas a serem executadas pelos voluntários estão descritas no quadro abaixo:

| **CTU-01** | **Passos** | **Critério de Êxito** | **O que será avaliado** |
| :---: | :---: | :---: | :---: |
|Cadastro de novo usuário | - Abrir o navegador; <br> - Acessar a aplicação; <br> - Clicar em "Entrar"; <br> - Clicar em "Cadastrar";  <br> - Preencher os campos obrigatórios (CPF; nome; e-mail, data de nascimento, CEP, logradouro, cidade, estado e senha); <br> - Clicar em "Salvar". | O cadastro é realizado com sucesso | Eficiência, erros, satisfação |
| **CTU-02** | **Passos** | **Critério de Êxito** | **O que será avaliado** |
|Fazer o login no sistema | - Abrir o navegador; <br> - Acessar a aplicação; <br> - Clicar em "Entrar";  <br> - Preencher os dados cadastrados (CPF e senha); <br> - Clicar em "Entrar". | O usuário consegue fazer o login | Eficiênciação, erros, satisfação |
| **CTU-03** | **Passos** | **Critério de Êxito** | **O que será avaliado** |
|Busca de ativos| - Clicar em "Registros"; <br> - Clicar em "Create New"; <br> - Buscar o Ticker do ativo. | A aplicação vai retornar o ativo buscado pelo usuário. | Eficiência, erros, recorrência de erros, reminisciência e satisfação|
| **CTU-04** | **Passos** | **Critério de Êxito** | **O que será avaliado** |
| Efetuar a compra de ativos | - Clicar em "Registros"; <br> - Clicar em "Create New"; <br> - Preencher as informações de negociação; <br> - Escolher a opção de "Compra"; <br> - Clicar em "Create". | O usuário consegue efetivar a compra do ativo | Eficiência, erros, recorrência de erros, reminisciência e satisfação |
| **CTU-05** | **Passos** | **Critério de Êxito** | **O que será avaliado** |
| Efetuar a venda de ativos | - Clicar em "Registros"; <br> - Clicar em "Create New"; <br> - Preencher as informações de negociação; <br> - Escolher a opção de "Venda"; <br> - Clicar em "Create". | O usuário consegue realizar a liquidação do ativo da sua carteira | Eficiência, erros, recorrência de erros, reminisciência e satisfação |
| **CTU-06** | **Passos** | **Critério de Êxito** | **O que será avaliado** |
| Dashboard | - Abrir o navegador; <br> - Acessar a aplicação; <br> - Realizar o login;  <br> - Acessar dashboard principal da carteira. | O usuário consegue visualizar o dashboard. | Eficiência, erros, satisfação |
| **CTU-07** | **Passos** | **Critério de Êxito** | **O que será avaliado** |
| Gerar relatórios da carteira | - Abrir o navegador; <br> - Acessar a aplicação; <br> - Realizar o login;  <br> - Clicar em "Gerar relatório". | O usuário consegue gerar o relatório solicitado | Eficiência, erros, recorrência de erros, reminisciência e satisfação |
| **CTU-08** | **Passos** | **Critério de Êxito** | **O que será avaliado** |
| Validar CEP | - Abrir o navegador, <br> - Acessar a aplicação; <br> - Clicar em "Entrar"; <br> - Clicar em "Cadastrar";  <br> - Preencher o campo CEP; <br> - Clicar fora do campo CEP ou teclar "tab". | - Não retornar as mensagens "Formato de CEP inválido", ao inserir CEP em formato inválido ou "CEP não encontrado", quando o CEP não existir na base de dados da API ViaCEP. | Eficiência, erros, recorrência de erros, reminisciência e satisfação |
| **CTU-09** | **Passos** | **Critério de Êxito** | **O que será avaliado** |
| Preencher campos de endereço automaticamente | - Abrir o navegador, <br> - Acessar a aplicação; <br> - Clicar em "Entrar"; <br> - Clicar em "Cadastrar";  <br> - Preencher o campo CEP; <br> - Clicar fora do campo CEP ou teclar "tab". | - Preencher automaticamente os campos "Logradouro", "Bairro", "Cidade" e "Estado". | Eficiência, erros, recorrência de erros, reminisciência e satisfação |

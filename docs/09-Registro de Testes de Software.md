# Registro de Testes de Software

Segue abaixo o relatório com os resultados obtidos seguindo o plano de testes pré-definido.


## Caso de teste 01 - Cadastro
* Requisito Funcional relacionado: RF-01

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t7-cafezinho/assets/108690900/96022008-b3db-4991-bd79-ef29469d551b

## Caso de Teste 02 - Login
* Requisito Funcional relacionado: RF-02

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t7-cafezinho/assets/108690900/e5428fab-7950-4400-8967-336afaab738d

## Caso de Teste 03 - Buscar Ativos
 * Requisito Funcional relacionado: RF-05

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t7-cafezinho/assets/108690900/2e057a09-f407-4d43-bef3-0d933ce4418c

## Caso de Teste 04 - Compra
* Requisito Funcional relacionado: RF-07

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t7-cafezinho/assets/82981072/da9baba5-627b-40c9-bf2d-9ff0b2e0fd97

## Caso de Teste 05 - Venda
* Requisito Funcional relacionado: RF-08
### **No momento do registro, o usuário escolhe se vai fazer o cadastro ou a liquidação do ativo na carteira.**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t7-cafezinho/assets/82981072/a21e062a-f644-4361-973b-2b106ea61bb5

## Caso de Teste 06 - Dashboard
* Requisito Funcional relacionado: RF-010

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t7-cafezinho/assets/82981072/cbbe4af8-e382-48d1-90ac-622a6278a291

## Caso de Teste 07 - Relatórios
* Requisito Funcional relacionado: RF-11/12/13
### **No momento do registro, os relatórios ainda estão sendo implementados.**
![teste-relatorios](img/RegistroLista.png)
![teste-relatorios2](img/Home.png)

## Caso de Teste 08 - Validar CEP
* Requisito Funcional relacionado: RF-14

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t7-cafezinho/assets/82981072/f6519e6e-e1f5-499b-aa62-2c1de8803923

## Caso de Teste 09 - Preencher campos de endereço automaticamente
* Requisito Funcional relacionado: RF-15

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t7-cafezinho/assets/82981072/f81dd40d-69d6-40bf-af77-ccf12e538c9a

<br>

## Relatório de Testes de Software

| 1 | Criar Conta |
|:---:	|:---:	|
|	Requisito	| RF - 01 - Permitir ao usuário gerenciar seu cadastro na plataforma; <br> RF - 03 - Realizar a validação de credenciais do usuário. |
| Observação | Presente na página inicial, a funcionalidade de cadastro de conta é acionada ao clicar em "Cadastrar", após o preenchimento de informações essenciais como CPF, nome e e-mail a conta é criada e o usuário já pode realizar o login. Dessa forma, o requisito **RF - 01 Criar Conta** é atendido.|
|  	|  	|
| 2 | Efetuar login	|
| Requisito | RF - 02 - Permitir ao usuário realizar o login na plataforma. |
| Observação | Após a realização do cadastro, o usuário pode preencher os dados necessários CPF e senha para a realização do login e então será redirecionado para a tela da sua carteira. Com esta funcionalidade a aplicação atende ao requisito **RF - 02 Efetuar Login**.|
|  	|  	|
| 3 | Busca de ativos |
|Requisito | RF - 04 - Permitir a busca por nomes e tipos de ativos. |
| Observação | Antes de efetuar a compra, o usuário deve buscar um ativo pelo Ticker presente na lista que a aplicação oferece. Assim sendo, o requisito **RF - 04 Busca de ativos** foi atendido. |
|  	|  	|
| 4 | Registrar compra |
|Requisito | RF - 05 - 	Permitir que o usuário gerencie sua carteira de investimentos; <br> RF - 06 - Registrar a compra de ativos. |
| Observação | Após a busca e escolha do ativo, o usuário deve preencher as demais informações referente a compra. Os requisitos **RF - 05 Gerenciar carteira e RF - 06 Regsitrar compra** são atendidos. |
|  	|  	|
| 5 | Registrar venda |
|Requisito | RF - 05 - 	Permitir que o usuário gerencie sua carteira de investimentos; <br> RF - 07 - Registrar a venda de ativos. |
| Observação | Da mesma forma que acontece no registro de compra, porém agora o usuário deve escolher a opção de venda do ativo. Os requisitos **RF - 05 Gerenciar carteira e RF - 07 Regsitrar venda** são atendidos. |
|  	|  	|
| 6 | Dashboard |
|Requisitos | RF - 09 - Apresentar dashboard principal com recurso visual, identificando por tipos de ativos. |
| Observação | Ao acessar sua carteira o usuário entra na tela do dashboard, que vai mostrar por gráficos o conteúdo da sua carteira. Dessa forma, a aplicação atende ao requisito **RF - 09 Dashboard**. |
|  	|  	|
| 7 | Relatórios |
|Requisito | RF - 08 - Realizar o processamento das informações solicitadas pelo usuário; <br> RF - 10 - Gerar relatório para acompanhamento dos ativos em carteira; <br> RF - 11 - Gerar relatório para acompanhamento da variação percentual dos ativos em carteira; <br> RF - 12 - Gerar relatório de patrimônio total, investido e/ou liquidado; <br> RF - 13 - Gerar relatório de preço médio e valorização/desvalorização médio, de um ativo da carteira do usuário. |
| Observação |  |
|  	|  	|
| 8 | Validar CEP |
|Requisito | RF - 03 - Realizar a validação de credenciais do usuário; <br> RF - 14 - Realizar a validação de CEP ao gerenciar cadastro de usuário. |
| Observação | Ao realizar o cadastro, o usuário deve preencher o campo "CEP" com o formato válido e existente, caso contrário a aplicação irá retornar um aviso mostrando o erro. Assim, o requisito **RF - 14 Validar CEP** é atendido. |
|  	|  	|
| 9 | Preencher campos de endereço automaticamente |
|Requisito | RF - 03 - Realizar a validação de credenciais do usuário; <br> RF - 15 - Preencher automaticamente os campos "Logradouro", "Bairro", "Cidade" e "Estado", após inserção de CEP válido, ao gerenciar cadastro de usuário. |
| Observação | Complementando a validação do CEP, se o campo "CEP" for preenchido corretamente, a aplicação irá preencher de forma automática os seguintes campos "Logradouro", "Bairro", "Cidade", e "Estado". Com isso o requisito **RF - 15 Preencher campos de endereço automaticamente** também é atendido. |

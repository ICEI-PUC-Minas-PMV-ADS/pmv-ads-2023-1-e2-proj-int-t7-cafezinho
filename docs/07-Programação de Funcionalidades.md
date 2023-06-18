# Programação de Funcionalidades

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) | Responsável(eis) |
|------|-----------------------------------------|----|----|
|RF-01| Permitir ao usuário gerenciar seu cadastro na plataforma. | Cliente.cs, Create.cshtml, Edit.cshtml, Delete.cshtml, ClientesController.cs, FiltroCliente.cshtml e site.js| Flávio / Ronald|
|RF-02| Permitir ao usuário realizar o login na plataforma. | Login.cshtml e ClientesController.cs |Flávio / Ronald|
|RF-03| Realizar a validação de credenciais do usuário. | Login.cshtml e ClientesController.cs |Flávio / Ronald|
|RF-04| Permitir a busca por ativos através do TICKER. |  Registro.cs,  Create.cshtml, Delete.cshtml, Details.cshtml, Edit.cshtml, Index.cshtml e RegistrosController.cs | Amanda|
|RF-05| Permitir que o usuário gerencie sua carteira de investimentos. | Carteira.cs, Create.cshtml, Delete.cshtml, Details.cshtml, Edit.cshtml, Index.cshtml e CarteirasController.cs|Amanda|
|RF-06| Registrar a compra de ativos. | Registro.cs,  Create.cshtml, Delete.cshtml, Details.cshtml, Edit.cshtml, Index.cshtml e RegistrosController.cs|Amanda|
|RF-07| Registrar a venda de ativos. | Vender.cshtml, Index.cshtml, DeleteVenda.cshtml, CarteiraController.cs, _ViewStart.cshtml, _ViewImports.cshtml |Amanda / Flávio|
|RF-08| Realizar o processamento das informações solicitadas pelo usuário. | Em desenvolvimento |  |
|RF-09| Apresentar dashboard principal com recurso visual, identificando por tipos de ativos. | Index.cshtml e mdb.min.js |Diego / Pedro|
|RF-10| Gerar relatório para acompanhamento dos ativos em carteira (comprados/vendidos). | CarteiraController.cs, Index.cshtml | Amanda / Lucas / Matheus |
|RF-11| Gerar relatório para acompanhamento da variação percentual dos ativos em carteira. | Em desenvolvimento |  |
|RF-12| Gerar relatório de patrimônio total, investido e/ou liquidado. | Em desenvolvimento |  |
|RF-13| Gerar relatório de preço médio e valorização/desvalorização médio, de um ativo da carteira do usuário. | Em desenvolvimento |  |
|RF-14| Realizar a validação de CEP ao gerenciar cadastro de usuário. | Cliente.cs, Create.cshtml, ClientesController.cs e site.js | Flávio |
|RF-15| Preencher automaticamente os campos "Logradouro", "Bairro", "Cidade" e "Estado", após inserção de CEP válido, ao gerenciar cadastro de usuário. | Cliente.cs, Create.cshtml, ClientesController.cs e site.js | Flávio |

# Instruções de acesso

Para experimentar a aplicação, acesse [https://cafezinhonet.azurewebsites.net](https://cafezinhonet.azurewebsites.net/).  

É possível criar um novo usuário, ao clicar em "Entrar" na página inicial, e depois em "Cadastrar" na página de login.  
Esse usuário possuirá privilégios básicos, não conseguindo acessar páginas de gerenciamento de clientes e de ativos.  

O usuário com privilégio de administrador para teste completo da aplicação é:  
CPF: 001
Senha: 1234
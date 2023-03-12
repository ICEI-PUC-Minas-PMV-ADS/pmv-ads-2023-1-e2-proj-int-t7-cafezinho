# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

## Histórias de Usuários

| EU COMO... `PERSONA`    | QUERO/PRECISO ... `FUNCIONALIDADE`                 | PARA ... `MOTIVO/VALOR`                              |
|-------------------------|----------------------------------------------------|------------------------------------------------------|
| Estudante universitário | Acompanhar meus investimentos                      | Não ter problemas financeiros no futuro              |
| Estudante universitário | Acompanhar meus rendimentos                        | Poder planejar a aquisição de bens materiais         |
| Mãe e trabalhadora      | Registrar meus investimentos                       | Poder planejar uma viagem com meus filhos            |
| Mãe e trabalhadora      | Ter o rendimento em tempo real dos meus investimentos | Poder tomar descisões de compra/venda de ativos   |
| Aposentada              | Visualizar meu patrimônio                          | Poder decidir qual o destino da minha próxima viagem |
| Aposentada              | Visualizar meus resgates                           | Poder investir melhor em outro(s) ativo(s)           |
| Empresária              | Gerenciar o dinheiro investido                     | Saber quanto estou recebendo           |
| Empresária              | Saber onde investir                                | Devolver para a minha empresa          |
| CEO                     | Coordenar meus investimentos                       | Investir conscientemente               |
| CEO                     | Saber o meu valor total investido                  | Gerenciar melhor minhas fontes de renda|


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| Permitir ao usuário realizar o cadastro na plataforma. | ALTA | 
|RF-02| Permitir lançamentos de arrecadação e/ou dispêndio.   | ALTA |
|RF-03| Permitir a exclusão e/ou alteração de um lançamento.   | ALTA |
|RF-04| Criação de um dashboard principal com as movimentações do mês atual.   | ALTA |
|RF-05| Criação de categorias para organização de recebimentos e consumos.   | ALTA |
|RF-06| Listar ativos do mercado financeiro.   | ALTA |
|RF-07| Apresentação dos resultados financeiros com recursos visuais (grágicos).  | MÉDIA |
|RF-08| Simulação de rendimentos de aplicações do usuário indexada a algum dos ativos financeiros do mercado.   | BAIXA |
|RF-09| Incluir informações sobre os principais ativos do mercado financeiro (principais ações da B3, criptomoedas, Selic, etc).   | BAIXA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku)  | ALTA | 
|RNF-02| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) |  ALTA | 
|RNF-03| O site deve ter bom nível de contraste entre os elementos da tela em conformidade. |  ALTA |
|RNF-04| O site deve ser desenvolvido com layout simples, organizado e intuitivo. |  ALTA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deve ser entregue até o final do semestre |
|RE-02| A equipe do projeto não poderá subcontratar o desenvolvimento do projeto.        |

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)

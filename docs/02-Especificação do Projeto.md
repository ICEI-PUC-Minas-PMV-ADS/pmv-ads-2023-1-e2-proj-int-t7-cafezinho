# Especificações do Projeto

A escolha do problema foi definida por meio de discussões e estudos realizados pelos membros da equipe.  
Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

`João`: Idade: 22 anos. Profissão: estudante universitário. Aplicativos: Instagram, Twitter, TikTok, Nubank. Frustrações: falta de uma plataforma moderna que lhe permita organizar seus investimentos. Hobbies: tendências tecnológicas e esportes. Motivações: maneiras de se manter atualizado com as últimas tendências tecnológicas e de esportes, e está sempre buscando novas experiências e aventuras.

`Bárbara`: Idade: 35 anos, mãe de dois filhos. Profissão: professora universitária. Aplicativos: Facebook, Instagram, ModalMais Investimentos. Frustrações: Dificuldade em se manter atualizada a respeito dos movimentos do mercado financeiro diariamente. Hobbies: sair com sua família e amigos nos finais de semana. Motivações: entender mais sobre o mercado financeiro e conseguir realizar melhores investimentos.

`Helena`: Idade: 44 anos. Profissão: Empresária. Aplicativos: Instagram, XP Investimentos, Banco do Brasil, Google Finance. Frustrações: grande número de bancos, financeira e aplicativos dificultam a aferição de seu patrimônio investido de forma automatizada. Hobbies: atividades físicas, cuidar da saúde e bem-estar. Motivações: novas oportunidades de negócios para que consiga alavancar seus investimentos, tendo informações rápidas e precisas.

`Felipe`: Idade: 53 anos, pai. Profissão: CEO de um startup no ramo de tecnologia. Aplicativos: Bradesco Conta, Cartão e Pix, Clear Corretora, Gmail. Frustrações: dificuldade em quantificar seu rendimento em carteira e cotação média dos ativos ao longo do tempo. Hobbies: de aprender sobre investimentos e praticar atividades físicas e esportes com sua família. Motivação: gerir melhor seu patrimônio para realizar investimentos mais lucrativos e poder passar mais tempo com sua família.

## Histórias de Usuários

| EU COMO... `PERSONA`    | QUERO/PRECISO ... `FUNCIONALIDADE`                 | PARA ... `MOTIVO/VALOR`                              |
|-------------------------|----------------------------------------------------|------------------------------------------------------|
| Estudante universitário | Acompanhar meus investimentos                      | Não ter problemas financeiros no futuro              |
| Estudante universitário | Acompanhar a variação percentual dos ativos em carteira | Poder planejar a aquisição de bens materiais    |
| Estudante universitário | Visualizar meus ativos em forma de relatórios e dashboards       | Poder decidir com mais precisão quais papeis adquirir no futuro  |
| Mãe e trabalhadora      | Registrar meus investimentos                       | Poder planejar uma viagem com meus filhos            |
| Mãe e trabalhadora      | Ter a cotação em tempo real dos meus ativos       | Poder tomar descisões de compra/venda de ativos      |
| Mãe e trabalhadora      | Acompanhar meus investimentos de forma mais precisa                            | Futuramente aumentar minha reserva de emergência com a venda de ativos         |
| Empresária              | Gerenciar o dinheiro investido                     | Saber quanto estou recebendo em cada operação de venda           |
| Empresária              | Ter em uma única plataforma todos os meus investimentos em ações e criptomoedas  | Realizar um controle financeiro mais eficiente           |
| Empresária              | Visualizar meu patrimônio                          | Para decidir quanto eu posso retirar para a proxima viagem |
| CEO                     | Coordenar meus investimentos                       | Investir de forma a maximizar meus ganhos no mercado financeiro           |
| CEO                     | Saber a cotação média dos ativos                   | Para saber a valorização patrimonial ao longo dos meses |
| CEO                     | Quantificar o que recebi com as operações em bolsa                           | Poder investir outro(s) ativo(s)      |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais, que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| Permitir ao usuário gerenciar seu cadastro na plataforma. | ALTA |
|RF-02| Permitir ao usuário realizar o login na plataforma. | ALTA |
|RF-03| Realizar a validação de credenciais do usuário. | ALTA | 
|RF-04| Permitir a busca por nomes e tipos de ativos. | ALTA |
|RF-05| Permitir que o usuário gerencie sua carteira de investimentos. | ALTA |
|RF-06| Registrar a compra de ativos. | ALTA |
|RF-07| Registrar a venda de ativos. | ALTA |
|RF-08| Realizar o processamento das informações solicitadas pelo usuário. | ALTA |
|RF-09| Apresentar dashboard principal com recurso visual, identificando por tipos de ativos. | MÉDIA |
|RF-10| Gerar relatório para acompanhamento dos ativos em carteira. | ALTA |
|RF-11| Gerar relatório para acompanhamento da variação percentual dos ativos em carteira. | BAIXA |
|RF-12| Gerar relatório de patrimônio total, investido e/ou liquidado. | ALTA |
|RF-13| Gerar relatório de preço médio e valorização/desvalorização médio, de um ativo da carteira do usuário. | BAIXA |
|RF-14| Realizar a validação de CEP ao gerenciar cadastro de usuário. | BAIXA |
|RF-15| Preencher automaticamente os campos "Logradouro", "Bairro", "Cidade" e "Estado", após inserção de CEP válido, ao gerenciar cadastro de usuário. | BAIXA |



### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku).  | ALTA | 
|RNF-02| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge). | ALTA |
|RNF-03| A aplicação deverá ser responsiva permitindo a visualização em diversos dispositivos de forma adequada. | ALTA |
|RNF-04| O site deve ter bom nível de contraste entre os elementos da tela em conformidade. | ALTA |
|RNF-05| O site deve ser desenvolvido com layout simples, organizado e intuitivo. | ALTA |
|RNF-06| A aplicação deve se comunicar com o banco de dados SQL. | ALTA | 
|RNF-07| A aplicação deve estár acessível e sem interrupções por pelo menos 95% do tempo, apresentando um tempo de inatividade mínimo. | ALTA | 
|RNF-08| A aplicação deverá realizar a validação de CEP e preencher automaticamente campos de endereço utilizando a API [ViaCEP](https://viacep.com.br/). | BAIXA | 
|RNF-09| A aplicação deverá usar a API [Brapi](https://brapi.dev/) para preencher o banco de dados de ativos. | BAIXA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deve ser entregue até o final do semestre. |
|RE-02| A equipe do projeto não poderá subcontratar o desenvolvimento do projeto. |

## Diagrama de Casos de Uso

O diagrama de casos de uso contempla as principais ligações entre os atores e os casos de uso, além de permitir identificar os requisitos funcionais apresentados anteriormente.

![Diagrama de uso](./img/Diagrama-caso-de-uso.png "Diagrama do sistema")

Foi utilizada a ferramenta [Lucidchart](https://www.lucidchart.com/) para elaborar o diagrama de casos de uso.

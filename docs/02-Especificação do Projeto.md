# Especificações do Projeto

## Personas

Teresa tem 40 anos, tem uma filha, é jornalista e estuda Análise e Desenvolvimento de Sistemas, a distância, em uma universidade de Minas Gerais. Pensa em fazer transição de carreira para a área de tecnologia da informação, mas teme ter dificuldade de encontrar oportunidades de trabalho, em virtude da sua idade e por não ter uma rede de contatos com pessoas que atuem no setor de TI.|

Albano tem 52 anos, é engenheiro agrônomo e sócio em uma *startup* que desenvolveu uma solução inovadora de [agricultura de precisão](https://pt.wikipedia.org/wiki/Agricultura_de_precis%C3%A3o). Com a expansão dos negócios, o quadro de trabalhadores da empresa quadruplicou em três anos. Até o final de 2023, estima-se que a empresa precisará de oito novos empregados, entre desenvolvedores de software e analistas comerciais.

Victor Almeida tem 38 anos, é Sócio e Diretor de uma empresa de Desenvolvimento de Software e criação de websites, com mais de 20 anos de experiência na área de t.i e gestão de projetos. Carlos está enfrentando dificuldades em encontrar profissionais qualificados para sua empresa. Muitos dos candidatos que ele encontra não possuem experiência na área de TI ou têm interesse em seguir outras carreiras além de sua formação. Isso torna difícil encontrar pessoas que possuam as habilidades técnicas necessárias e também estejam dispostas a se comprometer com a área de TI a longo prazo.

Aurora Barcelos tem 25 anos, formou-se recentemente em Ciência da Computação. Durante seu periodo academico teve um otimo desempenho e participou de diversos projetos de pesquisas e desenvolvimento na area de inteligencia artifical. Apesar de sua sólida formação acadêmica, Aurora está enfrentando dificuldades para ingressar no mercado de TI. Ela percebe que a maioria das vagas exige experiência profissional relevante, o que ele não possui. Aurora também sente que a concorrência é acirrada, com muitos candidatos mais experientes disputando as mesmas oportunidades.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Teresa              | Localizar vagas de trabalho na modalidade home office | Conseguir uma oportunidade profissional como desenvolvedora mobile junior |
|Teresa              | Descrever no meu perfil as minhas habilidades como desenvolvedora de software | Ser encontrada por empresas de TI |
|Albano              | Anunciar vagas de trabalho | Selecionar profissionais com o perfil desejado pela minha empresa |
|Albano              | Localizar profissionais a partir das suas habilidades ("hard skills") | Convidar pessoas a ingressar na empresa sem precisar anunciar uma vaga na plataforma |
|João                | Encontrar profissionais qualificados na área de TI que estejam alinhados com os objetivos e necessidades da empresa. | Impulsionar o desenvolvimento de software, inovar, gerenciar projetos, oferecer suporte técnico, manter os sistemas e impulsionar o crescimento e a expansão de sua empresa de software. |
|João                | Contratar profissionais de TI altamente qualificados. |  Impulsionar o crescimento da equipe e garantir a satisfação dos clientes. |
|Aurora              | Ingressar no mercado de T.I | Impulsionar sua carreira profissional. | 
|Aurora              | Oportunidade no mercado de T.I | Aprimorar suas habilidades e obter experiências praticas. | 

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-------------------------|------------|
|RF-001| A aplicação deve permitir que o usuário (empresa ou profissional) gerencie um perfil na plataforma | ALTA | 
|RF-002| A aplicação deve permitir que a empresa gerencie vagas de trabalho | ALTA | 
|RF-003| A aplicação deve permitir que o profissional se candidate a vagas de trabalho  | ALTA |
|RF-004| A aplicação deve permitir que o profissional encontre vagas por meio de um mecanismo de pesquisa  | ALTA |
|RF-005| A aplicação deve permitir que a empresa defina as qualificações que procura em um profissional | ALTA |
|RF-006| A aplicação deve permitir que o profissional se autoavalie de acordo com as qualificações definidas pela empresa | ALTA |
|RF-007| A aplicação deve permitir que a empresa visualize os resultados das autoavaliações | ALTA |
|RF-008| A aplicação deve permitir que a empresa encontre profissionais por meio de um mecanismo de pesquisa  | MÉDIA |
|RF-009| A aplicação deve permitir que o profissional acompanhe o status de suas candidaturas. | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  | Prioridade |
|-------|-------------------------|------------|
|RNF-001| O sistema deve ser responsivo, de modo a ser adequadamente exibido em dispositivos móveis | MÉDIA |
|RNF-002| O sistema deve ser implementado na linguagem de programação C# | ALTA | 
|RNF-003| O sistema deve manter o tempo máximo de resposta para qualquer interação do usuário na aplicação abaixo de 15 segundos | MÉDIA |
|RNF-004| O sistema deve ser capaz de suportar até 1000 usuários navegando simultaneamente, mantendo um tempo de resposta satisfatório e sem degradação significativa de desempenho | MÉDIA |
|RNF-005| O sistema deve garantir a segurança dos dados dos usuários, protegendo as informações pessoais e confidenciais armazenadas na aplicação | ALTA | 

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição |
|--|-----------|
|RE-01|A aplicação deve ser entregue de forma plenamente funcional até 06/12/2023.  |
|RE-02|A aplicação deve ser desenvolvida exclusivamente pelos membros do grupo.  |
|RE-03|A apliação deve exigir que apenas os usuários residentes no Brasil de candidatem as vagas de emprego.

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)

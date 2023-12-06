# Registro de Testes de Software

A seguir, apresentamos o registro das evidências dos testes realizados na aplicação pela equipe, que confirmam se o critério de êxito foi alcançado ou não.

| Caso de Teste            | Evidência |
|--------------------------|-----------|
| CT-01 - Gerenciamento de pefil | - [Gerenciamento de pefil Profissional](https://youtu.be/oZBRNcfHrPA) - [Gerenciamento de pefil Empresa](https://youtu.be/YaWCPWE-9tM) |
| CT-02 - Gerenciamento de vagas | - [criar e gerenciar vagas](https://youtu.be/EVeq6dI3mtQ) 
| CT-03 - Candidatura a vagas | - [Candidatura a vagas de emprego ](https://youtu.be/5N9EPc--MJg) 
| CT-11 - Login, Cadastro  | - [Cadastro e Login Profissional](https://www.youtube.com/embed/8Hyh923iCoQ?si=7ELGPodV6Gs24zMi) - [Cadastro e Login Empresa](https://www.youtube.com/embed/cAc-FRB0LT8?si=pOKAe8takrv2sF1r) |
| CT-13 - Cadastro de Currículo | - [Cadastro de currículo Profissional](https://youtu.be/ieDeD6ODWoQ)  |
 

## Relatório de Testes de Software

O objetivo deste relatório é indicar se a aplicação TechTalent atende aos requisitos previamente propostos e sugerir possíveis pontos de correção.

| 1 | Gerenciar Perfil |
|--------------------------|-----------|
| Requisito | RF - 001 - 	A aplicação deve permitir que tanto empresas quanto profissionais criem e gerenciem seus perfis na plataforma. Isso inclui a capacidade de preencher informações relevantes, como nome, informações de contato, descrição da empresa e quaisquer outras informações relevantes. Os perfis devem ser personalizáveis e editáveis a qualquer momento. | 
| Observação | A solução atende parcialmente ao requisito de gerenciamento de perfil. Após o login, o usuário pode editar seus dados cadastrais, sendo empresa ou profissional, mas o usuário encontra erros ao tentar modificar a senha. Dito isso, uma alternativa a se considerar será a revisão do código para a resolução do problema. |


| Caso de Teste            | Avaliação |
|--------------------------|-----------|
| CT-01 – Gerenciamento de perfil | A solução atende parcialmente ao requisito de gerenciamento de perfil. Após o login, o usuário pode editar seus dados cadastrais, sendo empresa ou profissional, mas o usuário encontra erros ao tentar modificar a senha. Dito isso, uma alternativa a se considerar será a revisão do código para a resolução do problema. |


| Caso de Teste            | Avaliação |
|--------------------------|-----------|
| CT-02 – Gerenciamento de vagas | A solução atende ao requisito proposto, permitindo que o usuário, definido como empresa, crie e gerencie suas vagas, fazendo com que usuários, definidos como profissionais, se candidatem com êxito nas vagas criadas. Durante o processo de desenvolvimento, enfrentei inúmeras situações desafiadoras, como erros relacionados ao banco de dados e à formatação do código. Esses desafios me levaram a compreender a extrema importância de manter o código organizado e limpo para facilitar sua compreensão. Pretendo aplicar esses ensinamentos na próxima etapa, visando um desenvolvimento mais eficiente e evitando possíveis erros futuros. Além disso, é de extrema importância trabalhar em melhorias relacionadas à formatação dos campos, possibilitando que os usuários tenham mais facilidade ao cadastrar seus dados. |



| Caso de teste            | Avaliação | 
|--------------------------|-----------|
| CT-003 - Candidatura a vagas  | A solução atende plenamente aos requisitos estabelecidos, proporcionando ao usuário (profissional) a capacidade de visualizar oportunidades de emprego, candidatar-se a elas e revisar facilmente as vagas às quais se candidatou. A navegação entre as páginas opera de maneira eficaz, garantindo uma experiência fluida e intuitiva. |


| Caso de Teste            | Avaliação |
|--------------------------|-----------|
| CT-11 - Login, Cadastro  | A solução atende ao requisito conforme o esperado, permitindo que os usuários realizem o processo de cadastro e login, seja como empresa ou como profissional. As validações dos campos nos formulários de cadastro e login, como o tamanho da senha e a verificação se o e-mail já está sendo utilizado, funcionam corretamente. A navegação e as permissões entre as páginas funcionam adequadamente, com a opção de cadastro e perfil de usuário aparecendo somente após o login. Além disso, a performance de navegação não apresenta problemas. O principal desafio será consolidar o perfil do usuário, tanto como empresa quanto como profissional. Uma alternativa em consideração é ocultar a aba de usuário para ambos e adicionar o e-mail no perfil de profissional e empresa com base no usuário. Se o usuário excluir o perfil, implementaremos um fluxo de saída e será necessário um novo cadastro, sem a capacidade de recuperação de dados. Além disso, é de extrema importância trabalhar no requisito de recuperação de senha. |

| Caso de Teste            | Avaliação |
|--------------------------|-----------|
| CT-013– Cadastro de currículo | A solução atende ao requisito como esperado, o profissional consegue cadastrar e gerenciar seu currículo. A funcionalidade permite que o usuário cadastre seu resumo profissional e, após isso, cadastre sua formação acadêmica e experiência profissional que podem ser visualizadas na página de resumo profissional. Alguns desafios encontrados foram, a formatação dos campos (Data e hora onde é necessário apenas data) e a visualização das informações inseridas pelo usuário na página de resumo profissional. Dito isso, uma alternativa a ser considerada é a mudança na formatação dos campos e um atalho que facilite ao usuário o retorno para a página com todas as informações. Além disso, outro desafio encontrado foi que o usuário não consegue cadastrar seu cargo atual na experiência profissional e uma formação em andamento na formação acadêmica. Isso posto, uma alternativa a ser considerada é uma opção disponível para o usuário escolher se as informações que ele está digitando é sobre seu cargo atual/ formação acadêmica em andamento ou criar um novo campo. |


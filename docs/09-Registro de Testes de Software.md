# Registro de Testes de Software

A seguir, apresentamos o registro das evidências dos testes realizados na aplicação pela equipe, que confirmam se o critério de êxito foi alcançado ou não.

| Caso de Teste            | Evidência |
|--------------------------|-----------|
| CT-01- Gerenciamento de pefil | - [Gerenciamento de pefil Profissional](https://youtu.be/oZBRNcfHrPA) - [Gerenciamento de pefil Empresa](https://youtu.be/YaWCPWE-9tM) |
| CT-11 - Login, Cadastro  | - [Cadastro e Login Profissional](https://www.youtube.com/embed/8Hyh923iCoQ?si=7ELGPodV6Gs24zMi) - [Cadastro e Login Empresa](https://www.youtube.com/embed/cAc-FRB0LT8?si=pOKAe8takrv2sF1r) |
| CT-13 -  Cadastro de Currículo | - [Cadastro de currículo Profissional](https://youtu.be/ieDeD6ODWoQ)  |

## Avaliação

A seguir, exibimos os resultados dos testes, destacando tanto os aspectos positivos quanto os desafios identificados na solução. Também discutiremos como planejamos abordar esses desafios nas próximas iterações, incluindo as falhas detectadas e as melhorias decorrentes dos resultados dos testes.


| Caso de Teste            | Avaliação |
|--------------------------|-----------|
| CT-01 – Gerenciamento de perfil | A solução atende parcialmente ao requisito de gerenciamento de perfil. Após o login, o usuário pode editar seus dados cadastrais, sendo empresa ou profissional, mas o usuário encontra erros ao tentar modificar a senha. Dito isso, uma alternativa a se considerar será a revisão do código para a resolução do problema. |

| Caso de Teste            | Avaliação |
|--------------------------|-----------|
| CT-11 - Login, Cadastro  | A solução atende ao requisito conforme o esperado, permitindo que os usuários realizem o processo de cadastro e login, seja como empresa ou como profissional. As validações dos campos nos formulários de cadastro e login, como o tamanho da senha e a verificação se o e-mail já está sendo utilizado, funcionam corretamente. A navegação e as permissões entre as páginas funcionam adequadamente, com a opção de cadastro e perfil de usuário aparecendo somente após o login. Além disso, a performance de navegação não apresenta problemas. O principal desafio será consolidar o perfil do usuário, tanto como empresa quanto como profissional. Uma alternativa em consideração é ocultar a aba de usuário para ambos e adicionar o e-mail no perfil de profissional e empresa com base no usuário. Se o usuário excluir o perfil, implementaremos um fluxo de saída e será necessário um novo cadastro, sem a capacidade de recuperação de dados. Além disso, é de extrema importância trabalhar no requisito de recuperação de senha. |

| Caso de Teste            | Avaliação |
|--------------------------|-----------|
| CT-013– Cadastro de currículo | A solução atende ao requisito como esperado, o profissional consegue cadastrar e gerenciar seu currículo. A funcionalidade permite que o usuário cadastre seu resumo profissional e, após isso, cadastre sua formação acadêmica e experiência profissional que podem ser visualizadas na página de resumo profissional. Alguns desafios encontrados foram, a formatação dos campos (Data e hora onde é necessário apenas data) e a visualização das informações inseridas pelo usuário na página de resumo profissional. Dito isso, uma alternativa a ser considerada é a mudança na formatação dos campos e um atalho que facilite ao usuário o retorno para a página com todas as informações. Além disso, outro desafio encontrado foi que o usuário não consegue cadastrar seu cargo atual na experiência profissional, sendo uma alternativa a ser considerada uma opção disponível para o usuário escolher se é seu cargo atual ou não, ou criar um novo campo. |


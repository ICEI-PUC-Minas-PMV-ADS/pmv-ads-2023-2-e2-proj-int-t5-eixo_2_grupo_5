# Registro de Testes de Software

A seguir, apresentamos o registro das evidências dos testes realizados na aplicação pela equipe, que confirmam se o critério de êxito foi alcançado ou não.

| Caso de Teste            | Evidência |
|--------------------------|-----------|
| CT-11 - Login, Cadastro  | - [Cadastro e Login Profissional](https://www.youtube.com/embed/8Hyh923iCoQ?si=7ELGPodV6Gs24zMi) - [Cadastro e Login Empresa](https://www.youtube.com/embed/cAc-FRB0LT8?si=pOKAe8takrv2sF1r) |






## Avaliação

A seguir, exibimos os resultados dos testes, destacando tanto os aspectos positivos quanto os desafios identificados na solução. Também discutiremos como planejamos abordar esses desafios nas próximas iterações, incluindo as falhas detectadas e as melhorias decorrentes dos resultados dos testes.


| Caso de Teste            | Evidência |
|--------------------------|-----------|
| CT-11 - Login, Cadastro  | A solução atende ao requisito conforme o esperado, permitindo que os usuários realizem o processo de cadastro e login, seja como empresa ou como profissional.

As validações dos campos nos formulários de cadastro e login, como o tamanho da senha e a verificação se o e-mail já está sendo utilizado, funcionam corretamente.

A navegação e as permissões entre as páginas funcionam adequadamente, com a opção de cadastro e perfil de usuário aparecendo somente após o login. Além disso, a performance de navegação não apresenta problemas.

O principal desafio será consolidar o perfil do usuário, tanto como empresa quanto como profissional. Uma alternativa em consideração é ocultar a aba de usuário para ambos e adicionar o e-mail no perfil de profissional e empresa com base no usuário. Se o usuário excluir o perfil, implementaremos um fluxo de saída e será necessário um novo cadastro, sem a capacidade de recuperação de dados.

Além disso, é de extrema importância trabalhar no requisito de recuperação de senha. |

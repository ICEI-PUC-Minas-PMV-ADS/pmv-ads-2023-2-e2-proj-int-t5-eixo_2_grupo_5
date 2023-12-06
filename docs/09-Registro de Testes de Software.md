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


| 2 | Gerenciar Vagas |
|--------------------------|-----------|
| Requisito | RF - 002 - A aplicação deve ter a capacidade de permitir que uma empresa crie e gerencie vagas de trabalho disponíveis na plataforma. As empresas devem ser capazes de fornecer detalhes sobre a vaga, como título, descrição, localização, requisitos, benefícios e prazos para candidatura. Além disso, as empresas devem ter a opção de marcar vagas como abertas ou fechadas, dependendo do status da vaga. | 
| Observação |  A solução atende ao requisito proposto, permitindo que o usuário, definido como empresa, crie e gerencie suas vagas, fazendo com que usuários, definidos como profissionais, se candidatem com êxito nas vagas criadas.  é de extrema importância trabalhar em melhorias relacionadas à formatação dos campos, possibilitando que os usuários tenham mais facilidade ao cadastrar seus dados. |


| 3 | Candidatar a vagas |
|--------------------------|-----------|
| Requisito | RF - 003 - A aplicação deve oferecer aos profissionais a capacidade de se candidatarem a vagas de trabalho que estão listadas na plataforma. Isso deve incluir a opção de enviar um currículo, carta de apresentação e outras informações relevantes conforme exigido pela empresa. | 
| Observação | A solução atende plenamente aos requisitos estabelecidos, proporcionando ao usuário (profissional) a capacidade de visualizar oportunidades de emprego, candidatar-se a elas e revisar facilmente as vagas às quais se candidatou. A navegação entre as páginas opera de maneira eficaz, garantindo uma experiência fluida e intuitiva. |


| 4 | Mecanismo de Pesquisa |
|--------------------------|-----------|
| Requisito | RF - 004 - A aplicação deve disponibilizar um mecanismo de pesquisa avançado que permita aos profissionais procurar vagas de trabalho com base em critérios específicos, como palavras-chave, localização, setor da indústria, tipo de contrato e nível de experiência. Os resultados da pesquisa devem ser precisos e relevantes. | 
| Observação | Ao utilizar o mecanismo de pesquisa, os profissionais podem encontrar resultados precisos e relevantes, obtendo informações sobre oportunidades que atendam exatamente às suas necessidades. A pesquisa abrange diversos elementos, incluindo título da vaga, descrição, localização, formação, experiência profissional e habilidades exigidas. Essa abordagem abrangente garante que os resultados sejam alinhados com as expectativas e objetivos dos usuários, proporcionando uma experiência de busca de emprego mais eficiente e satisfatória. |


| 5 | Compartilhamento em redes sociais |
|--------------------------|-----------|
| Requisito | RF - 010 - A aplicação deve permitir que os usuários compartilhem vagas de trabalho por meio de redes sociais, como Facebook, Twitter, LinkedIn, etc. Isso aumentará a visibilidade das vagas e permitirá que os usuários ajudem a divulgar oportunidades para sua rede de contatos. | 
| Observação | A aplicação oferece um excelente fluxo para o compartilhamento de vagas de trabalho, permitindo que os usuários compartilhem facilmente oportunidades por meio de redes sociais, como Facebook e Twitter. Essa funcionalidade amplia a visibilidade das vagas, possibilitando que os usuários contribuam para a divulgação de oportunidades dentro de suas redes de contatos. O processo é intuitivo e eficaz, permitindo uma maior disseminação de informações sobre as vagas disponíveis. Apesar de, atualmente, a aplicação suportar o compartilhamento apenas com Facebook e Twitter, a experiência proporcionada é eficiente e promove uma divulgação abrangente das oportunidades de trabalho. |


| 6 | Cadastrar Perfil  |
|--------------------------|-----------|
| Requisito | RF - 011 - A aplicação deve fornecer um mecanismo de login e registro para as empresas e os profissionais. O login e o registro devem ser separados para cada tipo de usuário (empresas e profissionais) permitindo que eles acessem funcionalidades específicas. As empresas devem ter a opção de se registrar na plataforma, fornecendo informação como nome da empresa, endereço de email, número de telefone, CNPJ, senha e confirmar senha. Os profissionais devem ter a opção de se registrar na plataforma fornecendo informações como nome completo, endereço de email, senha e confirmar senha. Após o registro, as empresas e os profissionais devem ter a opção de fazer login na plataforma usando suas credenciais (por exemplo, e-mail e senha). | 
| Observação | A solução atende ao requisito conforme o esperado. Os usuários podem realizar o processo de cadastro como empresa ou profissional. As validações nos campos do formulário, como o tamanho da senha e a verificação de e-mail em uso, funcionam corretamente no processo de cadastro. |


| 7 | Efetuar login |
|--------------------------|-----------|
| Requisito | RF - 011 - A aplicação deve fornecer um mecanismo de login e registro para as empresas e os profissionais. O login e o registro devem ser separados para cada tipo de usuário (empresas e profissionais) permitindo que eles acessem funcionalidades específicas. As empresas devem ter a opção de se registrar na plataforma, fornecendo informação como nome da empresa, endereço de email, número de telefone, CNPJ, senha e confirmar senha. Os profissionais devem ter a opção de se registrar na plataforma fornecendo informações como nome completo, endereço de email, senha e confirmar senha. Após o registro, as empresas e os profissionais devem ter a opção de fazer login na plataforma usando suas credenciais (por exemplo, e-mail e senha). | 
| Observação | A solução permite que os usuários realizem o processo de login, seja como empresa ou profissional. As validações nos campos, como o tamanho da senha e a verificação de e-mail em uso, funcionam corretamente no processo de login. A navegação e as permissões entre as páginas ocorrem adequadamente, com a opção de cadastro e perfil de usuário aparecendo somente após o login. Além disso, a performance de navegação não apresenta problemas. |


| 8 | Recuperação de senha |
|--------------------------|-----------|
| Requisito | RF - 012 - A aplicação deve fornecer um mecanismo de recuperação de senha para permitir que os usuários redefinam suas senhas em caso de esquecimento. | 
| Observação | A solução proporciona um bom fluxo para o currículo, permitindo que o profissional cadastre e gerencie suas informações de maneira eficaz. O usuário pode cadastrar seu resumo profissional, formação acadêmica e experiência profissional, as quais são visualizadas na página de resumo profissional.  |


| 9 | Cadastrar currículo |
|--------------------------|-----------|
| Requisito | RF - 013 - A aplicação deve permitir que o profissional cadastre seu currículo. Isso inclui a capacidade de preencher campos com informações acadêmicas e experiência profissional. | 
| Observação | A solução proporciona um bom fluxo para o currículo, permitindo que o profissional cadastre e gerencie suas informações de maneira eficaz. O usuário pode cadastrar seu resumo profissional, formação acadêmica e experiência profissional, as quais são visualizadas na página de resumo profissional.  |


Possíveis pontos de correção

Como possíveis pontos de correção, sugerimos as seguintes ações:

- Verificou-se que, ao realizar a alteração de senha, a nova senha do usuário não está sendo devidamente criptografada. É imperativo abordar essa lacuna de segurança para garantir a proteção adequada das informações sensíveis dos usuários. Recomenda-se revisar o código associado à alteração de senha e confirmar a implementação de um algoritmo de hash robusto, como bcrypt ou Argon2, para garantir a criptografia segura das senhas antes de serem armazenadas no banco de dados.
- Identificou-se que, durante a edição de informações relacionadas à formação acadêmica, os usuários são obrigados a editar o ano de conclusão. Recomenda-se revisitar código para que as informações sejam salvas, removendo a obrigatoriedade de fornecer o ano de conclusão novamente. Isso proporcionará uma experiência mais flexível e intuitiva para os usuários ao atualizarem outros campos relacionados à formação acadêmica. Além disso, não é possível adicionar uma formação acadêmica em andamento. Para isso, recomenda-se criar uma opção que o usuário consiga informar se possui uma formação acadêmica em andamento e cadastrá-la.
- Similar à questão na formação acadêmica, observou-se que há uma obrigatoriedade de editar data de início e término ao realizar modificações na experiência profissional do usuário. Sugere-se revisitar o código para que as informações sejam salvas, permitindo que os usuários editem outros detalhes sem a necessidade de especificar novamente esses campos. Além disso, não é possível adicionar uma exeperiência profissional atual. Para isso, recomenda-se criar uma opção que o usuário consiga informar se possui experiência profissional atual.
- Identificou-se que algumas páginas da aplicação não estão proporcionando uma experiência responsiva, o que pode comprometer a usabilidade em diferentes dispositivos. Recomenda-se revisitar o código CSS e as configurações de layout para garantir a adaptabilidade em várias resoluções de tela. A incorporação de consultas de mídia CSS e o uso de frameworks responsivos, como Bootstrap, são estratégias eficazes para assegurar um design flexível e consistente.
- Observou-se que os botões de compartilhar não estão sendo exibidos de maneira ideal, impactando a experiência do usuário. Recomenda-se analisar a implementação atual dos botões e verificar se estão configurados corretamente para funcionar em diversas plataformas. Pode ser benéfico explorar soluções de terceiros confiáveis ou realizar ajustes personalizados para garantir uma exibição uniforme e uma funcionalidade eficaz.
- Foi identificado que o modal de sucesso de candidatura está aparecendo muito rapidamente, o que pode prejudicar a compreensão por parte dos usuários. Sugere-se ajustar o tempo de exibição do modal, proporcionando um período adequado para que os usuários absorvam as informações. Introduzir transições suaves e opções de fechamento manual pode contribuir para uma interação mais amigável e controlada.




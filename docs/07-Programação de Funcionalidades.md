# Programação de Funcionalidades


|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-011| Login e Cadastro  | tarefas.shtml / tarefas.cs / controllertarefas.cs | 


| ID | Status | Descrição do Requisito | Artefato(s) produzido(s) |
|---|---|---|---|
| RF-001 (Gerenciamento de Perfil) | Em construção | A aplicação deve permitir que tanto empresas quanto profissionais criem e gerenciem seus perfis na plataforma. Isso inclui a capacidade de preencher informações relevantes, como nome, informações de contato, descrição da empresa ou currículo do profissional, foto do perfil e quaisquer outras informações relevantes. Os perfis devem ser personalizáveis e editáveis a qualquer momento. | - |
| RF-002 (Gerenciamento de Vagas) | A fazer | A aplicação deve ter a capacidade de permitir que uma empresa crie e gerencie vagas de trabalho disponíveis na plataforma. As empresas devem ser capazes de fornecer detalhes sobre a vaga, como título, descrição, localização, requisitos, benefícios e prazos para candidatura. Além disso, as empresas devem ter a opção de marcar vagas como abertas ou fechadas, dependendo do status da vaga. | - |
| RF-003 (Candidatura a Vagas) | A fazer | A aplicação deve oferecer aos profissionais a capacidade de se candidatarem a vagas de trabalho que estão listadas na plataforma. Isso deve incluir a opção de enviar um currículo, carta de apresentação e outras informações relevantes conforme exigido pela empresa. | - |
| RF-004 (Mecanismo de Pesquisa Avançada) | A fazer | A aplicação deve disponibilizar um mecanismo de pesquisa avançado que permita aos profissionais procurar vagas de trabalho com base em critérios específicos, como palavras-chave, localização, setor da indústria, tipo de contrato e nível de experiência. Os resultados da pesquisa devem ser precisos e relevantes. | - |
| RF-005 (Definição de Qualificações) | A fazer | A aplicação deve permitir que as empresas definam as qualificações e requisitos desejados para uma vaga ao criarem um anúncio. Isso pode incluir formação educacional, experiência profissional anterior, habilidades técnicas e comportamentais, entre outros critérios. Essas informações ajudarão a filtrar os candidatos mais adequados para a vaga. | - |
| RF-006 (Autoavaliação de Habilidades) | A fazer | A aplicação deve possibilitar que um profissional avalie suas próprias qualificações e habilidades com base nos critérios definidos pela empresa no anúncio da vaga. Isso pode envolver respostas a perguntas específicas ou a seleção de opções que melhor descrevam suas habilidades em áreas relevantes. | - |
| RF-007 (Visualização de Autoavaliações) | A fazer | A aplicação deve fornecer à empresa a capacidade de visualizar os resultados das autoavaliações realizadas pelos candidatos para uma vaga específica. Isso pode incluir gráficos ou pontuações que mostram a correspondência entre as habilidades do candidato e os requisitos da vaga. | - |
| RF-008 (Pesquisa de Profissionais) | A fazer | A aplicação deve ter um mecanismo de pesquisa que permita que as empresas encontrem profissionais com base em critérios como habilidades, experiência, localização e formação. Isso permitirá que as empresas identifiquem possíveis candidatos para futuras oportunidades de emprego. | - |
| RF-009 (Acompanhamento de Candidaturas) | A fazer | A aplicação deve permitir que os profissionais acompanhem o status de suas candidaturas. Isso pode incluir informações sobre se a candidatura está pendente, em análise, rejeitada ou aceita. Esse recurso fornecerá aos profissionais uma visão clara de suas atividades de candidatura. | - |
| RF-010 (Compartilhamento em Redes Sociais) | A fazer | A aplicação deve permitir que os usuários compartilhem vagas de trabalho por meio de redes sociais, como Facebook, Twitter, LinkedIn, etc. Isso aumentará a visibilidade das vagas e permitirá que os usuários ajudem a divulgar oportunidades para sua rede de contatos. | - |
| RF-011 (Login e Cadastro) | Feito | A aplicação deve fornecer um mecanismo de login e registro para as empresas e os profissionais. O login e o registro devem ser separados para cada tipo de usuário (empresas e profissionais), permitindo que eles acessem funcionalidades específicas. As empresas devem ter a opção de se registrar na plataforma, fornecendo informações como nome da empresa, endereço de email, número de telefone, CNPJ, senha e confirmar senha. Os profissionais devem ter a opção de se registrar na plataforma fornecendo informações como nome completo, endereço de email, senha e confirmar senha. Após o registro, as empresas e os profissionais devem ter a opção de fazer login na plataforma usando suas credenciais (por exemplo, e-mail e senha). | \Controllers\UsuariosController.cs; ProfissionaisController.cs; EmpresasController.cs
\Models\Usuario.cs; Profissional.cs; Empresa.cs; AppDbContext.cs
\Views\Empresas\Create.cshtml, Delete.cshtml, Details.cshtml, Edit.cshtml, Index.cshtml
\Views\Profissional\Create.cshtml, Delete.cshtml, Details.cshtml, Edit.cshtml, Index.cshtml
\Views\Usuario\Create.cshtml, Delete.cshtml, Details.cshtml, Edit.cshtml, Index.cshtml, Login.cshtml, AccessDenied.cshtml |
| RF-012 (Recuperação de acesso) | A fazer | A aplicação deve fornecer um mecanismo de recuperação de senha para permitir que os usuários redefinam suas senhas em caso de esquecimento. | - |

# Instruções de acesso

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)

# TechTalent

`TECNOLOGIA EM DESENVOLVIMENTO E ANÁLISE DE SISTEMAS`

`Projeto: Desenvolvimento de uma Aplicação Interativa`

`2º Semestre`

Uma plataforma que aproxima empresas e candidatos em busca de oportunidades profissionais no setor de Tecnologia da Informação e Comunicação.

## Integrantes

* Daniel Drumond Fonte Boa
* Frederico Adjovani Silva de Aguilar Lemos
* Lafayete Queiroz Horta
* Letícia Rangel Vilarim
* Maria Fernanda Silva Salomao
* Weglesson de Moura Silva


## Orientadora

* Luciana de Nardin

## Instruções de utilização

### Programas necessários para inicializar o projeto:

#### .NET Framework 6.0

#### Dotnet Entity Framework

Comando de instalação:

``dotnet tool install --global dotnet-ef``

#### Database: SQL Server Express - LocalDB

Localização da connection line:
[./app_tech_talent/appsettings.Development.json](./app_tech_talent/app_tech_talent/appsettings.Development.json)

### Como inicializar o projeto:

Vá para a pasta de conteúdo do app ([aqui](./app_tech_talent/app_tech_talent/)) e rode os seguintes comandos:

```bash
dotnet build
dotnet ef database update # para rodar as migrations
dotnet run
```

Acesse a aplicação no endereço: https://techtalent.azurewebsites.net/


### Configurações para rodar a aplicação localmente

Esta aplicação utiliza o PostgreSQL. Para rodar a aplicação localmente, siga estas etapas:

1. Instale o PostgreSQL na sua máquina. Acesse [https://www.postgresql.org/download/](https://www.postgresql.org/download/).

2. **Não altere as configurações padrão de propriedades.**

3. Altere a `ConnectionStrings` no arquivo `appsettings.Development` do projeto para apontar para o PostgreSQL local.

   Exemplo de `ConnectionStrings` no formato JSON:

   ```json
   {
     "Logging": {
       "LogLevel": {
         "Default": "Information",
         "Microsoft.AspNetCore": "Warning"
       }
     },
     "AllowedHosts": "*",
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=123456;SSL Mode=Prefer;"
     }
   }

### Observações:

- As propriedades `Host`, `Port` e `Database` devem ser alteradas de acordo com a sua configuração local do PostgreSQL.

- A propriedade `Username` e `Password` devem ser alteradas para as credenciais do seu usuário do PostgreSQL.

- A propriedade `SSL Mode` pode ser alterada para `Require` ou `VerifyCa` para usar o SSL.

# Documentação

<ol>
<li><a href="docs/01-Documentação de Contexto.md"> Documentação de Contexto</a></li>
<li><a href="docs/02-Especificação do Projeto.md"> Especificação do Projeto</a></li>
<li><a href="docs/03-Metodologia.md"> Metodologia</a></li>
<li><a href="docs/04-Projeto de Interface.md"> Projeto de Interface</a></li>
<li><a href="docs/05-Arquitetura da Solução.md"> Arquitetura da Solução</a></li>
<li><a href="docs/06-Template Padrão da Aplicação.md"> Template Padrão da Aplicação</a></li>
<li><a href="docs/07-Programação de Funcionalidades.md"> Programação de Funcionalidades</a></li>
<li><a href="docs/08-Plano de Testes de Software.md"> Plano de Testes de Software</a></li>
<li><a href="docs/09-Registro de Testes de Software.md"> Registro de Testes de Software</a></li>
<li><a href="docs/10-Plano de Testes de Usabilidade.md"> Plano de Testes de Usabilidade</a></li>
<li><a href="docs/11-Registro de Testes de Usabilidade.md"> Registro de Testes de Usabilidade</a></li>
<li><a href="docs/12-Apresentação do Projeto.md"> Apresentação do Projeto</a></li>
<li><a href="docs/13-Referências.md"> Referências</a></li>
</ol>

# Código

<li><a href="./app_tech_talent/app_tech_talent/"> Código Fonte</a></li>

# Apresentação

<li><a href="presentation/README.md"> Apresentação da solução</a></li>

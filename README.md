# Clientes_TDSA

Este projeto é uma aplicação CRUD (Create, Read, Update, Delete) para gerenciamento de clientes, desenvolvida utilizando **Blazor Web App / ASP.NET**, **C# (.NET)**, **Entity Framework Core** e **MySQL** como banco de dados. A aplicação foi criada com base nos princípios da **Arquitetura Limpa** (Clean Architecture), com o objetivo de manter uma organização modular e escalável do código.

## Tecnologias Utilizadas

- **C# (.NET)**: Linguagem de programação e framework usados para o desenvolvimento da aplicação.
- **Blazor Web App**: Framework para criação de interfaces de usuário interativas em aplicações web, rodando no lado do cliente e servidor com ASP.NET.
- **Entity Framework Core**: ORM (Object-Relational Mapper) que facilita a comunicação com o banco de dados, utilizando uma abordagem baseada em objetos para manipular dados.
- **MySQL**: Banco de dados relacional utilizado para armazenar informações de clientes.
  
## Funcionalidades

O sistema permite as seguintes operações para gerenciamento de clientes:

- **Cadastro de clientes** (Create)
- **Visualização de clientes cadastrados** (Read)
- **Atualização de informações dos clientes** (Update)
- **Remoção de clientes** (Delete)

## Estrutura do Projeto

O projeto foi desenvolvido utilizando os princípios da **Arquitetura Limpa** (Clean Architecture). A arquitetura limpa propõe uma organização modular, separando as responsabilidades em diferentes camadas para tornar o código mais fácil de manter, testar e escalar.

### Por que utilizei a Arquitetura Limpa?

A arquitetura limpa tem como objetivo principal garantir que o projeto seja:

1. **Independente de Frameworks**: O sistema não depende de nenhum framework específico. Frameworks são ferramentas, e não a base do sistema.
2. **Testável**: Separando a lógica de negócio e a infraestrutura, é possível testar o domínio sem depender de detalhes externos, como banco de dados ou interfaces.
3. **Independente de UI (Interface de Usuário)**: A camada de apresentação (UI) é separada da lógica de negócio. Neste projeto, a interface é feita com Blazor, mas poderia ser trocada sem grandes impactos nas outras camadas.
4. **Independente de Banco de Dados**: O sistema é projetado para não depender de um banco de dados específico, o que permite a troca de banco de dados facilmente, caso necessário.
5. **Facilmente Extensível e Mantível**: A separação das camadas permite que o código seja mais organizado e facilite a implementação de novas funcionalidades.

### Organização dos Projetos

1. **Domínio (Domain)**: Contém as entidades de negócio, como a classe `Cliente`, e as interfaces de repositórios, que definem os contratos de acesso a dados.
   
2. **Infraestrutura (Infrastructure)**: Implementa as interfaces de repositórios utilizando o Entity Framework Core e contém a configuração do contexto de banco de dados.

3. **Crosscutting**: Camada responsável por injetar as dependências e adicionar serviços compartilhados entre as camadas. 

4. **Apresentação (Presentation)**: Camada Blazor Web App, rodando no lado do cliente e servidor com ASP.NET, que contém as páginas e componentes da interface de usuário, além de manipular as interações dos usuários com o sistema.

## Como Rodar o Projeto

### Pré-requisitos

- [.NET 8 SDK]
- [MySQL]
- Visual Studio ou Visual Studio Code (recomendado)

### Passos

1. Clone este repositório:
    ```bash
    git clone https://github.com/YagoGomesDaSilva/Clientes_TDSA.git
    ```

2. Configure a string de conexão com o MySQL no arquivo `appsettings.json` do projeto **AppClientes**:
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=ClienteDb;Uid=seuUsuario;Pwd=suaSenha;"
      }
    }
    ```

3. Aplique as migrações do banco de dados:
    ```bash
    dotnet ef database update
    ```

4. Execute a aplicação:
    ```bash
    dotnet run
    ```


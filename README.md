
# API de Gerenciamento de Pizzas

Esta é uma API RESTful para gerenciar um catálogo de pizzas. A API permite adicionar, atualizar, deletar e buscar pizzas. Os dados das pizzas são armazenados em memória (cache), sem utilização de banco de dados.

## Funcionalidades

- **Listar todas as pizzas**
- **Buscar pizza por ID**
- **Adicionar nova pizza**
- **Atualizar pizza existente**
- **Deletar pizza**

## Tecnologias Utilizadas

- ASP.NET Core
- C#
- Swagger para documentação da API

## Pré-requisitos

- [.NET 6.0 ou superior](https://dotnet.microsoft.com/download)
- Um ambiente de desenvolvimento como Visual Studio ou Visual Studio Code (opcional)

## Instalação

1. Clone o repositório:
   ```bash
   git clone https://seu-repositorio-url.git
   cd aprendendo_pizza
   ```

2. Restaure as dependências:
   ```bash
   dotnet restore
   ```

3. Execute a aplicação:
   ```bash
   dotnet run
   ```

## Documentação da API

A documentação da API está disponível através do Swagger UI. Acesse a seguinte URL após executar a aplicação:

```
http://localhost:{Port}/swagger
```

## Endpoints

### 1. Listar todas as pizzas

- **URL**: `/Pizza`
- **Método**: `GET`
- **Resposta**: Lista de pizzas
- **Exemplo de Resposta**:
  ```json
  [
    {
      "id": 1,
      "name": "peperoni",
      "isGlutenFree": true
    },
    {
      "id": 2,
      "name": "pomodoro",
      "isGlutenFree": false
    }
  ]
  ```

### 2. Buscar pizza por ID

- **URL**: `/Pizza/{id}`
- **Método**: `GET`
- **Parâmetros**:
  - `id` (int): O ID da pizza a ser buscada
- **Exemplo de Resposta**:
  ```json
  {
    "id": 1,
    "name": "peperoni",
    "isGlutenFree": true
  }
  ```

### 3. Adicionar nova pizza

- **URL**: `/Pizza`
- **Método**: `POST`
- **Corpo da Requisição**:
  ```json
  {
    "name": "Margherita",
    "isGlutenFree": false
  }
  ```
- **Resposta**: 201 Created com a nova pizza criada.

### 4. Atualizar pizza existente

- **URL**: `/Pizza/{id}`
- **Método**: `PUT`
- **Parâmetros**:
  - `id` (int): O ID da pizza a ser atualizada
- **Corpo da Requisição**:
  ```json
  {
    "id": 1,
    "name": "Margherita",
    "isGlutenFree": true
  }
  ```
- **Resposta**: 200 OK com a pizza atualizada.

### 5. Deletar pizza

- **URL**: `/Pizza/{id}`
- **Método**: `DELETE`
- **Parâmetros**:
  - `id` (int): O ID da pizza a ser deletada
- **Resposta**: 204 No Content se a pizza for deletada com sucesso.

## Contribuição

Sinta-se à vontade para contribuir com melhorias ou novas funcionalidades. Crie um *pull request* ou abra uma *issue* para discutir mudanças.

## Licença

Este projeto está licenciado sob a MIT License. Consulte o arquivo `LICENSE` para mais detalhes.

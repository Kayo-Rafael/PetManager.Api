# Pet.Api 🐾

Este projeto é um CRUD simples desenvolvido com **ASP.NET Core**, criado com fins puramente educacionais.

## 📚 Objetivo

O principal objetivo deste projeto é estudar e praticar os seguintes conceitos:

- Estruturação de projetos com ASP.NET Core
- Criação de Controllers e Use Cases
- Separação de responsabilidades em camadas (API, Application, Communication)
- Boas práticas com respostas HTTP (`StatusCodes`, `ProducesResponseType`, etc.)

> ⚠️ **Importante:** Este projeto **não possui lógica de negócios** implementada. As classes de UseCase apenas simulam o fluxo de um CRUD básico e não interagem com banco de dados ou qualquer serviço externo. Ele serve exclusivamente como base de estudo para estruturação de projetos.

## 📁 Estrutura do Projeto

- `Pet.Api`: Camada de apresentação (API) com os endpoints REST.
- `Pet.Application`: Camada onde ficam os "casos de uso" (UseCases) para cada operação do CRUD.
- `Pet.Communication`: Contém os contratos de requisição (`Requests`) e resposta (`Responses`) usados entre as camadas.

## 🚀 Funcionalidades Simuladas

- `GET /api/pet` → Listar todos os pets
- `GET /api/pet/{id}` → Buscar pet por ID
- `POST /api/pet` → Registrar novo pet
- `PUT /api/pet/{id}` → Atualizar pet existente
- `DELETE /api/pet/{id}` → Deletar pet

## 🔧 Tecnologias Utilizadas

- ASP.NET Core
- C#
- RESTful APIs
- Visual Studio

## 🧪 Próximos Passos (Futuros Estudos)

- Implementar persistência com Entity Framework e banco de dados
- Aplicar testes unitários nos UseCases
- Inserir autenticação/autorização
- Criar camada de domínio e aplicar regras de negócio

---

Este projeto representa uma **fase de aprendizado**. Toda e qualquer sugestão de melhoria é bem-vinda!

---

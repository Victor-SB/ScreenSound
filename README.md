# 🎵 ScreenSound

> Aplicação para gerenciamento de artistas e suas obras + API REST com ASP.NET Core.

---

## 📖 Descrição

O **ScreenSound** é uma aplicação completa que permite gerenciar e exibir informações sobre artistas e suas músicas. Ele conta com uma **interface interativa** e uma **API Web** desenvolvida com ASP.NET Core, tornando o gerenciamento e consulta de dados simples e eficiente.

---

## ✨ Funcionalidades da Aplicação

- ✅ **Cadastro de Artistas**  
  Adicione nome, biografia e foto de perfil de novos artistas.

- 📋 **Listagem de Artistas**  
  Visualize facilmente todos os artistas cadastrados.

- 🔄 **Atualização de Dados**  
  Edite as informações de artistas existentes.

- ❌ **Remoção de Artistas**  
  Exclua artistas do sistema com segurança.

- 💾 **Persistência com EF Core**  
  Os dados são salvos de forma eficiente utilizando o Entity Framework Core.

---

## 🔌 Funcionalidades da API

- 📂 **Listar todos os artistas cadastrados**
- 🔍 **Consultar artista pelo nome**
- ⚙️ **Respostas com códigos de status apropriados (200, 404, etc.)**

---

## 🛣️ Estrutura de Rotas da API

| Método | Rota                     | Descrição                                       |
|--------|--------------------------|-------------------------------------------------|
| GET    | `/Artistas`              | Retorna uma lista com todos os artistas.        |
| GET    | `/Artistas/{nome}`       | Retorna informações de um artista específico.   |

---

## 🧰 Tecnologias Utilizadas

- 🟦 **.NET Core** – Backend moderno, leve e de alto desempenho.  
- 🛠️ **ASP.NET Core** – Framework para construção da API RESTful.  
- 🧮 **Entity Framework Core** – ORM para persistência no banco de dados.  
- 🗄️ **SQL Server** – Sistema de banco de dados relacional.

---

## 🗃️ Estrutura do Banco de Dados

A estrutura do banco contém a tabela principal `Artistas`, com os seguintes campos:

| Campo       | Descrição                        |
|-------------|----------------------------------|
| `Nome`      | Nome completo do artista         |
| `Bio`       | Biografia resumida do artista    |
| `FotoPerfil`| URL da imagem de perfil do artista |

---

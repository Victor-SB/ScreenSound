# 🎵 ScreenSound

> Aplicação para gerenciamento de artistas e suas obras + API REST com ASP.NET Core.

---

## 📖 Descrição

O **ScreenSound** é uma aplicação completa que permite gerenciar e exibir informações sobre artistas e suas músicas. Ele conta com uma **interface interativa** e uma **API Web** desenvolvida com ASP.NET Core, tornando o gerenciamento e consulta de dados simples e eficiente.

---

## ✨ Funcionalidades da Aplicação

### Artistas

- ✅ **Cadastro de Artistas**  
  Adicione nome, biografia e foto de perfil de novos artistas.

- 📋 **Listagem de Artistas**  
  Visualize facilmente todos os artistas cadastrados.

- 🔄 **Atualização de Dados**  
  Edite as informações de artistas existentes.

- ❌ **Remoção de Artistas**  
  Exclua artistas do sistema com segurança.

### Músicas

- ✅ **Cadastro de Músicas**  
  Adicione título, duração e artista associado a novas músicas.

- 📋 **Listagem de Músicas**  
  Visualize facilmente todas as músicas cadastradas.

- 🔄 **Atualização de Dados**  
  Edite as informações de músicas existentes.

- ❌ **Remoção de Músicas**  
  Exclua músicas do sistema com segurança.

- 💾 **Persistência com EF Core**  
  Os dados das músicas são salvos de forma eficiente utilizando o Entity Framework Core.
---

## 🔌 Funcionalidades da API

### Artistas

- 📂 **Listar todos os artistas cadastrados**
- 🔍 **Consultar artista pelo nome**
- ⚙️ **Respostas com códigos de status apropriados (200, 404, etc.)**

### Músicas

- 📂 **Listar todas as músicas cadastradas**
- 🔍 **Consultar música pelo título**
- ⚙️ **Respostas com códigos de status apropriados (200, 404, etc.)**

---

## 🛣️ Estrutura de Rotas da API

| Método | Rota                     | Descrição                                       |
|--------|--------------------------|-------------------------------------------------|
| GET    | `/Artistas`              | Retorna uma lista com todos os artistas.        |
| GET    | `/Artistas/{nome}`       | Retorna informações de um artista específico.   |
| GET    | `/Musicas`               | Retorna uma lista com todas as músicas.         |
| GET    | `/Musicas/{titulo}`      | Retorna informações de uma música específica.   |

---

## 🖼️ Documentação da API

A documentação da API é gerada automaticamente pelo Swagger. Você pode acessá-la através da URL:
https://localhost:7089/Swagger/index.html

### Imagem da API no Swagger

![image](https://github.com/user-attachments/assets/13bf7c6b-b2c9-4833-9d67-13c888767680)

---

## 🧰 Tecnologias Utilizadas

- 🟦 **.NET Core** – Backend moderno, leve e de alto desempenho.  
- 🛠️ **ASP.NET Core** – Framework para construção da API RESTful.  
- 🧮 **Entity Framework Core** – ORM para persistência no banco de dados.  
- 🗄️ **SQL Server** – Sistema de banco de dados relacional.

---

## 🗃️ Estrutura do Banco de Dados

A estrutura do banco contém as tabelas principais `Artistas` e `Musicas`, com os seguintes campos:

### Tabela Artistas

| Campo       | Descrição                        |
|-------------|----------------------------------|
| `Nome`      | Nome completo do artista         |
| `Bio`       | Biografia resumida do artista    |
| `FotoPerfil`| URL da imagem de perfil do artista |

### Tabela Musicas

| Campo       | Descrição                        |
|-------------|----------------------------------|
| `Titulo`    | Título da música                 |
| `ArtistaId` | ID do artista associado          |
| `Duracao`   | Duração da música em minutos     |
| `AnoDeLancamento`   | Ano de lançamento        |

---

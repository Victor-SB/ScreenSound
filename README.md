# 🎵 ScreenSound

> Aplicação para gerenciamento de artistas e suas obras + API REST com ASP.NET Core, agora publicada no Azure.

---

## 📖 Descrição

O **ScreenSound** é uma aplicação completa que permite gerenciar e exibir informações sobre artistas, músicas e agora também **gêneros musicais**. Conta com uma **interface interativa**, uma **API Web com ASP.NET Core** e foi recentemente **publicada no Azure**, permitindo acesso online e escalável.

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
  Adicione título, duração, artista associado e agora também o **gênero musical**.

- 📋 **Listagem de Músicas**  
  Visualize todas as músicas com detalhes de artista e gênero.

- 🔄 **Atualização de Dados**  
  Edite as informações de músicas existentes.

- ❌ **Remoção de Músicas**  
  Exclua músicas do sistema com segurança.

- 💾 **Persistência com EF Core**  
  Todos os dados são armazenados eficientemente com o Entity Framework Core.

### Gêneros

- 🎶 **Cadastro de Gêneros Musicais**  
  Adicione nome e descrição de cada gênero musical, relacionando-os com artistas via ID.

- 📋 **Listagem de Gêneros**  
  Veja todos os gêneros cadastrados com suas descrições.

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

### Gêneros

- 📂 **Listar todos os gêneros musicais**
- 🔍 **Consultar gênero pelo nome**
- 🔗 **Consultar gênero por artista (via ID)**
- ⚙️ **Respostas com status apropriados**

---

## 🛣️ Estrutura de Rotas da API

| Método | Rota                        | Descrição                                          |
|--------|-----------------------------|----------------------------------------------------|
| GET    | `/Artistas`                 | Retorna todos os artistas                         |
| GET    | `/Artistas/{nome}`          | Retorna dados de um artista específico            |
| GET    | `/Musicas`                  | Retorna todas as músicas                          |
| GET    | `/Musicas/{titulo}`         | Retorna dados de uma música específica            |
| GET    | `/Generos`                  | Retorna todos os gêneros musicais                 |
| GET    | `/Generos/{nome}`           | Retorna dados de um gênero específico             |
| GET    | `/Generos/por-artista/{id}` | Retorna gêneros relacionados a um artista via ID  |

### 🔍 Imagens da API rodando no Azure
![API](https://github.com/user-attachments/assets/8011a60c-b8b4-456b-9b15-0b7b8f254b8a)

---

## ☁️ Publicação no Azure

A aplicação foi publicada na plataforma **Microsoft Azure**, com os seguintes recursos criados:

- ✅ **App Service** para hospedagem da API
- ✅ **SQL Database** para persistência dos dados
- ✅ **Resource Group** e **Service Plan** organizando a infraestrutura
- 🌐 URL da API pública:  
  `https://screen-sound-api.azurewebsites.net/swagger`

### 🔍 Imagens dos Recursos no Azure
![Azure](https://github.com/user-attachments/assets/db39fada-eb08-440e-85b2-3591a6bc0ca3)

---

## 🧰 Tecnologias Utilizadas

- 🟦 **.NET Core** – Backend moderno, leve e de alto desempenho  
- 🛠️ **ASP.NET Core** – Framework para construção da API RESTful  
- 🧮 **Entity Framework Core** – ORM para persistência no banco de dados  
- 🗄️ **SQL Server** – Sistema de banco de dados relacional  
- ☁️ **Azure** – Hospedagem da aplicação e banco em nuvem  

---

## 🗃️ Estrutura do Banco de Dados

### Tabela Artistas

| Campo       | Descrição                          |
|-------------|------------------------------------|
| `Nome`      | Nome completo do artista           |
| `Bio`       | Biografia resumida do artista      |
| `FotoPerfil`| URL da imagem de perfil do artista |

### Tabela Musicas

| Campo             | Descrição                        |
|-------------------|----------------------------------|
| `Titulo`          | Título da música                 |
| `ArtistaId`       | ID do artista associado          |
| `Duracao`         | Duração da música em minutos     |
| `AnoDeLancamento` | Ano de lançamento da música      |
| `GeneroId`        | ID do gênero associado           |

### Tabela Generos

| Campo         | Descrição                          |
|---------------|------------------------------------|
| `Nome`        | Nome do gênero musical             |
| `Descricao`   | Descrição geral do gênero musical  |

---

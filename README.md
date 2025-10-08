# 📝 API de Gerenciamento de Tarefas com Usuários (.NET Web API)

Uma **API RESTful completa**, desenvolvida em **ASP.NET Core Web API**, que oferece **gerenciamento de tarefas e usuários**.  
O projeto utiliza **Entity Framework Core (EF Core)** para persistência de dados e **SQLite** como banco de dados.

Este projeto foi desenvolvido para **fins de aprendizado**, seguindo o conteúdo do canal **[Programador Tech](https://www.youtube.com/@ProgramadorTech)**.  

---

## 🚀 Funcionalidades

### 🔹 Gerenciamento de Tarefas (`/api/tarefas`)
- **Criação de Tarefas:** Adicione novas tarefas com título, descrição e ID de usuário associado.  
- **Listagem de Tarefas:** Recupere todas as tarefas ou filtre por usuário.  
- **Atualização de Status:** Modifique o status da tarefa (ex: de *Pendente* para *Concluída*).  

### 🔹 Gerenciamento de Usuários (`/api/usuarios`)
- **Cadastro de Usuários:** Crie novas contas de usuário (ex: Nome, Email).  
- **Listagem e Busca:** Visualize todos os usuários ou busque um usuário específico.  
- **Exclusão:** Remova contas de usuário.  

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#  
- **Framework:** ASP.NET Core Web API  
- **ORM:** Entity Framework Core (EF Core)  
- **Banco de Dados:** SQLite  
- **Arquitetura:** MVC (Model-View-Controller) / RESTful  

---

## ⚙️ Configuração e Instalação

Siga os passos abaixo para clonar e executar o projeto localmente:

### 🔧 Pré-requisitos
Certifique-se de ter instalado:
- [.NET SDK](https://dotnet.microsoft.com/download) (versão compatível)  
- [Git](https://git-scm.com/)

### 📦 Clonando o Repositório
```bash
git clone https://github.com/seu-usuario/nome-do-repositorio.git

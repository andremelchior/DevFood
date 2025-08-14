# DevFood - README

[![Status do Projeto](https://img.shields.io/badge/Status-Em%20Pausa-yellow)]()
[![GitHub last commit](https://img.shields.io/github/last-commit/andremelchior/DevFood)]()
[![CSharp](https://img.shields.io/badge/C%23-C--Sharp-brightgreen?style=flat&logo=csharp)]()

Este projeto é um **programa desktop** para cadastro, acompanhamento e gerenciamento de pedidos de um restaurante feito em **C#** no Visual Studio, utilizanddo componentes do **Windows Forms** e **Class Libray** para criar bibliotecas de classes reutilizaveis, que são: "Users" que contém as classes "Pessoa" e "Funcionario" que são as entidades que representam o usuário do sistema e "DAO" que faz acesso ao banco de dados **MySQL** (Data Access Object).

## 👥 Integrantes:
- André Diogo Melchior da Silva
- Leandro Souza de Oliveira
- Widson da Paz Venancio

## 🧑🏻 Orientador
- Prof. [Jeferson Ferreira](https://github.com/developerspro) (Desenvolvimento de Sistemas I - Etec JK)

## 🚀 Tecnologias utilizadas

- C# (.NET Framework)
- Windows Forms
- Class Library
- MySQL
- MySqlConnection

## ✨ Funcionalidades

- Cadastro de Funcionario
- Login e logout de funcionarios
- Cadastro de Pedidos
- Acompanhamento de Pedidos
- Cadastro de novos pratos

## ▶️ Como executar no Visual Studio

#### 📦 Pré-requisitos:
- Sistema operacional Windows
- **Visual Studio** com o componente de Desenvolvimento para desktop com .NET
- Tenha o MySQL instalado

#### 🔢 Passo a passo:

1. Clone o repositório
   ```bash
   git clone https://github.com/andremelchior/DevFood.git
   ```
   
2. Acesse a pasta do projeto
   ```bash
   cd DevFood
   ```
   
3. Abra o projeto no Visual Studio
   - Clique duas vezes no arquivo **.sln** ou abra pelo Visual Studio via **Arquivo** > **Abrir** > **Projeto/Solução**

4. Compile as bibliotecas **DAO** e **Users** acessando suas pastas de projeto

5. Execute o projeto
   - Clique no projeto **DevFood** e pressione ```F5``` ou clique em **Iniciar (Start)** para compilar e rodar o programa

## 💻 Como executar por CLI

#### 📦 Pré-requisitos:
- [.NET SDK](https://dotnet.microsoft.com/en-us/download) instalado (versão 5.0 ou superior)
- Tenha o MySQL instalado

#### 🔢 Passo a passo:

1. Clone o repositório
   ```bash
   git clone https://github.com/andremelchior/DevFood.git
   ```

2. Acesse a pasta do projeto
   ```bash
   cd DevFood
   ```

3. Acesse a pasta **DAO** e compile a biblioteca
   ```bash
   cd DAO
   ```
   Compile a biblioteca
   ```bash
   dotnet build --project DAO.csproj
   ```
   Ou simplesmente:
   ```bash
   dotnet build
   ```
   
4. Volte para a pasta do projeto e acesse a pasta **Users** e compile a biblioteca 
   ```bash
   cd ..
   cd Users
   ```
   Compile a biblioteca
   ```bash
   dotnet build --project Users.csproj
   ```
   Ou simplesmente:
   ```bash
   dotnet build
   ```
   
5. Execute o programa
   
   Volte para a pasta do projeto e acesse a pasta **DevFood**
   ```bash
   cd ..
   cd DevFood
   ```
   Compile e rode o projeto
   ```bash
   dotnet run --project DevFood.csproj
   ```
   Ou simplesmente:
   ```bash
   dotnet run
   ```

❗ Importante: é necessário **executar o script SQL** localmente e **compilar as bibliotecas** de classe para que tudo dê certo 😊


## 🤝 Contribuições
Sinta-se à vontade para abrir **Pull Requests** com melhorias de código ou **Issues** com sugestões caso queira contribur ao projeto.

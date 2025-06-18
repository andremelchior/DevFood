# DevFood

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
- Tenha o [.NET Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet) instalado
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
   - Clique duas vezes no arquivo **.sln** ou abra pelo Visual Studio via **Arquivo** > **Abrir** > **Projeto/Solução**.

4. Execute o projeto
   - Pressione ```F5``` ou clique em **Iniciar (Start)** para compilar e rodar o aplicativo.

## 💻 Como executar por CLI

#### 📦 Pré-requisitos:
- [.NET SDK](https://dotnet.microsoft.com/en-us/download) instalado (versão 5.0 ou superior)
- Sistema operacional Windows
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
   
3. Execute usando "dotnet"
   ```bash
   dotnet run --project DevFood.csproj
   ```
   Caso esteja na pasta do projeto:
   ```bash
   dotnet run
   ```

## 🤝 Contribuições
Sinta-se à vontade para abrir **Pull Requests** com melhorias de código ou **Issues** com sugestões caso queira contribur ao projeto.

# 🖥️ Verificador de Idade e Habilitação

Um simples programa de **console em .NET** que solicita ao usuário seu **nome completo** e sua **data de nascimento**, calcula a idade e informa se a pessoa **é maior de idade** e se **pode tirar a carteira de habilitação**.

---

## 📋 Funcionalidades

✅ Solicita o **nome completo** do usuário.  
✅ Solicita a **data de nascimento** no formato `dd/MM/yyyy`.  
✅ Calcula automaticamente a **idade atual** do usuário.  
✅ Informa se a pessoa **é maior de idade**.  
✅ Diz se a pessoa **está apta a tirar a carteira de habilitação**.  
✅ Inclui **validação de entrada de data**, garantindo que o formato informado seja válido.  

---

## 🚀 Tecnologias Utilizadas

- 🟦 **.NET SDK** (C#)
- ⚙️ **Console Application**
- 📦 Estrutura simples utilizando **Struct**

---

## 📂 Estrutura do Projeto

```plaintext
📦 SeuProjeto
 ┣ 📜 Program.cs        # Código principal do programa
 ┣ 📜 SeuProjeto.csproj # Arquivo de configuração do projeto .NET
 ┗ 📜 README.md         # (este arquivo)
```

---

⚙️ Pré-requisitos

Antes de rodar o projeto, garanta que você tem instalado:

📥 .NET SDK 6.0 ou superior

Um editor de código, como Visual Studio Code ou Visual Studio


Para verificar a instalação do .NET, rode no terminal:

`dotnet --version`


---

▶️ Como Executar

1. Clone ou baixe este repositório:

`git clone`


2. Acesse a pasta do projeto:

`cd SeuProjeto`

3. Compile e execute o projeto:

`dotnet run`


---

💻 Uso do Programa

Ao rodar o projeto, o console exibirá:

Digite seu nome completo:
> Maria Eduarda

Digite sua data de nascimento (formato: dd/MM/yyyy):
> 15/08/2006

Exemplo de saída:

Olá, Maria Eduarda!
Sua idade é: 18 anos.
Você é maior de idade e pode tirar a carteira de habilitação!

Pressione qualquer tecla para sair...


---

🧩 Lógica do Programa

O projeto utiliza uma struct Pessoa para organizar as informações:

Nome → Armazena o nome do usuário.

DataNascimento → Armazena a data de nascimento.

CalcularIdade() → Calcula a idade com base na data atual.

VerificarMaiorIdade() → Retorna a mensagem sobre habilitação.

---

📄 Licença

Este projeto é de uso educacional e está disponível sob a licença MIT.
Sinta-se à vontade para usar, modificar e compartilhar.


---

👨‍💻 Autor

Projeto desenvolvido para fins acadêmicos na disciplina de Desenvolvimento em .NET.

👤 Maria Eduarda Araujo Penas















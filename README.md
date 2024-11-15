# <p> Projeto - Trabalhar com os Dados em  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/csharp/csharp-original.svg" style="width: 60px; height: 60px; vertical-align: middle" /> </p>
          

> Projeto desenvolvidoda Trilha de Aprendizagem  "Introdução ao C#, Parte 4", integrante dos módulos que são requisitos para a Certificação em Fundamentos de C# . 

## Etapa 1 - Projeto Guiado :dart:

> Objetivos de Aprendizagem
>> - Aplique instruções de iteração para coletar dados de entrada.
>> - Usar o processamento de dados.
>> - Formatar a saída de dados.
>> - Escolher os tipos de dados corretos e converter tipos de dados com segurança.
>> - Manipular matrizes de números, cadeia de caracteres e caracteres, além de adicionar, remover e ordenar dados.
>> - Modificar e criar cadeias de caracteres complexas a partir de várias fontes de dados e formatar dados para a exibição em várias regiões.

### 📝 Orientações

Use o Visual Studio Code para desenvolver uma versão de um aplicativo de console em C#. 

- O aplicativo vem com os recursos básicos de criar dados de exemplo sobre animais de estimação disponíveis para adoção e exibir as informações dos animais de estimação.

-  O principal recurso a ser adicionado é pesquisar cães disponíveis usando um só termo de pesquisa. 

- As tarefas secundárias incluem adicionar e exibir dados de `suggestedDonation`.


Para os novos recursos do aplicativo **Contoso Pets**, a especificação de design fornece detalhes sobre a busca de cães e a funcionalidade de doação sugerida:

- **Busca por atributos de cães**
    - Obter a entrada para o termo de busca das características do animal.
    - Percorrer o array `animals` e identificar os "cães".
    - Para cada cão, combinar as descrições físicas e de personalidade para realizar a busca.
    - Procurar no texto combinado uma correspondência com o termo de busca fornecido.
    - Exibir os cães que correspondem ao termo buscado.

- **Dados de doação sugerida**
    - Definir a string `suggestedDonation`.
    - Expandir o array `ourAnimals` para incluir o campo `suggestedDonation` e preencher os dados de exemplo.
    - Garantir que todos os usos do array `ourAnimals` considerem o campo adicional `suggestedDonation`.
    - Exibir a doação sugerida com o símbolo de moeda regional apropriado `($, €, ¥, etc.)`.


- O projeto inicial para este módulo de projeto guiado inclui um arquivo Program.cs que fornece os seguintes recursos de código:

    - o código declara variáveis usadas para coletar e processar dados de animais de estimação e seleções de itens de menu
    - o código declara o array `ourAnimals`
    - o código usa um loop for em torno de uma estrutura `switch..case` para preencher o array `ourAnimals` com um conjunto de dados de exemplo
    - o código exibe as seguintes opções de menu principal para seleção do usuário:
        ```
            1. List all of our current pet information
            2. Display all dogs with a specified characteristic

            Enter menu item selection or type "Exit" to exit the program
        ```
        

    - o código lê a seleção de item de menu do usuário e exibe uma mensagem repetindo sua seleção
    - apenas a seleção `"1. Listar todas as informações atuais dos nossos animais de estimação"` funciona usando o código inicial

- Seu objetivo é atualizar o código existente para desenvolver os recursos do aplicativo descritos anteriormente. Os principais recursos:

    - Adicionar busca por atributos de cachorro
    - Incluir dados de doação sugerida

## 🔎 Referências

🖥 [Roteiro do Projeto Guiado - Trabalhando com os Dados em C#](https://learn.microsoft.com/en-us/training/modules/guided-project-work-variable-data-c-sharp/)

🖥 [Código Starter do Projeto Guiado - Trabalhando com os Dados em C#](https://github.com/MicrosoftLearning/Guided-project-Work-with-variable-data-in-CSharp/archive/refs/heads/main.zip)

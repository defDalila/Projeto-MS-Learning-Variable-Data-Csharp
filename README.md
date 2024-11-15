# <p> Projeto - Trabalhar com os Dados em  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/csharp/csharp-original.svg" style="width: 60px; height: 60px; vertical-align: middle" /> </p>
          

> Projeto desenvolvidoda Trilha de Aprendizagem  "Introdução ao C#, Parte 4", integrante dos módulos que são requisitos para a Certificação em Fundamentos de C# . 

> Objetivos de Aprendizagem
>> - Aplique instruções de iteração para coletar dados de entrada.
>> - Usar o processamento de dados.
>> - Formatar a saída de dados.
>> - Escolher os tipos de dados corretos e converter tipos de dados com segurança.
>> - Manipular matrizes de números, cadeia de caracteres e caracteres, além de adicionar, remover e ordenar dados.
>> - Modificar e criar cadeias de caracteres complexas a partir de várias fontes de dados e formatar dados para a exibição em várias regiões.

## Etapa 1 - Projeto Guiado :dart:


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

## Etapa 2 - Desafio de Projeto :dart:

### 📝 Orientações: Especificação de Pesquisa

Neste primeiro exercício de desafio, é necessário atualizar o recurso de pesquisa de termo único para permitir que os usuários insiram diversos termos de pesquisa separados por vírgulas.

- ***Reunir diversos termos de pesquisa do usuário***

    - Permitir que o usuário insira diversos termos de pesquisa ao pesquisar cães

    - O usuário precisa de instruções para "inserir os termos de pesquisa separados por vírgulas"

    - Separe os termos de pesquisa individuais da cadeia de caracteres de entrada do usuário e armazene como valores em uma matriz

    - Classifique os termos na matriz em ordem de classificação alfanumérica

- ***Identifique cães com descrições que correspondem a um ou mais termos de pesquisa do usuário***

    - Ao identificar um cão em animalsArray, procure correspondências para cada termo inserido pelo usuário

    - Para uma correspondência de termo, envie uma mensagem com o nome do cão e o termo correspondente

        - Por exemplo: `Our dog Jake is a match for your search for sheppard!`
    
    - Quando todas as pesquisas de termos forem concluídas para a descrição atual do cão, faça o seguinte:

        - Para uma ou mais correspondências, exiba o apelido e a descrição do cão atual

        - Para uma ou mais correspondências, verifique se houve uma correspondência a fim de saber quando não é preciso exibir a mensagem "Nenhuma correspondência encontrada para nenhum cão disponível" (confira o próximo item)

    - Depois que todas as pesquisas de cães forem concluídas sem correspondências, a mensagem "Nenhuma correspondência encontrada para nenhum cão disponível" será exibida

- ***Aplique as regras de validação a seguir***

    - os valores não podem ser nulos

    - os valores não podem ter zero caracteres

    - qualquer outra restrição depende do desenvolvedor

### 📝 Orientações: Adicionar uma animação de pesquisa aprimorada

Neste segundo exercício de desafio, você precisa atualizar a animação da pesquisa para representar uma rotação e adicionar uma contagem regressiva (2, 1, 0).

- ***Alterar os ícones atuais da animação da "pesquisa"***

    - Atualizar os "ícones" atuais da animação `string[] searchingIcons = {". ", ".. ", "..."}`;

    - Usar novos ícones que simulam uma rotação

    - Para obter um exemplo, confira o GIF animado a seguir.

    - É possível criar a animação da "pesquisa" para exibir a "rotação" de maneira diferente da exibida na imagem animada

    - A animação da "pesquisa" deve continuar a ser substituída depois de cada animação, para permanecer na mesma linha e para não ser exibida depois que a animação for interrompida.

- ***Adicionar uma contagem regressiva à animação da "pesquisa"***

    - Examine a imagem animada anterior e observe a contagem regressiva na saída

        - `“searching...retriever / 2”`

        - O número anterior, `"2"`, é exibido como `"1"` e, por fim, como `"0`", passando por uma contagem regressiva

    - Atualizar o loop que contém a animação da "pesquisa" para que ele exiba uma contagem regressiva

## 🔎 Referências

🖥 [Roteiro do Projeto Guiado - Trabalhando com os Dados em C#](https://learn.microsoft.com/en-us/training/modules/guided-project-work-variable-data-c-sharp/)

🖥 [Roteiro do Desafio de Projeto - Trabalhando com os Dados em C#](https://learn.microsoft.com/pt-br/training/modules/challenge-project-work-variable-data-c-sharp/)

🖥 [Código Starter do Projeto Guiado - Trabalhando com os Dados em C#](https://github.com/MicrosoftLearning/Guided-project-Work-with-variable-data-in-CSharp/archive/refs/heads/main.zip)

🖥 [Código Starter Desafio de Projeto - Trabalhando com os Dados em C#](https://github.com/MicrosoftLearning/Challenge-project-Work-with-variable-data-in-CSharp/archive/refs/heads/main.zip)
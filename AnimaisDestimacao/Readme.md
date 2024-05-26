# Contoso Pets Console Application

## Visão Geral do Projeto

Estou trabalhando no aplicativo Contoso Pets, um aplicativo que ajuda a colocar animais de estimação em novos lares. As especificações para a minha aplicação são:

- Crie uma aplicação de console em C#.
- Armazene dados de aplicativos em uma matriz de cadeias de caracteres multidimensional chamada `ourAnimals`.
- A matriz `ourAnimals` inclui as seguintes "características de animais de estimação" para cada animal:
  - ID do animal de estimação.
  - Espécies de animais de companhia (gato ou cão).
  - Idade do animal de estimação (anos).
  - Descrição da condição/características físicas do animal de estimação.
  - Uma descrição da personalidade do animal de estimação.
  - O apelido do animal de estimação.
- Implemente um conjunto de dados de exemplo que represente cães e gatos atualmente sob meus cuidados.
- Exiba opções do menu para acessar os principais recursos do aplicativo.

As principais características permitem as seguintes tarefas:

1. Listar as informações do animal de estimação para todos os animais na matriz `ourAnimals`.
2. Adicionar novos animais à matriz `ourAnimals`. Aplicam-se as seguintes condições:
   - As espécies de animais de companhia (cão ou gato) devem ser inseridas quando um novo animal é adicionado à matriz `ourAnimals`.
   - Um ID de animal de estimação deve ser gerado programaticamente quando um novo animal é adicionado à matriz `ourAnimals`.
   - Algumas características físicas de um animal de estimação podem ser desconhecidas até o exame de um veterinário. Por exemplo: idade, raça e status de castração.
   - O apelido e a personalidade de um animal podem ser desconhecidos quando um animal de estimação chega pela primeira vez.
3. Certifique-se de que as idades dos animais e as descrições físicas estão completas. Isto pode ser necessário após o exame de um veterinário.
4. Certifique-se de que os apelidos dos animais e as descrições de personalidade estão completas (esta ação pode ocorrer depois que a equipe conhece um animal de estimação).
5. Edite a idade de um animal (se a data de nascimento de um animal for conhecida e o animal tiver um aniversário enquanto estiver ao meu cuidado).
6. Edite a descrição da personalidade de um animal (um animal de estimação pode se comportar de forma diferente depois de passar mais tempo ao meu cuidado).
7. Exiba todos os gatos que atendem às características físicas especificadas pelo usuário.
8. Exiba todos os cães que atendem às características físicas especificadas pelo usuário.

Uma versão inicial do aplicativo já foi concluída. O projeto de código inicial para este módulo de projeto guiado inclui um arquivo `Program.cs` que fornece os seguintes recursos de código:

- O código declara variáveis usadas para coletar e processar dados de animais de estimação e seleções de itens de menu.
- O código declara a matriz `ourAnimals`.
- O código usa um loop `for` em torno de uma construção `if-elseif-else` para preencher a matriz `ourAnimals` com um conjunto de dados de exemplo.
- O código exibe as seguintes opções do menu principal para a seleção do usuário:
  1. Liste todas as nossas informações atuais sobre animais de estimação.
  2. Atribua valores aos campos da matriz `ourAnimals`.
  3. Certifique-se de que as idades dos animais e as descrições físicas estão completas.
  4. Certifique-se de que os apelidos dos animais e as descrições de personalidade estão completas.
  5. Edite a idade de um animal.
  6. Edite a descrição da personalidade de um animal.
  7. Exiba todos os gatos com uma característica especificada.
  8. Exiba todos os cães com uma característica especificada.
- Entre na seleção de itens de menu ou digite "Sair" para sair do programa.
- O código lê a seleção de itens de menu do usuário e exibe uma mensagem ecoando sua seleção.

Meu objetivo é desenvolver os recursos que implementam as duas primeiras opções de menu. Para atingir esse objetivo, concluirei as seguintes tarefas:

1. Atualizar o código usado para criar os dados de exemplo para o aplicativo.
2. Construir um loop em torno do menu principal e criar uma instrução de seleção que estabeleça uma ramificação de código para cada opção de menu.
3. Escrever o código para exibir todos os dados da matriz `ourAnimals` (opção de menu 1).
4. Criar um loop para inserir novos dados na matriz `ourAnimals` (opção de menu 2 - parte 1).
5. Escrever código para ler e salvar novos dados na matriz `ourAnimals` (opção de menu 2 - parte 2).
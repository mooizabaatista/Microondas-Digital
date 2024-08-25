# Microondas Digital

## Descrição

O projeto **Microondas Digital** é um sistema para simular o funcionamento de um microondas digital. Ele permite gerenciar programas de aquecimento personalizados e padrões, ajustar potência e tempo, e realizar operações como iniciar, pausar e cancelar o aquecimento.

## Funcionalidades

- **Gerenciamento de Programas**:
  - Adicionar, editar e excluir programas personalizados.
  - Visualizar e selecionar programas padrão e personalizados.

- **Operações do Micro-ondas**:
  - Iniciar, pausar e cancelar o aquecimento.
  - Ajustar o tempo e a potência do microondas.
  - Incrementar o tempo de aquecimento em 30 segundos.

- **Visualização**:
  - Mostrar o tempo restante no visor.
  - Indicar a potência atual.
  - Emitir sinais sonoros ao final do aquecimento ou quando o tempo está quase terminando.

## Camadas do Projeto

1. **Business Logic Layer (BLL)**: Gerencia a lógica de negócios, incluindo o gerenciamento do temporizador e a validação de programas personalizados.

2. **Data Access Layer (DAL)**: Interfaces e implementações para acesso a dados, como criação, leitura, atualização e exclusão de programas personalizados.

3. **User Interface (UI)**: Interface gráfica do usuário para interação com o micro-ondas digital.

4. **Microondas.Utils**: Fornece utilitários e constantes compartilhadas usadas em várias partes do projeto. Ela inclui:


## Requisitos

- .NET 8


## Instalação

1. **Clonar o repositório**:
   ```bash
   https://github.com/mooizabaatista/Microondas-Digital.git
   
2. **Restaurar os pacotes Nuget**
    ```bash
    dotnet restore
    
3. **Criar o banco de dados de programas personalizados**
    ```bash
    Rodar o script que está junto aos arquivos clonados para a criação da base de dados utilizada na aplicação.
    
4. **Connecion String**
    ```bash
    Alterar a connection string localizada em: Microondas.Utils > Shared > Constants > SharedConstants.cs
   

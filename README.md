# Microondas Digital

[https://github.com/user-attachments/assets/6a296913-3431-4ff0-8487-4e9ecbccddef](https://github-production-user-asset-6210df.s3.amazonaws.com/73617999/361258091-6a296913-3431-4ff0-8487-4e9ecbccddef.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAVCODYLSA53PQK4ZA%2F20240825%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240825T204308Z&X-Amz-Expires=300&X-Amz-Signature=c142a622b0edde163cc6849f944ec704632c07a29c2235f3b9780263676d0f76&X-Amz-SignedHeaders=host&actor_id=73617999&key_id=0&repo_id=847438787)

## Descrição

O projeto **Microondas Digital** é um sistema para simular o funcionamento de um microondas digital. Ele permite gerenciar programas de aquecimento personalizados e padrões, ajustar potência e tempo e realizar operações como iniciar, pausar e cancelar o aquecimento.

## Funcionalidades

- **Gerenciamento de Programas**:
  - Adicionar, editar e excluir programas personalizados.
  - Visualizar e selecionar programas padrão e personalizados.

- **Operações do Microondas**:
  - Iniciar, pausar e cancelar o aquecimento.
  - Ajustar o tempo e a potência do microondas.
  - Acrescentar o tempo de aquecimento em 30 segundos.

- **Visualização**:
  - Mostrar o tempo restante no visor.
  - Indicar a potência atual.
  - Emitir sinais sonoros ao final do aquecimento.

## Camadas do Projeto

1. **Business Logic Layer (BLL)**: Gerencia a lógica de negócios, incluindo o gerenciamento do temporizador e a validação de programas personalizados.

2. **Data Access Layer (DAL)**: Interfaces e implementações para acesso a dados, como criação, leitura, atualização e exclusão de programas personalizados.

3. **User Interface (UI)**: Interface gráfica do usuário para interação com o micro-ondas digital.

4. **Microondas.Utils**: Fornece utilitários e constantes compartilhadas usadas em várias partes do projeto.


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
   

# Projeto de Estudo – Banco de Dados de Veículos

Este repositório foi criado com o objetivo de **estudo e prática** no desenvolvimento de aplicações web utilizando tecnologias modernas da plataforma .NET.

## Tecnologias Utilizadas

- **.NET**
- **ASP.NET MVC**
- **Entity Framework Core**

## Sobre o Projeto

O sistema simula uma aplicação de **cadastro e gerenciamento de veículos**, com funcionalidades que evoluíram ao longo do processo de aprendizado. Agora, o projeto inclui múltiplos módulos com operações completas de CRUD.

### Funcionalidades Implementadas

-  **CRUD de veículos**:
    - Cadastro de novos veículos
    - Listagem
    - Visualização de detalhes
    - Edição de dados
    - Exclusão

-  **CRUD de consumos por veículo**:
  - Cada consumo contém:
    - Descrição
    - Valor pago
    - Data do consumo
    - Quilometragem do carro no momento
    - Associação ao veículo correspondente
  - Página de **relatório** individual por carro com:
    - Listagem de todos os consumos
    - **Somatória total de gastos** daquele veículo

-  **CRUD de usuários com controle de acesso**:
  - Somente **administradores** podem:
    - Cadastrar novos usuários
    - Gerenciar contas existentes
  - **Sistema de login** com distinção entre:
    - **Usuários comuns** (acesso restrito)
    - **Administradores** (acesso total ao sistema)

## Objetivos do Projeto

Este projeto tem como foco principal o **aprendizado prático** de conceitos fundamentais no desenvolvimento web com ASP.NET:

- Estruturar e organizar projetos com padrão MVC
- Integrar o **Entity Framework** para comunicação com banco de dados relacional
- Utilizar **scaffolding** para gerar componentes com agilidade
- Implementar autenticação, autorização e controle de perfis de usuário
- Trabalhar com **relacionamentos entre tabelas** (ex: veículos e consumos)
- Criar funcionalidades úteis como **relatórios com totais dinâmicos**

## Observações

> Este é um projeto de estudo, **não destinado ao uso em produção**. A ideia é explorar o ciclo completo de desenvolvimento com ASP.NET MVC.

---

**Feedbacks, sugestões e dicas são super bem-vindos!** Estou sempre buscando melhorar e aprender mais sobre o universo .NET e desenvolvimento web.

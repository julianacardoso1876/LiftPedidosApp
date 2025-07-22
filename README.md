LiftPedidosApp

- Objetivo
Criar uma aplicação em C# ASP.NET que consome a API pública do Sistema Lift, listando os pedidos realizados, com detalhes como:

* Código do pedido
* Nome do cliente
* Data
* Valor total

- Status do Projeto
O projeto foi desenvolvido com sucesso até a parte de consumo e tratamento de dados da API. No entanto, durante a tentativa de exibir os dados corretamente na interface, surgiu um erro relacionado à leitura do XML retornado pela API:

> **"There is an error in XML document (1, 1): Data at the root level is invalid"**

Esse erro indica que a API retorna um conteúdo que não está em um formato XML válido, ou que não pode ser corretamente desserializado no formato esperado pela aplicação, mesmo com todos os ajustes de modelo e estrutura XML feitos durante o desenvolvimento.

- O que foi feito

* Implementação da estrutura de modelos: `Cliente`, `Pedido`, `ItemPedido`, `Produto`
* Criação dos serviços de consumo via `HttpClient` para lidar com dados em **JSON** e **XML**
* Mapeamento com `XmlSerializer` para tratar corretamente as respostas da API
* Página Razor configurada para exibir os pedidos na interface

- Considerações

Mesmo com diversas tentativas de ajustes, validações e testes, a API continuou apresentando dados que não puderam ser tratados corretamente, impedindo a execução final sem erro.

Acredito que esse tipo de problema pode ocorrer em projetos reais, especialmente ao trabalhar com APIs de terceiros que não seguem um padrão consistente ou que retornam dados fora do esperado.
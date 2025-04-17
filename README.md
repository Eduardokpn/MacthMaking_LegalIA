🚀 Como rodar o projeto

### Pré-requisitos

- Visual Studio 2022+
- .NET 6 ou superior
- SQL Server LocalDB ou equivalente

### Passos

1. Caso prefira acesse o sitema por: https://macthmakingit-dahzc2fphpf6f0dc.brazilsouth-01.azurewebsites.net

2. **Clone o repositório**:
   ```bash
   git clone https://github.com/seuusuario/matchmaking-mvp.git
   
3. **Abra a solução do projeto**

4. **Não é necessario rodar script, pois o banco esta em nuvem**


🧠 Principais decisões tomadas
* Design Simples e Responsivo: Interface construída com HTML + Bootstrap para entregar uma experiência visual limpa e adaptável em dispositivos diferentes.

* Dapper + Repository Pattern: Escolha do Dapper pela leveza e performance, e a facil utilização de querrys, combinando com o padrão Repository para manter o código desacoplado e organizado.

* IA Simulada: A afinidade entre usuários é gerada aleatoriamente no backend, simulando o comportamento de um filtragem colaborativa usando os dados do banco já registrados.

🔧 O que eu faria se tivesse mais tempo
* Adicionar autenticação e perfis reais para permitir login e conexões reais entre usuários.

* Salvar o histórico de matches em banco de dados para análise posterior.

* Implementar uma lógica de afinidade baseada em regras reais ou até mesmo utilizando IA de verdade (ex: modelos de recomendação).

* Criar uma API RESTful para desacoplar o front-end e permitir integrações futuras (ex: app mobile).

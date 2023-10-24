# Jogo do JokenPô (Pedra, papel e tesoura.. e +)
Aplicação feita para teste de qualificação tecnica. Nesse projeto eu criei uma aplicação Web onde o usuário pode jogar o famoso pedra, papel e tesoura. Porém nesse jogo foi adicionado mais alguns itens na lista, o Lagarto e o Spock. Devido a simplicidade do jogo não houve necessidade de usar um banco de dados, pois não há armazenamento de pontuação, nome de jogador nem ranks.

![Logo](https://github.com/jcsantosgit/btg-jokenpo/blob/main/frontend/images/pedra-papel-tesoura-2.jpeg)

## Instruções para Executar o Programa
Entre na pasta do projeto (./backend/jokenpo_api/) execute o seguinte comando

```sh
dotnet run
```
A aplicação ira subir na porta 5195 (http) e 7234 (https). Para visualizar os endpoints digite http://localhost:5195/swagger/index.html no seu navegador. Então ira aparecer três endpoints:

| MÉTODO | ENDPOINT | DESCRIÇÃO
| ------ | ------ | ------ |
| GET | /api/Jokenpo | Lista os itens disponiveis para o jogo |
| GET | /api/Jokenpo/{id} | Pesquisa um item pelo ID dele |
| GET | /api/Jokenpo/play/{id} | Realiza uma jogada passando o ID do item selecionado pelo jogador |

Para rodar a aplicação do Frontend eu utilizei o plugin Live Server no Visual Studio Code

Nota: 
`Devido ao CORS é preciso liberar as requisições do seu IP no arquivo Program.cs da aplicação backend. No meu caso tive que liberar o http://127.0.0.1:5500/ que é gerado automaticamente pelo plugin Live Server`

Mudi aqui
![image](https://github.com/jcsantosgit/btg-jokenpo/assets/6317939/3c6536d4-eb2b-40e2-be70-a0852fde81a3)


## Telas do Jogo Feito em HTML, CSS e Javascript

### Tela Inciail
![image](https://github.com/jcsantosgit/btg-jokenpo/assets/6317939/f9c66638-d93b-4f8c-b312-e149a20ac320)

### Tela de Instruções do Jogo
![image](https://github.com/jcsantosgit/btg-jokenpo/assets/6317939/f9a0a41f-2318-4895-8bf6-3ce0cd1e377d)

### Tela do Jogo
![image](https://github.com/jcsantosgit/btg-jokenpo/assets/6317939/c89aea58-532f-490f-89d4-a0bec6c2b80a)



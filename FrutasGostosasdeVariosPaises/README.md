# Frutas Gostosas de Vários Países

Este projeto é uma aplicação C# que gera um site estático interativo para apresentação de frutas de diversos países, com informações detalhadas de cada produto. O site utiliza HTML, CSS e JavaScript organizados em diretórios separados, seguindo boas práticas de estruturação.

---

## Estrutura do Projeto

```
FrutasGostosasdeVariosPaises/
│
├── Program.cs                # Código principal em C# que gera o HTML
├── FrutasGostosasdeVariosPaises.csproj
├── Data/
│   └── frutas.json           # Lista de frutas em formato JSON
├── Views/
│   └── relatorio.html        # HTML gerado pelo programa
└── wwwroot/
    ├── css/
    │   └── style.css         # Estilos do site
    └── js/
        └── apresentacao.js   # Lógica de interação do site
```

---

## Como Utilizar

### 1. Pré-requisitos

- [.NET 6.0 SDK ou superior](https://dotnet.microsoft.com/download)
- Editor de código (Visual Studio Code, Visual Studio, etc.)

### 2. Configuração

1. Clone ou baixe este repositório.
2. Certifique-se de que o arquivo `Data/frutas.json` contém a lista de frutas desejada.
3. Os arquivos de estilo (`style.css`) e JavaScript (`apresentacao.js`) estão em `wwwroot/css` e `wwwroot/js`, respectivamente.

### 3. Gerando o HTML

Abra o terminal na pasta do projeto e execute:

```bash
dotnet run
```

O arquivo `Views/relatorio.html` será gerado automaticamente.

### 4. Visualizando o Site

Abra o arquivo `Views/relatorio.html` em seu navegador para visualizar o site interativo.

---

## Funcionalidades

- **Lista de frutas**: Exibe botões para cada fruta cadastrada.
- **Detalhes do produto**: Ao clicar em uma fruta, exibe informações detalhadas (nome, país de origem, preço unitário, quantidade por caixa e preço total da caixa).
- **Layout moderno**: Nome da empresa fixo à esquerda, lista de frutas e detalhes à direita.
- **Estrutura separada**: HTML, CSS e JS organizados em pastas distintas para fácil manutenção.

---

## Personalização

- **Adicionar/editar frutas**: Edite o arquivo `Data/frutas.json` conforme necessário.
- **Alterar estilos**: Modifique `wwwroot/css/style.css`.
- **Alterar lógica de interação**: Modifique `wwwroot/js/apresentacao.js`.

---

## Publicação na Azure (Site Estático)

1. Gere o HTML, CSS e JS.
2. Faça upload dos arquivos das pastas `Views` e `wwwroot` para um Static Website em uma Conta de Armazenamento Azure.
3. Use a URL fornecida pela Azure para acessar seu site.

---

## Exemplo de frutas.json

```json
[
  {
    "Nome": "Maçã",
    "PaisOrigem": "Brasil",
    "PrecoUnitario": 2.5,
    "QuantidadeCaixa": 10
  },
  {
    "Nome": "Banana",
    "PaisOrigem": "Equador",
    "PrecoUnitario": 1.8,
    "QuantidadeCaixa": 12
  }
  // ...adicione mais frutas conforme desejar
]
```

---

## Licença

Este projeto é livre para uso educacional e
# Frutas Gostosas de Vários Países

## Descrição

Aplicação em C# que gera um site estático interativo para apresentação de frutas de diversos países, exibindo informações detalhadas de cada produto. O projeto utiliza HTML, CSS e JavaScript organizados em diretórios separados, seguindo boas práticas de estruturação.

---

## Sumário

- [Descrição](#descrição)
- [Instalação](#instalação)
- [Uso](#uso)
- [Recursos](#recursos)
- [Configuração](#configuração)
- [Licença](#licença)

---

## Instalação

1. Certifique-se de ter o [.NET 8.0 SDK ou superior](https://dotnet.microsoft.com/download) instalado.
2. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   ```
3. Navegue até a pasta do projeto:
   ```bash
   cd FrutasGostosasdeVariosPaises
   ```

---

## Uso

1. Edite o arquivo `Data/frutas.json` para adicionar ou modificar frutas.
2. No terminal, execute:
   ```bash
   dotnet run
   ```
3. O arquivo `Views/relatorio.html` será gerado automaticamente.
4. Abra `Views/relatorio.html` em seu navegador para visualizar o site interativo.

---

## Recursos

- **Lista de frutas**: Exibe botões para cada fruta cadastrada.
- **Detalhes do produto**: Ao clicar em uma fruta, exibe informações detalhadas (nome, país de origem, preço unitário, quantidade por caixa e preço total da caixa).
- **Layout moderno**: Nome da empresa fixo à esquerda, lista de frutas e detalhes à direita.
- **Estrutura separada**: HTML, CSS e JS organizados em pastas distintas para fácil manutenção.

---

## Configuração

- **Adicionar/editar frutas**: Edite o arquivo `Data/frutas.json`.
- **Alterar estilos**: Modifique `wwwroot/css/style.css`.
- **Alterar lógica de interação**: Modifique `wwwroot/js/apresentacao.js`.

---

## Licença

Este projeto é livre para uso educacional e pessoal. Sinta-se à vontade para modificar e compartilhar conforme necessário.
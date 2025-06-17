using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Fruta
{
    public required string Nome { get; set; }
    public required string PaisOrigem { get; set; }
    public required double PrecoUnitario { get; set; }
    public required int QuantidadeCaixa { get; set; }
}

class Program
{
    static void Main()
    {
        string caminhoJson = Path.Combine("Data", "frutas.json");
        if (!File.Exists(caminhoJson))
        {
            Console.WriteLine($"Arquivo não encontrado: {caminhoJson}");
            return;
        }

        string json = File.ReadAllText(caminhoJson);
        List<Fruta>? frutas = JsonSerializer.Deserialize<List<Fruta>>(json);
        string frutasJson = JsonSerializer.Serialize(frutas);

        string pastaViews = "Views";
        if (!Directory.Exists(pastaViews))
            Directory.CreateDirectory(pastaViews);

        string html = $@"
<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
    <title>Frutas Gostosas de Vários Países</title>
    <link rel='stylesheet' href='../wwwroot/css/style.css'>
</head>
<body>
    <div class='main-layout'>
        <div class='empresa'>
            Frutas Gostosas de Vários Países
        </div>
        <div class='frutas-area'>
            <div class='frutas-lista'>
                <h2>Frutas</h2>
                <div id='lista-frutas'></div>
            </div>
            <div id='info-fruta' class='info-fruta'></div>
        </div>
    </div>
    <script>
        window.frutasData = {frutasJson};
    </script>
    <script src='../wwwroot/js/apresentacao.js'></script>
</body>
</html>
";
        File.WriteAllText(Path.Combine(pastaViews, "relatorio.html"), html);
        Console.WriteLine("Relatório HTML gerado em Views/relatorio.html");
    }
}

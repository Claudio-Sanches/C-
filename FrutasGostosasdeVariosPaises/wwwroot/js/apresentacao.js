document.addEventListener("DOMContentLoaded", () => {
    const frutas = window.frutasData;
    const lista = document.getElementById('lista-frutas');
    const info = document.getElementById('info-fruta');

    frutas.forEach((fruta, idx) => {
        const btn = document.createElement('button');
        btn.textContent = fruta.Nome;
        btn.onclick = () => {
            info.innerHTML = `
                <h3>${fruta.Nome}</h3>
                <ul>
                    <li><strong>País de origem:</strong> ${fruta.PaisOrigem}</li>
                    <li><strong>Preço da fruta:</strong> R$ ${fruta.PrecoUnitario.toFixed(2)}</li>
                    <li><strong>Quantidade da caixa:</strong> ${fruta.QuantidadeCaixa}</li>
                    <li><strong>Preço da caixa:</strong> R$ ${(fruta.PrecoUnitario * fruta.QuantidadeCaixa).toFixed(2)}</li>
                </ul>
            `;
            info.style.display = 'block';
        };
        lista.appendChild(btn);
        lista.appendChild(document.createElement('br'));
    });
});
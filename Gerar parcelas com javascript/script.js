let ValueToPortion = document.querySelector(".value-portion");
let numberPortion = document.querySelector(".number-portion");

let tbody = document.querySelector("tbody");
let btnParcelar = document.querySelector(".btn-parcelar");

function ValidateFields() {
    let fildValidated = false;
    if (ValueToPortion.value)
        fildValidated = true;

    return fildValidated;
}

btnParcelar.addEventListener("click", () => {
    if (!ValidateFields() || Number.isNaN(parseFloat(ValueToPortion.value))) {
        alert("Preencha o campo ou digite uma valor válido!");
        return;
    }

    ParcelarValor(parseFloat(ValueToPortion.value), numberPortion.value);
})

function ParcelarValor(valueTotal, numberPortion) {
    tbody.innerHTML = "";
    let dateNow = new Date();

    for (let i = 0; i < numberPortion; i++) {
        dateNow.setMonth(dateNow.getMonth() + 1);
        tbody.innerHTML += `
            <tr>
                <th>${i + 1}</th>
                <th>${dateNow.toLocaleDateString()}</th>
                <th>R$ ${(valueTotal / numberPortion).toFixed(2)}</th>
            </tr>
        `
    }
}
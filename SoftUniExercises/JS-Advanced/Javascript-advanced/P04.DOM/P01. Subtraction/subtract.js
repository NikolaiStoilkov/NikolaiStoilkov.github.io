function subtract() {
    let fNumber = Number(document.getElementById('firstNumber').value);
    let sNumber = Number(document.getElementById('secondNumber').value);

    let calculate = fNumber - sNumber;
    document.getElementById('result').textContent(calculate);

}
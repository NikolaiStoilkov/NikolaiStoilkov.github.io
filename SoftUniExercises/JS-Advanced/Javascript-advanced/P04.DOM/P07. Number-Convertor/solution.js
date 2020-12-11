function solve() {

    let convertButton = document.getElementById('btn');
    
    convertButton.addEventListener('click', () => {
        let number = document.getElementById('input').value;
        let typeToConvert = document.getElementById('selectMenuTo').value;
        let resultValue = document.getElementById('result')
        resultValue.value = '';
        let parsedNumber = Number(number);
        if(typeToConvert == 'Binary '){
            let result = convertToBinary(parsedNumber);
            
            resultValue.value = result;
            
        }else if(typeToConvert == 'Hexadeicmal'){
           let result = toHex(parsedNumber);

           resultValue.value = result;
        }   
        
    })

    
}

function toHex(number) {
    if (number < 0)
    {
      number = 0xFFFFFFFF + number + 1;
    }
  
    return number.toString(16).toUpperCase();
}

function convertToBinary(x) {
    let bin = 0;
    let rem, i = 1, step = 1;
    while (x != 0) {
        rem = x % 2;
        x = parseInt(x / 2);
        bin = bin + rem * i;
        i = i * 10;
    }

    console.log(bin)
    return bin;
}


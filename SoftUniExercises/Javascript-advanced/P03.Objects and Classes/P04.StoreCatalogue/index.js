function storeCatalogue(input) {
    let store = {}; 

    input.sort()
    input.forEach(
        line => {
            let[product, price] = line.split(' : ');
            let letter = product[0];
            if(!store[letter]){
                store[letter] = [product+ ': ' + Number(price)];
            } else {
                store[letter].push(product+ ': ' + Number(price));
            }
        }
    );

    //print object
    Object.keys(store).forEach(letter => {
        console.log(letter);

        store[letter].forEach(v => {
            let output = `  ${v}`
            console.log(output);
        });
    })
}

storeCatalogue(['Banana : 2',
    'Rubi\'s Cube : 5',
'Raspberry P : 4999',
    'Rolex : 100000',
    'Rollon : 10',
    'Rali Car : 2000000',
    'Pesho : 0.000001',
    'Barrel : 10']


)
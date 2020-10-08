function givenDelimiter(array) {
    let delimiter = array[array.length - 1];
    let concatenate = '';
    for (let i = 0; i < array.length - 1; i++) {

        if (i === array.length -2){
            concatenate += array[i]
        }else{
            concatenate += array[i] + delimiter;
        }
    }
    BigInt a = ne

    console.log(concatenate);
}

givenDelimiter(['One',
    'Two',
    'Three',
    'Four',
    'Five',
    '-']
);
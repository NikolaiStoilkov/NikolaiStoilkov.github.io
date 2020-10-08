function processOddNumbers(arr) {

    let numbers = [];
    for (let i = 0; i < arr.length; i++) {
        if (i % 2 != 0){
            let doubled = Number(arr[i]) * 2;
            numbers.push(doubled);
        }
    }

    numbers.reverse();

    //print
    console.log(numbers.join(' '));
}
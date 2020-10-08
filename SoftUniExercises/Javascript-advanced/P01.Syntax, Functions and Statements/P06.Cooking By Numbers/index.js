function coockingByNumbers(array) {
    let number = Number(array[0]);
    for (let i = 1; i < array.length; i++) {

        let command = array[i];
        switch (command) {
            case 'chop':
                //TODO: divide the number by two
                console.log(number = number / 2);
                break;
            case 'dice':
                //TODO: square root of number
                console.log(number = Math.sqrt(number));
                break;
            case 'spice':
                //TODO: add 1 to number
                console.log(number++);
                break;
            case 'bake':
                //TODO: multiply number by 3
                console.log(number *= 3);
                break;
            case 'fillet':
                //TODO: subtract 20% from number
                console.log((number *= 0.80).toFixed(1));

                break;
        }
    }
}
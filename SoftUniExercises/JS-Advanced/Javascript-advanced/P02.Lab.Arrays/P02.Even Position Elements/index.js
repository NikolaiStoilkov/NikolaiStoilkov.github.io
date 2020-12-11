function evenPosition(array) {

    let str = '';
    for (let i = 0; i < array.length; i++) {
        if (i % 2 == 0) {
            str += array[i]+ ' ';
        }
    }
    console.log(str);
}
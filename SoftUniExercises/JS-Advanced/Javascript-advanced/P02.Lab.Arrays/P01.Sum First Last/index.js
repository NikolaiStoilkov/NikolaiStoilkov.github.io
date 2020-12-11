function sumFirstLast(array) {
    let sum = 0;

    let firstElement = Number(array[0]);
    let lastElement = Number(array[array.length - 1]);
    sum = firstElement + lastElement;
    console.log(sum);
}
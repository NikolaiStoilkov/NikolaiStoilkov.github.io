function biggestElement(matrix) {
    let arr =[];
    let biggestNum = Number.NEGATIVE_INFINITY;
    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j <matrix[i].length; j++) {
            arr[j] = matrix[i][j];
        }
        arr.forEach(function (a) {
            if (biggestNum < a){
                biggestNum = a;
            }
            return biggestNum;
        });
    }
    console.log(biggestNum);
}
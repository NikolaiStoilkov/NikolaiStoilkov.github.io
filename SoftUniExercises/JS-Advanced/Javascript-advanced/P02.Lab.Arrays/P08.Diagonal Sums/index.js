function diagonalSum(matrix) {
    let leftDiagonal = 0;
    let rightDiagonal = 0;
    let index = 0;
    // left to right diagonal sum
    for (let i = 0; i < matrix.length; i++) {
        for (let j = index; j < matrix[i].length ; j++) {
            leftDiagonal += Number(matrix[i][j]);
            break;
        }
        index++;
    }
    // right to left diagonal sum
    let lastIndex = matrix.length - 1;
    for (let j = 0; j < matrix.length; j++) {
        for (let i = lastIndex; i >= 0; i--) {
            rightDiagonal += Number(matrix[j][i]);
            break;
        }
        lastIndex--;
    }
    console.log(`${leftDiagonal} ${rightDiagonal}`)
}
function equalNeighbors(matrix) {
    let cnt = 0;
    let checkForNeighbors = function (matrix, currentMatrix) {
        for (let k = 0; k < matrix.length; k++) {
            for (let l = 0; l < matrix[k].length; l++) {
                if (matrix[k][l] === currentMatrix && matrix[k][l+1] === currentMatrix) {
                    return true;
                }
            }
        }
        return false;
    }
    let neighbors = [];
    let matrixLength = matrix.length % 2 != 0 ? matrix.length % 2 : matrix.length / 2;
    for (let i = 1; i <= matrixLength; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            let currentNeighbor = matrix[i][j];
            if (i > 0 && i < matrix.length - 1) {
                // equal to top side
                if (currentNeighbor === matrix[i - 1][j]) {
                    if (!checkForNeighbors(neighbors,matrix[i-1][j])){
                        cnt++;
                    }
                    neighbors.push([matrix[i][j], matrix[i-1][j]]);
                }
                // equal to bottom side
                if (currentNeighbor === matrix[i + 1][j]) {
                    if (!checkForNeighbors(neighbors,matrix[i + 1][j])){
                        cnt++;
                    }
                    neighbors.push([matrix[i][j], matrix[i+1][j]]);
                }
            }
        }
    }
    console.log(cnt);
}
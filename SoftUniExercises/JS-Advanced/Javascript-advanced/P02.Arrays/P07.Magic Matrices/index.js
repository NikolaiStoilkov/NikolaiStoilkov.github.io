function magicMatrix(inputArgs) {
    /*
    const getDiagonalValue = (matrix) => {
        let firstValue = matrix[0][0];
        let secondValue = matrix[1][1];
        let thirdValue = matrix[2][2];

        return Number(firstValue) + Number(secondValue) + Number(thirdValue);
    }
     */

    const getVerticalValue = (array) => {
        let isTrue = false;
        let newArr = [0, 0, 0];
        let indexer = 0;


        for (let row = 0; row < array.length; row++) {
            for (let col = 0; col < array[row].length; col++) {
                newArr[indexer] += Number(array[row][col]);
                indexer++;
            }
            indexer = 0;
        }


        if (newArr.every((x) => x === newArr[0])) {
            isTrue = true;
        }

        return isTrue;

    }

    const getHorizontalValue = (array) => {
        let isTrue = false;
        let newArr = [0, 0, 0];
        let indexer = 0;

        for (let row = 0; row < array.length; row++) {
            for (let col = 0; col < array[row].length; col++) {
                newArr[indexer] += Number(array[row][col]);
            }
            indexer++;
        }

        if (newArr.every((x) => x === newArr[0])) {
            isTrue = true;
        }

        return isTrue;
    }

    let horizontal = getHorizontalValue(inputArgs);
    let vertical = getVerticalValue(inputArgs);
    //let diagonal = getDiagonalValue(inputArgs);

    if (horizontal === vertical) {
        return true;
    } else {
        return false;
    }


}

console.log(magicMatrix([[1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]]
));
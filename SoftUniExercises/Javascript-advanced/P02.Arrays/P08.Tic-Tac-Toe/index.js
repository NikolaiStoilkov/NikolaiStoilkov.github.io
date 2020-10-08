function ticTacToe(inputs) {
    let table = Array.from(Array(3),()  => new Array(3).fill(false));

    let isValid = false;
    const checkValidCoordinates = (table, x,y) => {
        //TODO: check for valid coordinates
        if (x >= 0 && x <= 2 &&
            y >= 0 && y <= 2){
            if (table[x][y] === false){
                isValid = true;
            }
        }

        return isValid;
    }

    const checkWinner = (table, x,y) => {
        //TODO: Check for winner

        const lines = [
            [[0,0], [0,1], [0,2]],
            [[1,0], [1,1], [1,2]],
            [[2,0], [2,1], [2,2]],
            [[0,0], [1,0], [2,0]],
            [[0,1], [1,1], [2,1]],
            [[0,2], [1,2], [2,2]],
            [[0,0], [1,1], [2,2]],
            [[0,2], [1,1], [2,0]],
        ];
        for (let i = 0; i < lines.length; i++) {
            let [a,b,c] = lines[i];

            let first = table[a[0]][a[1]];
            let second = table[b[0]][b[1]];
            let third = table[c[0]][c[1]];
            if (first && first == second && second == third) {
                return first;
            }
        }
        return null;
    }

    let playerRound = 0;
    let isWinner = false;
    while (isWinner !== true) {
        for (let i = 0; i < inputs.length; i++) {
            let coordinates = inputs[i].split(' ');
            let x = coordinates[0];
            let y = coordinates[1];
            //let tableCoordinates = table[x][y];
            if (table[x][y] === false) {
                if (playerRound % 2 === 0) {
                    // X turn
                    checkValidCoordinates(table, x,y);

                    if (isValid){
                        table[x][y] = `X`;
                        isValid = false;
                    }

                    if (checkWinner(table,x,y) !== null){
                        console.log(`Player X wins!`)
                        isWinner = true;
                        break;
                    }
                } else {
                    // O turn
                    checkValidCoordinates(table, x,y);

                    if (isValid){
                        table[x][y] = `O`;
                        isValid = false;
                    }

                    if (checkWinner(table,x,y) !== null){
                        console.log(`Player O wins!`)
                        isWinner = true;
                        break;
                    }
                }

            }else{
                console.log('This place is already taken. Please choose another!');
                playerRound--;
            }
            playerRound++;
        }
    }

    let elements = '';
    for (let i = 0; i < table.length; i++) {
        table[i].forEach((element) => {
                elements += element + '\t';
            }
        )
        console.log(elements.trimEnd());
        elements= '';
    }
}

ticTacToe(["0 0",
    "0 0",
    "1 1",
    "0 1",
    "1 2",
    "0 2",
    "2 2",
    "1 2",
    "2 2",
    "2 1"]

);
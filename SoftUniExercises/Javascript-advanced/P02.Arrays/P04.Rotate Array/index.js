function rotateArray(input) {
    let rotations = Number(input[input.length - 1]);
    input.pop();
    for(let i = 0; i < rotations; i++) {
        input.unshift(input.pop());
    }
    console.log(input.join(' '));
}
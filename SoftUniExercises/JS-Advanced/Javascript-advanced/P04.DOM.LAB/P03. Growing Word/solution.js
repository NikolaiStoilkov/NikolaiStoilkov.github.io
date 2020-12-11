function growingWord() {
    let word = document.createElement('div');

    let initialSize = 2;
    let typeOfColor = 'blue';
    let appendColor = ``;

    if (typeOfColor === 'blue') {
        appendColor = `<p style="color: ${typeOfColor} font-size: ${initialSize}px">Growing Word</p>`
        typeOfColor = 'green';

    } else if (typeOfColor === 'green') {
        appendColor = `<p style="color: ${typeOfColor} font-size: ${initialSize * 2}px">Growing Word</p>`;
        typeOfColor = 'red';
        initialSize += 2;
    } else if (typeOfColor === 'red') {
        appendColor = `<p style="color: ${typeOfColor} font-size: ${initialSize * 2}px">Growing Word</p>`;
        typeOfColor = 'blue';
        initialSize = 2;
    }

    word.innerHTML = appendColor;
    console.log(document.getElementById('word').appendChild(word));
    return document.getElementById('word').appendChild(word);


}


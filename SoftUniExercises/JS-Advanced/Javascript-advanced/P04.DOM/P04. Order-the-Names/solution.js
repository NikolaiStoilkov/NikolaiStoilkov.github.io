function solve() {
    let input = document.getElementsByTagName('input')[0];
    let btn = document.getElementsByTagName('button')[0];


    let database = {};
    let index = 0;
    for (let symbol = 65; symbol <= 90; symbol++) {
        let letter = String.fromCharCode(symbol);
        database[letter] = index++;
    }


    let e = () => {
        let array = document.getElementsByTagName('ol')[0].children;


        let currentName = input.value.toString()[0].toUpperCase() + input.value.slice(1).toLocaleLowerCase();
        let capitalLetter = currentName[0];

        if (database[capitalLetter] != undefined) {
            let currentIndex = database[capitalLetter];
            let currentElement = array[currentIndex];

            if(currentElement.innerText == ''){
                currentElement.textContent = currentName;
            } else {
                currentElement.textContent += ', ' + currentName;
            }
        }

        input.value = '';
    }
    btn.addEventListener('click', e);

}
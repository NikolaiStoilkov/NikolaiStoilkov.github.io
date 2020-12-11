function formatArticle() {

    let text = document.getElementById('input').innerText;


    let strText = text.toString();
    //count sentences
    let counter = 0;
    let sentences = [];
    let str = '';
    let letterCounter = 0;

    for (let i = 0; i <= strText.length; i++) {
        letterCounter++;

        if (strText[i] === '.') {
            counter++;
            let currentIndex = i - letterCounter + 1;
            for (let j = currentIndex; j <= (i + 1); j++) {
                str += strText[j];
            }

            sentences.push(str.trimStart());
            str = '';
            letterCounter = 0;
        }

    }

    let wholeText = '';
    if (counter < 3) {
        let createElement = document.createElement('div');

        let stringToAppend = (sentences) => {
            sentences.forEach(
                line => {
                    wholeText += line.toString();
                }
            );

            return `<p>${wholeText}</p>`
        }

        createElement.innerHTML = stringToAppend(sentences);

        return document.getElementById('output').appendChild(createElement);
    } else {
        let createElement = document.createElement('div');
        console.log(sentences);
        let isEmpty = false;
        let indexer = 0;

        let stringToAppend = (sentences) => {
            let args = '';

            while (isEmpty !== true) {
                for (let i = 0; i < 3; i++) {
                    wholeText += sentences[indexer].toString();
                    indexer++;

                    if (sentences[indexer] === undefined) {
                        isEmpty = true;
                        break;
                    }
                }

                args += `<p>${wholeText}</p>`
                wholeText = '';

            }

            return args;
        }

        createElement.innerHTML = stringToAppend(sentences);

        return document.getElementById('output').appendChild(createElement);
    }
}

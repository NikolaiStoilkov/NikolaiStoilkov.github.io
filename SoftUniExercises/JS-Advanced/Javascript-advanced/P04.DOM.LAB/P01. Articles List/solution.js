function createArticle() {
	let titleValue = document.getElementById('createTitle').value;
	let articleContent = document.getElementById('createContent').value;

	if(titleValue === '' || articleContent === ''){

    }else {
        // child element
        let createArticleElement = document.createElement("article");

        // element to append
        let articleScope = `<h3>${titleValue}</h3><p>${articleContent}</p>`;

        //convert to DOM element
        createArticleElement.innerHTML = articleScope;

        //return the DOM element to target ID
        return document.getElementById('articles').appendChild(createArticleElement);
    }
}


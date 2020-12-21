function addItem(e) {
    let inputElement = document.getElementById('newItemText');
    if (inputElement.value != '') {
        let itemsListElement = document.getElementById('items')
        let liElement = document.createElement('li');
        liElement.innerHTML = `${inputElement.value}`;
        let deleteElement = document.createElement('span');
        deleteElement.innerText = '[DELETE]';
        deleteElement.style.cursor = 'pointer';
        liElement.appendChild(deleteElement);
        deleteElement.addEventListener('click', function (e) {
            let parentElement = e.target.parentElement;
            parentElement.remove();
        });
        itemsListElement.appendChild(liElement);
        inputElement.value = '';
    }else{
        alert("Input cannot be empty!")
    }
}


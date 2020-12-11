function addItem() {
    let text = document.getElementById('newItemText');
    let data = document.getElementById('newItemValue');
    let select = document.getElementById('menu');

    let option = `<option value= '${data.value}'>${text.value}</option>`
    //select.innerHTML += option;

    select.insertAdjacentElement('beforeend', option);



    text.value = '';
    data.value = '';
}
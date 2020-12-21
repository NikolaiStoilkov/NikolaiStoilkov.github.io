function deleteByEmail() {
    let input = document.getElementById('email');

    let elements = document.querySelector('table#customers');

    let tbody = elements.querySelector('tbody')
    let tr = tbody.querySelector('tr').innerText;

    let rows = document.getElementsByTagName('tbody')[0].rows;


    for (var i = 0; i < rows.length; i++) {
        var td = rows[i].getElementsByTagName('td');
        if (input.value == td[1].innerText) {
            rows[i].remove();
            let result = document.getElementById('result');
            result.innerHTML = '';
            return result.append(deletedElement('p'));
        }
    }

    //TODO: not found
    let result = document.getElementById('result');
    result.innerHTML = '';
    result.append(notFoundElement('p'));



}

function notFoundElement(type) {
    let e = document.createElement(type);
    let c = `Not found!`
    e.innerHTML = c;

    return e;
}

function deletedElement(type) {
    let e = document.createElement(type);
    let c = `Deleted!`
    e.innerHTML = c;

    return e;
}
// var rows =document.getElementsByTagName("tbody")[0].rows;
// for(var i=0;i<rows.length;i++){
// var td = rows[i].getElementsByTagName("td")[i];
// console.log(td)
// }
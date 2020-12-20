function deleteByEmail() {
    let elements = document.querySelectorAll('table#customers');
    // elements.forEach(e => console.log(e))


    let tbod = elements.forEach(e => {
        let tableValue = e.querySelector('tbody');
        for(var i =0;i <tableValue.length; i++){
            var td = tableValue[i].getElementByTagName('td')[i];
            console.log(td);
        }
        
        
    })


    
    let emailToRemove = document.getElementById('email').value;
    // console.log(emailToRemove)
    for (let i = 0; i < elements.length; i++) {
        if (elements[i] === emailToRemove) {
            elements[i].removeAttribute(`${emailToRemove}`);
        }
    }
}
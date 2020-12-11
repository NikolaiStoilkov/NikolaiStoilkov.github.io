function attachEvents() {
    const url = 'https://phonebook-nakov.firebaseio.com/phonebook.json';
    let btnLoad = document.getElementById('btnLoad');
    let ul = document.getElementById('phonebook')

    btnLoad.addEventListener('click', () => {
        fetch(url).then(response => response.json())
            .then(data => {
                Object.keys(data).forEach((key) => {
                    let li = document.createElement('li')
                    li.textContent = `${data[key].person}: ${data[key].phone}`;


                    let deleteBtn = document.createElement('button');
                    let deleteUrl = `https://phonebook-nakov.firebaseio.com/phonebook/${key}.json`;
                    deleteBtn.textContent = 'DELETE';

                    //todo add eventListener
                    deleteBtn.addEventListener('click', () => {
                        fetch(deleteUrl, {method: 'delete'});
                    })


                    li.appendChild(deleteBtn);
                    ul.appendChild(li);
                });



            });
    })

    btnCreate.AddEventListener('click',() => {
        let person = document.getElementById('person')
        let phone = document.getElementById('phone')

        fetch(url,{
            method: 'POST',
            body: JSON.stringify(
                {person:person.value, phone: phone.value})})
    })
}

attachEvents();
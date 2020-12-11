function solve() {
    let btn = document.getElementById('send');
    let chatInput = document.getElementById('chat_input');
    let chatBodyBox = document.getElementById('chat_box_body');
    let chat = document.getElementById('chat_messages');
    let enterBtn = document.getElementById('chat_input');


    btn.addEventListener('click', () => {
        let child = document.createElement('div');
        let appendInput = `${chatInput.value}`;

        child.className = 'message my-message'
        child.innerHTML = appendInput;


        chat.appendChild(child);

        chatInput.value = '';

    });

    enterBtn.addEventListener('keydown',(event) => {
        if (event.key === "Enter"){
            let child = document.createElement('div');
            let appendInput = `${chatInput.value}`;

            child.className = 'message my-message'
            child.innerHTML = appendInput;


            chat.appendChild(child);

            chatInput.value = '';
        }
    })
}



function toggle() {
    let btn = document.getElementsByClassName('button')[0];
    let info = document.getElementById('extra');

    if (btn.textContent == 'More'){

        info.style.display = 'block';
        btn.textContent = 'Less'
    } else {
        info.style.display = 'none';
        btn.textContent = 'More';
    }
}
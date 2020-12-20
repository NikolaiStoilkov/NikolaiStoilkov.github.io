function solve() {
  
  let btns = document.getElementsByClassName('link-1');

  let softuni = btns[0];
  let softuniCount = 0;

  let google = btns[1];
  let googleCount = 0;

  let youtube = btns[2];
  let youtubeCount = 0;

  let wikipedia = btns[3];
  let wikipediaCount = 0;

  let gmail = btns[4];
  let gmailCount = 0;

  let stackoverflow = btns[5];
  let stackoverflowCount = 0;

  softuni.addEventListener('click', () => {
    let softuniTimes = document.querySelector('p#softuni');
    softuniTimes.innerHTML = '';
    softuniTimes.className = 'p-style'
    softuniTimes.append(createElement(++softuniCount,'p'));
  });

  google.addEventListener('click', () => {
    let googleTimes = document.querySelector('p#google');
    googleTimes.innerHTML = '';
    googleTimes.append(createElement(++googleCount,'p'));
  });

  youtube.addEventListener('click', () => {
    let youtubeTimes = document.querySelector('p#youtube');
    youtubeTimes.innerHTML = '';
    youtubeTimes.append(createElement(++youtubeCount,'p'));
  });

  wikipedia.addEventListener('click', () => {
    let wikipediaTimes = document.querySelector('p#wikipedia');
    wikipediaTimes.innerHTML = '';
    wikipediaTimes.append(createElement(++wikipediaCount,'p'));
  });

  gmail.addEventListener('click', () => {
    let gmailTimes = document.querySelector('p#gmail');
    gmailTimes.innerHTML = '';
    gmailTimes.append(createElement(++gmailCount,'p'));
  });

  stackoverflow.addEventListener('click', () => {
    let stackoverflowTimes = document.querySelector('p#stackoverflow');
    stackoverflowTimes.innerHTML = '';
    stackoverflowTimes.append(createElement(++stackoverflowCount,'p'));
  });


}

function createElement(counter, type){
  let e = document.createElement(type);
  let c = `visited ${counter} times`
  e.innerHTML = c;
  
  return e;
}
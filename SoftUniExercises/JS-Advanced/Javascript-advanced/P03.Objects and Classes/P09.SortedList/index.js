const { SortedList: srList } = require('./SortedList.js');

function solve() {
    const list = new srList();
    console.log(list);
    list.add(5);
    console.log(list);
}

solve();
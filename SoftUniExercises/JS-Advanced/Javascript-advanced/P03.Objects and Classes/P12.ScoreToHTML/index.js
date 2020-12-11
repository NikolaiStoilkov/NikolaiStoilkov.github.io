function scoreHTML(input) {
    let info = {};

    input.forEach(
        person => {
            let name = person.name;
            let score = Number(person.score);
            if(!info[name]){
                info[name] = {name: name, score: score};
            } else {
                info[name][score] += Number(score);
            }
        }
    )




}

scoreHTML([{"name":"Pesho & Kiro",
    "score":479
},
{"name":"Gosho, Maria & Viki",
    "score":205
}]
);
function heroicInventory(input) {
    let heroes = [];
    input.forEach(
        (line) => {
            let [name, level, items] = line.split(" / ");
            level = Number(level);

            items = items ? items.split(", ") : [];

            let hero = {name, level, items};
            heroes.push(hero);
        }
    );

    console.log(JSON.stringify(heroes));
}

heroicInventory(['Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara']
);
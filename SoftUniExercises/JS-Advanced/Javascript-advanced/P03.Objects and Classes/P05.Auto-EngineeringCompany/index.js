function autoCompany(input) {
    let cars = {};

    input.forEach(
        car => {
            let[brand, model, quantity] = car.split(" | ");
            if (!cars[brand]){
                cars[brand] = {};
            }

            if(!cars[brand][model]){
                cars[brand][model] = 0;
            }
            quantity = Number(quantity);
            cars[brand][model] += quantity;
        }
    );

    //print
    Object.entries(cars)
        .forEach(
            ([car,model,quantity]) => {
                console.log(car);
                Object.entries(model)
                    .forEach(
                        ([name, value]) => {
                            console.log(`###${name} -> ${value}`);
                        }
                    )
            }
        )
}

autoCompany(['Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10']
);
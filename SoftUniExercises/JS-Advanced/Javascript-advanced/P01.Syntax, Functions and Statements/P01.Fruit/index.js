function fruitShop(fruit,weight,price){
    let calculatedWeight = weight / 1000;
    let calculatedPrice = calculatedWeight * price;

    console.log(`I need $${calculatedPrice.toFixed(2)} to buy ${calculatedWeight.toFixed(2)} kilograms ${fruit}.`);
}

fruitShop('orange', '2500', '1.80');
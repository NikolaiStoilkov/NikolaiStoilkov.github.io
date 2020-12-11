function tickets(input, filterCriteria) {

    let tickets = [];
    input.forEach((line) => {
        [destination, price, status] = line.split("|");
        price = Number(price);
        tickets.push({ destination, price, status });
    });
    let sorted;
    if (filterCriteria === "destination") {
        sorted = tickets.sort((curr, next) =>
            curr.destination.localeCompare(next.destination)
        );
    } else if (filterCriteria === "price") {
        sorted = tickets.sort((curr, next) => curr.price - next.price);
    } else {
        sorted = tickets.sort((curr, next) =>
            curr.status.localeCompare(next.status)
        );
    }
    return sorted;
}

console.log(tickets(['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|departed'],
    'destination'
));
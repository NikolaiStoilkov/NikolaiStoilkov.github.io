function element(arr) {
    let n = Number(arr[arr.length - 1]);

    for (let i = 0; i < arr.length - 1; i +=n) {
            console.log(arr[i]);
    }
}

element(['5',
    '20',
    '31',
    '4',
    '20',
    '2']
);
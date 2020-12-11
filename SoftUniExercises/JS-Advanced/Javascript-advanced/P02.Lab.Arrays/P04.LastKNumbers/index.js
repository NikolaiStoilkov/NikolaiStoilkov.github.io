function lastNumberSequence(n, k) {
    let arr = [];


    for (let i = 0; i < n; i++) {
        let s = 0;
        arr[0] = 1;
        let cI = arr.length - 1;
        if (k >= arr.length) {

            for (let j = cI; j >= 0; j--) {
                s += Number(arr[j]);
            }
        }else{
            for (let j = cI; j > (cI-k); j--) {
                //i+1
                s += Number(arr[j]);
            }
        }

        arr[cI + 1] = s;

    }


    //print
    for (let j = 0; j < arr.length -1; j++) {
        console.log(arr[j]);
    }
}
function GCD(a, b) {

    let nA = Math.abs(a);
    let nB = Math.abs(b);

    let dvz = function (a, b) {

        if (b > a) {
            let temp = a;
            a = b;
            b = temp;
        }
        while (true) {
            if (b == 0) return a;
            a %= b;
            if (a == 0) return b;
            b %= a;

        }
    }

    let result = dvz(nA,nB);
    console.log(result);
}
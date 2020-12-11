function sameNubers(number) {
    let toStrNum = number.toString();
    let strLength = toStrNum.length;
    let sum = 0;
    let isSame = true;

    // check if all are same numbers
    for (let i = 0; i < strLength; i++) {
        let firstNum = toStrNum[0];
        if (firstNum !== toStrNum[i]){
            isSame = false;
        }
    }

    let getSum = function (a) {
        let sum = 0;
        for (let i = 0; i < a.length; i++) {
            sum += Number(a[i]);
        }

        return sum;
    }
    sum = getSum(toStrNum);

    console.log(isSame); // if all are same ? true : false
    console.log(sum);    // Value of all numbers
}
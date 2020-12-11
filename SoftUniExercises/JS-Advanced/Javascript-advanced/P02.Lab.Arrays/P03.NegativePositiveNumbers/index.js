function getPositiveOrNegative(nums) {
    let negativeNumbers = [];
    let positiveNumbers = [];

    for (let i = 0; i < nums.length; i++) {
        if (nums[i] < 0 && nums[i] > Number.NEGATIVE_INFINITY) {
            negativeNumbers.push(Number(nums[i]));
        }
        else{
            positiveNumbers.push(Number(nums[i]));
        }
    }
    negativeNumbers.sort();

    negativeNumbers.forEach(
        (x) => console.log(x)
    );

    positiveNumbers.forEach(
        (x) => console.log(x)
    );
}

getPositiveOrNegative([3, -2, 0, -1]
);
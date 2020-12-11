function extractSubsequence(input) {
    let subsequenceNumber = Number.NEGATIVE_INFINITY;

    let arr = [];
    input.forEach(
        function (element) {
            if (element >= subsequenceNumber){
                subsequenceNumber = element;
                arr.push(element);
            }
        }
    );

    console.log(arr.join('\n'));
}
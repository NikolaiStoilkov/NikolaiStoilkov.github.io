function roadRadar(input) {
    let speed = input[0];
    let place = input[1];

    const motorway = 130;
    const interstate  = 90;
    const city = 50;
    const residential = 20;


    if (place === 'motorway'){
        let calculateSpeed = speed - motorway;
        if (calculateSpeed >= 1
            && calculateSpeed<= 20){
            return 'speeding';
        }else if(calculateSpeed >=21 && calculateSpeed <= 40){
            return 'excessive speeding'
        }else if(calculateSpeed >=41){
            return 'reckless driving';
        }
    }
    else if(place === 'interstate'){
        let calculateSpeed = speed - interstate;
        if (calculateSpeed >= 1
            && calculateSpeed<= 20){
            return 'speeding';
        }else if(calculateSpeed >=21 && calculateSpeed <= 40){
            return 'excessive speeding'
        }else if(calculateSpeed >=41){
            return 'reckless driving';
        }
    }else if(place === 'city'){
        let calculateSpeed = speed - city;
        if (calculateSpeed >= 1
            && calculateSpeed<= 20){
            return 'speeding';
        }else if(calculateSpeed >=21 && calculateSpeed <= 40){
            return 'excessive speeding'
        }else if(calculateSpeed >=41){
            return 'reckless driving';
        }
    }else if(place === 'residential'){
        let calculateSpeed = speed - residential;
        if (calculateSpeed >= 1
            && calculateSpeed<= 20){
            return 'speeding';
        }else if(calculateSpeed >=21 && calculateSpeed <= 40){
            return 'excessive speeding'
        }else if(calculateSpeed >=41){
            return 'reckless driving';
        }
    }

}
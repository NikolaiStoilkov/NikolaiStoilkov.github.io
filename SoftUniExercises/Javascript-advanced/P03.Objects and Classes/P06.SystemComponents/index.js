function systemComponents(input) {
    let result = {};

    input.forEach(line => {
        let [systemName, component, subComponnent] = line.split(" | ");
        if (!result[systemName]) {
            result[systemName] = {};
        }

        if (!result[systemName][component]) {
            result[systemName][component] = [];
        }

        result[systemName][component].push(subComponnent);
    });

    Object.entries(result)
        .sort(
            (curr, next) => {
                return Object.entries(next[1]).lenght - Object.entries(curr[1]).length || curr[0].localeCompare(next[0]);
            }
        ).forEach(
        ([system, components]) => {
            console.log(system);
            Object.entries(components)
                .sort(
                    (curr, next) => {
                        return next[1].length - curr[1].length;
                    }
                ).forEach(
                ([component, subComponents]) => {
                    console.log(`|||${component}`)
                    subComponents.forEach(sub => {
                        console.log(`||||||${sub}`)
                    })
                }
            )
        }
    )
}

systemComponents(['SULS | Main Site | Home Page',
    'SULS | Main Site | Login Page',
    'SULS | Main Site | Register Page',
    'SULS | Judge Site | Login Page',
    'SULS | Judge Site | Submittion Page',
    'Lambda | CoreA | A23',
    'SULS | Digital Site | Login Page',
    'Lambda | CoreB | B24',
    'Lambda | CoreA | A24',
    'Lambda | CoreA | A25',
    'Lambda | CoreC | C4',
    'Indice | Session | Default Storage',
    'Indice | Session | Default Security']
);
function elements(commands) {
    let arr = [];
    let indexer = 1;
    let currentCommand;
    for (let i = 0; i < commands.length; i++) {
        currentCommand = commands[i];
        if (currentCommand.toLowerCase() === 'add') {
            arr.push(indexer);
            indexer++;
        } else if (currentCommand.toLowerCase() === 'remove') {
            arr.pop();
            indexer++;
        }

    }

    if (currentCommand === 'remove' && arr.length === 0) {
        return 'Empty';
    } else {
        arr.forEach(
            (x) => console.log(x)
        );
    }

}

elements(['add',
    'add',
    'remove',
    'add',
    'add']
);
function main(arr) {
    let obj = {};
    for (let i = 0; i < arr.length - 1; i += 2) {
        obj[arr[i]] = Number(arr[i + 1]);
    }
    console.log(obj);
}

main(['Yoghurt', 48, 'Rise', 138, 'Apple', 52]);
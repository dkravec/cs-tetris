// Testing

const IBlock = [
    [1, 1, 1, 1],
];

const JBlock = [
    [1, 0, 0],
    [1, 1, 1]
];

const LBlock = [
    [0, 0, 1],
    [1, 1, 1]
];

const OBlock = [
    [1, 1],
    [1, 1]
];

const SBlock = [
    [0, 1, 1],
    [1, 1, 0]
];

const TBlock = [
    [0, 1, 0],
    [1, 1, 1]
];

const ZBlock = [
    [1, 1, 0],
    [0, 1, 1]
];

const blocks = [
    IBlock,
    JBlock,
    LBlock,
    OBlock,
    SBlock,
    TBlock,
    ZBlock
]

console.log(blocks)

for (let i = 0; i < blocks.length; i++) {
    //console.log(blocks[i])
    drawArr(blocks[i])

    const rotated = rotate(blocks[i])
    drawArr(rotated)
}


function drawArr(arr) {
    console.log("----")
    for (let i = 0; i < arr.length; i++) {
        var row = ""
        for (let j = 0; j < arr[i].length; j++) {
            row += arr[i][j]
        }
        console.log(row)
    }
    console.log("----")
}

const arr = IBlock
function rotate(arr) {
    const arrX = arr.length;
    const arrY = arr[0].length;
    const arr1Data = {
        arr,
        arrX,
        arrY,
    }
    //console.log(arr1Data)

    for (let i = 0; i < arrX; i++) {
        arr[i].reverse();
    }

    const arr2 = [];

    for (let i = 0; i < arrY; i++) {
        arr2.push([]);
        for (let j = 0; j < arrX; j++) {
            arr2[i].push(arr[j][i]);
        }
    }

    return arr2;
}

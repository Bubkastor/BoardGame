// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// script.js

const TileSideCoord = {
    TOP_RIGHT_SIDE: { start:{x: 50, y: 10 }, end: {x: 70, y: 20}},
    TOP_RIGHT_SIDE_V2: { start: {x: 70, y: 20 }, end:{x: 90, y:30}},
    RIGHT_SIDE: { start:{ x: 90, y: 30 }, end: {x: 90, y: 50}},
    RIGHT_SIDE_V2: { start: {x: 90, y: 50}, end:{x: 90, y: 70} },
    BOTTOM_RIGHT_SIDE: { start:{x: 90, y: 70 }, end: {x: 70, y: 80}},
    BOTTOM_RIGHT_SIDE_V2: { start:{x: 70, y: 80 }, end: {x: 50, y: 90}},
    BOTTOM_LEFT_SIDE: { start:{x: 30, y: 80}, end: {x: 10, y: 70}},
    BOTTOM_LEFT_SIDE_V2: { start:{x: 50, y: 90}, end: {x: 30, y: 80}},
    LEFT_SIDE: { start:{x: 10, y: 50  }, end: {x: 10, y: 30 }},
    LEFT_SIDE_V2: { start:{x: 10, y: 70  }, end: {x: 10, y: 50}},
    TOP_LEFT_SIDE: { start:{x: 30, y: 20 }, end: {x: 50, y: 10}},
    TOP_LEFT_SIDE_V2: { start:{x: 10, y: 30  }, end: {x: 30, y: 20}},
};
const TileSidePoint = {
    TOP_RIGHT_SIDE: -1,
    TOP_RIGHT_SIDE_V2: -2,
    RIGHT_SIDE: -3,
    RIGHT_SIDE_V2: -4,
    BOTTOM_RIGHT_SIDE: -5,
    BOTTOM_RIGHT_SIDE_V2: -6,
    BOTTOM_LEFT_SIDE: -8,
    BOTTOM_LEFT_SIDE_V2: -7,
    LEFT_SIDE: -10,
    LEFT_SIDE_V2: -9,
    TOP_LEFT_SIDE: -12,
    TOP_LEFT_SIDE_V2: -11,
};
const TileSidePoointByKey = new Map ([
    [TileSidePoint.TOP_RIGHT_SIDE, TileSideCoord.TOP_RIGHT_SIDE],
    [TileSidePoint.TOP_RIGHT_SIDE_V2, TileSideCoord.TOP_RIGHT_SIDE_V2],
    [TileSidePoint.RIGHT_SIDE, TileSideCoord.RIGHT_SIDE],
    [TileSidePoint.RIGHT_SIDE_V2, TileSideCoord.RIGHT_SIDE_V2],
    [TileSidePoint.BOTTOM_RIGHT_SIDE, TileSideCoord.BOTTOM_RIGHT_SIDE],
    [TileSidePoint.BOTTOM_RIGHT_SIDE_V2, TileSideCoord.BOTTOM_RIGHT_SIDE_V2],
    [TileSidePoint.BOTTOM_LEFT_SIDE, TileSideCoord.BOTTOM_LEFT_SIDE],
    [TileSidePoint.BOTTOM_LEFT_SIDE_V2, TileSideCoord.BOTTOM_LEFT_SIDE_V2],
    [TileSidePoint.LEFT_SIDE, TileSideCoord.LEFT_SIDE],
    [TileSidePoint.LEFT_SIDE_V2, TileSideCoord.LEFT_SIDE_V2],
    [TileSidePoint.TOP_LEFT_SIDE, TileSideCoord.TOP_LEFT_SIDE],
    [TileSidePoint.TOP_LEFT_SIDE_V2, TileSideCoord.TOP_LEFT_SIDE_V2],
]);

const nodes1 = [
    {
        id: 1,
        neighbors : [ TileSidePoint.TOP_RIGHT_SIDE,TileSidePoint.TOP_RIGHT_SIDE_V2, TileSidePoint.RIGHT_SIDE, TileSidePoint.TOP_LEFT_SIDE, TileSidePoint.TOP_LEFT_SIDE_V2, 2, 3]
    },
    {
        id: 2,
        neighbors: [ TileSidePoint.RIGHT_SIDE, TileSidePoint.RIGHT_SIDE_V2, TileSidePoint.BOTTOM_RIGHT_SIDE,TileSidePoint.BOTTOM_RIGHT_SIDE_V2, TileSidePoint.BOTTOM_LEFT_SIDE_V2, 1, 3]
    },
    {
        id: 3,
        neighbors: [ TileSidePoint.BOTTOM_LEFT_SIDE, TileSidePoint.BOTTOM_LEFT_SIDE_V2, TileSidePoint.LEFT_SIDE,TileSidePoint.LEFT_SIDE_V2, TileSidePoint.TOP_LEFT_SIDE_V2, 1, 2]
    }
];
const nodes2= [
    {
        id : 1,
        neighbors : [ TileSidePoint.TOP_RIGHT_SIDE,TileSidePoint.TOP_RIGHT_SIDE_V2, TileSidePoint.TOP_LEFT_SIDE, TileSidePoint.RIGHT_SIDE, 2 ]
    },
    {
        id : 2,
        neighbors : [ TileSidePoint.TOP_LEFT_SIDE_V2, TileSidePoint.RIGHT_SIDE, TileSidePoint.RIGHT_SIDE_V2, TileSidePoint.BOTTOM_RIGHT_SIDE, 1, 3, 4 ]
    },
    {
        id : 3,
        neighbors : [ TileSidePoint.BOTTOM_RIGHT_SIDE, TileSidePoint.BOTTOM_RIGHT_SIDE_V2, TileSidePoint.BOTTOM_LEFT_SIDE, TileSidePoint.BOTTOM_LEFT_SIDE_V2, TileSidePoint.LEFT_SIDE_V2, 2, 4 ]
    },
    {
        id : 4,
        neighbors : [ TileSidePoint.TOP_LEFT_SIDE_V2, TileSidePoint.LEFT_SIDE, TileSidePoint.LEFT_SIDE_V2, 2, 3 ]
    }
]

const nodesGroup = document.querySelector('.nodes');
const linesGroup = document.querySelector('.lines');
let existSide = new Set();
nodes2.forEach(node => {
    // Определяем границы для рисования
    let boundarySides = node.neighbors.sort(function(x, y) {return y - x});
    boundarySides = boundarySides.filter(function(x) {return x < 0;}); 
    const points = boundarySides.map(side => {
        if(!existSide.has(side))
            existSide.add(side);
        else
            return;

        let x1 = TileSidePoointByKey.get(side).start.x;
        let y1 = TileSidePoointByKey.get(side).start.y;
        let x2 = TileSidePoointByKey.get(side).end.x;
        let y2 = TileSidePoointByKey.get(side).end.y;
        return `${x1},${y1} ${x2},${y2}`;
    }).join(" ");

    // Рисуем область ноды
    const area = document.createElementNS("http://www.w3.org/2000/svg", "polygon");
    area.setAttribute('class', 'node' + node.id);
    area.setAttribute('points', points);
    nodesGroup.appendChild(area);

    //Рисуем линии для границ
    // for (let i = 0; i < boundarySides.length; i++) {
    //     const currentSide = boundarySides[i];
    //     const nextSide = boundarySides[(i + 1) % boundarySides.length]; // Следующий side для замыкания периметра

    //     const line = document.createElementNS("http://www.w3.org/2000/svg", "line");
    //     line.setAttribute('class', 'line');
    //     line.setAttribute('x1', currentSide.x);
    //     line.setAttribute('y1', currentSide.y);
    //     line.setAttribute('x2', nextSide.x);
    //     line.setAttribute('y2', nextSide.y);
    //     linesGroup.appendChild(line);
    // }

    //Рисуем линии для соседних нод
    // node.neighbors.forEach(neighbor => {
    //     if (typeof neighbor === "number") {
    //         const neighborNode = nodes.find(n => n.id === neighbor);
    //         if (neighborNode) {
    //             const neighborBoundarySides = neighborNode.neighbors.slice(0, 5);
    //             const neighborPoints = neighborBoundarySides.map(side => `${side.x},${side.y}`);

    //             const line = document.createElementNS("http://www.w3.org/2000/svg", "line");
    //             line.setAttribute('class', 'line');
    //             line.setAttribute('x1', boundarySides[0].x); // Начинаем с первой границы
    //             line.setAttribute('y1', boundarySides[0].y);
    //             line.setAttribute('x2', neighborBoundarySides[0].x); // Соединяем с первой границей соседней ноды
    //             line.setAttribute('y2', neighborBoundarySides[0].y);
    //             linesGroup.appendChild(line);
    //         }
    //     }
    // });
});

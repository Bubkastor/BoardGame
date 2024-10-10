// script.js

const TileSide = {
    TOP_RIGHT_SIDE: { x: 175, y: 35 },
    TOP_RIGHT_SIDE_V2: { x: 185, y: 45 },
    RIGHT_SIDE: { x: 200, y: 75 },
    RIGHT_SIDE_V2: { x: 200, y: 85 },
    BOTTOM_RIGHT_SIDE: { x: 175, y: 115 },
    BOTTOM_RIGHT_SIDE_V2: { x: 185, y: 125 },
    BOTTOM_LEFT_SIDE: { x: 125, y: 115 },
    BOTTOM_LEFT_SIDE_V2: { x: 115, y: 125 },
    LEFT_SIDE: { x: 100, y: 75 },
    LEFT_SIDE_V2: { x: 100, y: 85 },
    TOP_LEFT_SIDE: { x: 125, y: 35 },
    TOP_LEFT_SIDE_V2: { x: 115, y: 45 },
};

const nodes = [
    {
        id: 1,
        neighbors: [
            TileSide.TOP_LEFT_SIDE_V2,
            TileSide.TOP_LEFT_SIDE,
            TileSide.TOP_RIGHT_SIDE,
            TileSide.TOP_RIGHT_SIDE_V2,
            TileSide.RIGHT_SIDE,
            2,
            3
        ]
    },
    {
        id: 2,
        neighbors: [
            TileSide.RIGHT_SIDE,
            TileSide.RIGHT_SIDE_V2,
            TileSide.BOTTOM_RIGHT_SIDE,
            TileSide.BOTTOM_RIGHT_SIDE_V2,
            TileSide.BOTTOM_LEFT_SIDE_V2,
            1,
            3
        ]
    },
    {
        id: 3,
        neighbors: [
            TileSide.BOTTOM_LEFT_SIDE,
            TileSide.BOTTOM_LEFT_SIDE_V2,
            TileSide.LEFT_SIDE,
            TileSide.LEFT_SIDE_V2,
            TileSide.TOP_LEFT_SIDE_V2,
            1,
            2
        ]
    }
];

const nodesGroup = document.querySelector('.nodes');
const linesGroup = document.querySelector('.lines');

nodes.forEach(node => {
    // Определяем границы для рисования
    const boundarySides = node.neighbors.slice(0, 5); // Берем только стороны для периметра
    const points = boundarySides.map(side => `${side.x},${side.y}`).join(" ");

    // Рисуем область ноды
    const area = document.createElementNS("http://www.w3.org/2000/svg", "polygon");
    area.setAttribute('class', 'node');
    area.setAttribute('points', points);
    nodesGroup.appendChild(area);

    // Рисуем линии для границ
    for (let i = 0; i < boundarySides.length; i++) {
        const currentSide = boundarySides[i];
        const nextSide = boundarySides[(i + 1) % boundarySides.length]; // Следующий side для замыкания периметра

        const line = document.createElementNS("http://www.w3.org/2000/svg", "line");
        line.setAttribute('class', 'line');
        line.setAttribute('x1', currentSide.x);
        line.setAttribute('y1', currentSide.y);
        line.setAttribute('x2', nextSide.x);
        line.setAttribute('y2', nextSide.y);
        linesGroup.appendChild(line);
    }

    // Рисуем линии для соседних нод
    node.neighbors.forEach(neighbor => {
        if (typeof neighbor === "number") {
            const neighborNode = nodes.find(n => n.id === neighbor);
            if (neighborNode) {
                const neighborBoundarySides = neighborNode.neighbors.slice(0, 5);
                const neighborPoints = neighborBoundarySides.map(side => `${side.x},${side.y}`);

                const line = document.createElementNS("http://www.w3.org/2000/svg", "line");
                line.setAttribute('class', 'line');
                line.setAttribute('x1', boundarySides[0].x); // Начинаем с первой границы
                line.setAttribute('y1', boundarySides[0].y);
                line.setAttribute('x2', neighborBoundarySides[0].x); // Соединяем с первой границей соседней ноды
                line.setAttribute('y2', neighborBoundarySides[0].y);
                linesGroup.appendChild(line);
            }
        }
    });
});

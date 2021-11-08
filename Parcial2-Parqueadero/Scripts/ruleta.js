window.onload = () => {
    drawWheel();
}

let wheel;

let drawWheel = () => {
    wheel = new Winwheel({
        'numSegments': 4,
        'outerRadius': 212,
        'textFontSize': 20,
        'segments':
            [
                { 'fillStyle': '#eae56f', 'text': 'Spot 1' },
                { 'fillStyle': '#89f26e', 'text': 'Spot 2' },
                { 'fillStyle': '#7de6ef', 'text': 'Spot 3' },
                { 'fillStyle': '#e7706f', 'text': 'Spot 4' },
                { 'fillStyle': '#eae56f', 'text': 'Spot 5' },
                { 'fillStyle': '#eae56f', 'text': 'Spot 6' },
                { 'fillStyle': '#eae56f', 'text': 'Spot 7' },
                { 'fillStyle': '#eae56f', 'text': 'Spot 8' },
                { 'fillStyle': '#eae56f', 'text': 'Spot 9' },
                { 'fillStyle': '#eae56f', 'text': 'Spot 10' },
            ],
        'animation':
        {
            'type': 'spinToStop',
            'duration': 5,
            'spins': 10,
            'callbackFinished': alertPrize,
            'callbackAfter': drawTriangle
        }
    });

    drawTriangle();
}

let startSpin = () => {
    wheel.startAnimation();
}

let resetSpin = () => {
    wheel.stopAnimation(false);
    wheel.rotationAngle = 0;
    wheel.draw();

}

let drawTriangle = () => {
    ctx = wheel.ctx;

    distnaciaX = 150;
    distnaciaY = 50;
    
    ctx.strokeStyle = "navy";
    ctx.fillStyle = "#000000";
    ctx.lineWidth = 2;
    ctx.beginPath();
    ctx.moveTo(distnaciaX + 170, distnaciaY + 5);
    ctx.lineTo(distnaciaX + 230, distnaciaY + 5);
    ctx.lineTo(distnaciaX + 200, distnaciaY + 40);
    ctx.lineTo(distnaciaX + 171, distnaciaY + 5);
    ctx.stroke();
    ctx.fill();
}

let alertPrize = (indicatedSegment) => {
    alert("You have won " + indicatedSegment.text);
}
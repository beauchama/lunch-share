export function changeColor(colorCode: string): void {
    document.getElementById("square").style.background = `#${colorCode}`;
}
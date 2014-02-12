#pragma strict

var vitesse: int = 5;

function Update () {
   transform.Rotate(Time.deltaTime * 20 * vitesse, Time.deltaTime * 16 * vitesse, Time.deltaTime * 12 * vitesse);
}
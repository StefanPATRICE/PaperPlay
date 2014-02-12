#pragma strict

var cible: String = "Quitter";

function OnMouseUp()
{
    if (cible == "Quitter")
        Application.Quit();
    else
        Application.LoadLevel(cible);
}
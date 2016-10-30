#pragma strict

var time : float = 10.0;

function Update () {
    timer -= Time.deltaTime;
    if (time == 0)
        // Do something
}

function OnGUI(){
    GUI.Box(new Rect(10, 10, 50, 20), "Time: " + timer.ToString("0"));
}
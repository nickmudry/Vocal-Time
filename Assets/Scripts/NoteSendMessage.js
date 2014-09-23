#pragma strict

function Start () {

}

function Update () {
	gameObject.SendMessage("MicVolume", MicControl.loudness);
}
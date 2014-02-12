#pragma strict

var webcam: GameObject;
var texture: Texture;
var CameraTexture: WebCamTexture;
var baseRotation: Quaternion;
var snap: Texture2D;
var textureCible: Texture2D;
private var webCamScript: WebCam2;

var texture2d: Texture2D;

// Use this for initialization
function Start()
{
	webcam = GameObject.Find("Webcam");
	webCamScript = webcam.GetComponent("WebCam2");
}

function Update ()
{
    /*
    Debug.Log(webCamScript);
    Debug.Log(webCamScript.snap);

	texture = webCamScript.snap;

	textureCible = new Texture2D(texture.width,texture.height);
    /*
	width = texture.width;
	height = texture.height;

	var cols = texture.GetPixels(0);
	for( var i = 0; i < cols.Length; ++i ) {
		//cols[i] = Color.Lerp( cols[i], colors[mip], 0.33 );
		if((cols[i].a + cols[i].b + cols[i].r) > 2)
			cols[i] = Color.white;
		else
			cols[i] = Color.black;

		//cols[i] = Color.Lerp( cols[i], Color.red, 0.5 );
		//cols[i] = new Color(Random.value,Random.value,Random.value);
	}
	/*
	for( i = 0; i < cols.Length; ++i ) {
		if(
		cols[i] != cols[topFrom(i)] ||
		cols[i] != cols[bottomFrom(i)] ||
		cols[i] != cols[leftFrom(i)] ||
		cols[i] != cols[rightFrom(i)])
			cols[i] = Color.red;
	}
	/
	textureCible.SetPixels(cols,0);
	textureCible.Apply();
	*/
	renderer.material.mainTexture = textureCible;
}
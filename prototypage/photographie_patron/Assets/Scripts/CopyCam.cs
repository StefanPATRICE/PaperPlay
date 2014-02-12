using UnityEngine;
using System.Collections;


public class CopyCam : MonoBehaviour {

	private WebCam2 webCamScript;

	void Start()
	{
		webCamScript = GameObject.Find("WebCam").GetComponent<WebCam2>();
	}
	
	void Update ()
	{
		renderer.material.mainTexture = webCamScript.snap;
		renderer.material.SetFloat("_Rotate", 90);
	}
}

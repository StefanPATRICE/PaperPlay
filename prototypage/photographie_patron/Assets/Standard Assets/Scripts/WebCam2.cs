using UnityEngine;
using System.Collections;


public class WebCam2 : MonoBehaviour
{
	private GameObject objetTampon;
	private Texture texture;
	private WebCamTexture CameraTexture;
	private Quaternion baseRotation;
	public Texture2D snap;
	public int angle;

	private Texture2D texture2d;
	
	// Use this for initialization
	void Start () {

		//Set up camera
		WebCamDevice[] devices = WebCamTexture.devices;
		string backCamName="";
		for( int i = 0 ; i < devices.Length ; i++ ) {
			Debug.Log("Device:"+devices[i].name+ "IS FRONT FACING:"+devices[i].isFrontFacing);
			
			if (!devices[i].isFrontFacing) {
				backCamName = devices[i].name;
			}
		}
		
		//CameraTexture = new WebCamTexture(backCamName,400,300,30);
		CameraTexture = new WebCamTexture (backCamName, 400, 300);
		CameraTexture.Play();

		snap = new Texture2D(CameraTexture.width, CameraTexture.height);
	}
	
	void Update ()
	{
		//Correction de l'angle de la camera en fonction du device
		//thirdCube.transform.rotation = baseRotation * Quaternion.AngleAxis(-CameraTexture.videoRotationAngle, Vector3.back);
        angle = CameraTexture.videoRotationAngle;

		snap.SetPixels(CameraTexture.GetPixels());
		snap.Apply();
	}
}

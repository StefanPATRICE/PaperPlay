using UnityEngine;
using System.Collections;

public class WebcamOverlay : MonoBehaviour {

	private WebCam2 webCamScript;
	private bool drawGui = true;
	public Texture2D guide;

	void Start()
	{
		webCamScript = GameObject.Find("WebCam").GetComponent<WebCam2>();
	}

    void OnGUI() {
        if (!webCamScript.snap) {
            Debug.LogError("Assign a Texture in the inspector.");
            return;
        }
        if(drawGui)
        {
            if(GUI.Button(new Rect(0, 0, Screen.width, Screen.height),"Click Me" + Screen.width + " " + Screen.height))
            {
                drawGui = false;
            }
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), webCamScript.snap, ScaleMode.ScaleAndCrop, true);

            Matrix4x4 matrixBackup = GUI.matrix;
            Vector2 pivotPoint = new Vector2(Screen.width / 2, Screen.height / 2);
            GUIUtility.RotateAroundPivot(webCamScript.angle, pivotPoint);
            if(webCamScript.angle == 0)
                GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), webCamScript.snap, ScaleMode.ScaleAndCrop, true);
            else
                GUI.DrawTexture(new Rect((Screen.width - Screen.height)/2, (Screen.height - Screen.width)/2, Screen.height, Screen.width), webCamScript.snap, ScaleMode.ScaleAndCrop, true);
            GUI.matrix = matrixBackup;

            GUI.color = new Color(1.0f, 1.0f, 1.0f, 0.50f);
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), guide, ScaleMode.ScaleAndCrop, true);
        }
    }
}

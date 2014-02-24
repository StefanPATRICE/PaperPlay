using UnityEngine;
using System.Collections;

public class WebcamOverlay : MonoBehaviour {

	private WebCam2 webCamScript;
	private int drawGui = 0;
	public Texture2D guide;
	public Texture2D modele;

	void OnMouseUp()
    {
        drawGui = 1;
        Debug.Log("StartGUI");
        OnGUI();
    }

	void Start()
	{
		webCamScript = GameObject.Find("WebCam").GetComponent<WebCam2>();
	}

    void OnGUI() {
        if (!webCamScript.snap) {
            Debug.LogError("Assign a Texture in the inspector.");
            return;
        }
        if(drawGui == 1)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), webCamScript.snap, ScaleMode.ScaleToFit, true);

            //Matrix4x4 matrixBackup = GUI.matrix;
            //Vector2 pivotPoint = new Vector2(Screen.width / 2, Screen.height / 2);
            //GUIUtility.RotateAroundPivot(webCamScript.angle, pivotPoint);
            //if(webCamScript.angle == 0)
                GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), webCamScript.snap, ScaleMode.ScaleToFit, true);
            //else
            //  GUI.DrawTexture(new Rect((Screen.width - Screen.height)/2, (Screen.height - Screen.width)/2, Screen.height, Screen.width), webCamScript.snap, ScaleMode.ScaleAndCrop, true);
            //GUI.matrix = matrixBackup;

            GUI.color = new Color(1.0f, 1.0f, 1.0f, 0.50f);
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), guide, ScaleMode.ScaleToFit, true);

            //ScaleToFit
            //ScaleAndCrop


            if(GUI.Button(new Rect(0, 0, Screen.width, Screen.height),"Click Me" + Screen.width + " " + Screen.height))
            {
                drawGui = 2;
                webCamScript.pause();
            }
        }
        else if(drawGui == 2)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), webCamScript.snap, ScaleMode.ScaleToFit, true);
            GUI.color = new Color(1.0f, 1.0f, 1.0f, 0.50f);
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), modele, ScaleMode.ScaleToFit, true);

            if(GUI.Button(new Rect(0, 0, Screen.width, Screen.height),"Click Me" + Screen.width + " " + Screen.height))
            {
                drawGui = 0;
            }
        }
    }
}

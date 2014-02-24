using UnityEngine;
using System.Collections;


public class CopyCam : MonoBehaviour {

	private WebCam2 webCamScript;
	public Texture2D formatCible;
	private int i = 2000;

	void Start()
	{
		webCamScript = GameObject.Find("WebCam").GetComponent<WebCam2>();

		if(formatCible)
		{
		    float _proportionTextureCible = (float) formatCible.width / (float) formatCible.height;
		    Debug.Log(webCamScript.ratio);
		    Debug.Log(_proportionTextureCible);
		    Debug.Log(webCamScript.ratio - _proportionTextureCible);

            float dif = (webCamScript.ratio - _proportionTextureCible) / 2;
            Debug.Log(dif);

            renderer.material.mainTextureScale = new Vector2(1 - dif, 1);
            renderer.material.mainTextureOffset = new Vector2(dif / 2, 0);
                                                          /*

            renderer.material.mainTextureScale = new Vector2(0.8f, 1);
            renderer.material.mainTextureOffset = new Vector2(0.1f, 0);
            */
		}
	}
	
	void Update ()
	{
		renderer.material.mainTexture = webCamScript.snap;
		renderer.material.SetFloat("_Rotate", 90);


		i++;
		if (i > 3100)
		{
		    i = 2500;
		}

		//float dif = (float) (i / 10000f);
		float dif = 0.25f;

        renderer.material.mainTextureScale = new Vector2(1 - dif, 1);
        renderer.material.mainTextureOffset = new Vector2(dif / 2, 0);
        //Debug.Log(dif);
	}


    void OnGUI()
    {
        if(GUI.Button(new Rect(0, 0, 100, 100),(string) "_" + 0.25f))
        {
        }
    }
}

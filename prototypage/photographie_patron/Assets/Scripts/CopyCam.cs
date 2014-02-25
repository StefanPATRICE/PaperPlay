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
		    //Debug.Log(_proportionTextureCible);
		    //Debug.Log(webCamScript.ratio - _proportionTextureCible);

            float dif = (webCamScript.ratio - 1) * 2 / 3;
            dif = dif + 0.02777777777f;
            Debug.Log(dif);
            Debug.Log(dif / 2f);
            Debug.Log(0.25f / 2f);

            renderer.material.mainTextureScale = new Vector2(1f - dif, 1f);
            renderer.material.mainTextureOffset = new Vector2(dif / 2f, 0f);


            renderer.material.mainTextureScale = new Vector2(1f - 0.25f, 1f);
            renderer.material.mainTextureOffset = new Vector2(0.25f / 2f, 0f);
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

        //Debug.Log(dif);
	}


    void OnGUI()
    {
        if(GUI.Button(new Rect(0, 0, 100, 100),(string) "_" + 0.25f))
        {
        }
    }
}

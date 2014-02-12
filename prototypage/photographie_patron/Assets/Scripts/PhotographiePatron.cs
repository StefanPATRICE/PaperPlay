using UnityEngine;
using System.Collections;

public class PhotographiePatron : MonoBehaviour {

    private WebCam2 webCamScript;
    //private WebCam2 webCamScript2;
    private TraitementImage traitementImageScript;

    void Start()
    {

        //webCamScript2 = GetComponent<WebCam2>();
        traitementImageScript = GetComponent<TraitementImage>();
        webCamScript = GameObject.Find("WebCam").GetComponent<WebCam2>();
    }

    void Update()
    {
    	//Debug.Log(2);
        renderer.material.mainTexture = traitementImageScript.process(webCamScript.snap);
    }
}

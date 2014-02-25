using UnityEngine;
using System.Collections;

public class giro_camera : MonoBehaviour {

    int i = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if(i > 1000)
			i = 0;
		else
			i++;

        transform.position = new Vector3(
            (float) i / 150f,
            Mathf.Cos(Input.acceleration.y) * 2f,
            0f
        );
	}
}

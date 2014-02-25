using UnityEngine;
using System.Collections;

public class move_camera : MonoBehaviour {

    int i = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(i > 100)
			i = 0;
		else
			i++;

		transform.position = new Vector3((float) i / 100f, 0, 0);
	}
}

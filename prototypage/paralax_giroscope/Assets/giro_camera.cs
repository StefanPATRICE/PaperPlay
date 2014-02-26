using UnityEngine;
using System.Collections;

public class giro_camera : MonoBehaviour {

    int i = 0;
    float accelerationY;

	// Use this for initialization
	void Start () {
		accelerationY = Input.acceleration.y;
	}
	
	// Update is called once per frame
	void Update () {

		i++;

		accelerationY = Mathf.Abs(Input.acceleration.y) * 0.3f + accelerationY * 0.7f;

        transform.position = new Vector3(
            (float) Mathf.Sin(i / 300f) * 6,
            Mathf.Cos(accelerationY) * 1f + 1,
            0f
        );
	}
}

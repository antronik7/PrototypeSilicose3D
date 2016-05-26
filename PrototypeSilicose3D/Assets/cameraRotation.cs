using UnityEngine;
using System.Collections;

public class cameraRotation : MonoBehaviour {

    public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {
            transform.LookAt(target);
            transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X") * 5);
        }
    }
}

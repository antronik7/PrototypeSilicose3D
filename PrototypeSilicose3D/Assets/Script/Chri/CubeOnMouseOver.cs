using UnityEngine;
using System.Collections;

public class CubeOnMouseOver : MonoBehaviour {

    [SerializeField] Material Over;
    [SerializeField] Material Aways;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver() {

        GetComponent<Renderer>().material = Over;

    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material = Aways;    
    }
}

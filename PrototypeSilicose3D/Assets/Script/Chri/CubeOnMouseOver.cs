using UnityEngine;
using System.Collections;

public class CubeOnMouseOver : MonoBehaviour {

    [SerializeField] Material good;
    [SerializeField] Material bad;
    [SerializeField] Material Aways;
    [SerializeField] GameObject compteurClique;
    CarteCliqueControlleur ctrlClique;

    [Tooltip("Cocher si l'objet doit etre cliquer pour gagner")][SerializeField] bool typeObjet;

	// Use this for initialization
	void Start () {
        ctrlClique = compteurClique.GetComponent<CarteCliqueControlleur>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver() {

        GetComponent<Renderer>().material.color = new Color(1f,1f,1f);
        //GetComponent<Renderer>().material = Over;
    }

    void OnMouseExit()
    {
        if(GetComponent<Collider>().enabled == true)
        { 
            GetComponent<Renderer>().material = Aways;
        }   
    }

    void OnMouseDown()
    {
        ctrlClique.joueurACliquer(typeObjet);

        if (!typeObjet)
        {
            GetComponent<Renderer>().material = good;
            GetComponent<Collider>().enabled = false;
        }
        else
        {
            GetComponent<Renderer>().material = bad;
            GetComponent<Collider>().enabled = false;
        }
    }
}

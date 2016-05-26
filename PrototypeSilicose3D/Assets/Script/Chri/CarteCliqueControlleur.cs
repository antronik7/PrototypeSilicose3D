using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarteCliqueControlleur : MonoBehaviour {

    [SerializeField] GameObject[] listeCartes;
    [SerializeField] int maxClique;
    [SerializeField] Color bon;
    [SerializeField] Color mauvais;

    int compteurClique = 0;

	// Use this for initialization
	void Start () {

        compteurClique = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void joueurACliquer(bool bonneReponse)
    {
        if(bonneReponse)
        {
            listeCartes[compteurClique].GetComponent<Image>().color = bon;
        }
        else
        {
            listeCartes[compteurClique].GetComponent<Image>().color = mauvais;
        }

        compteurClique++;

        if(compteurClique == maxClique)
        {
            //Faire appel au gameover somehow
        }
    }
}

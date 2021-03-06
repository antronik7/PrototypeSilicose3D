﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class CarteCliqueControlleur : MonoBehaviour {

    [SerializeField] GameObject[] carteASpawner;
    [SerializeField] GameObject derniereCarte;
    [SerializeField] GameObject[] listeCartes;
    [SerializeField] int maxClique;
    [SerializeField] Color bon;
    [SerializeField] Color mauvais;

    List<int> listeDeCarte;
    List<GameObject> bonneCarte;

    int compteurClique;
    int compteurMauvais;
    int compteurBon;

    Vector3 rotation;

	// Use this for initialization
	void Start () {

        compteurClique = 0;
        compteurMauvais = 0;
        compteurBon = 0;

        listeDeCarte = new List<int>();
        bonneCarte = new List<GameObject>();
        rotation = new Vector3(0, 0, -12.5f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void joueurACliquer(int numeroCarte)
    {
        if(numeroCarte != 0)
        {           
            //listeCartes[compteurBon].GetComponent<Image>().color = bon;
            listeDeCarte.Add(numeroCarte);
            listeDeCarte.Sort();
            compteurBon++;
            updateBonneCarte();
        }
        else
        {
            compteurMauvais++;
            listeCartes[maxClique - compteurMauvais].GetComponent<Image>().color = mauvais; 
        }

        compteurClique++;
        updateDerniereCarte();    
    }

    void updateDerniereCarte()
    {
        derniereCarte.GetComponent<Text>().text = compteurBon.ToString();

        if(compteurBon == 12)
        {
            //Faire appel au gameover somehow
            bonneCarte.Add((GameObject)Instantiate(carteASpawner[12], new Vector3(listeCartes[12].transform.position.x, listeCartes[12].transform.position.y, 1), Quaternion.Euler(rotation)));
            bonneCarte[12].transform.parent = listeCartes[12].transform;
        }
    }
    
    public void updateBonneCarte()
    {
        bonneCarte.Clear();

        for(int i = 0; i < compteurBon; i++)
        {
            bonneCarte.Add((GameObject)Instantiate(carteASpawner[listeDeCarte[i]-1], new Vector3(listeCartes[i].transform.position.x, listeCartes[i].transform.position.y, 1), Quaternion.Euler(rotation)));
            bonneCarte[i].transform.parent = listeCartes[i].transform;
        }
    }    
}

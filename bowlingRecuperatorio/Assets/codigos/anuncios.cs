using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class anuncios : MonoBehaviour {
	
	public Text puntos;
	public GameObject panel;
	private int contados;
	private int dies = 10;


	void Start () 
	{
	}
	
	void Update () 
	{
		puntos.text = ContadorPinos.numeros.ToString ();

		if (Input.GetKeyDown(KeyCode.R)) 
		{
			contados++;

			if (contados >= 2 || puntos.text == dies.ToString())
			{
				panel.SetActive(true);
			}		

					
		}

	}
}

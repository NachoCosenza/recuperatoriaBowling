using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pino : MonoBehaviour {


	private Rigidbody rb;
	private ContadorPinos lol;
	public int puntos;
	public int puntos2;
	ContadorPinos asad = new ContadorPinos();

	private bool activador;

	void Awake() 
	{
		rb = GetComponent<Rigidbody> ();
		activador = true;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Q)) 
		{
			//print ("puntos  "+ PinosDerribados());	
		}

		if (Input.GetKeyDown (KeyCode.R)) 
		{
			puntos = 0;	
		}
		
		if (0 != transform.rotation.y && activador == true)
		{
			puntos++;
			asad.PinosDerribados(1);
			activador = false;
		}
	}

	public int PinosDerribados2()
	{
		//PinosDerribados ();

		return 0;
		//muestra los puntos
	}
}
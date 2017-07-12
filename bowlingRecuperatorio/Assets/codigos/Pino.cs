using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pino : MonoBehaviour {


	private Rigidbody rb;
	private ContadorPinos lol;
	public int puntos;
	public int puntos2;

	private bool activador;

	void Awake() 
	{
		rb = GetComponent<Rigidbody> ();
		activador = true;
	}

	void Update ()
	{
		
		if (0 != transform.rotation.y && activador == true)
		{
			puntos++;
			ContadorPinos.PinosDerribados ();
			activador = false;
		}
	}

}
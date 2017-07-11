using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pino : MonoBehaviour {


	private Rigidbody rb;
	private ContadorPinos lol;
	private int numeros;
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
			PinosDerribados();
			activador = false;
		}
	}

	public void PinosDerribados()
	{
		numeros = numeros + 1;
		print (numeros);
	}
}
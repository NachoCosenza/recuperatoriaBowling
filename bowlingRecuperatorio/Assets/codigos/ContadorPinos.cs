using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorPinos {

	private Rigidbody rb;
	static public int numeros;
	public int numero;


	void Update ()
	{ 
		numero = numeros;
	}

	static public void PinosDerribados()
	{
		numeros++;
		Debug.Log ("numeros " + numeros);


	}

}


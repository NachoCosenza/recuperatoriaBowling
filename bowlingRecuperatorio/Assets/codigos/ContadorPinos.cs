using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorPinos : MonoBehaviour {

	private Rigidbody rb;
	private int numeros;

	void Awake() 
	{
		rb = GetComponent<Rigidbody>();
	}

	void Start ()
	{

	}


	void Update ()
	{ 
		/*if (rb.angularVelocity != Vector3.zero)
		{
			PinosDerribados ();
		}*/

	}

	public void PinosDerribados()
	{
		numeros = numeros + 1;

		print (numeros);
	}

}


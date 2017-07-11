using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisparoBola : MonoBehaviour {

	private Rigidbody rb;
	private float submit = 0f;
	private float giro = 0f;
	public float fuerza = 0;
	private float contador = 0;
	public float angulo = 0;
	public Image ControladorDelAngulo;

	[SerializeField] private Text FuerzaDeDisparo;

	void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}
		
	void Update ()
	{
		
		FuerzaDeDisparo.text = contador.ToString ();

		submit = Input.GetAxisRaw ("Submit");
		giro = Input.GetAxisRaw ("Horizontal");

		if (submit > 0) 
		{	contador = contador + 1;

			if (contador > 100) 
			{
				contador = 0;
			}
		}

	}

	void FixedUpdate()
	{
		if (Input.GetKeyUp(KeyCode.W)) 
		{
			rb.AddRelativeForce(Vector3.forward * (contador * fuerza));
			contador = 0;
		}

		if (giro > 0) 
		{
			transform.Rotate (Vector3.down * angulo);
			ControladorDelAngulo.transform.Rotate (Vector3.forward * angulo);
			print ("ok");
		}

		if (giro < 0) 
		{
			transform.Rotate  (Vector3.down * (-angulo));
			ControladorDelAngulo.transform.Rotate (Vector3.forward * (-angulo));
			print ("ok");
		}

	}
}

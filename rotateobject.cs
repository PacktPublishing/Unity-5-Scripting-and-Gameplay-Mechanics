using UnityEngine;
using System.Collections;

public class rotateobject : MonoBehaviour 
{
	//Rotate speed
	public float Speed = 90f;

	//Rotate Axis
	public Vector3 RotateAxis = Vector3.zero;

	//Reference to transform
	private Transform ThisTransform = null;

	// Use this for initialization
	void Awake () 
	{
		ThisTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		ThisTransform.Rotate (new Vector3(RotateAxis.x*Speed*Time.deltaTime,
										  RotateAxis.y*Speed*Time.deltaTime,
										  RotateAxis.z*Speed*Time.deltaTime), Space.World);
	}
}

using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour 
{
	void OnTriggerEnter(Collider Col)
	{
		if (!Col.CompareTag ("Player"))
			return;

		++playercontroller.CoinsCollected;
		Destroy (gameObject);
	}
}

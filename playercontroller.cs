using UnityEngine;
using System.Collections;

public class playercontroller : MonoBehaviour
{
	public static int CoinsCollected = 0;
	public static int CoinsToCollect = 0;

	public GameObject[] Fireworks;

	// Use this for initialization
	void Awake () 
	{
		//Get coin count
		CoinsToCollect = GameObject.FindGameObjectsWithTag("Coin").Length;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Check coins collected
		if (CoinsCollected >= CoinsToCollect) 
		{
			//You win
			foreach (GameObject GO in Fireworks)
				if(!GO.activeSelf)
					GO.SetActive (true);
		}
	}
}

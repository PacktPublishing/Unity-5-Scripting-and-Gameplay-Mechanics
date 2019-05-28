using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class timeout : MonoBehaviour 
{
	public float TotalTime = 60f;

	void Start()
	{
		Invoke ("Restart", TotalTime);
	}

	public void Restart()
	{
		if (playercontroller.CoinsCollected < playercontroller.CoinsToCollect)
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}

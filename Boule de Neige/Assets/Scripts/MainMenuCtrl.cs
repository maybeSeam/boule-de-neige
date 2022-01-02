using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCtrl : MonoBehaviour
{
	public void ExitGame()
	{
		Application.Quit();
		Debug.Log("Game closed");
	}

	public void StartGame()
	{
		SceneManager.LoadScene("GAME");
	}
}

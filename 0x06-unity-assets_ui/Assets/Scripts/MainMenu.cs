using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void LevelSelect(int level)
	{
		SceneManager.LoadScene("Level0" + level, LoadSceneMode.Single);
	}

	public void Exit()
	{
		Application.Quit();
		Debug.Log("Exited");
	}

	public void Options()
	{
		SceneManager.LoadScene("Options", LoadSceneMode.Single);
	}
}

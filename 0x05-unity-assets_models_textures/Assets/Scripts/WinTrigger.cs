using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
	public GameObject player;
	public Text TimerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.name == "Player")
		{
			player.GetComponent<Timer>().enabled = false;
			TimerText.color = Color.green;
			TimerText.fontSize = 60;
		}
	}
}

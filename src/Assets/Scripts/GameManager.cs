using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerController player;
    public Text startText;

    private Vector3 playerStartPoint;
    private bool started;

	// Use this for initialization
	void Start ()
	{
	    playerStartPoint = player.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (!started && Input.GetKeyDown(KeyCode.Return))
	    {
	        started = true;
	        player.run = true;
	    }

        startText.enabled = !started;
	}
}

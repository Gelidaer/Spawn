using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    public GameObject player;
    public int noPlayers = 4;

	// Use this for initialization
	void Start () 
	{
        Destroy(player);
        for (int i = 0; i < noPlayers; i++)
        {
            Instantiate(player, new Vector3(0, 1, -i-1), Quaternion.identity);
            player.GetComponent<Movement2>().enabled = true;
        }
	}
}

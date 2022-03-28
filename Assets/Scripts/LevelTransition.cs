using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{

    // ***WARNING*** This code is messed up and isn't working. Trying to figure it out
    // Basically when you go through a door or hop on a bee taxi, you're to be brought to the next level/scene
    // The first chunk of code checks what level you're on. From there it's supposed to determine where the exit is
    // I'm having trouble getting collision triggers to work properly as well as coordinate reading

    private double currentLevel = 0;
    public GameObject player;
    private Vector2 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player1_Placeholder");

        if (SceneManager.GetActiveScene().name == "level-1_cave")
            Debug.Log(player.transform.position.normalized);
        else if (SceneManager.GetActiveScene().name == "level-2_baseOfTree")
            currentLevel = 2;
        else if (SceneManager.GetActiveScene().name == "level-3_midTree")
            currentLevel = 3;
        else if (SceneManager.GetActiveScene().name == "level-4_treeTop")
            currentLevel = 4;
    }

    // Update is called once per frame
    void Update()
    {
        // Assigns player POS to a variable
        playerPos = player.transform.position.normalized;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Trying to figure out if collision is working. Result: It's not
            Debug.Log("Door door door");
    }

    // Vestigal code left behind from a separate attempt I made. Delete it if you'd like but I kept it around just in case.
    private void levelOne()
    {
        GetComponent<Rigidbody>().position = Vector2.zero;
        Debug.Log(GetComponent<Rigidbody>().position = Vector2.zero);
    }
}

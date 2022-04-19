using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cloudTransition : MonoBehaviour
{
    public string levelName;

    bool p1plat = false;
    bool p2plat = false;
    public bool restrictMovement = false;

    private GameObject cloudPlat;
    public GameObject player1;
    public GameObject player2;

    public int cloudSpeed = 5;
    public int cloudDistance = 10;

    void Start()
    {
        cloudPlat = GameObject.Find("cloudPlatform");
    }

    void Update()
    {
        if(cloudPlat.transform.position.y >= 18)
        {
            restrictMovement = false;
            SceneManager.LoadScene("level-4_treeTop");
        }
    }

    void OnTriggerStay2D(Collider2D Other)
    {
        if (Other.CompareTag("Player1"))
            p1plat = true;
        if (Other.CompareTag("Player2"))
            p2plat = true;
        if (p1plat == true && p2plat == true)
        {
            transform.position += transform.up * cloudSpeed * cloudDistance * Time.deltaTime;
            cloudPlat.transform.position += transform.up * cloudSpeed * cloudDistance * Time.deltaTime;

            player1.transform.position += transform.up * cloudSpeed * cloudDistance * Time.deltaTime;
            player2.transform.position += transform.up * cloudSpeed * cloudDistance * Time.deltaTime;

            restrictMovement = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        p1plat = false;
        p2plat = false;
    }

}
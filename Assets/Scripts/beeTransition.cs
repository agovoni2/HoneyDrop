using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class beeTransition : MonoBehaviour
{
    bool p1plat = false;
    bool p2plat = false;

    private GameObject TaxiBee;
    public GameObject player1;
    public GameObject player2;

    public int beeSpeed = 5;
    public int beeDistance = 5;

    public bool restrictMovement = false;

    // Start is called before the first frame update
    void Start()
    {
        TaxiBee = GameObject.Find("TaxiBee");
    }

    // Update is called once per frame
    void Update()
    {
        if (TaxiBee.transform.position.y >= 18)
        {
            restrictMovement = false;
            SceneManager.LoadScene("level-3_midTree");
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
            TaxiBee.transform.position += transform.right * beeSpeed * beeDistance * Time.deltaTime;
            TaxiBee.transform.position += transform.up * beeSpeed * beeDistance * Time.deltaTime;

            player1.transform.position += transform.right * beeSpeed * beeDistance * Time.deltaTime;
            player1.transform.position += transform.up * beeSpeed * beeDistance * Time.deltaTime;

            player2.transform.position += transform.right * beeSpeed * beeDistance * Time.deltaTime;
            player2.transform.position += transform.up * beeSpeed * beeDistance * Time.deltaTime;

            restrictMovement = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        p1plat = false;
        p2plat = false;
    }
}

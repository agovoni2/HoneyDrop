using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cloudTransition : MonoBehaviour
{
    public int index;
    public string levelName;
    bool p1plat = false;
    bool p2plat = false;
    private GameObject cloudPlat;
    public int moveSpeed = 5;
    public int intOther = 10;

    // Start is called before the first frame update
    void Start()
    {
        cloudPlat = GameObject.Find("cloudPlatform");
    }

    // Update is called once per frame
    void Update()
    {
        if(cloudPlat.transform.position.y >= 18)
        {
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
            transform.position += transform.up * moveSpeed * intOther * Time.deltaTime;
            cloudPlat.transform.position += transform.up * moveSpeed * intOther * Time.deltaTime;
        }
    }




}

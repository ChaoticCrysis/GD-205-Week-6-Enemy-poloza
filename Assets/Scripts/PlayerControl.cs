using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerControl : MonoBehaviour
{
    public float speed = 5f;
    public TMP_Text scoreText;
    int score = 0;

    public GameManager myManager;

    public GameObject gameOverText;

    bool letMove = true;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (letMove)
        { Vector3 currentPos = transform.position;
        
            if (Input.GetKey(KeyCode.W))
            { currentPos.z = currentPos.z + speed * Time.deltaTime; }


            if (Input.GetKey(KeyCode.A))
            { currentPos.x = currentPos.x - speed * Time.deltaTime; }

            if (Input.GetKey(KeyCode.S))
            { currentPos.z = currentPos.z - speed * Time.deltaTime; }

            if (Input.GetKey(KeyCode.D))
            { currentPos.x = currentPos.x + speed * Time.deltaTime; }

            transform.position = currentPos;

        }
    }
   

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collect")
        {
            myManager.allCollectables.Remove(other.gameObject);
            Destroy(other.gameObject);
        }
        
        for(int i = 0; i < myManager.enemyNum; i++)
        {
           if(other.gameObject == myManager.enemies[i])
            {
                letMove = false;
                Debug.Log("hit!");
            } 



        }



    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int objNum;
    public GameObject objCollect;

    public Transform leftTop;
    public Transform rightBottom;

    public List<GameObject> allCollectibles = new List<GameObject>();

     public List<GameObject> allCollectables = new List<GameObject> ();

    public int enemyNum;
    public GameObject enemyObj;

    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {

        enemies = new GameObject[enemyNum];


        for(int i = 0; i < objNum; i++)
        {
            float newX = Random.Range(leftTop.position.x, rightBottom.position.x);
            float newZ = Random.Range(rightBottom.position.z, leftTop.position.z);
            Vector3 newPos = new Vector3 (newX, transform.position.y, newZ);
            GameObject newObj = Instantiate(objCollect, newPos, Quaternion.identity);
            allCollectables.Add(newObj);
        }

        for (int i = 0; i < enemyNum; i++)
        {
            float newX = Random.Range(leftTop.position.x, rightBottom.position.x);
            float newZ = Random.Range(rightBottom.position.z, leftTop.position.z);
            Vector3 newPos = new Vector3(newX, transform.position.y, newZ);
            GameObject newObj = Instantiate(enemyObj, newPos, Quaternion.identity);
            enemies[i] = newObj;
        }




    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(allCollectables.Count);
    }
}

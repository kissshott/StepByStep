using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject coinPrefab;
    private Vector3 cubePos;
    private Vector3 pos;

    
    void Start()
    {
        int[] arr = new int[4] { 1, 2, 3, 4 };
        int rand = Random.Range(0, 4);
        cubePos = this.transform.position;
        pos = new Vector3(cubePos.x, cubePos.y + 1.5f, cubePos.z);
       
        if (rand == 1)
        {
            Instantiate(coinPrefab, pos, Quaternion.identity);
        }
        
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private GameObject place;
    private void Start()
    {
        place = this.gameObject;
    }
    private void OnCollisionExit(Collision player)
    {
        if(player.gameObject.tag == "Player")
        {
            Destroy(place);
        }
    }
}

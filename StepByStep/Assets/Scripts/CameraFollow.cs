using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField, Range(0, 1)] private float smoothing;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
       
            if (player)
            {
                Vector3 nextPosition = Vector3.Lerp(transform.position, player.position, smoothing);

                transform.position = nextPosition;
            }
        
       
    }
}

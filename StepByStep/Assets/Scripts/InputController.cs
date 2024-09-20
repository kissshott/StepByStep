using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public GameObject player;

    private IControllable contollableInterface;
    void Start()
    {
        contollableInterface = player.GetComponent<IControllable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UIControl._startMenu)
        {
            if (PlayerController.ready)
            {
                if (SwipeManager.swipeDown || SwipeManager.swipeUp || SwipeManager.swipeRight || SwipeManager.swipeLeft)
                {
                    contollableInterface.Move();

                }
            }
        }
        
        
    }
}

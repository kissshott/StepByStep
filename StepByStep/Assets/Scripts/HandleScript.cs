using UnityEngine;

using UnityEngine.EventSystems;

public class HandleScript : MonoBehaviour

{
    
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    private void Start()
    {
        
        Debug.Log("start");
    }
    private void Update()
        
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).deltaPosition;
        }
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).deltaPosition;

            
                if (endTouchPosition.x > startTouchPosition.x) Debug.Log("Right");

                else Debug.Log("Left");



            
            

                if (endTouchPosition.y > startTouchPosition.y) Debug.Log("Up");

                else Debug.Log("Down");



            

        }
    }
    
    
}

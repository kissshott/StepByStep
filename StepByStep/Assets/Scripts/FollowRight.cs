using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRight : MonoBehaviour
{
    [SerializeField]
    private Transform[] routesR;
    [SerializeField]
    private Transform[] routesL;
    [SerializeField]
    
    private Transform[] routesU;

    private int routeToGo;

    private float tParam;

    private Vector3 objectPosition;
    [SerializeField]
    private float speedModifier = 2f;

    private bool coroutineAllowed;

    // Start is called before the first frame update
    void Start()
    {
        routeToGo = 0;
        tParam = 0f;
        
        coroutineAllowed = true;
    }

  
    public void Follow_Right()
    {
        
        if (coroutineAllowed)
        {
            StartCoroutine(GoByTheRouteR(routeToGo));
        }
        
    }
    public void Follow_Left()
    {
        
        if (coroutineAllowed)
        {
            StartCoroutine(GoByTheRouteL(routeToGo));
        }
        
    }
    
    public void Follow_Up()
    {
       
        if (coroutineAllowed)
        {
            StartCoroutine(GoByTheRouteU(routeToGo));
        }
        
    }
    private IEnumerator GoByTheRouteR(int routeNum)
    {
        coroutineAllowed = false;

        Vector3 p0 = routesR[routeNum].GetChild(0).position;
        Vector3 p1 = routesR[routeNum].GetChild(1).position;
        Vector3 p2 = routesR[routeNum].GetChild(2).position;
        Vector3 p3 = routesR[routeNum].GetChild(3).position;

        while (tParam < 1)
        {
            tParam += Time.deltaTime * speedModifier;

            objectPosition = Mathf.Pow(1 - tParam, 3) * p0 + 3 * Mathf.Pow(1 - tParam, 2) * tParam * p1 + 3 * (1 - tParam) * Mathf.Pow(tParam, 2) * p2 + Mathf.Pow(tParam, 3) * p3;

            transform.position = objectPosition;
            yield return new WaitForFixedUpdate();
        }

        tParam = 0;
        
        routeToGo += 1;

        if (routeToGo > routesR.Length - 1)
        {
            routeToGo = 0;
        }

        coroutineAllowed = true;
        

    }
    private IEnumerator GoByTheRouteL(int routeNum)
    {
        coroutineAllowed = false;

        Vector3 p0 = routesL[routeNum].GetChild(0).position;
        Vector3 p1 = routesL[routeNum].GetChild(1).position;
        Vector3 p2 = routesL[routeNum].GetChild(2).position;
        Vector3 p3 = routesL[routeNum].GetChild(3).position;

        while (tParam < 1)
        {
            tParam += Time.deltaTime * speedModifier;

            objectPosition = Mathf.Pow(1 - tParam, 3) * p0 + 3 * Mathf.Pow(1 - tParam, 2) * tParam * p1 + 3 * (1 - tParam) * Mathf.Pow(tParam, 2) * p2 + Mathf.Pow(tParam, 3) * p3;

            transform.position = objectPosition;
            yield return new WaitForFixedUpdate();
        }

        tParam = 0;
        
        routeToGo += 1;

        if (routeToGo > routesL.Length - 1)
        {
            routeToGo = 0;
        }

        coroutineAllowed = true;
      

    }
    
    private IEnumerator GoByTheRouteU(int routeNum)
    {
        coroutineAllowed = false;

        Vector3 p0 = routesU[routeNum].GetChild(0).position;
        Vector3 p1 = routesU[routeNum].GetChild(1).position;
        Vector3 p2 = routesU[routeNum].GetChild(2).position;
        Vector3 p3 = routesU[routeNum].GetChild(3).position;

        while (tParam < 1)
        {
            tParam += Time.deltaTime * speedModifier;

            objectPosition = Mathf.Pow(1 - tParam, 3) * p0 + 3 * Mathf.Pow(1 - tParam, 2) * tParam * p1 + 3 * (1 - tParam) * Mathf.Pow(tParam, 2) * p2 + Mathf.Pow(tParam, 3) * p3;

            transform.position = objectPosition;
            yield return new WaitForFixedUpdate();
        }

        tParam = 0;
        
        routeToGo += 1;

        if (routeToGo > routesU.Length - 1)
        {
            routeToGo = 0;
        }

        coroutineAllowed = true;
        

    }
}

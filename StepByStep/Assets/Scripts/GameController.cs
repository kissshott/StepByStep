using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject cubePlacePrefab;
    public GameObject cubeToPlacePrefab;
    private Vector3 coordinates;
    private List<Vector3> allCoordinates;
    private List<Vector3> allCoordinatesToPlace;
    private Vector3 coordinatesToPlace;

    public Text coins;

    private float timer = 1f;

    
    void Start()
    {
        
        CoinCollect.coins = 0;
        allCoordinates = new List<Vector3> {
        new Vector3(coordinates.x, coordinates.y + 1, coordinates.z - 3),
        new Vector3(coordinates.x, coordinates.y + 1, coordinates.z + 3),
        new Vector3(coordinates.x - 3, coordinates.y + 1, coordinates.z),
        
        };

       

        Instantiate(cubePlacePrefab);
        ToPlace();

        
    }

    private void PlaceCoordinates()
    {
        coordinates = cubePlacePrefab.transform.position;
    }
    private void ToPlaceCoordinates()
    {
        coordinatesToPlace = cubeToPlacePrefab.transform.position;
    }
    private void ToPlace()
    {
        cubeToPlacePrefab.transform.position = allCoordinates[Random.Range(0, allCoordinates.Count)];
        Instantiate(cubeToPlacePrefab, cubeToPlacePrefab.transform.position, Quaternion.identity);
        
    }
    public void ToPlaceNext()
    {
        
        cubeToPlacePrefab.transform.position = allCoordinatesToPlace[Random.Range(0, allCoordinatesToPlace.Count)];
        var clonePlace = Instantiate(cubeToPlacePrefab, cubeToPlacePrefab.transform.position, Quaternion.identity);
        Destroy(clonePlace,5f * timer);
        if(timer >= 0.2f)
        {
            timer -= 0.005f;
        }
        
        
    }
    void Update()
    {
        coins.text = CoinCollect.coins.ToString();
        PlaceCoordinates();
        ToPlaceCoordinates();
        allCoordinatesToPlace = new List<Vector3> {
        new Vector3(coordinatesToPlace.x, coordinatesToPlace.y + 1, coordinatesToPlace.z - 3),
        new Vector3(coordinatesToPlace.x, coordinatesToPlace.y + 1, coordinatesToPlace.z + 3),
        new Vector3(coordinatesToPlace.x - 3, coordinatesToPlace.y + 1, coordinatesToPlace.z),

        };
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour, IControllable
{
    public GameObject gc;
    private GameController gm;
    public float _speed = 3f;
    private FollowRight f_R;
    [SerializeField]
    private GameObject toPlace;

    private AudioSource move_audio;

    private MeshCollider placeCol;
    public static bool ready = false;

    public Text score;
    private int scoreInt;
    public Text bestScore;
    private int bestScoreInt;
    public Text bestScore2;
    public Text score2;

    private void Start()
    {
        move_audio = GameObject.FindGameObjectWithTag("Move").GetComponent<AudioSource>();
        bestScoreInt = PlayerPrefs.GetInt("bestScore");
        bestScore.text = bestScoreInt.ToString();
        bestScore2.text = bestScoreInt.ToString();
        
        gm = gc.GetComponent<GameController>();
        f_R = this.GetComponent<FollowRight>();
        placeCol = toPlace.GetComponent<MeshCollider>();
        
    }
    void IControllable.Move()
    {
        PlayerMove();
        Debug.Log("Move");
        
    }
    

    private void PlaceCoordinates()
    {

    }
    private void PlayerMove()
    {
        if (SwipeManager.swipeRight)
        {
            f_R.Follow_Right();
        }
        if (SwipeManager.swipeLeft)
        {
            f_R.Follow_Left();
        }
        
        if (SwipeManager.swipeUp)
        {
            f_R.Follow_Up();
        }
    }

    private void OnTriggerEnter(Collider placeCol)
    {
        if(scoreInt > bestScoreInt)
        {
            bestScoreInt = scoreInt+1;
            PlayerPrefs.SetInt("bestScore", bestScoreInt);
            bestScore.text = bestScoreInt.ToString();
        }
        scoreInt++;
        score.text = scoreInt.ToString();
        score2.text = scoreInt.ToString();
        gm.ToPlaceNext();
        move_audio.Play();
    }
    private void OnCollisionEnter(Collision collision)
    {
        ready = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        ready = false;
    }
}


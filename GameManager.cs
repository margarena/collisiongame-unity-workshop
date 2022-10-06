using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int timeLeft;
    public static GameManager Instance;

    public int moveSpeed;
    public int explosionPower;

    public GameObject redPlayer;
    public GameObject bluePlayer;

    public bool redAlive = true;
    public bool blueAlive = true;

    public GameObject redBall;
    public GameObject blueBall;
    public GameObject eightBall;
    public bool redBallActive = true;
    public bool blueBallActive = true;
    public bool eightBallActive = true;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if(!redBallActive)  // if red ball is not "alive"
        {
            // spawn it
             Instantiate(redBall, new Vector3(25, 2, 0), Quaternion.identity);

             redBallActive = true;
        }

        if(!blueBallActive) // the same goes for blue
        {
             Instantiate(blueBall, new Vector3(-25, 2, 0), Quaternion.identity);

             blueBallActive = true;
        }

        if(!eightBallActive) // and the same for 8 ball
        {
            Instantiate(eightBall, new Vector3(0, 10, 0), Quaternion.identity);

            eightBallActive = true;
        }


        if(!redAlive) // if the red is dead
        {
            Instantiate(redPlayer, new Vector3(-10, 2, 0), Quaternion.identity);

            redAlive = true;
        }

        if(!blueAlive) // if the blue is dead
        {
            Instantiate(bluePlayer, new Vector3(10, 2, 0), Quaternion.identity);

            blueAlive = true;
        }
    }
}

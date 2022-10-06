using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGoalZone : MonoBehaviour
{
    public float redTimeLeft;
    public Rigidbody playerRb;
    private void OnCollisionEnter(Collision other)
    {
        print("Red zone!");
        
        
        if(other.gameObject.layer == 6) // if other game object is a red ball
        {
            print("Point for Red!");
            redTimeLeft = GameManager.Instance.timeLeft;

            UIManager.Instance.redScore ++;

            Destroy(other.gameObject);

            GameManager.Instance.redBallActive = false;

            // now update UI
            UIManager.Instance.ChangeRedScore();
        }

        if(other.gameObject.layer == 8) // if other game object is 8 ball
        {
            print("8 POINTS FOR BLUE!");

            UIManager.Instance.blueScore += 4;

            Destroy(other.gameObject);

            GameManager.Instance.eightBallActive = false;

            // now update UI
            UIManager.Instance.ChangeBlueScore();
        }


    }
    void Start()
    {
     redTimeLeft = GameManager.Instance.timeLeft; 
    }

    private void Update()
    {
        
    print(redTimeLeft);
    redTimeLeft -= Time.deltaTime;

        if(redTimeLeft <= 0){
        //  Instantiate(GameManager.Instance.redBall, new Vector3(0,0,0), Quaternion.identity);

        float randomX = Random.Range(-10,10);
        float randomZ = Random.Range(-10,10);

        playerRb.AddForce(300* randomX, 500, 300 * randomZ, ForceMode.Impulse);
                    
        redTimeLeft = GameManager.Instance.timeLeft;

         }
    }
}



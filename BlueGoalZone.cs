using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGoalZone : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        print("Blue zone!");
        
        if(other.gameObject.layer == 7) // if other game object is a blue ball
        {
            print("Point for Blue!");

            UIManager.Instance.blueScore ++;

            Destroy(other.gameObject);

            GameManager.Instance.blueBallActive = false;

            // now update UI
            UIManager.Instance.ChangeBlueScore();
        }

        if(other.gameObject.layer == 8) // if other game object is 8 ball
        {
            print("8 POINTS FOR RED!");

            UIManager.Instance.redScore += 4;

            Destroy(other.gameObject);

            GameManager.Instance.eightBallActive = false;

            // now update UI
            UIManager.Instance.ChangeRedScore();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 9 || other.gameObject.layer == 10)
        {
            other.gameObject.transform.position = new Vector3(0, 2, 0);
        }
        else
        {
            Destroy(other.gameObject);
        }

        if(other.gameObject.layer == 6) // if other game object is a red ball
        {
            GameManager.Instance.redBallActive = false;
        }

        if(other.gameObject.layer == 7) // if other game object is a blue ball
        {
            GameManager.Instance.blueBallActive = false;
        }

        // if(other.gameObject.layer == 9) // if other is the red player
        // {
        //     GameManager.Instance.redAlive = false;
        // }

        // if(other.gameObject.layer == 10) // if other is the blue player
        // {
        //     GameManager.Instance.blueAlive = false;
        // }
    }
}

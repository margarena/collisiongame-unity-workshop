using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoxes : MonoBehaviour
{
    [SerializeField] GameObject boxObj;
    public int numberOfBoxes;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numberOfBoxes; i++)
        {
            float randomX = Random.Range(-20f, 20f);
            float randomZ = Random.Range(-15f, 15f);

            // spawn the boxes
            Instantiate(boxObj, new Vector3(randomX, 1, randomZ), Quaternion.identity);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject objectToFollow;   // an object camera will follow
    [SerializeField] private Vector3 distanceFromObject; // camera's distance from obj

    [SerializeField] private float smoothness;  // value of 0.125 is fine

    private void LateUpdate()   // works after all update functions called
    {   
        // target position of the camera
        Vector3 goToPosition = objectToFollow.transform.position + distanceFromObject;
        
        Vector3 smoothPosition = Vector3.Lerp(transform.position, goToPosition, smoothness);
    
        transform.position = smoothPosition;
    }
}

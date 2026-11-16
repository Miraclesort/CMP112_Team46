using System;
using Unity.VisualScripting;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    [SerializeField] Transform ball;
    [SerializeField] float tiltstrength = 10f;
    void Start()
    {

    }


    void Update()
    {
        
    }


    void FixedUpdate()
    {
      
        
    }
    void LateUpdate()
    {
        float inputx = Input.GetAxis("Horizontal");
        float inputz = Input.GetAxis("Vertical");



        Vector3 vector = new Vector3(0f, 5f, -8f);
        transform.position = ball.position + vector;
        transform.LookAt(ball);
        transform.Rotate(inputz * tiltstrength, 0f, inputx * tiltstrength * -1);


    }
}

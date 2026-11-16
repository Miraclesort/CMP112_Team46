using System;
using UnityEngine;

public class Speedupscript : MonoBehaviour
{
    [SerializeField] float booststrength = 10f;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.attachedRigidbody != null)
            {
                Vector3 vector = new Vector3(other.attachedRigidbody.linearVelocity.x, 0f, other.attachedRigidbody.linearVelocity.z);
                vector = vector.normalized;


                Vector3 ballboost = new Vector3(vector.x * booststrength, 0f, vector.z * booststrength);
                other.attachedRigidbody.AddForce(ballboost, ForceMode.VelocityChange);
                Debug.Log("boost");
            }
        }
    }
}

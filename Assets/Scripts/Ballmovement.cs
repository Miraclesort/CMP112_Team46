using Unity.VisualScripting;
using UnityEngine;

public class Ballmovement : MonoBehaviour
{
    [SerializeField] float gravstrength = 5f;

    Rigidbody rb;
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        
    }

    void FixedUpdate()
    {
         float inputx = Input.GetAxis("Horizontal");
        float inputz = Input.GetAxis("Vertical");


        Vector3 playervector = new Vector3(inputx, 0f, inputz);
        playervector = Vector3.ClampMagnitude(playervector, 1);
        Vector3 gravity = new Vector3(playervector.x * gravstrength, -9.8f, playervector.z * gravstrength);
        Physics.gravity = gravity;

    }
}

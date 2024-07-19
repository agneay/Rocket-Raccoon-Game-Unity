using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrollController : MonoBehaviour
{
    public float patrollSpeed = 3.0f;  
    public float maxMovement = 4.0f;
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        CharacterController controller = GetComponent<CharacterController>();
        Vector3 forward = transform.TransformDirection(Vector3.forward);

        controller.SimpleMove(patrollSpeed*forward);

        float distance = Vector3.Distance(startPosition,transform.position);

        if (distance>maxMovement){
            transform.Rotate(0,180,0);
            startPosition = transform.position;
        }
    }
}

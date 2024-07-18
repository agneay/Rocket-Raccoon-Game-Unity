using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 4.0f; //The f at the end of the number says it is a floating-point number
    public float rotateSpeed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = Input.GetAxis("Vertical");
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        CharacterController controller = GetComponent<CharacterController>();
        controller.SimpleMove(speed * forward * moveSpeed);
        Animator anim = gameObject.GetComponent<Animator>();
        if (speed != 0)
        {
            anim.SetBool("forward", true);
        }
        else
        {
            anim.SetBool("forward", false);
        }
    }
}

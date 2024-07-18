using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starController : MonoBehaviour
{
    float spinSpeed = 1.5f;
    public AudioClip collectSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinSpeed * Vector3.up);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            starPlayer player = other.gameObject.GetComponent<starPlayer>();
            player.starCount += 1;
            Debug.Log("Star Count increased by 1");
            gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        }
    }
}

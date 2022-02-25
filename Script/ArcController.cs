using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcController : MonoBehaviour
{

    private Rigidbody arcRb;
    public float speed = 1.0f;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        arcRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position + transform.position).normalized;
        arcRb.AddForce(lookDirection * speed);


        transform.localScale=transform.localScale + new Vector3(0, 0, 1f*Time.deltaTime);
        if(transform.localScale.z>2)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private float rotateSpeed=5.0f;
    public GameObject projectilePrefab;
    public Image drumstick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position , transform.rotation);
        }


    }
    void OnMouseDrag()
    {
        float YaxisRotation = Input.GetAxis("Mouse X") * rotateSpeed;
        transform.Rotate(Vector3.up, YaxisRotation);
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("enemy"))
        {
            Destroy(col.gameObject);

        }

        if (col.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
            drumstick.gameObject.SetActive(true);
        }

    }
}

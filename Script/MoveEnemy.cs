using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed=5.0f;
    private int score = 0;
    private Rigidbody enemyRb;
    private GameObject player;
    private bool movetoplayer=false;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
    }

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
            score += 5;
            Debug.Log(score);
        }

    }
}

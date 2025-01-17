using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobScript : MonoBehaviour
{
    public Rigidbody2D physic;
    public Transform player;
    public float speed = 5f;
    public float agroDist;
    void Start()
    {
        physic = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        if (distToPlayer < agroDist)
        {
            StartHunting();
        }
        else
        {
            StopHunting();
        }

        void StartHunting()
        {
            if (transform.position.x < player.position.x)
            {
                physic.velocity = new Vector2(speed, 0);
            }
            else if (transform.position.x > player.position.x)
            {
                physic.velocity = new Vector2(-speed, 0);
            }
        }

        void StopHunting()
        {
            physic.velocity = new Vector2(0, 0);
        }
    }

}

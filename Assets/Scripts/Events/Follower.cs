using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private float speed = 15;
    private Transform target;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (transform.position.x + 20 > target.position.x || transform.position.x + 10 > target.position.x)
        {
            speed -= 3;
        }
    }

}

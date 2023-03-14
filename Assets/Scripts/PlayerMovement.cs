using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.position = new Vector3(transform.position.x + moveX, transform.position.y);
    }
}

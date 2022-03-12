using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed;
    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        moveSpeed = 5.0f;
    }
    [SerializeField]
    private float leftBoundX = -8.0f;
    [SerializeField]
    private float rightBoundX = 8.0f;

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * moveSpeed * Time.deltaTime ,
        0 , verticalInput * moveSpeed * Time.deltaTime);

        if(transform.position.x < leftBoundX)
        {
            transform.position = new Vector3(leftBoundX , transform.position.y , transform.position.z);
        }
        if(transform.position.x > rightBoundX)
        {
            transform.position = new Vector3(rightBoundX , transform.position.y , transform.position.z);
        }
    }
}

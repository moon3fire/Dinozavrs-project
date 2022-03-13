using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed;
    private float horizontalInput;
    private float verticalInput;

    [SerializeField]
    private float playerCoordinateBound = 8.0f;


    void Start()
    {
        moveSpeed = 5.0f;
    }

    void Update()
    {
        updatePlayerPosition();
    }

    private void updatePlayerPosition()
    {
        float horizontalDirectionChange = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float verticalDirectionChange = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(horizontalDirectionChange, 0, verticalDirectionChange);
        boundPlayerCoords();
    }

    private void boundPlayerCoords()
    {
        float coordX = boundValue(transform.position.x, playerCoordinateBound);
        float coordZ = boundValue(transform.position.z, playerCoordinateBound);
        transform.position = new Vector3(coordX, 0, coordZ);
    }

    public float boundValue(float value, float bound)
    {
        if (-bound < value && value < bound)
        {
            return value;
        }

        return bound * Math.Sign(value);
    }
}

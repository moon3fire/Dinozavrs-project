using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5.0f;
    [SerializeField]
    private float lowGroundZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.z < lowGroundZ)
            Destroy(gameObject);
        gameObject.transform.Translate(0 , 0 , -moveSpeed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMoving : MonoBehaviour
{
    public float speed;
    public float DeadZone = -1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;
        if (transform.position.x < DeadZone)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    private LogicManager logic;
    private int score = 1;
    public AudioSource Point;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Point.Play();
            logic.addScore(score);
        }
    }
}

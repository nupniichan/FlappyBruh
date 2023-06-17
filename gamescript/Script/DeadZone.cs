using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private LogicManager logic;
    public AudioSource dead;
    public AudioSource DeadALR;
    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            dead.Play();
            logic.GameOver();
            DeadALR.Play();
        }
    }
}

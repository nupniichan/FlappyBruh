using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRB;
    public float FlightStrength;
    public LogicManager logic;
    public bool IsAlive = true;
    public AudioSource audio;
    public AudioSource Click;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsAlive == true)
        {
            birdRB.velocity = Vector2.up * FlightStrength;
            Click.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsAlive = false;
        audio.Play();
        logic.GameOver();
    }
}

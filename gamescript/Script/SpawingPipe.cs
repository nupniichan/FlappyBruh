using UnityEngine;

public class SpawingPipe : MonoBehaviour
{
    public GameObject pipe;
    public float SpawnRate = 5f;
    private float timer = 0;
    private float HeightOffSet = 10f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }
    private void SpawnPipe()
    {
        float lowest = transform.position.y - HeightOffSet;
        float highest = transform.position.y + HeightOffSet;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowest,highest),0), Quaternion.identity);
    }
}

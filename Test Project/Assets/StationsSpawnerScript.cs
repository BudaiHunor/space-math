using UnityEngine;

public class StationsSpawnerScript : MonoBehaviour
{
    public GameObject stations;
    public float spawnRate = 5;
    private float timer = 0;
    public bool alive = true;
    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.transform.position = new Vector3(0, 15, 0);
        this.logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        this.Create();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.alive)
        {
            if (this.timer < this.spawnRate)
            {
                this.timer += Time.deltaTime;
            }
            else
            {
                this.timer = 0;
                this.Create();
            }
        }
    }

    private void Create()
    {
        Instantiate(stations, this.gameObject.transform.position, this.gameObject.transform.rotation);
        this.logic.CreateNewQuestion();
    }
}

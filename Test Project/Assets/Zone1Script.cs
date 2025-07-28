using UnityEngine;

public class Zone1Script : MonoBehaviour
{
    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            if (this.logic.IsAnswer1Correct())
            {
                this.logic.AddScore(1);
            }
            else
            {
                this.logic.GameOver();
            }
        }
    }
}

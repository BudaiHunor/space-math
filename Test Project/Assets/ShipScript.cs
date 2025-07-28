using UnityEngine;

public class ShipScript : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public float intensity = 10.0f;
    //public LogicScript logic;
    public bool alive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.transform.position = new Vector3(0, -8, -5);
        this.rigidBody2D.gravityScale = 0.0f;

        //this.logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.alive)
        {
            this.rigidBody2D.linearVelocity = this.VelocityByArrows(this.intensity);
        }
    }

    private Vector2 VelocityByArrows(float intensity)
    {
        Vector2 position = Vector2.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position += Vector2.right;
        }
        return position * intensity;
    }

    public void StopShip()
    {
        this.alive = false;
        this.rigidBody2D.linearVelocity = Vector2.zero;
    }
}

using UnityEngine;

public class StationsScrips : MonoBehaviour
{
    public float speed = 5.0f;
    public float deathZone = -20.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // this.gameObject.transform.position = new Vector3(0, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += Vector3.down * (this.speed * Time.deltaTime);

        if (this.gameObject.transform.position.y < this.deathZone)
        {
            //Debug.Log("Y = " + this.gameObject.transform.position.y);
            //Debug.Log("Death = " + this.deathZone);
            Destroy(this.gameObject);
        }
    }
}

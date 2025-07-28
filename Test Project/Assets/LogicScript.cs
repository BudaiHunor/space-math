using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LogicScript : MonoBehaviour
{
    public int scoreValue = 0;
    public Text question;
    public Text score;
    public Text answer1;
    public Text answer2;
    public Text answer3;
    public GameObject gameOverScreen;
    public ShipScript ship;
    public StationsSpawnerScript spawner;

    private int nr1;
    private int nr2;
    private int option1;
    private int option2;
    private int option3;

    private void CreateNumbers()
    {
        this.nr1 = Random.Range(10, 50);
        this.nr2 = Random.Range(10, 50);
        this.option1 = this.nr1 + this.nr2 + Random.Range(-10, 11);
        this.option2 = this.nr1 + this.nr2 + Random.Range(-10, 11);
        this.option3 = this.nr1 + this.nr2 + Random.Range(-10, 11);

        int index = Random.Range(1, 4);
        if (index == 1)
        {
            this.option1 = this.nr1 + this.nr2;
        }
        else if (index == 2)
        {
            this.option2 = this.nr1 + this.nr2;
        }
        else if (index == 3)
        {
            this.option3 = this.nr1 + this.nr2;
        }
    }

    public void CreateNewQuestion()
    {
        this.CreateNumbers();
        this.question.text = this.nr1 + "+" + this.nr2 + "=?";
        this.answer1.text = this.option1.ToString();
        this.answer2.text = this.option2.ToString();
        this.answer3.text = this.option3.ToString();
    }

    public bool IsAnswer1Correct()
    {
        return (this.option1 == this.nr1 + this.nr2);
    }

    public bool IsAnswer2Correct()
    {
        return (this.option2 == this.nr1 + this.nr2);
    }

    public bool IsAnswer3Correct()
    {
        return (this.option3 == this.nr1 + this.nr2);
    }

    public void AddScore(int score)
    {
        this.scoreValue += score;
        this.score.text = this.scoreValue.ToString();
    }

    public void GameOver()
    {
        this.gameOverScreen.SetActive(true);
        this.ship.StopShip();
        this.spawner.alive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

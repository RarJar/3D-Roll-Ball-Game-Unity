using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    Rigidbody myRigidbody;
    public int score;
    public Text scoreText;
    public GameManager myGameMangaer;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        myRigidbody.AddForce(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score += 1;
            scoreText.text = "Coin - " + score.ToString();
            GameObject.Destroy(other.gameObject);
        }

        if (other.CompareTag("Goal"))
        {
            SceneManager.LoadScene(myGameMangaer.nextLevel);
        }

        if (other.CompareTag("DeadZone"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}

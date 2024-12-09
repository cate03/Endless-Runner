using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float speed = 3f;
    Animator anim;

    public int coins;
    public int potions;
    public int maxCoins;

    public TMP_Text scoreDisplay;

    public Image bar;
    public int maxPotion = 4;
    public float fillAmount = 0.2f;

    public AudioSource moveSound;


    private void Start()
    {
        anim = GetComponent<Animator>();
        scoreDisplay.text = "Score: " + coins.ToString();

        bar.fillAmount = 0f;
    }


    //checks every single frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical");

        transform.Translate(0, translation * speed * Time.deltaTime, 0);

        if (translation != 0)
        {
            anim.SetBool("Moving", true);
        }
        else
        {
            anim.SetBool("Moving", false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveSound.Play();
        }

        UpdatePowerBar();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            coins++;
            Debug.Log("Coins: " + coins);
            scoreDisplay.text = "Score: " + coins.ToString();


            iif(points > maxPoints)
{
                SceneManager.LoadScene("MainMenu");
            }
        }

        if (collision.CompareTag("Potion"))
        {
            potions++;
            bar.fillAmount += fillAmount;
            Debug.Log("Potion: " + potions);
        }
    }


    void UpdatePowerBar()
    {

        //keep this as Q for this project
        if (potions >= maxPotion && Input.GetKeyDown(KeyCode.Q))
        {
            bar.fillAmount = 0f;
            potions = 0;

            // Here is where you add your script for the full bar action- meaning when you release the bar something happens, your choice 

        }
    }
}

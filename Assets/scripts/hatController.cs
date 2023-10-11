using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hatController : MonoBehaviour
{
    public Text sText;
    private int score = 0;
    public GameObject gameOverText;
    public GameObject winText;
    public Text lifeText;
    private int life = 10;
    public float speed = 0.5f;
    Vector2 position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -13f, 13f);
        transform.position = position;
    }
    

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("coin"))
        {
            score++;
            if (score==20)
            {
                winText.SetActive(true);
                Destroy(gameObject);
            }
            sText.text = "Score: " + score.ToString();
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag.Equals("bomb"))
        {
            life--;
            if (life<0)
            {
                gameOverText.SetActive(true);
                Destroy(gameObject);
            }
            lifeText.text = "Life: " + life.ToString();
            Destroy(col.gameObject);
            
        }
        
    }
}

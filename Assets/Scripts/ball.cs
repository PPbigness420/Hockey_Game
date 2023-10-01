using UnityEngine;
using TMPro;
using System;

public class ball : MonoBehaviour
{
    public TMP_Text Player_Score;
    public TMP_Text Enemy_Score;
    private int Player_Score_Int;
    private int Enemy_Score_Int;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Goal"))
        {
            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        if (collision.gameObject.name.Contains("Goal R"))
        {
            Player_Score_Int++;
            Player_Score.text = Player_Score_Int.ToString();
           
        }
        if (collision.gameObject.name.Contains("Goal L"))
        {
            Enemy_Score_Int++;
            Enemy_Score.text = Enemy_Score_Int.ToString();

        }

    }
}

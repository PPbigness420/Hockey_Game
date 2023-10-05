
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
    public Transform goal;
    public Transform ball;
    public float speed;
    public float attackspeed;
    public float defencespeed;

    public Vector3 target;
   

    private void Update()
    {
        bool isballinRange = ball.position.x >= 0;
        if (isballinRange)
        {
            target = ball.position;
            speed = attackspeed;
        }
        else
        {
            target = goal.position;
            speed = defencespeed;
        }


        var finalpos = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        GetComponent<Rigidbody2D>().MovePosition(finalpos);
    }
}

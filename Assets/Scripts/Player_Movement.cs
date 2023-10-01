using UnityEngine;

public class Player_Movement : MonoBehaviour
{
 
    void Start()
    {
               
    }


    void Update()
    {
        
        var MousePos =Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.z = 0;
        GetComponent<Rigidbody2D>().MovePosition(MousePos);
    }
}

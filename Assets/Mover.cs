using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
   [SerializeField]float moveSpeed = 10f; 
   
    // Start is called before the first frame update
    void Start()
    {
        PrintInstrucion();

    }

    // Update is called once per frame
    void Update()
    {  
        MovePlayer();

    }
    void PrintInstrucion()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("This is Meter, he hates delivery guys");
        Debug.Log("Move Meter with WASD or arrow keys");
        Debug.Log("Don't hit the Walls!");
        
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float yValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xValue,yValue,0);
    }

}

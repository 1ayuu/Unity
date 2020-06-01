using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float xspeed=0.01f;
    public float yspeed=0.02f;
   
    
    // Start is called before the first frame update
    void Start()
    {
       // print("this works!");
    }

    // Update is called once per frame
    void Update()
   {
           Move();
    }
    void Move()
    {     if (Input.GetKey(KeyCode.D))
            {
               Moveright()
                }

                    if (Input.GetKey(KeyCode.A))
                {
                  Moveleft()
                  }
      
                    if (Input.GetKey(KeyCode.W))
             { Moveup()
                    }
                        if (Input.GetKey(KeyCode.S))
                {
                     Movedown()
                    }

    }
    
     public void Moveleft(){
          transform.position -=new Vector3(xspeed,0,0);
    }
    public void Moveright(){
           transform.position +=new Vector3(xspeed,0,0);
    }
    public void Moveup(){
    transform.position +=new Vector3(0,yspeed,0);
    }
    public void Movedown()
    {
          transform.position -=new Vector3(0,yspeed,0);
    }
}

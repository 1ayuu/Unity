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
                transform.position +=new Vector3(xspeed,0,0);
                }

                    if (Input.GetKey(KeyCode.A))
                {
                    transform.position -=new Vector3(xspeed,0,0);
                    }
      
                    if (Input.GetKey(KeyCode.W))
                {
                    transform.position +=new Vector3(0,yspeed,0);
                    }
                        if (Input.GetKey(KeyCode.S))
                {
                    transform.position -=new Vector3(0,yspeed,0);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTriggerevent: MonoBehaviour
{
    public float xspeed=0.01f;
    public float yspeed=0.02f;
    public bool isMovingLeft=false;
      public bool isMovingRight=false;
        public bool isMovingUp=false;
          public bool isMovingDown=false;
    
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
    {     if (isMovingRight)
            {
                Moveright();
                }

                    if (isMovingLeft)
                {Moveleft();
                    }
      
                    if (isMovingUp)
                {
                   Moveup();
                    }
                        if (isMovingDown)
                {
                   Movedown();
                    }

    }
    public void TriggerLeft(bool canMove)
    {
        isMovingLeft =canMove;

    }
      public void TriggerRight(bool canMove)
    {
        isMovingRight =canMove;

    }  public void TriggerUp(bool canMove)
    {
        isMovingUp=canMove;

    }  public void TriggerDown(bool canMove)
    {
        isMovingDown =canMove;

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

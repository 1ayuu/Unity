using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class TestingEvents: MonoBehaviour
  {
  public event EventHandler<OnSpacePressedEventArgs>OnSpacePressed;
   public class OnSpacePressedEventArgs:EventArgs{
   public int spaceCount;
   
   }
   public event TestEventDelegate OnFloatEvent;
   public delegate void TestEventDelegate(float f);
   public event Action <bool,int>OnActionEVent;
   public UnityEvent OnUnityEvent;
   public int spaceCount;
   
      private void start()
      {
      OnSpacePressed+=Testing_OnSpacePressed;
      
      }
      private void update()
      {
            if (Input.GetKeyDown(KeyCode.Space))
            {
            spaceCount++;
            OnspacePressed?.Invoke(this,new OnSpacePressedEventArgs{spaceCount=spaceCount});
      OnFloatEvent?.Invoke(5.5f);
      OnActionEvent?.Invoke(true,56);
      OnUnityEvent?.Invoke();
            }

      }
  }

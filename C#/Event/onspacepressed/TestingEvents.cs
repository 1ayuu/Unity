using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class TestingEvents: MonoBehaviour
  {
  public event EventHandler OnSpacePressed;
      private void start()
      {
      OnSpacePressed+=Testing_OnSpacePressed;
      
      }
      private void update()
      {
            if (Input.GetKeyDown(KeyCode.Space4))
            {

            OnspacePressed?.Invoke(this,EventArgs.Empty);

            }

      }
  }

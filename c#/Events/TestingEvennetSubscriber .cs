using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  TestingEvennetSubscriber   : MonoBehaviour
{
public void Start()
{
TestingEvents testingEvents=GetComponent<TestingEvent>();
 testingEvents.OnSpacePressed +=Testing_OnSpacePressed;
 testingEvents.OnFloatEvent +=Testing_OnFloatEvent;
 testingEvents.OnActionEvent  +=TestingEvents_OnActionEvent;
 private void TestingEvents_OnActionEvent(bool arg1, int arg2)
 {
 Debug.Log(arg1+""+arg2);
 
 }
 public void testingEvents_OnFLoatEvent(float f){
 Debug.Log("Float:"+f);
 }
private void TestingEvents_OnSpacePressed(object sender,TestingEvents.OnSpacePressedEventArgs e)
{
Debug.Log("Space!"+e.spaceCount);

}
public void TestingUnityEvent(){
Debug.Log("TestingUnityEvent");
}

}

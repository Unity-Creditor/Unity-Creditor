using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SwipeScript : MonoBehaviour
{
   public UnityEvent OnSwipe = new UnityEvent();
   bool MouseDown = false;

   public void OnMouseDown()
   {
     MouseDown = true;
   }

   public void OnMouseUp()
   {
     MouseDown = false;
     if (Mathf.Abs(transform.position.x) >= 1.25f)
     {
       Debug.Log("I am here");
       OnSwipe.Invoke();
       Destroy(gameObject);
     }
     else
     {
       transform.position = new Vector3(0, transform.position.y, transform.position.z);
     }

   }

   public void Update()
   {
     if (MouseDown)
     {
       Vector3 actualPosition = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y, 0);
       transform.position = actualPosition;
     }
   }
}

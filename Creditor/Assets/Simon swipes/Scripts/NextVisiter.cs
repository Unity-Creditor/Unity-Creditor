using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextVisiter : MonoBehaviour
{
    public GameObject Visiter;
    public Vector3 Spawn = Vector3.zero;
    public Vector3 actualPosition = new Vector3(0, 0.2f, 0);
    //List<SwipeScript> Visiters;

    public void NextClient()
    {
      Debug.Log("Instantiate");
      var CreatedVisiter = Instantiate(Visiter, Spawn, Quaternion.identity);
    }


    /*IEnumerator ShowingTheFollowing()
    {
      Debug.Log("Instantiate");
      var CreatedVisiter = Instantiate(Visiter, Spawn, Quaternion.identity);
      while (CreatedVisiter.transform.position.y <= actualPosition.y)
      {
        CreatedVisiter.transform.position += new Vector3(0, 0.05f, 0);
        Debug.Log(CreatedVisiter.transform.position + "Visiter," + actualPosition + "Actual");
        yield return new WaitForSeconds(0.05f);
      }
    }*/
}

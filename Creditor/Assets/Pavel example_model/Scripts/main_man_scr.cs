using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_man_scr : MonoBehaviour
{
    public GameObject[] faces;
    public Vector2 facePlace;
    public GameObject[] body;
    public Vector2 bodyPlace;
    public GameObject[] eyes;
    public Vector2 eyesPlace;
    public GameObject[] mouth;
    public Vector2 mouthPlace;
    public GameObject[] hair;
    public Vector2 hairPlace;
    //public GameObject[] mouth;
    void Start()
    {
        Instantiate(faces[Random.Range(0,faces.Length)], new Vector2(transform.position.x+facePlace.x,transform.position.y+facePlace.y),transform.rotation);
        Instantiate(hair[Random.Range(0, hair.Length)], new Vector2(transform.position.x + hairPlace.x, transform.position.y + hairPlace.y), transform.rotation);
        Instantiate(body[Random.Range(0, body.Length)], new Vector2(transform.position.x + bodyPlace.x, transform.position.y + bodyPlace.y), transform.rotation);
        Instantiate(eyes[Random.Range(0, eyes.Length)], new Vector2(transform.position.x + eyesPlace.x, transform.position.y + eyesPlace.y), transform.rotation);
        Instantiate(mouth[Random.Range(0, mouth.Length)], new Vector2(transform.position.x + mouthPlace.x, transform.position.y + mouthPlace.y), transform.rotation);
    }
}

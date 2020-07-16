using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_scene_manager : MonoBehaviour
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
    public GameObject[] tie;
    public Vector2 tiePlace;
    public GameObject[] arms;
    public Vector2 armsPlace;
    public GameObject[] computer;
    public Vector2 computerPlace;
    public GameObject[] cup;
    public Vector2 cupPlace;

    //public GameObject[] mouth;
    void Start()
    {
        Instantiate(faces[Random.Range(0,faces.Length)], new Vector2(transform.position.x+facePlace.x,transform.position.y+facePlace.y),transform.rotation,transform)
            .GetComponent<SpriteRenderer>().sortingOrder = 10;
        Instantiate(hair[Random.Range(0, hair.Length)], new Vector2(transform.position.x + hairPlace.x, transform.position.y + hairPlace.y), transform.rotation, transform)
            .GetComponent<SpriteRenderer>().sortingOrder = 10;
        Instantiate(body[Random.Range(0, body.Length)], new Vector2(transform.position.x + bodyPlace.x, transform.position.y + bodyPlace.y), transform.rotation, transform)
            .GetComponent<SpriteRenderer>().sortingOrder = 5;
        Instantiate(eyes[Random.Range(0, eyes.Length)], new Vector2(transform.position.x + eyesPlace.x, transform.position.y + eyesPlace.y), transform.rotation, transform)
            .GetComponent<SpriteRenderer>().sortingOrder = 20;
        Instantiate(mouth[Random.Range(0, mouth.Length)], new Vector2(transform.position.x + mouthPlace.x, transform.position.y + mouthPlace.y), transform.rotation, transform)
            .GetComponent<SpriteRenderer>().sortingOrder = 20;
        Instantiate(tie[Random.Range(0, tie.Length)], new Vector2(transform.position.x + tiePlace.x, transform.position.y + tiePlace.y), transform.rotation, transform)
            .GetComponent<SpriteRenderer>().sortingOrder = 5;
        Instantiate(arms[Random.Range(0, arms.Length)], new Vector2(transform.position.x + armsPlace.x, transform.position.y + armsPlace.y), transform.rotation, transform)
            .GetComponent<SpriteRenderer>().sortingOrder = 20;
        Instantiate(computer[Random.Range(0, computer.Length)], new Vector2(transform.position.x + computerPlace.x, transform.position.y + computerPlace.y), transform.rotation, transform)
            .GetComponent<SpriteRenderer>().sortingOrder = 100;
        Instantiate(cup[Random.Range(0, cup.Length)], new Vector2(transform.position.x + cupPlace.x, transform.position.y + cupPlace.y), transform.rotation, transform)
            .GetComponent<SpriteRenderer>().sortingOrder = 100;
    }
}

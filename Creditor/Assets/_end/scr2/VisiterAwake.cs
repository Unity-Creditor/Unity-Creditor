using UnityEngine;

public class VisiterAwake : MonoBehaviour
{
    public Vector3 Spawn = Vector3.zero;
    public Vector3 actualPosition = new Vector3(0, 0.2f, 0);
    public GameObject[] faces = new GameObject[2];
    //public Color[] CreditHistoryColor = new Color[3];
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        int rand = Random.Range(0, faces.Length);
        var face = Instantiate(faces[rand], Spawn, Quaternion.identity/*, transform*/);

        face.transform.parent = gameObject.transform;

    }

    public void Update()
    {
        if (transform.position.y < actualPosition.y)
        {
            transform.position += new Vector3(0, 0.01f, 0);

        }
    }
}

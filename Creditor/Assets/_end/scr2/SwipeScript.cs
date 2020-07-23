using UnityEngine;
using UnityEngine.Events;


public class SwipeScript : MonoBehaviour
{
    public UnityEvent OnSwipe = new UnityEvent();
    public UnityEvent SwipeYes = new UnityEvent();
    public int Score = 0;
    bool MouseDown = false;
    //public AudioSource yes;
    //public AudioSource no;

    RulesScript rules;
    TaskSCR task;

    public void Start()
    {
        rules = FindObjectOfType<RulesScript>();
        task = FindObjectOfType<TaskSCR>();
    }

    public void OnMouseDown()
    {
        MouseDown = true;
    }

    public void OnMouseUp()
    {
        MouseDown = false;
        if (transform.position.x >= 1.25f)
        {
            //GameObject.FindWithTag("GameController").GetComponent<RulesScript>().RightSpriteFunc();
            rules.RightSpriteFunc();
            //FindObjectOfType<RulesScript>().RightSpriteFunc();
            FindObjectOfType<PlayerSCR>().PlayYes();
            Debug.Log("Yes");
            OnSwipe.Invoke();
            //SwipeYes.Invoke();
            Destroy(gameObject);
        }
        else if (transform.position.x <= -1.25f)
        {
            Debug.Log("No");
            OnSwipe.Invoke();
            FindObjectOfType<PlayerSCR>().PlayNo();
            Destroy(gameObject);
        }
        else
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }

    }

    public void Update()
    {
        if (MouseDown && !FindObjectOfType<RulesScript>().isEnd/*!FindObjectOfType<TaskSCR>()*/ /*&& !FindObjectOfType<TaskSCR>().isTask*//*task.isTask*/)
        {
            Vector3 actualPosition = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y, 0);
            transform.position = actualPosition;
        }
    }
}

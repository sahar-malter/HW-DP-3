using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class mediator : MonoBehaviour
{
    public static int direction;
    public GameObject plane;
    // Start is called before the first frame update
    void Start()
    {
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void get_plane_info()
    {
        StartCoroutine(check_direct());
    }

    public IEnumerator check_direct() // i know i know, but you got the point
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("this is TOWER let me check the direction");
        direction *= -1;
        yield return new WaitForSeconds(3f);
        Debug.Log("omg this is the wrong direction, change to this direction");
        plane.GetComponent<plane>().get_tower_info();
    }
}

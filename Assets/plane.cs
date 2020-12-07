using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class plane : MonoBehaviour
{
    public int direction;
    public GameObject tower;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(get_direct());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,1,0) * direction);
        
    }

    public void get_tower_info()
    {
        StartCoroutine(get_direct());
    }

    public IEnumerator get_direct()
    {
        yield return new WaitForSeconds(2f);
        direction = mediator.direction;
        Debug.Log("this is PLANE i got new direction, and i fly accordingly");
        yield return new WaitForSeconds(3f);
        Debug.Log("wait... is my direction ok?");
        tower.GetComponent<mediator>().get_plane_info();
    }
}

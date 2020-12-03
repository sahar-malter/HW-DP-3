using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mediator : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void get_press(GameObject child)
    {

        StartCoroutine(change_color(child));
    }
    public IEnumerator change_color(GameObject child)
    {
        Material mat;
        for (int i = 0; i < transform.childCount; i++)
        {
            mat = transform.GetChild(i).GetComponent<MeshRenderer>().material;
            transform.GetChild(i).GetComponent<MeshRenderer>().material = child.GetComponent<MeshRenderer>().material;
            yield return new WaitForSeconds(0.5f);
            transform.GetChild(i).GetComponent<MeshRenderer>().material = mat;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class child : MonoBehaviour
{
    private void OnMouseDown()
    {
       transform.parent.GetComponent<Mediator>().get_press(gameObject);
        Debug.Log("pressed " + this.name);
    }
}

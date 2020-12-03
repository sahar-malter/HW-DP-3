using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public List<Material> materials;
    private MeshRenderer MR;

    // Start is called before the first frame update
    void Start()
    {
        MR = GetComponent<MeshRenderer>();
        StartCoroutine(change_color());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator change_color()
    {
        MR.material = materials[Random.Range(0, materials.Count)];
        yield return new WaitForSeconds(0.5F);
        StartCoroutine(change_color());
    }
    private void OnMouseDown()
    {
        Debug.Log("color_changed by observer");
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<MeshRenderer>().material = MR.material;
        }
    }
}

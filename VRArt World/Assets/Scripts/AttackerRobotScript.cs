using Meta.XR.Editor.Tags;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerRobotScript : MonoBehaviour
{
    //This Script needs to detect when a sword comes in contact with it and delete it


    public float health = 4;
    public Collider collider;
    public Tag swordTag;
    public GameObject sword;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.tag);

        if (collision.gameObject.CompareTag(swordTag))
        {
            Destroy(this.gameObject);

        }
    }
}


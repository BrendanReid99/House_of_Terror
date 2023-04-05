using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmonster : MonoBehaviour
{

    [SerializeField] private GameObject monster;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            monster.SetActive(true);
            Destroy(this);
        }
    }
}

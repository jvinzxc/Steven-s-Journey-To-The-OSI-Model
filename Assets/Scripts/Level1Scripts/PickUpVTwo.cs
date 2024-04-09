using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpVTwo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    

    public string[] nameList = { "Shielded", "Unshielded", "Coaxial", "Rj45", "Tools" };

    public void OnTriggerEnter2D(Collider2D other)
    {
        nameList[0] = obj1.name;
        nameList[1] = obj2.name;
        nameList[2] = obj3.name;
        nameList[3] = obj4.name;
        nameList[4] = obj5.name;

        if (other.CompareTag("Player"))
        {
            obj1.SetActive(false);
            print(nameList);
        }
        

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{   
    [SerializeField]
    GameObject presentToDrop;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localScale.x == 1 && !presentToDrop.activeSelf)
        {
            presentToDrop.SetActive(true);
        }
    }
}

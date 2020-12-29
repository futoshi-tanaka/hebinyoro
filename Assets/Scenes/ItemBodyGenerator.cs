using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBodyGenerator : MonoBehaviour
{
    public GameObject ItemBody;
    public List<GameObject> ItemBodyList;

    // Start is called before the first frame update
    void Start()
    {
        // 適当に配置
        for(var i = 0; i < 10; i++)
        {
            var itemBody = Instantiate(ItemBody) as GameObject;
            var x = Random.Range(-8.0f, 8.0f);
            var y = Random.Range(-3.0f, 3.0f);
            itemBody.transform.position = new Vector3(x, y, 0.0f);
            ItemBodyList.Add(itemBody);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

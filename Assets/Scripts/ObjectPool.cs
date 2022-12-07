using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public GameObject enemy;

    void Start()
    {
        Instantiate(enemy, new Vector3(Random.Range(1, 30), 2, Random.Range(1, 10)), Quaternion.identity);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


/*
 Create a class called object pool. 

? Give it an object prefab and instantiate the number of objects you think 
you will need. 

? Store them in a list. When you need an object you search through the 
list for a deactivated object and returns the first you find. 

? If you realize you need more objects than the objects you started with, 
you have a few choices:

? You can instantiate more objects during gameplay. But make sure you 
don't instantiate too many objects because it will be a waste of memory. 
You could later remove the "extra" objects you added

? Find one of the objects that's active but the player will not notice if it 
suddenly disappears so you can use it.
 */
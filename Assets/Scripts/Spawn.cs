using UnityEngine;
using UnityEngine.InputSystem.Android;

public class Spawn : MonoBehaviour
{
    public GameObject zombiePrefab;
    public int counter;


    private void Start()
    {
        InvokeRepeating("SpawnZombie", 0, 1f);
    }

    void SpawnZombie()
    {
        if (--counter == 0) CancelInvoke("SpawnZombie");
        Instantiate(zombiePrefab, new Vector3(Random.Range(0,9), Random.Range(0, 9), Random.Range(0, 9)), Quaternion.identity);
       
    }
}

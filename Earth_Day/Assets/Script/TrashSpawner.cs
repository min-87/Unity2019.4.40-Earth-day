using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    [SerializeField] private float timeToSpawn;
    [SerializeField] private Trash[] trashes;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while(true){
             int randomTrashIndex = Random.Range(0, trashes.Length);
            Instantiate(trashes[randomTrashIndex], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeToSpawn);
        }
      
    }

}

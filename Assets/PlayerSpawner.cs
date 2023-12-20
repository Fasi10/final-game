using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;



public class PlayerSpawner : MonoBehaviour
{

    public static PlayerSpawner instance;

    public GameObject playerprefab;

   
    private void Awake()
    {
        instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        if(PhotonNetwork.IsConnected)
        {
            SpawnPlayer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlayer()
    {
        Transform spawnPoint = SpawnManager.instance.GetSpawnPoint();


        PhotonNetwork.Instantiate("Player", spawnPoint.transform.position, spawnPoint.transform.rotation);
        
    }
}
